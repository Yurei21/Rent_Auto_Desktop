using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Car_Rental_System
{
    public partial class AdminViewCar : UserControl
    {
        DatabaseHelper db = new DatabaseHelper();
        int vehicleId;

        public AdminViewCar(AdminDashboard dashboard)
        {
            InitializeComponent();
            loadCars();
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

        public void loadCars()
        {
            flowLayoutPanel1.Controls.Clear();


            string query = "SELECT * FROM vehicles";
            using (MySqlConnection conn = db.GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        string model = dr["model"].ToString();
                        string brand = dr["brand"].ToString();
                        string imagePath = dr["car_url"].ToString();
                        decimal price = Convert.ToDecimal(dr["rent_price"]);
                        string status = dr["availability_status"].ToString();
                        Console.WriteLine($"Adding Car: {model}, {brand}");

                        vehicleId = GetVehicleIdFromDatabase(model, brand);

                        AdminCarCard carCard = new AdminCarCard(model, brand, imagePath, price, status);
                        AdminDashboard dashboard = (AdminDashboard)this.ParentForm;
                        AdminEditCar carEd = new AdminEditCar(dashboard, vehicleId, model, brand, imagePath, price, status);
                        flowLayoutPanel1.Controls.Add(carCard);
                    }
                }
            }

        }
    }
}
