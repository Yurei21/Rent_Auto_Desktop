using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Car_Rental_System
{
    public partial class AdminUserVerification : UserControl
    {
        public AdminUserVerification()
        {
            InitializeComponent();
            LoadPendingUsers();
        }
        private void LoadPendingUsers()
        {
            string query = "SELECT user_id, name, status FROM Users WHERE status = 'Pending'";
            DatabaseHelper db = new DatabaseHelper();
            DataTable users = db.ExecuteQueryWithDataTable(query);

            foreach (DataRow row in users.Rows)
            {
                int userId = Convert.ToInt32(row["user_id"]);
                string userName = row["name"].ToString();
                string status = row["status"].ToString();

                CreateUserCard(userId, userName, status);
            }
        }
        private bool HasTwoValidIDs(int userId)
        {
            string query = "SELECT COUNT(*) FROM Documents WHERE user_id = @userId";
            MySqlParameter[] param = { new MySqlParameter("@userId", userId) };

            DatabaseHelper db = new DatabaseHelper();
            int docCount = Convert.ToInt32(db.ExecuteScalar(query, param));

            return docCount >= 2;
        }

        private DataTable GetUserDocuments(int userId)
        {
            string query = "SELECT document_url FROM documents WHERE user_id = @userId LIMIT 2";
            MySqlParameter[] mySqlParameters = { new MySqlParameter("@userId", userId) };
            DatabaseHelper db = new DatabaseHelper();
            return db.ExecuteQueryWithDataTable(query, mySqlParameters);
        }
        private void ApproveUser(int userId)
        {
            if (HasTwoValidIDs(userId))
            {
                string updateQuery = "UPDATE Users SET status = 'Accepted' WHERE user_id = @userId";
                MySqlParameter[] param = { new MySqlParameter("@userId", userId) };

                DatabaseHelper db = new DatabaseHelper();
                db.ExecuteQuery(updateQuery, param);

                MessageBox.Show("User has been successfully approved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                flowLayoutPanel1.Controls.Clear();
                LoadPendingUsers();
            }
            else
            {
                MessageBox.Show("User must upload at least two valid IDs before approval.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RejectUser(int userId)
        {
            string updateQuery = "UPDATE Users SET status = 'Rejected' WHERE user_id = @userId";
            MySqlParameter[] param = { new MySqlParameter("@userId", userId) };

            DatabaseHelper db = new DatabaseHelper();
            db.ExecuteQuery(updateQuery, param);

            MessageBox.Show("User has been successfully Rejected!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            flowLayoutPanel1.Controls.Clear();
            LoadPendingUsers();
        }

        private void SetupFlowLayoutPanel()
        {
            flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;
            flowLayoutPanel1.WrapContents = true;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void CreateUserCard(int userId, string userName, string status)
        {
            int panelWidth = (flowLayoutPanel1.Width / 2) - 10;
            Panel userPanel = new Panel
            {
                Size = new Size(panelWidth, 185),
                Padding = new Padding(10)
            };

            Label nameLabel = new Label
            {
                Text = "Name: " + userName,
                AutoSize = true,
                Location = new Point(10, 10),
                ForeColor = Color.White,
                Font = new Font("Heavitas", 9, FontStyle.Regular)
            };

            Label statusLabel = new Label
            {
                Text = "Status: " + status,
                AutoSize = true,
                Location = new Point(10, 30),
                ForeColor = Color.White,
                Font = new Font("Heavitas", 9, FontStyle.Regular)
            };

            DataTable documents = GetUserDocuments(userId);

            PictureBox pic1 = new PictureBox { Size = new Size(100, 100), Location = new Point(10, 50), SizeMode = PictureBoxSizeMode.StretchImage };
            PictureBox pic2 = new PictureBox { Size = new Size(100, 100), Location = new Point(120, 50), SizeMode = PictureBoxSizeMode.StretchImage };

            if (documents.Rows.Count > 0)
            {
                string docUrl1 = documents.Rows[0]["document_url"].ToString();
                if (File.Exists(docUrl1))
                {
                    pic1.ImageLocation = docUrl1;
                    pic1.Load();
                    pic1.Cursor = Cursors.Hand;
                    pic1.Click += (sender, e) => System.Diagnostics.Process.Start("explorer.exe", docUrl1);
                }
                else
                {
                    pic1.Image = Properties.Resources.r;
                    MessageBox.Show($"File not found: {docUrl1}");
                }
            }

            if (documents.Rows.Count > 1)
            {
                string docUrl2 = documents.Rows[1]["document_url"].ToString();
                if (File.Exists(docUrl2))
                {
                    pic2.ImageLocation = docUrl2;
                    pic2.Load();
                    pic2.Cursor = Cursors.Hand;
                    pic2.Click += (sender, e) => System.Diagnostics.Process.Start("explorer.exe", docUrl2);
                }
                else
                {
                    pic2.Image = Properties.Resources.r;
                    MessageBox.Show($"File not found: {docUrl2}");
                }
            }


            Button approveButton = new Button
            {
                Text = "Approve",
                Location = new Point(240, 70),
                Size = new Size(100, 30),
                BackColor = Color.Green,
                ForeColor = Color.White
            };

            Button rejectButton = new Button
            {
                Text = "Reject",
                Location = new Point(240, 100),
                Size = new Size(100, 30),
                BackColor = Color.Red,
                ForeColor = Color.White
            };

            approveButton.Click += (sender, e) =>
            {
                DialogResult result = MessageBox.Show($"Are you sure you want to approve {userName}?", "Confirm Approval", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ApproveUser(userId);
                }
            };

            rejectButton.Click += (sender, e) =>
            {
                DialogResult result = MessageBox.Show($"Are you sure you want to reject {userName}?", "Confirm Rejection", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    RejectUser(userId);
                }
            };


            userPanel.Controls.Add(nameLabel);
            userPanel.Controls.Add(statusLabel);
            userPanel.Controls.Add(pic1);
            userPanel.Controls.Add(pic2);
            userPanel.Controls.Add(approveButton);
            userPanel.Controls.Add(rejectButton);

            flowLayoutPanel1.Controls.Add(userPanel);
        }
    }
}
