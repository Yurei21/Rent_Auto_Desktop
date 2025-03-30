using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Car_Rental_System
{
    public partial class UserRentCar : UserControl
    {
        string model, brand, imagePath, status;
        decimal price;
        int vehicleId, userId;

        public UserRentCar(UserDashboard dashboard, int vehicleId, int userId, string model, string brand, string imagePath, decimal price, string status)
        {
            InitializeComponent();

            this.vehicleId = vehicleId;
            this.userId = userId;
            this.brand = brand;
            this.model = model;
            this.imagePath = imagePath;
            this.price = price;
            this.status = status;

            label2.Text = model;
            label3.Text = brand;
            try 
            {
                pictureBox1.ImageLocation = imagePath;
            }
            catch
            {
                pictureBox1.Image = Properties.Resources.default_car;
            }

            UpdateTotalCost();
            comboBox1.SelectedIndex = 0;
        }

        private void UpdateTotalCost()
        {
            DateTime startDate = dateTimePicker1.Value;
            DateTime endDate = dateTimePicker2.Value;

            int daysDifference = (endDate - startDate).Days + 1;
            if (daysDifference <= 0) daysDifference = 1;

            decimal newPrice = price * daysDifference;
            label6.Text = $"₱{newPrice:F2}";
        }

        public (int rentalId, int barcode) RentAndPay(int userId, int vehicleId, DateTime startDate, DateTime endDate, decimal totalCost, string paymentMethod)
        {
            int barcode = BarcodeGenerator.GenerateRandomBarcode();
            int rentalId = -1;
            DatabaseHelper db = new DatabaseHelper();

            using (MySqlConnection conn = db.GetConnection())
            {
                conn.Open();
                using (MySqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        string rentalQuery = @"
                            INSERT INTO Rentals (user_id, vehicle_id, rental_start_date, rental_end_date, total_cost, barcode, payment_status)
                            VALUES (@userId, @vehicleId, @startDate, @endDate, @totalCost, @barcode, 'Paid');
                        ";


                        MySqlParameter[] rentalParams = {
                            new MySqlParameter("@userId", userId),
                            new MySqlParameter("@vehicleId", vehicleId),
                            new MySqlParameter("@startDate", startDate),
                            new MySqlParameter("@endDate", endDate),
                            new MySqlParameter("@totalCost", totalCost),
                            new MySqlParameter("@barcode", barcode)
                        };

                        db.ExecuteNonQuery(rentalQuery, rentalParams, conn, transaction);

                        using (MySqlCommand cmd = new MySqlCommand("SELECT LAST_INSERT_ID();", conn, transaction))
                        {
                            object result = cmd.ExecuteScalar();
                            rentalId = (result != null && int.TryParse(result.ToString(), out int id)) ? id : -1;
                        }

                        if (rentalId <= 0)
                        {
                            throw new Exception("Failed to insert rental record.");
                        }

                        string paymentQuery = @"
                            INSERT INTO Payments (rental_id, amount_paid, payment_method, pay_status)
                            VALUES (@rentalId, @totalCost, @paymentMethod, 'Paid');
                        ";
                        MySqlParameter[] paymentParams = {
                            new MySqlParameter("@rentalId", rentalId),
                            new MySqlParameter("@totalCost", totalCost),
                            new MySqlParameter("@paymentMethod", paymentMethod)
                        };
                        db.ExecuteNonQuery(paymentQuery, paymentParams, conn, transaction);

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error: " + ex.Message);
                        rentalId = -1;
                        barcode = -1;
                    }
                }
            }
            return (rentalId, barcode);
        }


        private void Transaction_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePicker1.Value.Date;
            DateTime endDate = dateTimePicker2.Value.Date;

            int daysDifference = (int)Math.Ceiling((endDate - startDate).TotalDays);
            if (daysDifference <= 0)
            {
                MessageBox.Show("Invalid rental period. Please select a valid date range.");
                return;
            }

            decimal totalCost = price * daysDifference;
            string paymentMethod = comboBox1.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(paymentMethod))
            {
                MessageBox.Show("Please select a payment method.");
                return;
            }

            (int rentalId, int barcode) = RentAndPay(userId, vehicleId, startDate, endDate, totalCost, paymentMethod);

            if (rentalId != -1)
            {
                MessageBox.Show("Transaction successful! Your rental is confirmed.");
                UserReceipt userReceipt = new UserReceipt(vehicleId, rentalId, userId, brand, model, startDate, endDate, totalCost, paymentMethod, barcode);
                userReceipt.Show();
                ((UserDashboard)this.ParentForm).Close();
            }
            else
            {
                MessageBox.Show("Transaction failed. Please try again.");
            }
        }

        private void dateTimePicker2_ValueChanged_1(object sender, EventArgs e)
        {
            UpdateTotalCost();
        }
    }
}
