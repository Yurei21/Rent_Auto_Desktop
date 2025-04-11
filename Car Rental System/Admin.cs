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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignIn signForms = new SignIn();
            signForms.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Hide();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void signinButton_Click(object sender, EventArgs e)
        {
            string adminUsername = textBox1.Text;
            string adminPassword = textBox2.Text;

            if (String.IsNullOrWhiteSpace(adminUsername) || String.IsNullOrWhiteSpace(adminPassword))
            {
                MessageBox.Show("Please Input a username or password.");
                return;
            }

            DatabaseHelper db = new DatabaseHelper();
            String query = "SELECT password FROM admins WHERE username = @username";

            MySqlParameter[] param = { new MySqlParameter("@username", adminUsername) };
            object result = db.ExecuteScalar(query, param);

            if (result != null && result is string storedHashedPassword)
            {
                if (BCrypt.Net.BCrypt.Verify(adminPassword, storedHashedPassword))
                {
                    MessageBox.Show("Logged in Successfully");
                    AdminDashboard adminDashboard = new AdminDashboard();
                    adminDashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Password");
                }
            }
            else
            {
                MessageBox.Show("Username Not Found or Password Retrieval Failed");
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminRegistration registration = new AdminRegistration();
            registration.Show();
            this.Hide();
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = !checkBoxShowPassword.Checked;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }
    }
}
