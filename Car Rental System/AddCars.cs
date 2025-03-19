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
    public partial class AddCars : UserControl
    {
        private string carPath = "";
        public AddCars()
        {
            InitializeComponent();
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
                carPath = ofd.FileName;
            }
        }

        private void Register_Click(object sender, EventArgs e)
        {
            DatabaseHelper db = new DatabaseHelper();
            string model = textBox1.Text;
            string brand = textBox2.Text;
            int year;
            decimal rentPrice;

            // Validate year and price inputs
            if (!int.TryParse(textBox3.Text, out year))
            {
                MessageBox.Show("Please enter a valid year.");
                return;
            }

            if (!decimal.TryParse(textBox4.Text, out rentPrice))
            {
                MessageBox.Show("Please enter a valid rent price.");
                return;
            }

            string status = comboBox1.SelectedItem?.ToString() ?? "Available"; // Default to "Available" if nothing is selected
            string carUrl = carPath; // Path from file upload

            string query = "INSERT INTO vehicles (model, car_url, brand, year, rent_price, availability_status) VALUES (@model, @car_url, @brand, @year, @rent_price, @availability_status)";

            MySqlParameter[] parameters = {
                new MySqlParameter("@model", model),
                new MySqlParameter("@car_url", carUrl),
                new MySqlParameter("@brand", brand),
                new MySqlParameter("@year", year),
                new MySqlParameter("@rent_price", rentPrice),
                new MySqlParameter("@availability_status", status)
            };

            db.ExecuteQuery(query, parameters);
            MessageBox.Show("Car successfully added!");
        }
    }
}
