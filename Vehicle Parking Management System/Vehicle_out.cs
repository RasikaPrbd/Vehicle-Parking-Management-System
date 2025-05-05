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
using System.Drawing.Printing;
using System.IO;
using PdfSharp.Pdf;
using PdfSharp.Drawing;




namespace Vehicle_Parking_Management_System
{
    public partial class Vehicle_out : Form
    {
        public Vehicle_out()
        {
            InitializeComponent();
        }
        private readonly string connectionString = "Data Source=desktop-3234V3T;Initial Catalog=VPMS;Integrated Security=True;";

        SqlConnection con = new SqlConnection(@"Data Source=desktop-3234V3T;Initial Catalog=VPMS;Integrated Security=True;");

        private void btn_clear_Click(object sender, EventArgs e)
        {
            cmb_plate.Text = "";
            dtp_exit.Text = null;
            txt_amount.Clear();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            attendant_form attendant_Form = new attendant_form();
            attendant_Form.ShowDialog();
        }

        private void cmb_plate_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string selectedPlate = cmb_plate.Text;

                string queryVehicleInfo = "SELECT EntryTime, VehicleType FROM Vehicle_table WHERE LicensePlate = @PlateNumber ";
                SqlCommand cmdVehicleInfo = new SqlCommand(queryVehicleInfo, con);
                cmdVehicleInfo.Parameters.AddWithValue("@PlateNumber", selectedPlate);
                SqlDataReader reader = cmdVehicleInfo.ExecuteReader();

                DateTime entryTime = DateTime.MinValue;
                string VehicleType = "";
                if (reader.Read())
                {
                    entryTime = (DateTime)reader["EntryTime"];
                    VehicleType = reader["VehicleType"].ToString();
                }
                reader.Close();

