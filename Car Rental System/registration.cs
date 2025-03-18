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
using System.Xml.Linq;
using BCrypt.Net;

namespace Car_Rental_System
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string email = textBox2.Text;
            string phone = textBox3.Text;
            string address = textBox4.Text;
            string password = textBox5.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(address) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string queryAdmin = "INSERT INTO ad_user (pass) VALUES (@password)";

            MySqlParameter[] ad = { new MySqlParameter("@password", password) };

            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

            string query = "INSERT INTO users (name, email, phone, address, password) VALUES (@name, @email, @phone, @address, @password)";

            MySqlParameter[] parameters =
            {
        new MySqlParameter("@name", name),
        new MySqlParameter("@email", email),
        new MySqlParameter("@phone", phone),
        new MySqlParameter("@address", address),
        new MySqlParameter("@password", hashedPassword)
    };

            DatabaseHelper db = new DatabaseHelper();
            bool success = db.ExecuteQuery(query, parameters);
            db.ExecuteQuery(queryAdmin, ad);

            if (success)
            {
                MessageBox.Show("Registration Successful!");
            }
            else
            {
                MessageBox.Show("Error during registration. Please check your database connection.");
            }
        }

    }
}
