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
    }
}
