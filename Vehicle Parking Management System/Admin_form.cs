using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehicle_Parking_Management_System
{
    public partial class Admin_form : Form
    {
        public Admin_form()
        {
            InitializeComponent();
        }

        private void linklbl_logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void btn_editRate_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditRate editRate = new EditRate();
            editRate.ShowDialog();
        }

        private void Admin_form_Load(object sender, EventArgs e)
        {

        }

        private void btn_editSlots_Click(object sender, EventArgs e)
        {
            this.Hide();
            AvailableSlots availableSlots = new AvailableSlots();
            availableSlots.ShowDialog();
        }

        private void btn_status_Click(object sender, EventArgs e)
        {
            this.Hide();
            Status2 status2 = new Status2();
            status2.ShowDialog();
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            this.Hide();
            report Report = new report();
            Report.ShowDialog();
        }
    }
}
