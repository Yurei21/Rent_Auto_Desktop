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
        }

        public void LoadUserControl(UserControl control)
        {
            panel3.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panel3.Controls.Add(control);
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
        private void button2_Click(object sender, EventArgs e)
        {
            AdminViewCar viewCarsControl = new AdminViewCar(this);
            panel3.Controls.Clear();
            panel3.Controls.Add(viewCarsControl);
            viewCarsControl.Dock = DockStyle.Fill;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminRentals adminRentals = new AdminRentals();
            panel3.Controls.Clear();
            panel3.Controls.Add(adminRentals);
            adminRentals.Dock = DockStyle.Fill;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddCars addCarsForm = new AddCars();
            addCarsForm.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(addCarsForm);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            UserReturn userReturn = new UserReturn();
            userReturn.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(userReturn);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Landing landing = new Landing();
            landing.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdminPayments adminPayments = new AdminPayments();  
            adminPayments.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(adminPayments);
        }
    }
}
