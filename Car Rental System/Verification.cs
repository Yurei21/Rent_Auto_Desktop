﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Car_Rental_System
{
    public partial class Verification : Form
    {
        private int userId;
        private string idCardPath = "";
        private string dPath = "";
        private DatabaseHelper dbHelper = new DatabaseHelper();
        public Verification(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Title = "Select a picture of your Driver's License",
                Filter = "Image Files|*.jpg;*.png;*.jpeg;"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                dPath = ofd.FileName;
                LoadDriverImage(dPath);
            }
        }

        private void LoadDriverImage(string dPath)
        {
            try
            {
                pictureBox2.Image = Image.FromFile(dPath);
            }
            catch
            {
                pictureBox2.Image = Properties.Resources.r__1_;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Title = "Select a picture of your National ID",
                Filter = "Image Files|*.jpg;*.png;*.jpeg;"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                idCardPath = ofd.FileName;
                LoadIdImage(idCardPath);
            }
        }
        private void LoadIdImage(string idPath)
        {
            try
            {
                pictureBox3.Image = Image.FromFile(idPath);
            }
            catch
            {
                pictureBox3.Image = Properties.Resources.r__1_;
            }
        }

        private void Register_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idCardPath) || string.IsNullOrEmpty(dPath))
            {
                MessageBox.Show("Please upload both documents.");
                return;
            }

            using (MySqlConnection conn = dbHelper.GetConnection())
            {
                conn.Open();

                string statusQuery = "SELECT status FROM Users WHERE user_id = @userId";
                MySqlCommand statusCmd = new MySqlCommand(statusQuery, conn);
                statusCmd.Parameters.AddWithValue("@userId", userId);

                string currentStatus = statusCmd.ExecuteScalar()?.ToString();

                if (currentStatus == "Rejected")
                {
                    string updateStatusQuery = "UPDATE Users SET status = 'Pending' WHERE user_id = @userId";
                    MySqlCommand updateCmd = new MySqlCommand(updateStatusQuery, conn);
                    updateCmd.Parameters.AddWithValue("@userId", userId);
                    updateCmd.ExecuteNonQuery();
                }
                SaveDocument(conn, "ID Card", idCardPath);

                SaveDocument(conn, "Driver License", dPath);
            }

            MessageBox.Show("Documents uploaded successfully! Wait for the Admin to verify the documents");
            SignIn signIn = new SignIn();
            signIn.Show();
            this.Hide();
        }

        private void SaveDocument(MySqlConnection conn, string docType, string filePath)
        {
            string saveDirectory = @"C:\Users\Public\CarRentalDocs\";

            if (!Directory.Exists(saveDirectory))
            {
                Directory.CreateDirectory(saveDirectory);
            }

            string fileName = $"{docType.Replace(" ", "_")}_{userId}_{Path.GetFileName(filePath)}";
            string destinationPath = Path.Combine(saveDirectory, fileName);

            try
            {
                string checkQuery = "SELECT COUNT(*) FROM Documents WHERE user_id = @user_id AND document_type = @document_type";
                MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@user_id", userId);
                checkCmd.Parameters.AddWithValue("@document_type", docType);
                int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (count > 0)
                {
                    DialogResult result = MessageBox.Show($"{docType} already exists. Do you want to overwrite it?",
                                                          "Duplicate Document",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                        return;

                    string updateQuery = "UPDATE Documents SET document_url = @document_url WHERE user_id = @user_id AND document_type = @document_type";
                    MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn);
                    updateCmd.Parameters.AddWithValue("@user_id", userId);
                    updateCmd.Parameters.AddWithValue("@document_type", docType);
                    updateCmd.Parameters.AddWithValue("@document_url", destinationPath);
                    File.Copy(filePath, destinationPath, true);
                    updateCmd.ExecuteNonQuery();
                }
                else
                {
                    File.Copy(filePath, destinationPath, true);

                    string insertQuery = "INSERT INTO Documents (user_id, document_type, document_url) VALUES (@user_id, @document_type, @document_url)";
                    MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn);
                    insertCmd.Parameters.AddWithValue("@user_id", userId);
                    insertCmd.Parameters.AddWithValue("@document_type", docType);
                    insertCmd.Parameters.AddWithValue("@document_url", destinationPath);
                    insertCmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving document: {ex.Message}", "Upload Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
