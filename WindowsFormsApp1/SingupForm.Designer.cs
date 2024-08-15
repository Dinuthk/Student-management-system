namespace WindowsFormsApp1
{
    partial class SingupForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SingupForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.signup_loginghere = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.signup_close = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.signup_password = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.signup_showpass = new System.Windows.Forms.CheckBox();
			this.signup_btn = new System.Windows.Forms.Button();
			this.signup_username = new System.Windows.Forms.TextBox();
			this.signup_emailaddress = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.signup_loginghere);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.signup_close);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.signup_password);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.signup_showpass);
			this.panel1.Controls.Add(this.signup_btn);
			this.panel1.Controls.Add(this.signup_username);
			this.panel1.Controls.Add(this.signup_emailaddress);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(693, 448);
			this.panel1.TabIndex = 0;
			// 
			// signup_loginghere
			// 
			this.signup_loginghere.AutoSize = true;
			this.signup_loginghere.BackColor = System.Drawing.Color.Transparent;
			this.signup_loginghere.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.signup_loginghere.Location = new System.Drawing.Point(607, 410);
			this.signup_loginghere.Name = "signup_loginghere";
			this.signup_loginghere.Size = new System.Drawing.Size(74, 13);
			this.signup_loginghere.TabIndex = 35;
			this.signup_loginghere.Text = "Loging here";
			this.signup_loginghere.Click += new System.EventHandler(this.signup_loginghere_Click);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Location = new System.Drawing.Point(465, 410);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(135, 13);
			this.label10.TabIndex = 34;
			this.label10.Text = "Already have an account ?";
			// 
			// signup_close
			// 
			this.signup_close.AutoSize = true;
			this.signup_close.BackColor = System.Drawing.Color.Navy;
			this.signup_close.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.signup_close.Cursor = System.Windows.Forms.Cursors.Hand;
			this.signup_close.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.signup_close.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.signup_close.Location = new System.Drawing.Point(656, 9);
			this.signup_close.Name = "signup_close";
			this.signup_close.Size = new System.Drawing.Size(25, 25);
			this.signup_close.TabIndex = 33;
			this.signup_close.Text = "X";
			this.signup_close.Click += new System.EventHandler(this.signup_close_Click);
			this.signup_close.MouseClick += new System.Windows.Forms.MouseEventHandler(this.signup_close_MouseClick);
			this.signup_close.MouseEnter += new System.EventHandler(this.signup_close_MouseEnter);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.SystemColors.Desktop;
			this.label8.Location = new System.Drawing.Point(404, 196);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(93, 19);
			this.label8.TabIndex = 32;
			this.label8.Text = "User Name";
			// 
			// signup_password
			// 
			this.signup_password.Location = new System.Drawing.Point(408, 293);
			this.signup_password.Name = "signup_password";
			this.signup_password.Size = new System.Drawing.Size(273, 20);
			this.signup_password.TabIndex = 31;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.White;
			this.label7.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
			this.label7.Location = new System.Drawing.Point(31, 39);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(238, 26);
			this.label7.TabIndex = 30;
			this.label7.Text = "CodeCraft Academy";
			// 
			// signup_showpass
			// 
			this.signup_showpass.AutoSize = true;
			this.signup_showpass.BackColor = System.Drawing.Color.Transparent;
			this.signup_showpass.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.signup_showpass.ForeColor = System.Drawing.SystemColors.Desktop;
			this.signup_showpass.Location = new System.Drawing.Point(572, 326);
			this.signup_showpass.Name = "signup_showpass";
			this.signup_showpass.Size = new System.Drawing.Size(109, 19);
			this.signup_showpass.TabIndex = 27;
			this.signup_showpass.Text = "Show Password";
			this.signup_showpass.UseVisualStyleBackColor = false;
			this.signup_showpass.CheckedChanged += new System.EventHandler(this.signup_showpass_CheckedChanged);
			// 
			// signup_btn
			// 
			this.signup_btn.BackColor = System.Drawing.Color.Blue;
			this.signup_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.signup_btn.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.signup_btn.Location = new System.Drawing.Point(404, 342);
			this.signup_btn.Name = "signup_btn";
			this.signup_btn.Size = new System.Drawing.Size(89, 35);
			this.signup_btn.TabIndex = 26;
			this.signup_btn.Text = "SIGNUP";
			this.signup_btn.UseVisualStyleBackColor = false;
			this.signup_btn.Click += new System.EventHandler(this.signup_btn_Click);
			// 
			// signup_username
			// 
			this.signup_username.Location = new System.Drawing.Point(408, 225);
			this.signup_username.Name = "signup_username";
			this.signup_username.Size = new System.Drawing.Size(273, 20);
			this.signup_username.TabIndex = 25;
			// 
			// signup_emailaddress
			// 
			this.signup_emailaddress.Location = new System.Drawing.Point(408, 161);
			this.signup_emailaddress.Name = "signup_emailaddress";
			this.signup_emailaddress.Size = new System.Drawing.Size(273, 20);
			this.signup_emailaddress.TabIndex = 24;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
			this.label4.Location = new System.Drawing.Point(404, 268);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 19);
			this.label4.TabIndex = 23;
			this.label4.Text = "Password";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
			this.label3.Location = new System.Drawing.Point(404, 131);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(117, 19);
			this.label3.TabIndex = 22;
			this.label3.Text = "Email Address";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
			this.label2.Location = new System.Drawing.Point(507, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(93, 19);
			this.label2.TabIndex = 21;
			this.label2.Text = "Get Started";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 9);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(398, 429);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.DarkBlue;
			this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel3.Location = new System.Drawing.Point(0, 438);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(693, 10);
			this.panel3.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.DarkBlue;
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(693, 10);
			this.panel2.TabIndex = 0;
		
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label1.Location = new System.Drawing.Point(0, -2);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(428, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "C#   JavaScript   PHP   Swift   Java   Ruby  C++   Pyton   HTML   CSS   C   Node " +
    "  React";
			// 
			// SingupForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(693, 448);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "SingupForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SingupForm";
			this.Load += new System.EventHandler(this.SingupForm_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox signup_showpass;
        private System.Windows.Forms.Button signup_btn;
        private System.Windows.Forms.TextBox signup_username;
        private System.Windows.Forms.TextBox signup_emailaddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox signup_password;
        private System.Windows.Forms.Label signup_close;
        private System.Windows.Forms.Label signup_loginghere;
        private System.Windows.Forms.Label label10;
    }
}