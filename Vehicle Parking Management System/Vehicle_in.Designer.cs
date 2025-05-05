namespace Vehicle_Parking_Management_System
{
    partial class Vehicle_in
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vehicle_in));
            this.label1 = new System.Windows.Forms.Label();
            this.rbtn_bike = new System.Windows.Forms.RadioButton();
            this.rbtn_threewheel = new System.Windows.Forms.RadioButton();
            this.rbtn_car = new System.Windows.Forms.RadioButton();
            this.lbl_slot = new System.Windows.Forms.Label();
            this.txt_plate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_slot = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_entry = new System.Windows.Forms.DateTimePicker();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(141, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicle Type";
            // 
            // rbtn_bike
            // 
            this.rbtn_bike.AutoSize = true;
            this.rbtn_bike.BackColor = System.Drawing.Color.Transparent;
            this.rbtn_bike.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_bike.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtn_bike.Location = new System.Drawing.Point(197, 150);
            this.rbtn_bike.Name = "rbtn_bike";
            this.rbtn_bike.Size = new System.Drawing.Size(75, 29);
            this.rbtn_bike.TabIndex = 1;
            this.rbtn_bike.TabStop = true;
            this.rbtn_bike.Text = "Bike";
            this.rbtn_bike.UseVisualStyleBackColor = false;
            this.rbtn_bike.CheckedChanged += new System.EventHandler(this.rbtn_bike_CheckedChanged);
            // 
            // rbtn_threewheel
            // 
            this.rbtn_threewheel.AutoSize = true;
            this.rbtn_threewheel.BackColor = System.Drawing.Color.Transparent;
            this.rbtn_threewheel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_threewheel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtn_threewheel.Location = new System.Drawing.Point(347, 150);
            this.rbtn_threewheel.Name = "rbtn_threewheel";
            this.rbtn_threewheel.Size = new System.Drawing.Size(152, 29);
            this.rbtn_threewheel.TabIndex = 1;
            this.rbtn_threewheel.TabStop = true;
            this.rbtn_threewheel.Text = "Three wheel";
            this.rbtn_threewheel.UseVisualStyleBackColor = false;
            this.rbtn_threewheel.CheckedChanged += new System.EventHandler(this.rbtn_threewheel_CheckedChanged);
            // 
            // rbtn_car
            // 
            this.rbtn_car.AutoSize = true;
            this.rbtn_car.BackColor = System.Drawing.Color.Transparent;
            this.rbtn_car.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_car.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtn_car.Location = new System.Drawing.Point(577, 150);
            this.rbtn_car.Name = "rbtn_car";
            this.rbtn_car.Size = new System.Drawing.Size(68, 29);
            this.rbtn_car.TabIndex = 1;
            this.rbtn_car.TabStop = true;
            this.rbtn_car.Text = "Car";
            this.rbtn_car.UseVisualStyleBackColor = false;
            this.rbtn_car.CheckedChanged += new System.EventHandler(this.rbtn_car_CheckedChanged);
            // 
            // lbl_slot
            // 
            this.lbl_slot.AutoSize = true;
            this.lbl_slot.BackColor = System.Drawing.Color.Transparent;
            this.lbl_slot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_slot.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_slot.Location = new System.Drawing.Point(141, 300);
            this.lbl_slot.Name = "lbl_slot";
            this.lbl_slot.Size = new System.Drawing.Size(131, 25);
            this.lbl_slot.TabIndex = 2;
            this.lbl_slot.Text = "Slot Number";
            // 
            // txt_plate
            // 
            this.txt_plate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_plate.Location = new System.Drawing.Point(391, 224);
            this.txt_plate.Name = "txt_plate";
            this.txt_plate.Size = new System.Drawing.Size(142, 28);
            this.txt_plate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(130, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Plate Number";
            // 
            // cmb_slot
            // 
            this.cmb_slot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_slot.FormattingEnabled = true;
            this.cmb_slot.Location = new System.Drawing.Point(391, 295);
            this.cmb_slot.Name = "cmb_slot";
            this.cmb_slot.Size = new System.Drawing.Size(121, 30);
            this.cmb_slot.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(141, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Entry time";
            // 
            // dtp_entry
            // 
            this.dtp_entry.Enabled = false;
            this.dtp_entry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_entry.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_entry.Location = new System.Drawing.Point(391, 390);
            this.dtp_entry.Name = "dtp_entry";
            this.dtp_entry.Size = new System.Drawing.Size(200, 28);
            this.dtp_entry.TabIndex = 5;
            // 
            // btn_confirm
            // 
            this.btn_confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm.ForeColor = System.Drawing.Color.White;
            this.btn_confirm.Location = new System.Drawing.Point(735, 500);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(120, 50);
            this.btn_confirm.TabIndex = 6;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = false;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(525, 500);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(120, 50);
            this.btn_clear.TabIndex = 6;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(109, 500);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(120, 50);
            this.btn_back.TabIndex = 6;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Vehicle_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.dtp_entry);
            this.Controls.Add(this.cmb_slot);
            this.Controls.Add(this.txt_plate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_slot);
            this.Controls.Add(this.rbtn_car);
            this.Controls.Add(this.rbtn_threewheel);
            this.Controls.Add(this.rbtn_bike);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Vehicle_in";
            this.Text = "Vehicle_in";
            this.Load += new System.EventHandler(this.Vehicle_in_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtn_bike;
        private System.Windows.Forms.RadioButton rbtn_threewheel;
        private System.Windows.Forms.RadioButton rbtn_car;
        private System.Windows.Forms.Label lbl_slot;
        private System.Windows.Forms.TextBox txt_plate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_slot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_entry;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_back;
    }
}