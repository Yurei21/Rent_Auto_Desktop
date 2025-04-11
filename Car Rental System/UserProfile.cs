using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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

    }
}
