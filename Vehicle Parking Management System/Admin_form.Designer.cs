namespace Vehicle_Parking_Management_System
{
    partial class Admin_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_form));
            this.btn_editRate = new System.Windows.Forms.Button();
            this.btn_status = new System.Windows.Forms.Button();
            this.btn_editSlots = new System.Windows.Forms.Button();
            this.linklbl_logout = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_report = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_editRate
            // 
            this.btn_editRate.AutoSize = true;
            this.btn_editRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_editRate.Font = new System.Drawing.Font("Microsoft PhagsPa", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editRate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_editRate.Location = new System.Drawing.Point(152, 203);
            this.btn_editRate.Name = "btn_editRate";
            this.btn_editRate.Size = new System.Drawing.Size(250, 80);
            this.btn_editRate.TabIndex = 0;
            this.btn_editRate.Text = "Edit Rate";
            this.btn_editRate.UseVisualStyleBackColor = false;
            this.btn_editRate.Click += new System.EventHandler(this.btn_editRate_Click);
            // 
            // btn_status
            // 
            this.btn_status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_status.AutoSize = true;
            this.btn_status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_status.Font = new System.Drawing.Font("Microsoft PhagsPa", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_status.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_status.Location = new System.Drawing.Point(152, 376);
            this.btn_status.Name = "btn_status";
            this.btn_status.Size = new System.Drawing.Size(250, 80);
            this.btn_status.TabIndex = 1;
            this.btn_status.Text = "View Status";
            this.btn_status.UseVisualStyleBackColor = false;
            this.btn_status.Click += new System.EventHandler(this.btn_status_Click);
            // 
            // btn_editSlots
            // 
            this.btn_editSlots.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_editSlots.AutoSize = true;
            this.btn_editSlots.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_editSlots.Font = new System.Drawing.Font("Microsoft PhagsPa", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editSlots.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_editSlots.Location = new System.Drawing.Point(599, 203);
            this.btn_editSlots.Name = "btn_editSlots";
            this.btn_editSlots.Size = new System.Drawing.Size(250, 80);
            this.btn_editSlots.TabIndex = 2;
            this.btn_editSlots.Text = "Edit Parking Slots";
            this.btn_editSlots.UseVisualStyleBackColor = false;
            this.btn_editSlots.Click += new System.EventHandler(this.btn_editSlots_Click);
            // 
            // linklbl_logout
            // 
            this.linklbl_logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linklbl_logout.AutoSize = true;
            this.linklbl_logout.BackColor = System.Drawing.Color.Transparent;
            this.linklbl_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklbl_logout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.linklbl_logout.LinkColor = System.Drawing.SystemColors.Highlight;
            this.linklbl_logout.Location = new System.Drawing.Point(838, 529);
            this.linklbl_logout.Name = "linklbl_logout";
            this.linklbl_logout.Size = new System.Drawing.Size(105, 29);
            this.linklbl_logout.TabIndex = 3;
            this.linklbl_logout.TabStop = true;
            this.linklbl_logout.Text = "Log Out";
            this.linklbl_logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_logout_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImageLocation = "C:\\Users\\Rasika\\Desktop\\project\\VPMS Logo.png";
            this.pictureBox1.Location = new System.Drawing.Point(318, -54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(378, 413);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btn_report
            // 
            this.btn_report.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_report.AutoSize = true;
            this.btn_report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_report.Font = new System.Drawing.Font("Microsoft PhagsPa", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_report.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_report.Location = new System.Drawing.Point(599, 376);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(250, 80);
            this.btn_report.TabIndex = 5;
            this.btn_report.Text = "View Report";
            this.btn_report.UseVisualStyleBackColor = false;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // Admin_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.btn_report);
            this.Controls.Add(this.btn_editSlots);
            this.Controls.Add(this.btn_editRate);
            this.Controls.Add(this.btn_status);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linklbl_logout);
            this.Name = "Admin_form";
            this.Text = "Admin_form";
            this.Load += new System.EventHandler(this.Admin_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_editRate;
        private System.Windows.Forms.Button btn_status;
        private System.Windows.Forms.Button btn_editSlots;
        private System.Windows.Forms.LinkLabel linklbl_logout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_report;
    }
}