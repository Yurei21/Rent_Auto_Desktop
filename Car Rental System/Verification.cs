using System;
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
            string query = "INSERT INTO Documents (user_id, document_type, document_url) VALUES (@user_id, @document_type, @document_url)";
            MySqlParameter[] parameters = {
                new MySqlParameter("@user_id", userId),
                new MySqlParameter("@document_type", docType),
                new MySqlParameter("@document_url", Path.GetFileName(filePath))
            };

            dbHelper.ExecuteQuery(query, parameters);
        }
    }
}
