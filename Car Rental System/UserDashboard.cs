using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_System
{
    public partial class UserDashboard : Form
    {
        int userId;
        public UserDashboard(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            Console.WriteLine($"Debug: User ID being used: {userId}");
            UserViewCar userViewCar = new UserViewCar(this, this.GetLoggedInUserId());
            LoadUserControl(userViewCar);
        }
        public int GetLoggedInUserId()
        {
            return userId;
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

        private void button1_Click(object sender, EventArgs e)
        {
            UserReturn userReturn = new UserReturn();
            panel3.Controls.Clear();
            panel3.Controls.Add(userReturn);    
            userReturn.Dock = DockStyle.Fill;
        }
    }
}
