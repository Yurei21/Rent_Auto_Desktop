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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

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
                MessageBox.Show("Please input");
                return;
            }

            DatabaseHelper db = new DatabaseHelper();
            string query = "SELECT password FROM users WHERE email = @email";

            MySqlParameter[] param = new MySqlParameter[] { new MySqlParameter("@email", email) };
            object result = db.ExecuteScalar(query, param);


            if (result != null && result is string hashedPassword)
            {
                if (BCrypt.Net.BCrypt.Verify(password, hashedPassword))
                {
                    MessageBox.Show("Logged in Successfully");
                    UserDashboard ud = new UserDashboard();
                    ud.Show();
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

    }
}
