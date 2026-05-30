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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace CafeManagementSystem
{
    public partial class MenuForm : Form
    {
        SqlConnection con = new SqlConnection(
@"Data Source=ALIZASOHAIL\SQLEXPRESS;
Initial Catalog=CafeDB;
Integrated Security=True");
        public MenuForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
