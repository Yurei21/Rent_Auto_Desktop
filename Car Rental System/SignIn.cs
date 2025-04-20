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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Car_Rental_System
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
            linkLabel1.Visible = false;
        }
        private int clicked = 0;
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Admin adminForm = new Admin();
            adminForm.Show();
            this.Hide();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration registrationForm = new Registration();
            registrationForm.Show();
            this.Hide();
        }
        private void signinButton_Click(object sender, EventArgs e)
        {
            String email = textBox1.Text.Trim();
            String password = textBox2.Text.Trim();

            if (String.IsNullOrWhiteSpace(email) || String.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please input your email and password.");
                return;
            }

            DatabaseHelper db = new DatabaseHelper();
            string query = "SELECT password, status, user_id FROM users WHERE email = @email";

            MySqlParameter[] param = new MySqlParameter[] { new MySqlParameter("@email", email) };

            using (MySqlDataReader reader = db.ExecuteReader(query, param))
            {
                if (reader.Read())
                {
                    string hashedPassword = reader["password"].ToString();
                    string status = reader["status"].ToString();
                    int userId = Convert.ToInt32(reader["user_id"]);

                    if (status == "Pending")
                    {
                        MessageBox.Show("Your account is still pending approval. Please wait for an admin to verify your documents.",
                                        "Account Pending", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    if (status == "Rejected")
                    {
                        MessageBox.Show("Your account has been rejected. Please upload a valid image",
                                        "Account Rejected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Verification verification = new Verification(userId);
                        verification.Show();
                        this.Hide();
                    }
                    
                    if (status == "Accepted") { 
                        if (BCrypt.Net.BCrypt.Verify(password, hashedPassword))
                        {
                            MessageBox.Show("Logged in Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            UserDashboard ud = new UserDashboard(userId);
                            ud.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Username not found or password retrieval failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            clicked++;
            if (clicked == 5) linkLabel1.Visible = true;
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = !checkBoxShowPassword.Checked;
        }
    }
}
