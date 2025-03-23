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
    public partial class AddPastMaintenance : UserControl
    {
        private int carId;
        public AddPastMaintenance(int carId)
        {
            InitializeComponent();
            this.carId = carId;
        }

        private void Register_Click(object sender, EventArgs e)
        {
            DatabaseHelper db = new DatabaseHelper();
            string info = textBox1.Text;
            decimal cost;
            string date = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss");

            if (!decimal.TryParse(textBox2.Text, out cost)) 
            {
                MessageBox.Show("Please enter a valid amount");
                return;
            }

            string query = "INSERT INTO maintenance (vehicle_id, maintenance_date, details, cost) VALUES (@vehicle_id, @date, @details, @cost)";

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@vehicle_id", carId),
                new MySqlParameter("@date", date),
                new MySqlParameter("@details", info),
                new MySqlParameter("@cost", cost)
            };

            if (db.ExecuteQuery(query, parameters)) 
            {
                MessageBox.Show("Maintenance record added successfully.");
                UpdateVehicleStatus(carId);
            }
            else
            {
                MessageBox.Show("Failed to add maintenance record.");
            }

        }

        private void UpdateVehicleStatus(int carId)
        {
            string query = "SELECT COUNT(*) FROM Maintenance WHERE vehicle_id = @vehicleId AND DATE(maintenance_date) = CURDATE()";

            MySqlParameter[] parameters = {
                new MySqlParameter("@vehicleId", carId)
            };

            DatabaseHelper db = new DatabaseHelper();
            int count = db.ExecuteScalarQuery(query, parameters); 

            string status = (count > 0) ? "Under Maintenance" : "Available";

            string updateQuery = "UPDATE Vehicles SET availability_status = @status WHERE vehicle_id = @vehicleId";

            MySqlParameter[] updateParams = {
                new MySqlParameter("@status", status),
                new MySqlParameter("@vehicleId", carId)
            };

            db.ExecuteQuery(updateQuery, updateParams);
        }

    }
}
