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
    public partial class UserDashboard : Form
    {
        int userId;
        public UserDashboard(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            string name = GetUserName(userId);
            string format = string.Join("\n", name.Split(' '));
            label1.Text = $"Welcome, \n{format}";
            UserViewCar userViewCar = new UserViewCar(this, this.GetLoggedInUserId());
            LoadUserControl(userViewCar);
        }
        public int GetLoggedInUserId()
        {
            return userId;
        }

        public string GetUserName(int userId)
        {
            string name = "";
            DatabaseHelper db = new DatabaseHelper();
            String query = "SELECT name FROM users WHERE user_id = @userId";
            MySqlParameter[] param = { new MySqlParameter("@userId", userId) };
            db.ExecuteScalar(query, param);
            DataTable result = db.FetchData(query, param);

            if (result.Rows.Count > 0)
            {
                name = result.Rows[0]["name"].ToString();
            }

            return name;
        }

        public void LoadUserControl(UserControl control)
        {
            panel3.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panel3.Controls.Add(control);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserViewCar userViewCar = new UserViewCar(this, this.GetLoggedInUserId());
            panel3.Controls.Clear();
            panel3.Controls.Add(userViewCar);
            userViewCar.Dock = DockStyle.Fill;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to proceed?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Logging out", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Landing landing = new Landing();
                landing.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserProfile userProfile = new UserProfile(userId);
            LoadUserControl(userProfile);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UserRecords userRecords = new UserRecords(userId);
            panel3.Controls.Clear();
            panel3.Controls.Add(userRecords);
            userRecords.Dock = DockStyle.Fill;
        }
    }
}
