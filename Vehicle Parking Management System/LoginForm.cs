using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Vehicle_Parking_Management_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            txt_pass.PasswordChar = '*';
        }



        private void btn_login_Click(object sender, EventArgs e)
        {
            string userID = txt_uID.Text;
            string password = txt_pass.Text;

            if (userID == "operator" && password == "123")
            {
                this.Hide();
                attendant_form attendant_Form = new attendant_form();
                attendant_Form.ShowDialog();
            }
            else if (userID == "Admin" && password == "123")
                        {
                this.Hide();
                Admin_form admin_form = new Admin_form();
                admin_form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid login credentials, Please check UserId and Password and try again",
                    "Invalid login details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            txt_uID.Focus();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_uID.Clear();
            txt_pass.Clear();
            txt_uID.Focus();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = 
                MessageBox.Show("Are you sure, Do you want to exit...?", "Exit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                Console.WriteLine("Application still running.");
            }
        }

        private void txt_uID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_pass.Focus();
                e.SuppressKeyPress = true;
            }
        }
       

        private void txt_pass_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void Enter(object sender, EventArgs e) { }

        private void txt_pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_login.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {
        }

    }
}
