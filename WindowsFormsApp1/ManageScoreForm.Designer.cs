namespace WindowsFormsApp1
{
    partial class ManageScoreForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.comboBox_stdCourse = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox_description = new System.Windows.Forms.TextBox();
			this.textBox_Score = new System.Windows.Forms.TextBox();
			this.textBox_StdId = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.button_clear = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.button_delete = new System.Windows.Forms.Button();
			this.button_update = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.guna2DataGridView_StudentList = new Guna.UI2.WinForms.Guna2DataGridView();
			this.guna2DataGridView_ScoreList = new Guna.UI2.WinForms.Guna2DataGridView();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView_StudentList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView_ScoreList)).BeginInit();
			this.panel5.SuspendLayout();
			this.panel6.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.comboBox_stdCourse);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.textBox_description);
			this.panel1.Controls.Add(this.textBox_Score);
			this.panel1.Controls.Add(this.textBox_StdId);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.button_clear);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.button_delete);
			this.panel1.Controls.Add(this.button_update);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 288);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(768, 224);
			this.panel1.TabIndex = 0;
			// 
			// comboBox_stdCourse
			// 
			this.comboBox_stdCourse.FormattingEnabled = true;
			this.comboBox_stdCourse.Items.AddRange(new object[] {
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
			this.comboBox_stdCourse.Location = new System.Drawing.Point(134, 57);
			this.comboBox_stdCourse.Name = "comboBox_stdCourse";
			this.comboBox_stdCourse.Size = new System.Drawing.Size(350, 29);
			this.comboBox_stdCourse.TabIndex = 105;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
			this.label3.Location = new System.Drawing.Point(8, 60);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(120, 19);
			this.label3.TabIndex = 104;
			this.label3.Text = "Select Course :";
			// 
			// textBox_description
			// 
			this.textBox_description.Location = new System.Drawing.Point(134, 142);
			this.textBox_description.Multiline = true;
			this.textBox_description.Name = "textBox_description";
			this.textBox_description.Size = new System.Drawing.Size(350, 51);
			this.textBox_description.TabIndex = 103;
			// 
			// textBox_Score
			// 
			this.textBox_Score.Location = new System.Drawing.Point(134, 96);
			this.textBox_Score.Name = "textBox_Score";
			this.textBox_Score.Size = new System.Drawing.Size(159, 27);
			this.textBox_Score.TabIndex = 102;
			// 
			// textBox_StdId
			// 
			this.textBox_StdId.Location = new System.Drawing.Point(134, 24);
			this.textBox_StdId.Name = "textBox_StdId";
			this.textBox_StdId.Size = new System.Drawing.Size(159, 27);
			this.textBox_StdId.TabIndex = 101;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
			this.label5.Location = new System.Drawing.Point(26, 145);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(102, 19);
			this.label5.TabIndex = 100;
			this.label5.Text = "Description :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
			this.label2.Location = new System.Drawing.Point(68, 100);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 19);
			this.label2.TabIndex = 99;
			this.label2.Text = "Score :";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
			this.label1.Location = new System.Drawing.Point(35, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(93, 19);
			this.label1.TabIndex = 98;
			this.label1.Text = "Student Id :";
			// 
			// button_clear
			// 
			this.button_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(227)))), ((int)(((byte)(34)))));
			this.button_clear.ForeColor = System.Drawing.SystemColors.ControlText;
			this.button_clear.Location = new System.Drawing.Point(490, 186);
			this.button_clear.Name = "button_clear";
			this.button_clear.Size = new System.Drawing.Size(87, 32);
			this.button_clear.TabIndex = 97;
			this.button_clear.Text = "Clear";
			this.button_clear.UseVisualStyleBackColor = false;
			this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(768, 12);
			this.panel2.TabIndex = 94;
			// 
			// button_delete
			// 
			this.button_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(34)))), ((int)(((byte)(55)))));
			this.button_delete.ForeColor = System.Drawing.SystemColors.ControlText;
			this.button_delete.Location = new System.Drawing.Point(676, 186);
			this.button_delete.Name = "button_delete";
			this.button_delete.Size = new System.Drawing.Size(87, 32);
			this.button_delete.TabIndex = 93;
			this.button_delete.Text = "Delete";
			this.button_delete.UseVisualStyleBackColor = false;
			this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
			// 
			// button_update
			// 
			this.button_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(217)))), ((int)(((byte)(201)))));
			this.button_update.ForeColor = System.Drawing.SystemColors.ControlText;
			this.button_update.Location = new System.Drawing.Point(583, 186);
			this.button_update.Name = "button_update";
			this.button_update.Size = new System.Drawing.Size(87, 32);
			this.button_update.TabIndex = 92;
			this.button_update.Text = "Update";
			this.button_update.UseVisualStyleBackColor = false;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
			this.panel3.Controls.Add(this.label7);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(768, 45);
			this.panel3.TabIndex = 21;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(282, 9);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(170, 26);
			this.label7.TabIndex = 0;
			this.label7.Text = "Manage Score";
			// 
			// guna2DataGridView_StudentList
			// 
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
			this.guna2DataGridView_StudentList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
			this.guna2DataGridView_StudentList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.guna2DataGridView_StudentList.BackgroundColor = System.Drawing.Color.Gainsboro;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.guna2DataGridView_StudentList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
			this.guna2DataGridView_StudentList.ColumnHeadersHeight = 4;
			this.guna2DataGridView_StudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.guna2DataGridView_StudentList.DefaultCellStyle = dataGridViewCellStyle9;
			this.guna2DataGridView_StudentList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.guna2DataGridView_StudentList.Location = new System.Drawing.Point(3, 6);
			this.guna2DataGridView_StudentList.Name = "guna2DataGridView_StudentList";
			this.guna2DataGridView_StudentList.ReadOnly = true;
			this.guna2DataGridView_StudentList.RowHeadersVisible = false;
			this.guna2DataGridView_StudentList.Size = new System.Drawing.Size(327, 231);
			this.guna2DataGridView_StudentList.TabIndex = 22;
			this.guna2DataGridView_StudentList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.guna2DataGridView_StudentList.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.guna2DataGridView_StudentList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.guna2DataGridView_StudentList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.guna2DataGridView_StudentList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.guna2DataGridView_StudentList.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
			this.guna2DataGridView_StudentList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.guna2DataGridView_StudentList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.guna2DataGridView_StudentList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.guna2DataGridView_StudentList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2DataGridView_StudentList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.guna2DataGridView_StudentList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.guna2DataGridView_StudentList.ThemeStyle.HeaderStyle.Height = 4;
			this.guna2DataGridView_StudentList.ThemeStyle.ReadOnly = true;
			this.guna2DataGridView_StudentList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.guna2DataGridView_StudentList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.guna2DataGridView_StudentList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2DataGridView_StudentList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.guna2DataGridView_StudentList.ThemeStyle.RowsStyle.Height = 22;
			this.guna2DataGridView_StudentList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.guna2DataGridView_StudentList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.guna2DataGridView_StudentList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView_StudentList_CellContentClick);
			// 
			// guna2DataGridView_ScoreList
			// 
			dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
			this.guna2DataGridView_ScoreList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
			this.guna2DataGridView_ScoreList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.guna2DataGridView_ScoreList.BackgroundColor = System.Drawing.Color.Gainsboro;
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.guna2DataGridView_ScoreList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
			this.guna2DataGridView_ScoreList.ColumnHeadersHeight = 4;
			this.guna2DataGridView_ScoreList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.guna2DataGridView_ScoreList.DefaultCellStyle = dataGridViewCellStyle12;
			this.guna2DataGridView_ScoreList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.guna2DataGridView_ScoreList.Location = new System.Drawing.Point(5, 4);
			this.guna2DataGridView_ScoreList.Name = "guna2DataGridView_ScoreList";
			this.guna2DataGridView_ScoreList.ReadOnly = true;
			this.guna2DataGridView_ScoreList.RowHeadersVisible = false;
			this.guna2DataGridView_ScoreList.Size = new System.Drawing.Size(412, 231);
			this.guna2DataGridView_ScoreList.TabIndex = 23;
			this.guna2DataGridView_ScoreList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.guna2DataGridView_ScoreList.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.guna2DataGridView_ScoreList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.guna2DataGridView_ScoreList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.guna2DataGridView_ScoreList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.guna2DataGridView_ScoreList.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
			this.guna2DataGridView_ScoreList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.guna2DataGridView_ScoreList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.guna2DataGridView_ScoreList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.guna2DataGridView_ScoreList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2DataGridView_ScoreList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.guna2DataGridView_ScoreList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.guna2DataGridView_ScoreList.ThemeStyle.HeaderStyle.Height = 4;
			this.guna2DataGridView_ScoreList.ThemeStyle.ReadOnly = true;
			this.guna2DataGridView_ScoreList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.guna2DataGridView_ScoreList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.guna2DataGridView_ScoreList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2DataGridView_ScoreList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.guna2DataGridView_ScoreList.ThemeStyle.RowsStyle.Height = 22;
			this.guna2DataGridView_ScoreList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.guna2DataGridView_ScoreList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.guna2DataGridView_ScoreList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView_ScoreList_CellContentClick);
			// 
			// panel4
			// 
			this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
			this.panel4.Location = new System.Drawing.Point(335, 45);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(10, 245);
			this.panel4.TabIndex = 24;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.guna2DataGridView_StudentList);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel5.Location = new System.Drawing.Point(0, 45);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(332, 243);
			this.panel5.TabIndex = 25;
			// 
			// panel6
			// 
			this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel6.Controls.Add(this.guna2DataGridView_ScoreList);
			this.panel6.Location = new System.Drawing.Point(348, 47);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(420, 243);
			this.panel6.TabIndex = 26;
			// 
			// ManageScoreForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(768, 512);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel6);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "ManageScoreForm";
			this.Text = "ManageScoreForm";
			this.Load += new System.EventHandler(this.ManageScoreForm_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView_StudentList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView_ScoreList)).EndInit();
			this.panel5.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_stdCourse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_description;
        private System.Windows.Forms.TextBox textBox_Score;
        private System.Windows.Forms.TextBox textBox_StdId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
		private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView_StudentList;
		private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView_ScoreList;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel6;
	}
}