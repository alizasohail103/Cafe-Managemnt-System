using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagementSystem
{
    public partial class OrderForm : Form
    {
        SqlConnection con = new SqlConnection(
@"Data Source=ALIZASOHAIL\SQLEXPRESS;
Initial Catalog=CafeDB;
Integrated Security=True");
        public OrderForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int qty;
            double price, total;

            qty = Convert.ToInt32(txtQty.Text);
            price = Convert.ToDouble(txtPrice.Text);

            total = qty * price;

            txtTotal.Text = total.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // ADD TO DATAGRIDVIEW
            dgvOrders.Rows.Add(
                txtCustomer.Text,
                cmbItem.Text,
                txtQty.Text,
                txtPrice.Text,
                txtTotal.Text
            );

            con.Open();

            SqlCommand cmd = new SqlCommand(
            @"INSERT INTO Orders
            (CustomerName, ItemName, Quantity, Price, Total)
            VALUES
            (@customer,@item,@qty,@price,@total)", con);

            cmd.Parameters.AddWithValue("@customer", txtCustomer.Text);
            cmd.Parameters.AddWithValue("@item", cmbItem.Text);
            cmd.Parameters.AddWithValue("@qty", Convert.ToInt32(txtQty.Text));
            cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(txtPrice.Text));
            cmd.Parameters.AddWithValue("@total", Convert.ToDecimal(txtTotal.Text));

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Order Added Successfully");
        }




        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomer.Clear();
            cmbItem.Text = "";
            txtQty.Clear();
            txtPrice.Clear();
            txtTotal.Clear();
        }


        private void cmbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbItem.Text == "Espresso")
                txtPrice.Text = "450";

            else if (cmbItem.Text == "Latte")
                txtPrice.Text = "650";

            else if (cmbItem.Text == "Cappuccino")
                txtPrice.Text = "700";

            else if (cmbItem.Text == "Mocha")
                txtPrice.Text = "750";

            else if (cmbItem.Text == "Cold Coffee")
                txtPrice.Text = "850";

            else if (cmbItem.Text == "Croissant")
                txtPrice.Text = "400";

            else if (cmbItem.Text == "Brownie")
                txtPrice.Text = "500";

            else if (cmbItem.Text == "Lava Cake")
                txtPrice.Text = "950";

            else if (cmbItem.Text == "Chocolate Pastry")
                txtPrice.Text = "450";

            else if (cmbItem.Text == "Donut")
                txtPrice.Text = "300";

            else if (cmbItem.Text == "Zinger Burger")
                txtPrice.Text = "900";

            else if (cmbItem.Text == "Pizza")
                txtPrice.Text = "950";

            else if (cmbItem.Text == "Fries")
                txtPrice.Text = "350";

            else if (cmbItem.Text == "Club Sandwich")
                txtPrice.Text = "850";

            else if (cmbItem.Text == "Pasta")
                txtPrice.Text = "1200";

            else if (cmbItem.Text == "Mint Margarita")
                txtPrice.Text = "450";

            else if (cmbItem.Text == "Juice")
                txtPrice.Text = "350";

            else if (cmbItem.Text == "Cold Drink")
                txtPrice.Text = "250";

            else if (cmbItem.Text == "Milkshake")
                txtPrice.Text = "850";

            else if (cmbItem.Text == "Iced Tea")
                txtPrice.Text = "500";
        }
    }
}
