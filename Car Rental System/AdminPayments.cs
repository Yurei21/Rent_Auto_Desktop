using Microsoft.VisualBasic.Devices;
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
    public partial class AdminPayments : UserControl
    {
        public AdminPayments()
        {
            InitializeComponent();
            PopulateFilterCombobox();
            LoadRentalRecords();
            CustomizeDataGridView();
        }
        private void LoadRentalRecords(string keyword = "", string paymentStatus = "")
        {
            string query = @"
            SELECT * FROM payments
            WHERE 
                (CAST(rental_id AS CHAR) LIKE @keyword OR 
                 payment_method LIKE @keyword)
        ";

            if (!string.IsNullOrEmpty(paymentStatus))
                query += " AND pay_status = @paymentStatus";

            DatabaseHelper db = new DatabaseHelper();

            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@keyword", $"%{keyword}%");

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
                    MessageBox.Show("Error loading payment records: " + ex.Message);
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
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(180, 180, 180);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            dataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30);
            dataGridView1.DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(230, 230, 250); // light purple-ish
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;

            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns["payment_id"].HeaderText = "ID";
                dataGridView1.Columns["rental_id"].HeaderText = "Rent ID";
                dataGridView1.Columns["amount_paid"].HeaderText = "Amount Paid";
                dataGridView1.Columns["payment_method"].HeaderText = "Payment Method";
                dataGridView1.Columns["payment_date"].HeaderText = "Payment Date";
                dataGridView1.Columns["pay_status"].HeaderText = "Status";
                dataGridView1.Columns["additionalOrLate_fee"].HeaderText = "Additional Fee";

                dataGridView1.Columns["amount_paid"].DefaultCellStyle.Format = "'₱'#,##0.00";
                dataGridView1.Columns["additionalOrLate_fee"].DefaultCellStyle.Format = "'₱'#,##0.00";
                dataGridView1.Columns["payment_date"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            string status = cmbStatusFilter.SelectedItem?.ToString() ?? "";

            LoadRentalRecords(keyword, status);
        }

        private void PopulateFilterCombobox()
        {
            cmbStatusFilter.Items.Clear();
            cmbStatusFilter.Items.Add("Paid");
            cmbStatusFilter.Items.Add("Pending");
            cmbStatusFilter.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cmbStatusFilter.SelectedIndex = -1;
            LoadRentalRecords();
        }
    }
}
