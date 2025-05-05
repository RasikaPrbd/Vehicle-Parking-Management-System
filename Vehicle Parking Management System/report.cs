using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehicle_Parking_Management_System
{
    public partial class report : Form
    {
        public report()
        {
            InitializeComponent();
        }

        private void report_Load(object sender, EventArgs e)
        {
            cmb_month.Items.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });

            for (int i = 2020; i <= DateTime.Now.Year; i++)
            {
                cmb_year.Items.Add(i.ToString());
            }

            cmb_month.SelectedIndex = DateTime.Now.Month - 1;
            cmb_year.SelectedIndex = cmb_year.Items.Count - 1;
        }

        private void btn_generateReport_Click(object sender, EventArgs e)
        {
            int selectedMonth = Convert.ToInt32(cmb_month.SelectedItem);
            int selectedYear = Convert.ToInt32(cmb_year.SelectedItem);

            FetchMonthlyReport(selectedMonth, selectedYear);
        }

        private void FetchMonthlyReport(int selectedMonth, int selectedYear)
        {
            string connectionString = "Data Source=desktop-3234V3T;Initial Catalog=VPMS;Integrated Security=True;";

            string query = @"SELECT VehicleType, COUNT(*) AS TotalVehicle, SUM(ParkingFee) AS TotalIncome FROM Ticket_table WHERE MONTH(ExitTime) = @SelectedMonth AND 
                            Year(ExitTime) = @SelectedYear GROUP BY VehicleType";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@SelectedMonth", selectedMonth);
                cmd.Parameters.AddWithValue("@SelectedYear", selectedYear);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);

                dataGridView1.DataSource = dt;

                decimal totalIncome = 0;
                int totalVehicles = 0;

                foreach (DataRow row in dt.Rows)
                {
                    totalIncome += Convert.ToDecimal(row["TotalIncome"]);
                    totalVehicles += Convert.ToInt32(row["TotalVehicle"]);
                }
                

                txt_total.Text = totalIncome.ToString("N2");

                txt_vehicle.Text = totalVehicles.ToString();

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
