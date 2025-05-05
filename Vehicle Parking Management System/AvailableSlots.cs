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
    public partial class AvailableSlots : Form
    {
        public AvailableSlots()
        {
            InitializeComponent();
        }

        string connectionString = "Data Source=desktop-3234V3T;Initial Catalog=VPMS;Integrated Security=True;";

        private void AvailableSlots_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string queryUnavailable = "SELECT SlotNumber FROM ParkingSlots_table WHERE Status = 'Unavailable'";
                SqlCommand commandUnavailable = new SqlCommand(queryUnavailable, con);
                using (SqlDataReader reader = commandUnavailable.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cmb_addSlots.Items.Add(reader["SlotNumber"].ToString());
                    }
                }

                string queryAvailable = "SELECT SlotNumber FROM ParkingSlots_table WHERE Status = 'Available'";
                SqlCommand commandAvailable = new SqlCommand(queryAvailable, con);
                using (SqlDataReader reader = commandAvailable.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cmb_removeSlot.Items.Add(reader["SlotNumber"].ToString());
                    }
                }
            }

            Dictionary<string, string> slotStatus = GetSlotStatuses();
            UpdateButtonColors(this.Controls, slotStatus);
        }

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

        private void btn_AddSlot_Click(object sender, EventArgs e)
        {
            if (cmb_addSlots.SelectedItem != null)
            {
                string selectedSlot = cmb_addSlots.SelectedItem.ToString();
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "UPDATE ParkingSlots_table SET Status = 'Available' WHERE SlotNumber = @SlotNumber";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@SlotNumber", selectedSlot);

                    con.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show($"Slot {selectedSlot} is now available.", "Success");
                        cmb_addSlots.Items.Remove(selectedSlot);
                        cmb_removeSlot.Items.Add(selectedSlot);
                        RefreshSlotColors();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update the slot status.", "Error");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a slot before confirming.", "Error");
            }
        }

        private void btn_RemoveSlot_Click(object sender, EventArgs e)
        {
            if (cmb_removeSlot.SelectedItem != null)
            {
                string selectedSlot = cmb_removeSlot.SelectedItem.ToString();
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "UPDATE ParkingSlots_table SET Status = 'Unavailable' WHERE SlotNumber = @SlotNumber";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@SlotNumber", selectedSlot);

                    con.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show($"Slot {selectedSlot} is now unavailable.", "Success");
                        cmb_removeSlot.Items.Remove(selectedSlot);
                        cmb_addSlots.Items.Add(selectedSlot);
                        RefreshSlotColors();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update the slot status.", "Error");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a slot before confirming.", "Error");
            }
        }

        private void RefreshSlotColors()
        {
            Dictionary<string, string> slotStatus = GetSlotStatuses();
            UpdateButtonColors(this.Controls, slotStatus);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_form admin_Form = new Admin_form();
            admin_Form.ShowDialog();
        }
    }
}
