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
    public partial class EditRate : Form
    {
        public EditRate()
        {
            InitializeComponent();


        }
        string connectionString = "Data Source=desktop-3234V3T;Initial Catalog=VPMS;Integrated Security=True;";

        SqlConnection con = new SqlConnection(@"Data Source=desktop-3234V3T;Initial Catalog=VPMS;Integrated Security=True;");


        private void EditRate_Load(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT DISTINCT VehicleType FROM EditRate_table";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();

            cmb_VehicleType.DropDownStyle = ComboBoxStyle.DropDownList;

            while (reader.Read())
            {
                cmb_VehicleType.Items.Add(reader["VehicleType"].ToString());
            }

            reader.Close();
            con.Close();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            
            string vehicleType = cmb_VehicleType.Text;

            if (string.IsNullOrEmpty(vehicleType) ||
                string.IsNullOrEmpty(txt_FirstHour.Text) ||
                string.IsNullOrEmpty(txt_AddHours.Text))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            if  (!decimal.TryParse(txt_FirstHour.Text, out decimal firstHourRate) ||
                !decimal.TryParse(txt_AddHours.Text, out decimal addHoursRate))
            {
                MessageBox.Show("Invalid input for rates. Please enter valid numbers.");
                return;
            }

            try
            {
                con.Open();
                string checkQuery = "SELECT COUNT(*) FROM EditRate_table WHERE VehicleType = @VehicleType";
                SqlCommand checkCmd = new SqlCommand(checkQuery, con);

                checkCmd.Parameters.AddWithValue("@VehicleType", vehicleType);
                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    string updateQuery = @"UPDATE EditRate_table SET FirstHourRate = @FirstHourRate, AdditionalHourRate= @AdditionalHourRate WHERE VehicleType = @VehicleType";
                    SqlCommand updateCmd = new SqlCommand(updateQuery, con);

                    updateCmd.Parameters.AddWithValue("@VehicleType", vehicleType);
                    updateCmd.Parameters.AddWithValue("@FirstHourRate", firstHourRate);
                    updateCmd.Parameters.AddWithValue("@AdditionalHourRate", addHoursRate);
                    updateCmd.ExecuteNonQuery();
                }
                else
                {
                    string insertQuery = @"INSERT INTO EditRate_table (VehicleType, FirstHourRate, AdditionalHourRate) VALUES (@VehicleType, @FirstHourRate, @AdditionalHourRate)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, con);

                    insertCmd.Parameters.AddWithValue("@VehicleType", vehicleType);
                    insertCmd.Parameters.AddWithValue("@FirstHourRate", firstHourRate);
                    insertCmd.Parameters.AddWithValue("@AdditionalHourRate", addHoursRate);
                    insertCmd.ExecuteNonQuery();
                }

                MessageBox.Show("Rates saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving rates: "+ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_form admin_Form = new Admin_form();
            admin_Form.ShowDialog();
        }

        private void cmb_VehicleType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedVehicleType = cmb_VehicleType.Text;

            if (!string.IsNullOrEmpty(selectedVehicleType) )
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    try
                    {
                        con.Open();
                        string query = "SELECT FirstHourRate, AdditionalHourRate FROM EditRate_table WHERE VehicleType= @VehicleType";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@VehicleType", selectedVehicleType);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            txt_FirstHour.Text = reader["FirstHourRate"].ToString();
                            txt_AddHours.Text = reader["AdditionalHourRate"].ToString();
                        }
                        else
                        {
                            txt_FirstHour.Text = string.Empty;
                            txt_AddHours.Text = string.Empty;
                            MessageBox.Show("Rates not found for the selected vehicle Type.");
                        }
                    }
                    catch(Exception ex) 
                    {
                        MessageBox.Show("Error loading retes: " + ex.Message);
                    }
                }
            }
        }
    }
}
