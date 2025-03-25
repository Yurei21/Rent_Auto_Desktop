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
            this.imagePath = imagePath;
            this.price = price;
            this.status = status;

            label2.Text = model;
            label3.Text = brand;

            DateTime startDate = dateTimePicker1.Value;
            DateTime endDate = dateTimePicker2.Value;
            int daysDifference = (endDate - startDate).Days;

            decimal newPrice = price * daysDifference;
            label6.Text = $"₱{newPrice:F2}";
        }
        public bool RentAndPay(int userId, int vehicleId, DateTime startDate, DateTime endDate, decimal totalCost, string paymentMethod)
        {
            int barcode = BarcodeGenerator.GenerateRandomBarcode();
            bool success = false;
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
                        db.ExecuteNonQuery(rentalQuery, rentalParams);

                        int rentalId = db.GetLastInsertedId(conn);

                        string paymentQuery = @"
                            INSERT INTO Payments (rental_id, amount_paid, payment_method, pay_status)
                            VALUES (@rentalId, @totalCost, @paymentMethod, 'Paid');
                        ";
                        MySqlParameter[] paymentParams = {
                            new MySqlParameter("@rentalId", rentalId),
                            new MySqlParameter("@totalCost", totalCost),
                            new MySqlParameter("@paymentMethod", paymentMethod)
                        };
                        db.ExecuteNonQuery(paymentQuery, paymentParams);

                        string updateVehicleQuery = @"
                            UPDATE Vehicles SET availability_status = 'Rented' WHERE vehicle_id = @vehicleId;
                        ";
                        MySqlParameter[] updateVehicleParams = {
                            new MySqlParameter("@vehicleId", vehicleId)
                        };
                        db.ExecuteNonQuery(updateVehicleQuery, updateVehicleParams);

                        transaction.Commit();
                        success = true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            return success;
        }



    }
}
