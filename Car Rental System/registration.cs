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
            string name = textBox1.Text.Trim();
            string email = textBox2.Text.Trim();
            string phone = textBox3.Text.Trim();
            string address = textBox4.Text.Trim();
            string password = textBox5.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(address) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Invalid email format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidPhone(phone))
            {
                MessageBox.Show("Invalid phone number! Use only digits (10-15 characters).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsStrongPassword(password))
            {
                MessageBox.Show("Password must be at least 8 characters long and include an uppercase letter, lowercase letter, a number, and a special character.", "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DatabaseHelper db = new DatabaseHelper();
            string checkEmailQuery = "SELECT COUNT(*) FROM users WHERE email = @email";
            MySqlParameter[] checkParams = { new MySqlParameter("@email", email) };
            int userExists = db.ExecuteScalarQuery(checkEmailQuery, checkParams);

            //for admins
            string queryAdmin = "INSERT INTO unhashedUsers (pass) VALUES (@password)";
            MySqlParameter[] ad = { new MySqlParameter("@password", password) };
            db.ExecuteQuery(queryAdmin, ad);

            if (userExists > 0)
            {
                MessageBox.Show("Email is already registered. Try another one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

            string queryUser = "INSERT INTO users (name, email, phone, address, password) VALUES (@name, @email, @phone, @address, @password)";
            MySqlParameter[] userParams =
            {
                new MySqlParameter("@name", name),
                new MySqlParameter("@email", email),
                new MySqlParameter("@phone", phone),
                new MySqlParameter("@address", address),
                new MySqlParameter("@password", hashedPassword)
            };

            int userId;
            using (var conn = new DatabaseHelper().GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(queryUser, conn);

                foreach (var param in userParams) cmd.Parameters.Add(param);

                userId = Convert.ToInt32(cmd.ExecuteScalar());
            }

            bool success = db.ExecuteQuery(queryUser, userParams);

            if (success)
            {
                MessageBox.Show("Registration Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Verification vForm = new Verification(userId);
                vForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error during registration. Please check your database connection.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsValidPhone(string phone)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(phone, @"^\d{10,15}$");
        }


        private bool IsStrongPassword(string password)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
