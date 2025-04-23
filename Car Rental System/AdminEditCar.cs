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
    public partial class AdminEditCar : UserControl
    {
        private AdminDashboard dashboard;
        private int vehicleId;
        public AdminEditCar(AdminDashboard dashboard, int vehicleId, string model, string brand, string imagePath, decimal price, string status)
        {
            InitializeComponent();
            this.dashboard = dashboard;
            label1.Text = brand;
            label8.Text = model;
            this.vehicleId = vehicleId;

            textBox1.Text = brand;
            textBox2.Text = model;
            textBox3.Text = price.ToString();

            try
            {
                pictureBox1.Image = Image.FromFile(imagePath);
            }
            catch
            {
                pictureBox1.Image = Properties.Resources.default_car;
            }

            LoadMaintenanceRecords(vehicleId);
            CustomizeDataGridView();
        }

        private void Modify_Click(object sender, EventArgs e)
        {
            string newBrand = textBox1.Text;
            string newModel = textBox2.Text;
            decimal newPrice;
            int newYear;

            if (!decimal.TryParse(textBox3.Text, out newPrice))
            {
                MessageBox.Show("Invalid price input.");
                return;
            }

            if (!int.TryParse(textBox4.Text, out newYear))
            {
                MessageBox.Show("Invalid year input.");
                return;
            }

            string newStatus = comboBox1.SelectedItem.ToString();
            string oldModel = label8.Text; 

            string query = "UPDATE Vehicles SET brand = @brand, model = @model, rent_price = @price, year = @year, availability_status = @status WHERE model = @oldModel";

            MySqlParameter[] parameters = {
                new MySqlParameter("@brand", newBrand),
                new MySqlParameter("@model", newModel),
                new MySqlParameter("@price", newPrice),
                new MySqlParameter("@year", newYear),
                new MySqlParameter("@status", newStatus),
                new MySqlParameter("@oldModel", oldModel)
            };

            DatabaseHelper db = new DatabaseHelper();
            bool success = db.ExecuteQuery(query, parameters);

            if (success)
            {
                MessageBox.Show("Vehicle details updated successfully!");
            }
            else
            {
                MessageBox.Show("Update failed.");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Vehicles WHERE model = @model";
            MySqlParameter[] parameters = {
                new MySqlParameter("@model", label8.Text) 
            };

            DatabaseHelper db = new DatabaseHelper();
            bool success = db.ExecuteQuery(query, parameters);

            if (success)
            {
                MessageBox.Show("Vehicle deleted successfully!");
                dashboard.LoadUserControl(new AdminViewCar(dashboard)); 
            }
            else
            {
                MessageBox.Show("Delete failed.");
            }
        }

        private void UpdateVehicleStatus(int vehicleId)
        {
            string query = "SELECT COUNT(*) FROM Maintenance WHERE vehicle_id = @vehicleId AND DATE(maintenance_date) = CURDATE()";

            MySqlParameter[] parameters = {
                new MySqlParameter("@vehicleId", vehicleId)
            };

            DatabaseHelper db = new DatabaseHelper();
            int count = db.ExecuteScalarQuery(query, parameters); 

            string status = (count > 0) ? "Under Maintenance" : "Available";

            string updateQuery = "UPDATE Vehicles SET availability_status = @status WHERE vehicle_id = @vehicleId";

            MySqlParameter[] updateParams = {
                new MySqlParameter("@status", status),
                new MySqlParameter("@vehicleId", vehicleId)
            };

            db.ExecuteQuery(updateQuery, updateParams);
        }


        private void Maintenance_Click(object sender, EventArgs e)
        {
            DatabaseHelper db = new DatabaseHelper();   
            string date = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string detail = textBox5.Text;
            decimal cost;

            if (!decimal.TryParse(textBox6.Text, out cost))
            {
                MessageBox.Show("Please enter a valid amount");
                return;
            }
            string query = "INSERT INTO maintenance (vehicle_id, maintenance_date, details, cost) VALUES (@vehicle_id, @date, @details, @cost)";

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@vehicle_id", vehicleId),
                new MySqlParameter("@date", date),
                new MySqlParameter("@details", detail),
                new MySqlParameter("@cost", cost)
            };

            if (db.ExecuteQuery(query, parameters))
            {
                MessageBox.Show("Maintenance record added successfully.");
                UpdateVehicleStatus(vehicleId);
                LoadMaintenanceRecords(vehicleId);
            }
            else
            {
                MessageBox.Show("Failed to add maintenance record.");
            }

        }

        private void LoadMaintenanceRecords(int vehicleId)
        {
            string query = "SELECT maintenance_date, details, cost FROM Maintenance WHERE vehicle_id = @vehicleId";

            MySqlParameter[] parameters = {
                new MySqlParameter("@vehicleId", vehicleId)
            };

            DatabaseHelper db = new DatabaseHelper();

            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddRange(parameters);
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading maintenance records: " + ex.Message);
                }
            }
        }

        private void CustomizeDataGridView()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            dataGridView1.BackgroundColor = Color.FromArgb(30, 30, 30);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(210, 210, 210);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            dataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30);
            dataGridView1.DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(230, 230, 250); // light purple-ish
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;

            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns["details"].HeaderText = "Details";
                dataGridView1.Columns["cost"].HeaderText = "Cost";
                dataGridView1.Columns["maintenance_date"].HeaderText = "Maintenance Date";
                dataGridView1.Columns["maintenance_date"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";
            }
        }

    }
}
