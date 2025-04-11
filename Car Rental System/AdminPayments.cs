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
    public partial class AdminPayments: UserControl
    {
        public AdminPayments()
        {
            InitializeComponent();
            LoadRentalRecords();
            CustomizeDataGridView();
        }
        private void LoadRentalRecords()
        {
            string query = "SELECT * FROM payments;";

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
    }
}
