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
    public partial class UserRentCar : UserControl
    {
        public UserRentCar(UserDashboard dashboard, int vehicleId, string model, string brand, string imagePath, decimal price, string status)
        {
            InitializeComponent();
        }
    }
}
