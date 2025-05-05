namespace Vehicle_Parking_Management_System
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_logoName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_uID = new System.Windows.Forms.TextBox();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.lbl_uID = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImageLocation = "C:\\Users\\Rasika\\Desktop\\project\\VPMS Logo.png";
            this.pictureBox1.Location = new System.Drawing.Point(293, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_logoName
            // 
            this.lbl_logoName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_logoName.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_logoName.Location = new System.Drawing.Point(271, 133);
            this.lbl_logoName.Name = "lbl_logoName";
            this.lbl_logoName.Size = new System.Drawing.Size(340, 71);
            this.lbl_logoName.TabIndex = 1;
            this.lbl_logoName.Text = "Vehicle Parking Management System";
            this.lbl_logoName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn_clear);
            this.groupBox1.Controls.Add(this.btn_login);
            this.groupBox1.Controls.Add(this.txt_pass);
            this.groupBox1.Controls.Add(this.txt_uID);
            this.groupBox1.Controls.Add(this.lbl_pass);
            this.groupBox1.Controls.Add(this.lbl_uID);
            this.groupBox1.Location = new System.Drawing.Point(184, 219);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(565, 281);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(118, 166);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(120, 50);
            this.btn_clear.TabIndex = 2;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(319, 166);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(120, 50);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_pass
            // 
            this.txt_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(204, 120);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(220, 28);
            this.txt_pass.TabIndex = 1;
            this.txt_pass.TextChanged += new System.EventHandler(this.txt_pass_TextChanged);
            this.txt_pass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_pass_KeyDown);
            this.txt_pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Enter);
            this.txt_pass.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_pass_KeyUp);
            // 
            // txt_uID
            // 
            this.txt_uID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_uID.Location = new System.Drawing.Point(204, 62);
            this.txt_uID.Name = "txt_uID";
            this.txt_uID.Size = new System.Drawing.Size(220, 28);
            this.txt_uID.TabIndex = 1;
            this.txt_uID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_uID_KeyDown);
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pass.ForeColor = System.Drawing.Color.Black;
            this.lbl_pass.Location = new System.Drawing.Point(78, 116);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(106, 25);
            this.lbl_pass.TabIndex = 0;
            this.lbl_pass.Text = "Password";
            // 
            // lbl_uID
            // 
            this.lbl_uID.AutoSize = true;
            this.lbl_uID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_uID.ForeColor = System.Drawing.Color.Black;
            this.lbl_uID.Location = new System.Drawing.Point(78, 56);
            this.lbl_uID.Name = "lbl_uID";
            this.lbl_uID.Size = new System.Drawing.Size(84, 25);
            this.lbl_uID.TabIndex = 0;
            this.lbl_uID.Text = "User ID";
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(105, 541);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(120, 50);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.lbl_logoName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LoginForm";
            this.Text = "Login form";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.Shown += new System.EventHandler(this.LoginForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_logoName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Label lbl_uID;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_uID;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_exit;
    }
}

