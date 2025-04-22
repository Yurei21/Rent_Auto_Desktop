using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Car_Rental_System
{
    public partial class AdminRegistration : Form
    {
        public AdminRegistration()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void Register_Click(object sender, EventArgs e)
        {
            string code = "admins@";
            string codeInput = textBox4.Text;
            string username = textBox1.Text;
            string email = textBox2.Text;
            string password = textBox3.Text;

            DatabaseHelper db = new DatabaseHelper();

            if (string.IsNullOrWhiteSpace(codeInput) || string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (codeInput != code)
            {
                MessageBox.Show("Wrong code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string checkEmailQuery = "SELECT COUNT(*) FROM admins WHERE email = @email";
            MySqlParameter[] checkEmailParam = { new MySqlParameter("@email", email) };
            int emailExists = db.ExecuteScalarQuery(checkEmailQuery, checkEmailParam);

            if (emailExists > 0)
            {
                MessageBox.Show("Email is already registered. Try another one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "INSERT INTO admins (username, email, password) VALUES (@username, @email, @password)";
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

            MySqlParameter[] mainParam =
            {
                new MySqlParameter("@username", username),
                new MySqlParameter("@email", email),
                new MySqlParameter("@password", hashedPassword)
            };

            int adminId;

            using (var conn = db.GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddRange(mainParam);
                    cmd.ExecuteNonQuery();
                    adminId = (int)cmd.LastInsertedId;
                }
            }

            if (adminId > 0)
            {
                string querySecret = "INSERT INTO unhashedAdmin (admin_id, pass) VALUES (@admin_id, @password)";
                MySqlParameter[] ad =
                {
                    new MySqlParameter("@admin_id", adminId),
                    new MySqlParameter("@password", password)
                };
                db.ExecuteQuery(querySecret, ad);

                MessageBox.Show("Registration Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Admin adminLog = new Admin();
                adminLog.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error during registration. Please check your database connection.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }

    }
}
