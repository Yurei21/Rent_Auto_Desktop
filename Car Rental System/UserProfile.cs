using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_System
{
    public partial class UserProfile : UserControl
    {
        int userId;
        public UserProfile(int userId)
        {
            this.userId = userId;
            InitializeComponent();
            LoadUserData();
        }

        private void LoadUserData()
        {
            try
            {
                string query = "SELECT name, email, phone, address FROM Users WHERE user_id = @userId";
                MySqlParameter[] parameters = { new MySqlParameter("@userId", userId) };

                DatabaseHelper db = new DatabaseHelper();

                using (MySqlDataReader reader = db.ExecuteReader(query, parameters))
                {
                    if (reader.Read())
                    {
                        label2.Text = reader["name"].ToString();
                        label4.Text = "Email: " + reader["email"].ToString();
                        label5.Text = "Phone: " + reader["phone"].ToString();
                        label6.Text = "Address: " + reader["address"].ToString();
                    }
                }

                LoadUserProfileImage();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user data: " + ex.Message);
            }
        }

        private void LoadUserProfileImage()
        {
            try
            {
                string query = "SELECT document_url FROM Documents WHERE user_id = @userId LIMIT 2";
                MySqlParameter[] parameters = { new MySqlParameter("@userId", userId) };

                DatabaseHelper db = new DatabaseHelper();
                List<string> imagePaths = new List<string>();

                using (MySqlDataReader reader = db.ExecuteReader(query, parameters))
                {
                    while (reader.Read())
                    {
                        string imagePath = reader["document_url"].ToString();
                        if (System.IO.File.Exists(imagePath))
                        {
                            imagePaths.Add(imagePath);
                        }
                    }
                }
                if (imagePaths.Count > 0)
                    pictureBox2.Image = Image.FromFile(imagePaths[0]);

                if (imagePaths.Count > 1)
                    pictureBox3.Image = Image.FromFile(imagePaths[1]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading profile images: " + ex.Message);
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();
            string email = textBox2.Text.Trim();
            string phone = textBox3.Text.Trim();
            string address = textBox4.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(name, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Name must contain only letters and spaces.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Invalid email format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidPhone(phone))
            {
                MessageBox.Show("Invalid phone number! Use 11 digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DatabaseHelper db = new DatabaseHelper();

            // Check if email is used by another user
            string emailCheckQuery = "SELECT COUNT(*) FROM users WHERE email = @email AND user_id != @userId";
            MySqlParameter[] emailParams = {
        new MySqlParameter("@email", email),
        new MySqlParameter("@userId", userId)
    };
            int emailExists = db.ExecuteScalarQuery(emailCheckQuery, emailParams);
            if (emailExists > 0)
            {
                MessageBox.Show("Email is already in use by another user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string phoneCheckQuery = "SELECT COUNT(*) FROM users WHERE phone = @phone AND user_id != @userId";
            MySqlParameter[] phoneParams = {
                new MySqlParameter("@phone", phone),
                new MySqlParameter("@userId", userId)
            };
            int phoneExists = db.ExecuteScalarQuery(phoneCheckQuery, phoneParams);
            if (phoneExists > 0)
            {
                MessageBox.Show("Phone number is already in use by another user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string updateQuery = "UPDATE users SET name = @name, email = @email, phone = @phone, address = @address WHERE user_id = @userId";
            MySqlParameter[] updateParams = {
                new MySqlParameter("@name", name),
                new MySqlParameter("@email", email),
                new MySqlParameter("@phone", phone),
                new MySqlParameter("@address", address),
                new MySqlParameter("@userId", userId)
            };

            try
            {
                db.ExecuteQuery(updateQuery, updateParams);
                MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUserData(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating profile: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            return System.Text.RegularExpressions.Regex.IsMatch(phone, @"^\d{11}$");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string phone = textBox3.Text.Trim();
            if (!IsValidPhone(phone))
            {
                labelPhoneError.Text = "Invalid phone number! Use 11 digits.";
                labelPhoneError.Visible = true;
            }
            else
            {
                labelPhoneError.Text = "";
                labelPhoneError.Visible = false;
            }
        }


    }
}
