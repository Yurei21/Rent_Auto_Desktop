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
    public partial class AdminRentals: UserControl
    {
        public AdminRentals()
        {
            InitializeComponent();
            LoadRentalRecords();
            CustomizeDataGridView();
        }
        private void LoadRentalRecords()
        {
            string query = @"
                    SELECT 
                        r.rental_id,
                        u.name AS user_name,
                        v.model AS car_name,
                        r.rental_start_date,
                        r.rental_end_date,
                        r.total_cost,
                        r.payment_status,
                        r.status,
                        r.carstatus,
                        r.barcode
                    FROM Rentals r
                    INNER JOIN Users u ON r.user_id = u.user_id INNER JOIN vehicles v ON r.vehicle_id = v.vehicle_id;";

            DatabaseHelper db = new DatabaseHelper();

            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
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

            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns["rental_id"].HeaderText = "ID";
                dataGridView1.Columns["user_name"].HeaderText = "USER";
                dataGridView1.Columns["car_name"].HeaderText = "Car";
                dataGridView1.Columns["rental_start_date"].HeaderText = "Start Date";
                dataGridView1.Columns["rental_end_date"].HeaderText = "End Date";
                dataGridView1.Columns["total_cost"].HeaderText = "Total Cost";
                dataGridView1.Columns["payment_status"].HeaderText = "Payment";
                dataGridView1.Columns["status"].HeaderText = "Rental Status";
                dataGridView1.Columns["carstatus"].HeaderText = "Car Status";
                dataGridView1.Columns["barcode"].HeaderText = "Barcode";

                dataGridView1.Columns["total_cost"].DefaultCellStyle.Format = "'₱'#,##0.00";
                dataGridView1.Columns["rental_start_date"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";
                dataGridView1.Columns["rental_end_date"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";
            }
        }

    }
}
