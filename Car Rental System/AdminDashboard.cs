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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();

            AdminHome hForm = new AdminHome() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, };
            hForm.FormBorderStyle = FormBorderStyle.None;
            this.panel3.Controls.Add(hForm);
            hForm.Show();
        }

        public void LoadUserControl (UserControl control)
        {
            panel3.Controls.Clear();
            control.Dock = DockStyle.Fill;   
            panel3.Controls.Add(control);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminHome hForm = new AdminHome() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, };
            hForm.FormBorderStyle = FormBorderStyle.None;
            this.panel3.Controls.Add(hForm);
            hForm.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            AdminViewCar viewCarsControl = new AdminViewCar();
            panel3.Controls.Clear();
            panel3.Controls.Add(viewCarsControl);
            viewCarsControl.Dock = DockStyle.Fill;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddCars addCarsForm = new AddCars();
            addCarsForm.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(addCarsForm);
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
