using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using ZXing.QrCode.Internal;
using NetBarcode;
using System.Drawing.Printing;
using System.IO;
using MySql.Data.MySqlClient;

namespace Car_Rental_System
{
    public partial class UserReceipt : Form
    {
        int userId;
        public UserReceipt(int rentalId, int userId, string brand, string model, DateTime startDate, DateTime endDate, decimal totalCost, string paymentMethod, int barcode)
        {
            InitializeComponent();
            this.userId = userId;

            label1.Text = $"Rental ID: {rentalId}";
            label2.Text = $"User ID: {userId}";
            label3.Text = $"Brand: {brand}";
            label4.Text = $"Model: {model}";
            label5.Text = $"Start Date: {startDate:yyyy-MM-dd}";
            label6.Text = $"End Date: {endDate:yyyy-MM-dd}";
            label7.Text = $"Total Cost: ₱{totalCost:F2}";
            label8.Text = $"Payment: {paymentMethod}";

            // Generate barcode
            pictureBox1.Image = GenerateBarcode(barcode.ToString());
        }
        public static Bitmap GenerateBarcode(string barcodeText)
        {
            Barcode barcode = new Barcode(barcodeText, NetBarcode.Type.Code128, true);
            using (MemoryStream ms = new MemoryStream(barcode.GetByteArray()))
            {
                return new Bitmap(ms);
            }
        }
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 12);
            Brush brush = Brushes.Black;
            float yPos = 50;

            e.Graphics.DrawString(label1.Text, font, brush, 50, yPos); yPos += 30;
            e.Graphics.DrawString(label2.Text, font, brush, 50, yPos); yPos += 30;
            e.Graphics.DrawString(label3.Text, font, brush, 50, yPos); yPos += 30;
            e.Graphics.DrawString(label4.Text, font, brush, 50, yPos); yPos += 30;
            e.Graphics.DrawString(label5.Text, font, brush, 50, yPos); yPos += 30;
            e.Graphics.DrawString(label6.Text, font, brush, 50, yPos); yPos += 30;
            e.Graphics.DrawString(label7.Text, font, brush, 50, yPos); yPos += 30;
            e.Graphics.DrawString(label8.Text, font, brush, 50, yPos); yPos += 30;

            if (pictureBox1.Image != null)
            {
                e.Graphics.DrawImage(pictureBox1.Image, new Rectangle(50, (int)yPos, 200, 50));
            }
        }

        private void buttonPrint_Click_1(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
            printDialog.Document = printDocument;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Printing receipt...");
                UpdateVehicleStatus("Rented");
                UserDashboard ud = new UserDashboard(userId);
                ud.Show();
                this.Close();
                printDocument.Print();
            }
            else return;
        }

        private void UpdateVehicleStatus(string status)
        {
            string query = "UPDATE Vehicles SET availability_status = @status WHERE model = @model AND brand = @brand";

            MySqlParameter[] parameters = {
                new MySqlParameter("@status", status),
                new MySqlParameter("@model", label4.Text.Replace("Model: ", "").Trim()), 
                new MySqlParameter("@brand", label3.Text.Replace("Brand: ", "").Trim()) 
            };

            DatabaseHelper db = new DatabaseHelper();
            bool success = db.ExecuteQuery(query, parameters);

            if (success)
            {
                MessageBox.Show("Vehicle status updated successfully.");
            }
            else
            {
                MessageBox.Show("Error updating vehicle status.");
            }
        }

    }
}
