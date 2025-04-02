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
        private int id;
        public UserRecords(int id)
        {
            InitializeComponent();
            this.id = id;

            LoadRentalRecords(id);
        }
        private void LoadRentalRecords(int userId)
        {
            string query = "SELECT * FROM rentals WHERE @userId = user_id;";

            DatabaseHelper db = new DatabaseHelper();
            MySqlParameter[] param = { new MySqlParameter("@userId", userId) };

            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddRange(param);
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
