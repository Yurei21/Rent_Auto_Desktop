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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Car_Rental_System
{
    public partial class AddMaintenance : UserControl
    {
        private int carId;
        public AddMaintenance(int carId)
        {
            InitializeComponent();
            this.carId = carId;
        }

        private void Register_Click(object sender, EventArgs e)
        {
            DatabaseHelper db = new DatabaseHelper();
            string info = textBox1.Text;
            decimal cost;

            if (!decimal.TryParse(textBox2.Text, out cost)) 
            {
                MessageBox.Show("Please enter a valid amount");
                return;
            }

            string query = "INSERT INTO maintenance (vehicle_id, details, cost) VALUES (@vehicle_id, @details, @cost)";

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@vehicle_id", carId),
                new MySqlParameter("@details", info),
                new MySqlParameter("@cost", cost)
            };

            if (db.ExecuteQuery(query, parameters)) 
            {
                MessageBox.Show("Maintenance record added successfully.");
            }
            else
            {
                MessageBox.Show("Failed to add maintenance record.");
            }

        }
    }
}
