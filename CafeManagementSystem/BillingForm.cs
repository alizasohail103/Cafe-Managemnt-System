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

    public partial class BillingForm : Form
    {
        public BillingForm()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            rtbBill.Clear();

            rtbBill.AppendText("\tCAFE BILL\n");
            rtbBill.AppendText("--------------------------------------------------------\n");
            rtbBill.AppendText(
"Customer".PadRight(12) +
"Item".PadRight(20) +
"Qty".PadRight(6) +
"Price".PadRight(8) +
"Total\n"
);
            rtbBill.AppendText("---------------------------------------------------------\n");

            double grandTotal = 0;

            OrderForm o = (OrderForm)Application.OpenForms["OrderForm"];

            if (o != null)
            {
                foreach (DataGridViewRow row in o.dgvOrders.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        string customer = row.Cells[0].Value.ToString();
                        string item = row.Cells[1].Value.ToString();
                        string qty = row.Cells[2].Value.ToString();
                        string price = row.Cells[3].Value.ToString();
                        string total = row.Cells[4].Value.ToString();

                        rtbBill.AppendText(
                            customer.PadRight(12) +
                            item.PadRight(20) +
                            qty.PadRight(6) +
                            price.PadRight(8) +
                            total + "\n"
                        );

                        grandTotal += Convert.ToDouble(total);
                    }
                }
            }

            rtbBill.AppendText("----------------------------------------------------------\n");
            rtbBill.AppendText("Grand Total = " + grandTotal);
        }

        

        private void btnClear_Click(object sender, EventArgs e)

        {

            rtbBill.Clear();

        }

    }

}

    




