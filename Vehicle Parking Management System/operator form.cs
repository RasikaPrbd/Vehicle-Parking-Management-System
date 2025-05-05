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
    public partial class attendant_form : Form
    {
        public attendant_form()
        {
            InitializeComponent();
        }

        private void btn_V_in_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vehicle_in vehicle_In = new Vehicle_in();
            vehicle_In.ShowDialog();
        }

        private void btn_V_out_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vehicle_out vehicle_Out = new Vehicle_out();
            vehicle_Out.ShowDialog();
        }

        private void linkLbl_logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void btn_AvailableSlots_Click(object sender, EventArgs e)
        {
            this.Hide();
            Slot_form slot_form = new Slot_form();
            slot_form.ShowDialog();
        }

        private void btn_status_Click(object sender, EventArgs e)
        {
            this.Hide();
            Status status = new Status();
            status.ShowDialog();
        }
    }
}