                if (entryTime != DateTime.MinValue)
                {
                    DateTime exitTime = DateTime.Now;
                    TimeSpan parkedTime = exitTime - entryTime;

                    int totalHours = (int)Math.Ceiling(parkedTime.TotalHours);

                    string queryRate = "SELECT FirstHourRate, AdditionalHourRate FROM EditRate_table WHERE VehicleType = @VehicleType";
                    SqlCommand cmdRate = new SqlCommand(queryRate, con);

                    cmdRate.Parameters.AddWithValue("@VehicleType", VehicleType);

                    SqlDataReader rateReader = cmdRate.ExecuteReader();
                    decimal firstHourRate = 0;
                    decimal additionalHourRate = 0;

                    if (rateReader.Read())
                    {
                        firstHourRate = (decimal)rateReader["FirstHourRate"];
                        additionalHourRate = (decimal)rateReader["AdditionalHourRate"];
                    }
                    rateReader.Close();

                    decimal totalFee = firstHourRate;

                    if (totalHours > 1)
                    {
                        totalFee += (totalHours - 1) * additionalHourRate;
                    }
                    txt_amount.Text = totalFee.ToString("F2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }

        }

        private void Vehicle_out_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=desktop-3234V3T;Initial Catalog=VPMS;Integrated Security=True;"))
                {
                    con.Open();

                    string query = "SELECT LicensePlate FROM Vehicle_table";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable PlateNumbersTable = new DataTable();
                        adapter.Fill(PlateNumbersTable);

                        if (PlateNumbersTable.Rows.Count == 0)
                        {
                            MessageBox.Show("No vehicles currently parked.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            cmb_plate.DataSource = PlateNumbersTable;
                            cmb_plate.DisplayMember = "LicensePlate";
                            cmb_plate.ValueMember = "LicensePlate";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=desktop-3234V3T;Initial Catalog=VPMS;Integrated Security=True;";

            string selectedPlate = cmb_plate.SelectedValue?.ToString();
            if (string.IsNullOrEmpty(selectedPlate))
            {
                MessageBox.Show("Please Select a Plate Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            

            TimeSpan selectedTime = dtp_exit.Value.TimeOfDay;
            DateTime ExitTime = DateTime.Today.Add(selectedTime);

            string copyquery = @"INSERT INTO Ticket_table(VehicleID, LicensePlate,VehicleType, SlotNumber, EntryTime, ExitTime, Duration, ParkingFee) SELECT VehicleID, LicensePlate,VehicleType, SlotNumber, EntryTime, @ExitTime, @TotalHours, @TotalFee FROM Vehicle_table WHERE LicensePlate = @LicensePlate";
            string deletequery = "DELETE FROM Vehicle_table WHERE LicensePlate = @LicensePlate";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                        string queryVehicleInfo = "SELECT EntryTime, VehicleType, SlotNumber From Vehicle_table WHERE LicensePlate = @PlateNumber";
                        SqlCommand cmdVehicleInfo = new SqlCommand (queryVehicleInfo, con);
                        cmdVehicleInfo.Parameters.AddWithValue("@PlateNumber", selectedPlate);
                        
                        SqlDataReader reader = cmdVehicleInfo.ExecuteReader();
                        if (!reader.Read())
                    {
                        MessageBox.Show("No matching records found in Vehicle_table.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                        DateTime entryTime = (DateTime)reader["EntryTime"];
                        string vehicleType = reader["VehicleType"].ToString();
                        string slotNumber = reader["SlotNumber"].ToString();
                        reader.Close();

                        if (string.IsNullOrEmpty(slotNumber))
                    {
                        MessageBox.Show("SlotNumber is missing for the selectd vehicle.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                        DateTime exitTime = DateTime.Now;
                        TimeSpan parkedTime = exitTime - entryTime;
                        int totalHours = (int)Math.Ceiling(parkedTime.TotalHours);

                        string queryRate = "SELECT FirstHourRate, AdditionalHourRate From EditRate_table WHERE VehicleType = @VehicleType";
                        SqlCommand cmdRate = new SqlCommand (queryRate, con);
                        cmdRate.Parameters.AddWithValue("@VehicleType", vehicleType);

                        SqlDataReader rateReader = cmdRate.ExecuteReader();
                        if (!rateReader.Read())
                    {
                        MessageBox.Show("Rate details not found for this vehicle type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return ;
                    }
                        decimal firstHourRate = (decimal)rateReader["FirstHourRate"];
                        decimal additionalHourRate = (decimal)rateReader["AdditionalHourRate"];
                    
                        rateReader.Close();

                        decimal totalFee = firstHourRate;

                        if (totalHours > 1)
                        {
                            totalFee += (totalHours - 1) * additionalHourRate;
                        }
                        
                    


                    using (SqlTransaction transaction = con.BeginTransaction())
                    {
                        try
                        {
                            using (SqlCommand copyCmd = new SqlCommand(copyquery, con, transaction))
                            {
                                copyCmd.Parameters.AddWithValue("@LicensePlate", selectedPlate);
                                copyCmd.Parameters.AddWithValue("@ExitTime", ExitTime);
                                copyCmd.Parameters.AddWithValue("@TotalHours", totalHours);
                                copyCmd.Parameters.AddWithValue("@TotalFee", totalFee);
                                int rowsCopied = copyCmd.ExecuteNonQuery();
                                if (rowsCopied == 0)
                                {
                                    MessageBox.Show("No matching records found in Vehicle_table.", "Warning");
                                    transaction.Rollback();
                                    return;
                                }
                            }
                            using (SqlCommand deleteCmd = new SqlCommand(deletequery, con, transaction))
                            {
                                deleteCmd.Parameters.AddWithValue("@LicensePlate", selectedPlate);
                                deleteCmd.ExecuteNonQuery();
                            }
                            string updateSlotQuery = "UPDATE ParkingSlots_table SET Status = 'Available' WHERE SlotNumber = @SlotNumber";
                            using (SqlCommand updateSlotCmd = new SqlCommand(updateSlotQuery, con, transaction))
                            {
                                updateSlotCmd.Parameters.AddWithValue("@SlotNumber", slotNumber);
                                updateSlotCmd.ExecuteNonQuery();
                            }
                            transaction.Commit();


                            if (cmb_plate.SelectedItem != null)
                            {
                                string selectedSlot = cmb_plate.SelectedItem.ToString();
                                string query = "UPDATE ParkingSlots_table SET Status = 'Available' WHERE SlotNumber = @SlotNumber";
                                using (SqlCommand cmd = new SqlCommand(query, con, transaction))
                                {
                                    cmd.Parameters.AddWithValue("@SlotNumber", selectedSlot);
                                    cmd.ExecuteNonQuery();

                                }
                            }

                        }

                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            printDocument1.Print();

            this.Hide();
            Vehicle_out vehicle_Out = new Vehicle_out();
            vehicle_Out.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string selectedPlate = cmb_plate.SelectedValue?.ToString();
            if (string.IsNullOrEmpty(selectedPlate))
            {
                MessageBox.Show("Please select a plate number before printing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM Ticket_table Where LicensePlate = @LicensePlate";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@LicensePlate", selectedPlate);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                MessageBox.Show("Vehicle removed successfully!", "Record remove", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                string vehicleID = reader["VehicleID"].ToString();
                                string vehicleType = reader["vehicleType"].ToString();
                                string licensePlate = reader["LicensePlate"].ToString();
                                string slotNumber = reader["SlotNumber"].ToString();
                                DateTime entryTime = (DateTime)reader["EntryTime"];
                                DateTime exitTime = (DateTime)reader["ExitTime"];
                                decimal duration = (decimal)reader["Duration"];
                                decimal parkingFee = (decimal)reader["ParkingFee"];

                                string folderPath = @"C:\Users\Rasika\Desktop\test_pdf";
                                Directory.CreateDirectory(folderPath);

                                string fileName = $"Receipt_{licensePlate}_{exitTime:dd-MM-yyyy}.pdf";
                                string filePath = Path.Combine(folderPath, fileName);

                                float PageWidth = e.PageBounds.Width;
                                float centerX = PageWidth / 2;

                                string header = "VEHICLE PARKING MANAGEMENT SYSTEM";
                                e.Graphics.DrawString(header, new Font("Arial", 14, FontStyle.Bold), Brushes.Black, centerX - (e.Graphics.MeasureString(header, new Font("Arial", 14)).Width / 2), 20);
                                string separator = "==================================";
                                e.Graphics.DrawString(separator, new Font("Arial", 10), Brushes.Black, centerX - (e.Graphics.MeasureString(separator, new Font("Arial", 10)).Width / 2), 50);

                                string title = "PARKING RECEIPT";
                                e.Graphics.DrawString(title, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, centerX - (e.Graphics.MeasureString(title, new Font("Arial", 12)).Width / 2), 80);

                                e.Graphics.DrawString(separator, new Font("Arial", 10), Brushes.Black, centerX - (e.Graphics.MeasureString(separator, new Font("Arial", 10)).Width / 2), 110);

                                float startY = 140;
                                float lineHeight = 25;
                                Font detailFont = new Font("Arial", 10);

                                e.Graphics.DrawString($"Vehicle ID:            {vehicleID}", detailFont, Brushes.Black, centerX - 100, startY);
                                e.Graphics.DrawString($"Plate Number:       {licensePlate}", detailFont, Brushes.Black, centerX - 100, startY + lineHeight);
                                e.Graphics.DrawString($"Vehicle Type:        {vehicleType}", detailFont, Brushes.Black, centerX - 100, startY + lineHeight * 2);
                                e.Graphics.DrawString($"Slot Number:         {slotNumber}", detailFont, Brushes.Black, centerX - 100, startY + lineHeight * 3);
                                e.Graphics.DrawString($"Entry Time:            {entryTime:dd/MM/yyyy hh:mm tt}", detailFont, Brushes.Black, centerX - 100, startY + lineHeight * 4);
                                e.Graphics.DrawString($"Exit Time:              {exitTime:dd/MM/yyyy hh:mm tt}", detailFont, Brushes.Black, centerX - 100, startY + lineHeight * 5);
                                e.Graphics.DrawString($"Duration:                {duration:F2} hours", detailFont, Brushes.Black, centerX - 100, startY + lineHeight * 6);
                                e.Graphics.DrawString($"Parking Fee:         {parkingFee:C2}", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, centerX - 100, startY + lineHeight * 7);

                                float footerY = startY + lineHeight * 9;
                                e.Graphics.DrawString(separator, new Font("Arial", 10), Brushes.Black, centerX - (e.Graphics.MeasureString(separator, new Font("Arial", 10)).Width / 2), footerY);
                                string footerNote = "Thank you for parking with us!";
                                e.Graphics.DrawString(footerNote, new Font("Arial", 10, FontStyle.Italic), Brushes.Black, centerX - (e.Graphics.MeasureString(footerNote, new Font("Arial", 10)).Width / 2), footerY + 30);
                                string footerGreeting = "Have a great day!";
                                e.Graphics.DrawString(footerGreeting, new Font("Arial", 10, FontStyle.Italic), Brushes.Black, centerX - (e.Graphics.MeasureString(footerGreeting, new Font("Arial", 10)).Width / 2), footerY + 50);


                            }
                            else
                            {
                                MessageBox.Show("No ticket found the selected plate number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving ticket details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
