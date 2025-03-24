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
        public UserDashboard()
        {
            InitializeComponent();
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
    }
}
