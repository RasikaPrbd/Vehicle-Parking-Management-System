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
    public partial class Slot_form : Form
    {
        public Slot_form()
        {
            InitializeComponent();
        }

        string connectionString = "Data Source=desktop-3234V3T;Initial Catalog=VPMS;Integrated Security=True;";

        

        private Dictionary<string, string> GetSlotStatuses()
        {
            Dictionary<string, string> slotStatus = new Dictionary<string, string>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT SlotNumber, Status FROM ParkingSlots_table";
                SqlCommand command = new SqlCommand(query, con);

                con.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        slotStatus[reader["SlotNumber"].ToString()] = reader["Status"].ToString();
                    }
                }
            }

            return slotStatus;
        }

        private void UpdateButtonColors(Control.ControlCollection controls, Dictionary<string, string> slotStatus)
        {
            foreach (Control control in controls)
            {
                if (control is Button button && slotStatus.ContainsKey(button.Text))
                {
                    string status = slotStatus[button.Text];
                    switch (status)
                    {
                        case "Available":
                            button.BackColor = Color.Green;
                            break;
                        case "Unavailable":
                            button.BackColor = Color.Red;
                            break;
                        case "Parked":
                            button.BackColor = Color.Blue;
                            break;
                        default:
                            button.BackColor = SystemColors.Control;
                            break;
                    }
                }
                else if (control.HasChildren)
                {
                    UpdateButtonColors(control.Controls, slotStatus);
                }
            }
        }

        

       

        private void RefreshSlotColors()
        {
            Dictionary<string, string> slotStatus = GetSlotStatuses();
            UpdateButtonColors(this.Controls, slotStatus);
        }

       

        private void btn_back_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            attendant_form attendant_Form = new attendant_form();
            attendant_Form.ShowDialog();
        }

        private void Slot_form_Load_1(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string queryUnavailable = "SELECT SlotNumber FROM ParkingSlots_table WHERE Status = 'Unavailable'";
                SqlCommand commandUnavailable = new SqlCommand(queryUnavailable, con);
                using (SqlDataReader reader = commandUnavailable.ExecuteReader())
                {
                    while (reader.Read()) { }

                }

                string queryAvailable = "SELECT SlotNumber FROM ParkingSlots_table WHERE Status = 'Available'";
                SqlCommand commandAvailable = new SqlCommand(queryAvailable, con);
                using (SqlDataReader reader = commandAvailable.ExecuteReader())
                {
                    while (reader.Read()) { }

                }
            }

            Dictionary<string, string> slotStatus = GetSlotStatuses();
            UpdateButtonColors(this.Controls, slotStatus);
        }
    }
}
