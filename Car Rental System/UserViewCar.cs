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
    public partial class UserViewCar : UserControl
    {
        int vehicleId, userId;
        string model, brand, imagePath, status;
        decimal price;
        public UserViewCar(UserDashboard userDashboard, int userId)
        {
            InitializeComponent();
            this.userId = userId;   
            loadCars();
        }   
        
        public void loadCars()
        {
            flowLayoutPanel1.Controls.Clear();

            DatabaseHelper db = new DatabaseHelper();
            string query = "SELECT * FROM vehicles";
            using (MySqlConnection conn = db.GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        model = dr["model"].ToString();
                        brand = dr["brand"].ToString();
                        imagePath = dr["car_url"].ToString();
                        price = Convert.ToDecimal(dr["rent_price"]);
                        status = dr["availability_status"].ToString();
                        Console.WriteLine($"Adding Car: {model}, {brand}");
                        UserCarCard carCard = new UserCarCard(userId, model, brand, imagePath, price, status);

                        UserDashboard dashboard = (UserDashboard)this.ParentForm;
                        flowLayoutPanel1.Controls.Add(carCard);
                    }
                }
            }
        }
    }
}
