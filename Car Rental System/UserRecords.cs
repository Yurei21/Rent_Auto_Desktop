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
            string query = "SELECT rental_start_date, rental_end_date, total_cost, payment_status, status, carstatus, barcode FROM rentals WHERE user_id = @userId;";
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

            if (dataGridView1.Columns.Count > 0)
            {
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
