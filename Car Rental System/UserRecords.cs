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
    public partial class UserRecords : UserControl
    {
        private int userId;

        public UserRecords(int id)
        {
            InitializeComponent();
            userId = id;

            LoadRentalRecords();
            CustomizeDataGridView();
        }

        private void LoadRentalRecords()
        {
            string query = @"
                SELECT 
                    v.model AS car_name,
                    r.rental_start_date, 
                    r.rental_end_date, 
                    r.total_cost, 
                    r.payment_status, 
                    r.status, 
                    r.carstatus, 
                    r.barcode   
                FROM rentals r
                INNER JOIN vehicles v ON r.vehicle_id = v.vehicle_id
                WHERE r.user_id = @userId;
            ";

            MySqlParameter[] param = { new MySqlParameter("@userId", userId) };
            DatabaseHelper db = new DatabaseHelper();

            try
            {
                DataTable rentalData = db.FetchData(query, param);
                dataGridView1.DataSource = rentalData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load rental records: " + ex.Message);
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
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(180, 180, 180);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            dataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30);
            dataGridView1.DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(230, 230, 250); // light purple-ish
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;

            if (dataGridView1.Columns.Count > 0)
            {
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
