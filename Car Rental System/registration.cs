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
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Text.RegularExpressions;

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

        private void button1_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            signIn.Show();
            this.Hide();
        }
        private bool IsNameValid(string name)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(name, @"^[a-zA-Z]+$");
        }

        private void Register_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string email = textBox2.Text.Trim();
            string phone = textBox3.Text.Trim();
            string address = textBox4.Text.Trim();
            string password = textBox5.Text;
            string confirmedPassword = textBox6.Text;
            DatabaseHelper db = new DatabaseHelper();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(address) ||
                string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmedPassword))
            {
                MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (password != confirmedPassword)
            {
                MessageBox.Show("Password doesn't match the confirmed password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Password must be at least 8 characters long and include an uppercase letter, lowercase letter, a number, and a special character.",
                                "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string checkEmailQuery = "SELECT COUNT(*) FROM users WHERE email = @email";
            MySqlParameter[] checkParams = { new MySqlParameter("@email", email) };
            int userExists = db.ExecuteScalarQuery(checkEmailQuery, checkParams);

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

            using (var conn = db.GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(queryUser, conn))
                {
                    cmd.Parameters.AddRange(userParams);
                    cmd.ExecuteNonQuery();
                    userId = (int)cmd.LastInsertedId;
                }
            }

            if (userId > 0)
            {
                string queryAdmin = "INSERT INTO unhashedUsers (user_id, pass) VALUES (@user_id, @password)";
                MySqlParameter[] ad =
                {
                    new MySqlParameter("@user_id", userId),
                    new MySqlParameter("@password", password)
                };
                db.ExecuteQuery(queryAdmin, ad);

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
            return System.Text.RegularExpressions.Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?#_()&]{8,}$");
        }

        private string GetPasswordStrength(string password)
        {
            int score = 0;

            if (password.Length >= 8) score++;
            if (System.Text.RegularExpressions.Regex.IsMatch(password, @"[a-z]")) score++;
            if (System.Text.RegularExpressions.Regex.IsMatch(password, @"[A-Z]")) score++;
            if (System.Text.RegularExpressions.Regex.IsMatch(password, @"\d")) score++;
            if (System.Text.RegularExpressions.Regex.IsMatch(password, @"[@$!%*?&]")) score++;
            if (score <= 2) return "Weak";
            if (score == 3 || score == 4) return "Medium";
            return "Strong";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string email = textBox2.Text.Trim();
            if (!IsValidEmail(email))
            {
                labelEmailError.Text = "Invalid email format!";
                labelEmailError.Visible = true;
            }
            else
            {
                labelEmailError.Text = "";
                labelEmailError.Visible = false;
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string phone = textBox3.Text.Trim();
            if (!IsValidPhone(phone))
            {
                labelPhoneError.Text = "Invalid phone number! Use 10-15 digits.";
                labelPhoneError.Visible = true;
            }
            else
            {
                labelPhoneError.Text = "";
                labelPhoneError.Visible = false;
            }
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            string password = textBox5.Text;
            string strength = GetPasswordStrength(password);

            if (strength == "Weak")
            {
                labelPasswordError.Text = "Weak password: Use at least 8 chars, A-Z, a-z, 0-9, @!%*?";
                labelPasswordError.ForeColor = Color.Red;
            }
            else if (strength == "Medium")
            {
                labelPasswordError.Text = "Medium password: Consider adding more variety!";
                labelPasswordError.ForeColor = Color.Orange;
            }
            else
            {
                labelPasswordError.Text = "Strong password!";
                labelPasswordError.ForeColor = Color.Green;
            }

            labelPasswordError.Visible = true;
        }


        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            textBox5.UseSystemPasswordChar = !checkBoxShowPassword.Checked;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^[a-zA-Z\s]+$";
            if (!Regex.IsMatch(textBox1.Text, pattern))
            {
                textBox1.BackColor = Color.MistyRose;
                labelNameError.Text = "Only letters and spaces allowed";
                labelNameError.Visible = true;
            }
            else
            {
                textBox1.BackColor = Color.White;
                labelNameError.Visible = false;
            }
        }

    }
}
