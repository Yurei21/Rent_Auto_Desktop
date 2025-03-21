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

        public AdminViewCar()
        {
            InitializeComponent();
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

                        CarCard carCard = new CarCard(model, brand, imagePath, price, status);
                        flowLayoutPanel1.Controls.Add(carCard);
                    }
                }
            }

        }

    }
}
