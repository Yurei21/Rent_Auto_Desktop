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
    public partial class AdminRentals : UserControl
    {
        public AdminRentals()
        {
            InitializeComponent();
            PopulateFilterComboboxes();
            LoadRentalRecords();
            CustomizeDataGridView();
        }

        private void LoadRentalRecords(string keyword = "", string rentalStatus = "", string paymentStatus = "")
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
                INNER JOIN Users u ON r.user_id = u.user_id
                INNER JOIN vehicles v ON r.vehicle_id = v.vehicle_id
                WHERE (u.name LIKE @keyword OR v.model LIKE @keyword)
            ";

            if (!string.IsNullOrEmpty(rentalStatus))
                query += " AND r.status = @status";

            if (!string.IsNullOrEmpty(paymentStatus))
                query += " AND r.payment_status = @paymentStatus";

            DatabaseHelper db = new DatabaseHelper();

            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@keyword", $"%{keyword}%");

                        if (!string.IsNullOrEmpty(rentalStatus))
                            cmd.Parameters.AddWithValue("@status", rentalStatus);

                        if (!string.IsNullOrEmpty(paymentStatus))
                            cmd.Parameters.AddWithValue("@paymentStatus", paymentStatus);

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading rental records: " + ex.Message);
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

        private void PopulateFilterComboboxes()
        {
            cmbStatusFilter.Items.Clear();
            cmbStatusFilter.Items.Add("Ongoing");
            cmbStatusFilter.Items.Add("Completed");

            cmbPaymentFilter.Items.Clear();
            cmbPaymentFilter.Items.Add("Pending");
            cmbPaymentFilter.Items.Add("Paid");

            cmbStatusFilter.SelectedIndex = -1;
            cmbPaymentFilter.SelectedIndex = -1;
        }


        private void btnFilter_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            string rentalStatus = cmbStatusFilter.SelectedItem?.ToString() ?? "";
            string paymentStatus = cmbPaymentFilter.SelectedItem?.ToString() ?? "";

            LoadRentalRecords(keyword, rentalStatus, paymentStatus);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cmbStatusFilter.SelectedIndex = -1;
            cmbPaymentFilter.SelectedIndex = -1;
            LoadRentalRecords();
        }
    }
}
