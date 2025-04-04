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
using System.Diagnostics;

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

            label1.Refresh();
            label2.Refresh();
            label3.Refresh();
            label4.Refresh();
            label5.Refresh();
            label6.Refresh();
            label7.Refresh();
            label8.Refresh();
            MessageBox.Show($"Debug - Rental ID: {label1.Text}\nUser ID: {label2.Text}\nBrand: {label3.Text}\nModel: {label4.Text}");

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
                printDocument.Print();
                UpdateVehicleStatus();
                UserDashboard ud = new UserDashboard(userId);
                ud.Show();
                this.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF File|*.pdf";
            saveFileDialog.Title = "Save Receipt as PDF";
            saveFileDialog.FileName = "RentalReceipt.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                PrintDocument printDocument = new PrintDocument();
                printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
                printDocument.PrinterSettings.PrinterName = "Microsoft Print to PDF";
                printDocument.PrinterSettings.PrintToFile = true;
                printDocument.PrinterSettings.PrintFileName = saveFileDialog.FileName;

                try
                {
                    printDocument.Print();
                    MessageBox.Show("Receipt saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Process.Start(new ProcessStartInfo(saveFileDialog.FileName) { UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving receipt: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}