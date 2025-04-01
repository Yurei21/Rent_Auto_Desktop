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
using Org.BouncyCastle.Asn1.Esf;

namespace Car_Rental_System
{
    public partial class UserReturn : UserControl
    {
        public UserReturn()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ProcessBarcode(textBox1.Text.Trim());
                textBox1.Clear();
            }
        }

        private void SubmitBarcode()
        {
            string barcode = textBox1.Text;
            if (string.IsNullOrEmpty(barcode))
            {
                MessageBox.Show("Please scan or enter a barcode.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ProcessBarcode(barcode);
            textBox1.Clear();
        }

        private void ProcessReturn(int rentalId, int vehicleId, DateTime dueDate)
        {
            DateTime returnDate = DateTime.Now;
            decimal lateFee = 0;
            decimal damageFee = 0;

            if (!decimal.TryParse(textBox2.Text.Trim(), out damageFee))
            {
                MessageBox.Show("Invalid damage fee amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (returnDate > dueDate)
            {
                int daysLate = (returnDate - dueDate).Days;
                lateFee = daysLate * 500;
            }

            string updateQuery = @"
                UPDATE rentals SET carstatus = 'Returned', status = 'Completed' WHERE rental_id = @rentalId;
                UPDATE vehicles SET availability_status = 'Available' WHERE vehicle_id = @vehicleId;";

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@rentalId", rentalId),
                new MySqlParameter("@vehicleId", vehicleId)
            };

            DatabaseHelper db = new DatabaseHelper();
            db.ExecuteQuery(updateQuery, parameters);

            string paymentQuery = @"
                INSERT INTO payments (rental_id, amount_paid, payment_method, pay_status, additionalOrLate_fee)
                VALUES (@rentalId, @totalFee, 'Cash', 'Paid', @lateFee);";

            decimal totalFee = damageFee + lateFee;

            MySqlParameter[] paymentParams =
            {
                new MySqlParameter("@rentalId", rentalId),
                new MySqlParameter("@totalFee", totalFee),
                new MySqlParameter("@lateFee", lateFee)
            };

            db.ExecuteQuery(paymentQuery, paymentParams);

            MessageBox.Show($"Car returned successfully!\nTotal Fees: ₱{totalFee:F2}\nLate Fee: ₱{lateFee:F2}\nDamage Fee: ₱{damageFee:F2}",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ProcessBarcode(string barcode)
        {
            string query = "SELECT rental_id, vehicle_id, rental_end_date FROM rentals WHERE barcode = @barcode AND status = 'Ongoing'";
            MySqlParameter[] param = { new MySqlParameter("@barcode", barcode) };
            DatabaseHelper db = new DatabaseHelper();
            DataTable rentalData = db.ExecuteQueryWithDataTable(query, param);
            if (rentalData.Rows.Count > 0)
            {
                int rentalId = Convert.ToInt32(rentalData.Rows[0]["rental_id"]);
                int vehicleId = Convert.ToInt32(rentalData.Rows[0]["vehicle_id"]);
                DateTime endDate = Convert.ToDateTime(rentalData.Rows[0]["rental_end_date"]);

                ProcessReturn(rentalId, vehicleId, endDate);
            }
            else
            {
                MessageBox.Show("Invalid barcode or vehicle already returned.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            SubmitBarcode();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string curr = textBox1.Text;
            if (curr.Contains("#"))
            {
                textBox1.Text = curr.Replace("#", "");
                textBox1.SelectionStart = textBox1.Text.Length;
            }

        }

    }
}
