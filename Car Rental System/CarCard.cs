using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Asn1.Cmp;

namespace Car_Rental_System
{
    public partial class CarCard : UserControl
    {
        public CarCard(string model, string brand, string imagePath, decimal price, string status)
        {
            InitializeComponent();

            label1.Text = brand;
            label2.Text = model;
            label3.Text = $"₱{price:F2}/day";
            label4.Text = status;

            try
            {
                pictureBox1.Image = Image.FromFile(imagePath);
            }
            catch
            {
                pictureBox1.Image = Properties.Resources.default_car;
            }

            label4.ForeColor = status == "Available" ? Color.Green
            : status == "Rented" ? Color.Red
            : Color.Orange;
        }

        private void Register_Click(object sender, EventArgs e)
        {

        }
    }
}
