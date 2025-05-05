namespace Vehicle_Parking_Management_System
{
    partial class attendant_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(attendant_form));
            this.btn_status = new System.Windows.Forms.Button();
            this.btn_V_in = new System.Windows.Forms.Button();
            this.btn_V_out = new System.Windows.Forms.Button();
            this.btn_AvailableSlots = new System.Windows.Forms.Button();
            this.linkLbl_logout = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_status
            // 
            this.btn_status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_status.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_status.Location = new System.Drawing.Point(142, 337);
            this.btn_status.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_status.Name = "btn_status";
            this.btn_status.Size = new System.Drawing.Size(250, 80);
            this.btn_status.TabIndex = 0;
            this.btn_status.Text = "View Status";
            this.btn_status.UseVisualStyleBackColor = false;
            this.btn_status.Click += new System.EventHandler(this.btn_status_Click);
            // 
            // btn_V_in
            // 
            this.btn_V_in.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_V_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_V_in.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_V_in.Location = new System.Drawing.Point(142, 175);
            this.btn_V_in.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_V_in.Name = "btn_V_in";
            this.btn_V_in.Size = new System.Drawing.Size(250, 80);
            this.btn_V_in.TabIndex = 0;
            this.btn_V_in.Text = "Vehicle In";
            this.btn_V_in.UseVisualStyleBackColor = false;
            this.btn_V_in.Click += new System.EventHandler(this.btn_V_in_Click);
            // 
            // btn_V_out
            // 
            this.btn_V_out.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_V_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_V_out.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_V_out.Location = new System.Drawing.Point(577, 175);
            this.btn_V_out.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_V_out.Name = "btn_V_out";
            this.btn_V_out.Size = new System.Drawing.Size(250, 80);
            this.btn_V_out.TabIndex = 0;
            this.btn_V_out.Text = "Vehicle Out";
            this.btn_V_out.UseVisualStyleBackColor = false;
            this.btn_V_out.Click += new System.EventHandler(this.btn_V_out_Click);
            // 
            // btn_AvailableSlots
            // 
            this.btn_AvailableSlots.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_AvailableSlots.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AvailableSlots.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_AvailableSlots.Location = new System.Drawing.Point(577, 337);
            this.btn_AvailableSlots.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_AvailableSlots.Name = "btn_AvailableSlots";
            this.btn_AvailableSlots.Size = new System.Drawing.Size(250, 80);
            this.btn_AvailableSlots.TabIndex = 0;
            this.btn_AvailableSlots.Text = "Available Slots";
            this.btn_AvailableSlots.UseVisualStyleBackColor = false;
            this.btn_AvailableSlots.Click += new System.EventHandler(this.btn_AvailableSlots_Click);
            // 
            // linkLbl_logout
            // 
            this.linkLbl_logout.AutoSize = true;
            this.linkLbl_logout.BackColor = System.Drawing.Color.Transparent;
            this.linkLbl_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLbl_logout.LinkColor = System.Drawing.SystemColors.Highlight;
            this.linkLbl_logout.Location = new System.Drawing.Point(842, 513);
            this.linkLbl_logout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLbl_logout.Name = "linkLbl_logout";
            this.linkLbl_logout.Size = new System.Drawing.Size(105, 29);
            this.linkLbl_logout.TabIndex = 1;
            this.linkLbl_logout.TabStop = true;
            this.linkLbl_logout.Text = "Log Out";
            this.linkLbl_logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLbl_logout_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ImageLocation = "C:\\Users\\Rasika\\Desktop\\project\\VPMS Logo.png";
            this.pictureBox1.Location = new System.Drawing.Point(298, -28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(374, 359);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // attendant_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.btn_V_out);
            this.Controls.Add(this.btn_V_in);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLbl_logout);
            this.Controls.Add(this.btn_AvailableSlots);
            this.Controls.Add(this.btn_status);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "attendant_form";
            this.Text = "Operator_form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_status;
        private System.Windows.Forms.Button btn_V_in;
        private System.Windows.Forms.Button btn_V_out;
        private System.Windows.Forms.Button btn_AvailableSlots;
        private System.Windows.Forms.LinkLabel linkLbl_logout;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}