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
    public partial class UserForgotPassword : Form
    {
        public UserForgotPassword()
        {
            InitializeComponent();
        }

        private void signinButton_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text.Trim();
            string phone = textBox2.Text.Trim();
            string password = textBox3.Text;
            string confirmPassword = textBox4.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phone) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DatabaseHelper db = new DatabaseHelper();

                string checkQuery = "SELECT user_id FROM users WHERE email = @Email AND phone = @Phone";
                MySqlParameter[] checkParams = {
                    new MySqlParameter("@Email", email),
                    new MySqlParameter("@Phone", phone)
                };

                object result = db.ExecuteScalar(checkQuery, checkParams);

                if (result == null || result == DBNull.Value)
                {
                    MessageBox.Show("Email and phone number do not match any account.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int userId;
                if (!int.TryParse(result.ToString(), out userId))
                {
                    MessageBox.Show("Invalid user ID retrieved. Please contact support.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

                string updateUserPassword = "UPDATE users SET password = @Password WHERE user_id = @UserId";
                MySqlParameter[] updateParams = {
                    new MySqlParameter("@Password", hashedPassword),
                    new MySqlParameter("@UserId", userId)
                };

                bool userPasswordUpdated = db.ExecuteQuery(updateUserPassword, updateParams);

                string updateUnhashedPassword = "UPDATE unhashedUsers SET pass = @Password WHERE user_id = @UserId";
                MySqlParameter[] unhashedParams = {
                    new MySqlParameter("@Password", password),
                    new MySqlParameter("@UserId", userId)
                };

                bool unhashedUpdated = db.ExecuteQuery(updateUnhashedPassword, unhashedParams);

                if (userPasswordUpdated && unhashedUpdated)
                {
                    MessageBox.Show("Password reset successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SignIn login = new SignIn();
                    this.Close();
                    login.Show();
                }
                else
                {
                    MessageBox.Show("Something went wrong while updating the password.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (MySqlException sqlEx)
            {
                MessageBox.Show("Database error: " + sqlEx.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.UseSystemPasswordChar = !checkBoxShowPassword.Checked;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignIn login = new SignIn();
            this.Close();
            login.Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
