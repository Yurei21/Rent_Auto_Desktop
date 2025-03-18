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
    public partial class Verification : Form
    {
        private int userId;
        public Verification(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Register_Click(object sender, EventArgs e)
        {

        }
    }
}
