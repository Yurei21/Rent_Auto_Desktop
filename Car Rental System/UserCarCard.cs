using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_System
{
    public partial class UserCarCard : UserControl
    {
        string model, brand, imagePath, status;
        decimal price;
        int vehicleId, userId;
        public UserCarCard(int userId, string model, string brand, string imagePath, decimal price, string status)
        {
            InitializeComponent();


            this.model = model;
            this.brand = brand;
            this.imagePath = imagePath;
            this.status = status;
            this.price = price;
            this.userId = userId;

            label1.Text = brand;
            label2.Text = model;
            label3.Text = $"₱{price:F2}/day";
            label4.Text = status;

            Label labelWarning = new Label();
            labelWarning.AutoSize = true;
            labelWarning.ForeColor = Color.OrangeRed;
            labelWarning.Font = new Font("Arial", 9, FontStyle.Bold);
            labelWarning.Location = new Point(54, 353); 
            labelWarning.Visible = false;
            this.Controls.Add(labelWarning);

            try
            {
                pictureBox1.Image = Image.FromFile(imagePath);
            }
            catch
            {
                pictureBox1.Image = Properties.Resources.default_car;
            }

            label4.ForeColor = status == "Available" ? Color.Green
                : status == "Rented" ? Color.Red
                : Color.Orange;

            if (status == "Rented" || status == "Under Maintenance" || OccuringRent(userId))
            {
                Register.Visible = false;
                if (status == "Rented")
                    labelWarning.Text = "This car is currently rented.";
                else if (status == "Under Maintenance")
                    labelWarning.Text = "This car is under maintenance.";
                else
                    labelWarning.Text = "Return the car first.";

                labelWarning.Visible = true;
                this.Refresh();
            }
        }

        private int GetVehicleIdFromDatabase(string model, string brand)
        {
            int vehicleId = -1;
            string query = "SELECT vehicle_id FROM Vehicles WHERE model = @model AND brand = @brand LIMIT 1";

            MySqlParameter[] parameters = {
                new MySqlParameter("@model", model),
                new MySqlParameter("@brand", brand)
            };

            DatabaseHelper db = new DatabaseHelper();
            object result = db.ExecuteScalar(query, parameters);

            if (result != null)
            {
                vehicleId = Convert.ToInt32(result);
            }

            return vehicleId;
        }

        private bool OccuringRent(int userId)
        {
            string query = "SELECT COUNT(*) FROM rentals WHERE user_id = @userId AND status = 'Ongoing'";
            MySqlParameter[] parameters = { new MySqlParameter("userId", userId) }; 
            DatabaseHelper db = new DatabaseHelper();

            object result = db.ExecuteScalar(query, parameters);

            if (result != null && int.TryParse(result.ToString(), out int count))
            {
                return count > 0;
            }

            return false;
        }

        private void Register_Click(object sender, EventArgs e)
        {
            vehicleId = GetVehicleIdFromDatabase(model, brand);
            UserDashboard dashboard = (UserDashboard)this.ParentForm;
            UserRentCar userRent = new UserRentCar(dashboard, vehicleId, userId, model, brand, imagePath, price, status);
            dashboard.LoadUserControl(userRent);
        }
    }
}
