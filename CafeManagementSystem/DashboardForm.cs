using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagementSystem
{
    
        public partial class DashboardForm : Form
        {
            public DashboardForm()
            {
                InitializeComponent();
            }

        // MENU BUTTON
        private void btnMenu_Click(object sender, EventArgs e)
        {
            MenuForm m = new MenuForm();
            m.Show();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            OrderForm o = new OrderForm();
            o.Show();
        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            BillingForm b = new BillingForm();
            b.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportForm r = new ReportForm();
            r.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm l = new LoginForm();
            l.Show();

            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    }

