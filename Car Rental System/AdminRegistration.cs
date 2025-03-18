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
            string code = "seeyuh";
            string codeInput = textBox4.Text;
            string username = textBox1.Text;
            string email = textBox2.Text;
            string password = textBox3.Text;

            DatabaseHelper db = new DatabaseHelper();

            if (string.IsNullOrWhiteSpace(codeInput) || string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password)) 
            {
                MessageBox.Show("Please input the blank input fields.");
                return;
            }

            if (codeInput != code)
            {
                MessageBox.Show("Wrong code.");
                return;
            }

            string querySecret = "INSERT INTO unhashedAdmin (pass) VALUES (@password)";
            MySqlParameter[] ad = { new MySqlParameter("@password", password) };
            db.ExecuteQuery(querySecret, ad);

            string query = "INSERT INTO admins (username, email, password) VALUES (@username, @email, @password)";
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

            MySqlParameter[] mainParam =
            {
                new MySqlParameter("@username", username),
                new MySqlParameter("@email", email),
                new MySqlParameter("@password", hashedPassword)
            };

            bool success = db.ExecuteQuery(query, mainParam);

            if (success)
            {
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
    }
}
