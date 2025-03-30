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
        int userId, vehicleId;
        string model, brand;
        public UserReceipt(int vehicleId, int rentalId, int userId, string brand, string model, DateTime startDate, DateTime endDate, decimal totalCost, string paymentMethod, int barcode)
        {
            InitializeComponent();
            this.userId = userId;
            this.brand = brand;
            this.model = model;
            this.vehicleId = vehicleId; 

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

            int pageWidth = e.MarginBounds.Width;

            string[] labels = { label1.Text, label2.Text, label3.Text, label4.Text,
                        label5.Text, label6.Text, label7.Text, label8.Text };

            foreach (string text in labels)
            {
                if (!string.IsNullOrEmpty(text))
                {
                    SizeF textSize = e.Graphics.MeasureString(text, font);
                    float xPos = e.MarginBounds.Left + (pageWidth - textSize.Width) / 2; 
                    e.Graphics.DrawString(text, font, brush, xPos, yPos);
                    yPos += 30;
                }
            }

            if (pictureBox1.Image != null)
            {
                int imageWidth = 200;
                int imageHeight = 50;
                int xPos = e.MarginBounds.Left + (pageWidth - imageWidth) / 2; 
                e.Graphics.DrawImage(pictureBox1.Image, new Rectangle(xPos, (int)yPos, imageWidth, imageHeight));
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
                UpdateVehicleStatus();
                UserDashboard ud = new UserDashboard(userId);
                ud.Show();
                this.Close();
                printDocument.Print();
            }
            else return;
        }

        private void UpdateVehicleStatus()
        {
            string query = "UPDATE Vehicles SET availability_status = 'Rented' WHERE vehicle_id = @vehicleId";

            MySqlParameter[] parameters = {
                new MySqlParameter("@vehicleId", vehicleId)
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
