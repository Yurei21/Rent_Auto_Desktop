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
        int vehicleId;
        public UserCarCard(string model, string brand, string imagePath, decimal price, string status)
        {
            InitializeComponent();


            this.model = model;
            this.brand = brand;
            this.imagePath = imagePath;
            this.status = status;
            this.price = price;

            label1.Text = brand;
            label2.Text = model;
            label3.Text = $"₱{price:F2}/day";
            label4.Text = status;

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

        private void Register_Click(object sender, EventArgs e)
        {
            vehicleId = GetVehicleIdFromDatabase(model, brand);
            UserDashboard dashboard = (UserDashboard)this.ParentForm;
            UserRentCar userRent = new UserRentCar(dashboard, vehicleId, model, brand, imagePath, price, status);
            dashboard.LoadUserControl(userRent);
        }
    }
}
