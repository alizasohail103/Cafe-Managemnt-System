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
    public partial class ReportForm : Form
    {
        SqlConnection con = new SqlConnection(
@"Data Source=ALIZASOHAIL\SQLEXPRESS;
Initial Catalog=CafeDB;
Integrated Security=True");
        public ReportForm()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlDataAdapter da = new SqlDataAdapter(
            "SELECT * FROM Orders", con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvReports.DataSource = dt;

            con.Close();

            double totalSales = 0;

            foreach (DataGridViewRow row in dgvReports.Rows)
            {
                if (row.Cells["Total"].Value != null)
                {
                    totalSales += Convert.ToDouble(row.Cells["Total"].Value);
                }
            }

            lblSales.Text = "Total Sales : " + totalSales.ToString("0.00");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvReports.DataSource = null;
            dgvReports.Rows.Clear();
            dgvReports.Columns.Clear();

            lblSales.Text = "Total Sales : 0";
        }


    }
}

