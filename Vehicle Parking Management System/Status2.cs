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

namespace Vehicle_Parking_Management_System
{
    public partial class Status2 : Form
    {
        public Status2()
        {
            InitializeComponent();
        }
        string connectionString = "Data Source=desktop-3234V3T;Initial Catalog=VPMS;Integrated Security=True;";


        private void Status2_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Vehicle_table", con);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dgv.AutoGenerateColumns = false;
                dgv.DataSource = dtbl;

            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_form admin_Form = new Admin_form();
            admin_Form.ShowDialog();
        }
    }
}
