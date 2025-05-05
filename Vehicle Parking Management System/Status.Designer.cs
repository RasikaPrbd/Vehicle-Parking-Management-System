namespace Vehicle_Parking_Management_System
{
    partial class Status
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv = new System.Windows.Forms.DataGridView();
            this.VehicleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LicensePlate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntryTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SlotNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VehicleID,
            this.LicensePlate,
            this.VehicleType,
            this.EntryTime,
            this.SlotNumber});
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(909, 505);
            this.dgv.TabIndex = 0;
            // 
            // VehicleID
            // 
            this.VehicleID.DataPropertyName = "VehicleID";
            this.VehicleID.HeaderText = "Vehicle ID";
            this.VehicleID.MinimumWidth = 6;
            this.VehicleID.Name = "VehicleID";
            this.VehicleID.Width = 125;
            // 
            // LicensePlate
            // 
            this.LicensePlate.DataPropertyName = "LicensePlate";
            this.LicensePlate.HeaderText = "Plate Number";
            this.LicensePlate.MinimumWidth = 6;
            this.LicensePlate.Name = "LicensePlate";
            this.LicensePlate.Width = 125;
            // 
            // VehicleType
            // 
            this.VehicleType.DataPropertyName = "VehicleType";
            this.VehicleType.HeaderText = "Vehicle Type";
            this.VehicleType.MinimumWidth = 6;
            this.VehicleType.Name = "VehicleType";
            this.VehicleType.Width = 125;
            // 
            // EntryTime
            // 
            this.EntryTime.DataPropertyName = "EntryTime";
            this.EntryTime.HeaderText = "Entry Time";
            this.EntryTime.MinimumWidth = 6;
            this.EntryTime.Name = "EntryTime";
            this.EntryTime.Width = 125;
            // 
            // SlotNumber
            // 
            this.SlotNumber.DataPropertyName = "SlotNumber";
            this.SlotNumber.HeaderText = "Slot Number";
            this.SlotNumber.MinimumWidth = 6;
            this.SlotNumber.Name = "SlotNumber";
            this.SlotNumber.Width = 125;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_back.Location = new System.Drawing.Point(36, 532);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(120, 50);
            this.btn_back.TabIndex = 13;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 603);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.dgv);
            this.Name = "Status";
            this.Text = "Status";
            this.Load += new System.EventHandler(this.Status_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LicensePlate;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleType;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntryTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn SlotNumber;
        private System.Windows.Forms.Button btn_back;
    }
}