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
    public partial class Vehicle_in : Form
    {
        public Vehicle_in()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=desktop-3234V3T;Initial Catalog=VPMS;Integrated Security=True;");

        private void rbtn_bike_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_bike.Checked)
            {
                rbtn_threewheel.Checked = false;
                rbtn_car.Checked = false;

                cmb_slot.Items.Clear();
                cmb_slot.Text = "";

                using (SqlConnection con = new SqlConnection(@"Data Source=desktop-3234V3T;Initial Catalog=VPMS;Integrated Security=True;"))
                {
                    con.Open();

                    string query = "SELECT SlotNumber FROM ParkingSlots_table WHERE Status = 'Available' AND VehicleType = 'Bike'";
                    SqlCommand command = new SqlCommand(query, con);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmb_slot.Items.Add(reader["SlotNumber"].ToString());
                        }
                    }
                }
            }
        }

        private void rbtn_threewheel_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_threewheel.Checked)
            {
                rbtn_bike.Checked = false;
                rbtn_car.Checked = false;

                cmb_slot.Items.Clear();
                cmb_slot.Text = "";

                using (SqlConnection con = new SqlConnection(@"Data Source=desktop-3234V3T;Initial Catalog=VPMS;Integrated Security=True;"))
                {
                    con.Open();

                    string query = "SELECT SlotNumber FROM ParkingSlots_table WHERE Status = 'Available' AND VehicleType = 'Three Wheel'";
                    SqlCommand command = new SqlCommand(query, con);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmb_slot.Items.Add(reader["SlotNumber"].ToString());
                        }
                    }
                }
            }
        }

        private void rbtn_car_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_car.Checked)
            {
                rbtn_bike.Checked = false;
                rbtn_threewheel.Checked = false;

                cmb_slot.Items.Clear();
                cmb_slot.Text = "";

                using (SqlConnection con = new SqlConnection(@"Data Source=desktop-3234V3T;Initial Catalog=VPMS;Integrated Security=True;"))
                {
                    con.Open();

                    string query = "SELECT SlotNumber FROM ParkingSlots_table WHERE Status = 'Available' AND VehicleType = 'Car'";
                    SqlCommand command = new SqlCommand(query, con);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmb_slot.Items.Add(reader["SlotNumber"].ToString());
                        }
                    }
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            rbtn_bike.Checked = false;
            rbtn_car.Checked = false;
            rbtn_threewheel.Checked = false;

            txt_plate.Clear();
            cmb_slot.Items.Clear();
            cmb_slot.Text = "";
            dtp_entry.Text = null;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            attendant_form attendant_Form = new attendant_form();
            attendant_Form.ShowDialog();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            con.Open();
            int newID = 1;
            SqlCommand getLastID = new SqlCommand("SELECT MAX(VehicleID) FROM Vehicle_table", con);
            object result = getLastID.ExecuteScalar();
            if (result != DBNull.Value && result != null)
            {
                newID = Convert.ToInt32(result) + 1;
            }
            string VehicleID = newID.ToString("D3");

            string LicensePlate = txt_plate.Text;
            string VehicleType;
            if (rbtn_bike.Checked)
                VehicleType = "Bike";
            else if (rbtn_car.Checked)
                VehicleType = "Car";
            else if (rbtn_threewheel.Checked)
                VehicleType = "Three Wheel";
            else VehicleType = "Unknown";
            string SlotNumber = cmb_slot.Text;

            TimeSpan selectedTime = dtp_entry.Value.TimeOfDay;
            DateTime combinedDateTime = DateTime.Today.Add(selectedTime);
            DateTime EntryTime = combinedDateTime;

            if (string.IsNullOrEmpty(SlotNumber))
            {
                MessageBox.Show("Plaese select a parkin slot.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return;
            }
            if (string.IsNullOrEmpty(LicensePlate))
            {
                MessageBox.Show("Plaese enter the plate number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return;
            }

            string query_insert = "INSERT INTO Vehicle_table (VehicleID, LicensePlate, VehicleType, SlotNumber, EntryTime) VALUES('" + VehicleID + "','" + LicensePlate + "','" + VehicleType + "','" + SlotNumber + "','" + EntryTime + "')";
            SqlCommand cmnd = new SqlCommand(query_insert, con);
            cmnd.ExecuteNonQuery();
            MessageBox.Show("Record Added Succesfully", "Register Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            

            if (cmb_slot.SelectedItem != null)
            {
                string selectedSlot = cmb_slot.SelectedItem.ToString();
                string query = "UPDATE ParkingSlots_table SET Status = 'Parked' WHERE SlotNumber = @SlotNumber";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@SlotNumber", selectedSlot);
                cmd.ExecuteNonQuery();

                cmb_slot.Items.Remove(SlotNumber);
                cmb_slot.SelectedIndex = -1 ;
                
            }
            con.Close();
            txt_plate.Text = "";
        }

        private void Vehicle_in_Load(object sender, EventArgs e)
        {
            
        }
    }
}
