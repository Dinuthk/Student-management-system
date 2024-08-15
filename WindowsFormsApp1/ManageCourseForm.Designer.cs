namespace WindowsFormsApp1
{
    partial class ManageCourseForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.DataGridView_manageCourse = new Guna.UI2.WinForms.Guna2DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.textBox_stdId = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.button_clear = new System.Windows.Forms.Button();
			this.textBox_CId = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.button_delete = new System.Windows.Forms.Button();
			this.button_update = new System.Windows.Forms.Button();
			this.textBox_description = new System.Windows.Forms.TextBox();
			this.textBox_Chour = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridView_manageCourse)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
			this.panel3.Controls.Add(this.label7);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(768, 45);
			this.panel3.TabIndex = 20;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(282, 9);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(185, 26);
			this.label7.TabIndex = 0;
			this.label7.Text = "Manage Course";
			// 
			// DataGridView_manageCourse
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.DataGridView_manageCourse.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.DataGridView_manageCourse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DataGridView_manageCourse.BackgroundColor = System.Drawing.Color.Gainsboro;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.DataGridView_manageCourse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.DataGridView_manageCourse.ColumnHeadersHeight = 4;
			this.DataGridView_manageCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.DataGridView_manageCourse.DefaultCellStyle = dataGridViewCellStyle3;
			this.DataGridView_manageCourse.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.DataGridView_manageCourse.Location = new System.Drawing.Point(3, 47);
			this.DataGridView_manageCourse.Name = "DataGridView_manageCourse";
			this.DataGridView_manageCourse.RowHeadersVisible = false;
			this.DataGridView_manageCourse.Size = new System.Drawing.Size(760, 269);
			this.DataGridView_manageCourse.TabIndex = 21;
			this.DataGridView_manageCourse.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.DataGridView_manageCourse.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.DataGridView_manageCourse.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.DataGridView_manageCourse.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.DataGridView_manageCourse.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.DataGridView_manageCourse.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
			this.DataGridView_manageCourse.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.DataGridView_manageCourse.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.DataGridView_manageCourse.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.DataGridView_manageCourse.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DataGridView_manageCourse.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.DataGridView_manageCourse.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.DataGridView_manageCourse.ThemeStyle.HeaderStyle.Height = 4;
			this.DataGridView_manageCourse.ThemeStyle.ReadOnly = false;
			this.DataGridView_manageCourse.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.DataGridView_manageCourse.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.DataGridView_manageCourse.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DataGridView_manageCourse.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.DataGridView_manageCourse.ThemeStyle.RowsStyle.Height = 22;
			this.DataGridView_manageCourse.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.DataGridView_manageCourse.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.DataGridView_manageCourse.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_manageCourse_CellContentClick_1);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.SystemColors.Control;
			this.panel1.Controls.Add(this.textBox_stdId);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.comboBox1);
			this.panel1.Controls.Add(this.button_clear);
			this.panel1.Controls.Add(this.textBox_CId);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.button_delete);
			this.panel1.Controls.Add(this.button_update);
			this.panel1.Controls.Add(this.textBox_description);
			this.panel1.Controls.Add(this.textBox_Chour);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(0, 322);
			this.panel1.MinimumSize = new System.Drawing.Size(0, 213);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(768, 213);
			this.panel1.TabIndex = 22;
			// 
			// textBox_stdId
			// 
			this.textBox_stdId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_stdId.Location = new System.Drawing.Point(583, 82);
			this.textBox_stdId.Name = "textBox_stdId";
			this.textBox_stdId.Size = new System.Drawing.Size(159, 20);
			this.textBox_stdId.TabIndex = 77;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
			this.label4.Location = new System.Drawing.Point(579, 60);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(93, 19);
			this.label4.TabIndex = 76;
			this.label4.Text = "Student Id :";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Introduction to Programming",
            "Web Development",
            "Data Science and Machine Learning",
            "Full-Stack Development",
            "Data Science and Machine Learning",
            "Cybersecurity",
            "Cloud Computing",
            "DevOps",
            "Game Development",
            "Blockchain and Cryptocurrency",
            "Software Engineering Best Practices",
            "UI/UX Design"});
			this.comboBox1.Location = new System.Drawing.Point(23, 37);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(159, 21);
			this.comboBox1.TabIndex = 75;
			// 
			// button_clear
			// 
			this.button_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(227)))), ((int)(((byte)(34)))));
			this.button_clear.ForeColor = System.Drawing.SystemColors.ControlText;
			this.button_clear.Location = new System.Drawing.Point(483, 146);
			this.button_clear.Name = "button_clear";
			this.button_clear.Size = new System.Drawing.Size(87, 32);
			this.button_clear.TabIndex = 74;
			this.button_clear.Text = "Clear";
			this.button_clear.UseVisualStyleBackColor = false;
			this.button_clear.Click += new System.EventHandler(this.button_clear_Click_1);
			// 
			// textBox_CId
			// 
			this.textBox_CId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_CId.Location = new System.Drawing.Point(583, 37);
			this.textBox_CId.Name = "textBox_CId";
			this.textBox_CId.Size = new System.Drawing.Size(159, 20);
			this.textBox_CId.TabIndex = 73;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
			this.label3.Location = new System.Drawing.Point(579, 15);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 19);
			this.label3.TabIndex = 72;
			this.label3.Text = "Course Id :";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(768, 12);
			this.panel2.TabIndex = 71;
			// 
			// button_delete
			// 
			this.button_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(34)))), ((int)(((byte)(55)))));
			this.button_delete.ForeColor = System.Drawing.SystemColors.ControlText;
			this.button_delete.Location = new System.Drawing.Point(676, 146);
			this.button_delete.Name = "button_delete";
			this.button_delete.Size = new System.Drawing.Size(87, 32);
			this.button_delete.TabIndex = 70;
			this.button_delete.Text = "Delete";
			this.button_delete.UseVisualStyleBackColor = false;
			this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
			// 
			// button_update
			// 
			this.button_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(217)))), ((int)(((byte)(201)))));
			this.button_update.ForeColor = System.Drawing.SystemColors.ControlText;
			this.button_update.Location = new System.Drawing.Point(579, 146);
			this.button_update.Name = "button_update";
			this.button_update.Size = new System.Drawing.Size(87, 32);
			this.button_update.TabIndex = 69;
			this.button_update.Text = "Update";
			this.button_update.UseVisualStyleBackColor = false;
			this.button_update.Click += new System.EventHandler(this.button_update_Click_1);
			// 
			// textBox_description
			// 
			this.textBox_description.Location = new System.Drawing.Point(23, 127);
			this.textBox_description.Multiline = true;
			this.textBox_description.Name = "textBox_description";
			this.textBox_description.Size = new System.Drawing.Size(413, 51);
			this.textBox_description.TabIndex = 63;
			// 
			// textBox_Chour
			// 
			this.textBox_Chour.Location = new System.Drawing.Point(23, 82);
			this.textBox_Chour.Name = "textBox_Chour";
			this.textBox_Chour.Size = new System.Drawing.Size(159, 20);
			this.textBox_Chour.TabIndex = 62;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
			this.label5.Location = new System.Drawing.Point(19, 105);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(102, 19);
			this.label5.TabIndex = 58;
			this.label5.Text = "Description :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
			this.label2.Location = new System.Drawing.Point(19, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 19);
			this.label2.TabIndex = 55;
			this.label2.Text = "Hour :";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
			this.label1.Location = new System.Drawing.Point(19, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(123, 19);
			this.label1.TabIndex = 54;
			this.label1.Text = "Course Name :";
			// 
			// ManageCourseForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(768, 512);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.DataGridView_manageCourse);
			this.Controls.Add(this.panel3);
			this.Name = "ManageCourseForm";
			this.Text = "ManageCourseForm";
			this.Load += new System.EventHandler(this.ManageCourseForm_Load);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridView_manageCourse)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_manageCourse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.TextBox textBox_CId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.TextBox textBox_description;
        private System.Windows.Forms.TextBox textBox_Chour;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.TextBox textBox_stdId;
		private System.Windows.Forms.Label label4;
	}
}