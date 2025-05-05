namespace Vehicle_Parking_Management_System
{
    partial class EditRate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditRate));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_VehicleType = new System.Windows.Forms.ComboBox();
            this.txt_FirstHour = new System.Windows.Forms.TextBox();
            this.txt_AddHours = new System.Windows.Forms.TextBox();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(261, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicle Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(261, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Hour Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(261, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Additional Hours Rates";
            // 
            // cmb_VehicleType
            // 
            this.cmb_VehicleType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_VehicleType.FormattingEnabled = true;
            this.cmb_VehicleType.Location = new System.Drawing.Point(518, 170);
            this.cmb_VehicleType.Name = "cmb_VehicleType";
            this.cmb_VehicleType.Size = new System.Drawing.Size(167, 30);
            this.cmb_VehicleType.TabIndex = 3;
            this.cmb_VehicleType.SelectedIndexChanged += new System.EventHandler(this.cmb_VehicleType_SelectedIndexChanged);
            // 
            // txt_FirstHour
            // 
            this.txt_FirstHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FirstHour.Location = new System.Drawing.Point(518, 250);
            this.txt_FirstHour.Name = "txt_FirstHour";
            this.txt_FirstHour.Size = new System.Drawing.Size(167, 28);
            this.txt_FirstHour.TabIndex = 4;
            // 
            // txt_AddHours
            // 
            this.txt_AddHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AddHours.Location = new System.Drawing.Point(518, 301);
            this.txt_AddHours.Name = "txt_AddHours";
            this.txt_AddHours.Size = new System.Drawing.Size(167, 28);
            this.txt_AddHours.TabIndex = 4;
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.White;
            this.btn_Back.Location = new System.Drawing.Point(227, 443);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(120, 50);
            this.btn_Back.TabIndex = 5;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_confirm
            // 
            this.btn_confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm.ForeColor = System.Drawing.Color.White;
            this.btn_confirm.Location = new System.Drawing.Point(638, 443);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(120, 50);
            this.btn_confirm.TabIndex = 6;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = false;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // EditRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.txt_AddHours);
            this.Controls.Add(this.txt_FirstHour);
            this.Controls.Add(this.cmb_VehicleType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "EditRate";
            this.Text = "EditRate";
            this.Load += new System.EventHandler(this.EditRate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_VehicleType;
        private System.Windows.Forms.TextBox txt_FirstHour;
        private System.Windows.Forms.TextBox txt_AddHours;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_confirm;
    }
}