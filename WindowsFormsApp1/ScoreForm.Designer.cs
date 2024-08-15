namespace WindowsFormsApp1
{
    partial class ScoreForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.comboBox_stdCourse = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox_description = new System.Windows.Forms.TextBox();
			this.textBox_Score = new System.Windows.Forms.TextBox();
			this.textBox_StdId = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.guna2DataGridView_StudentList = new Guna.UI2.WinForms.Guna2DataGridView();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.guna2DataGridView_ScoreList = new Guna.UI2.WinForms.Guna2DataGridView();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView_StudentList)).BeginInit();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView_ScoreList)).BeginInit();
			this.panel5.SuspendLayout();
			this.panel6.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.comboBox_stdCourse);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.textBox_description);
			this.panel1.Controls.Add(this.textBox_Score);
			this.panel1.Controls.Add(this.textBox_StdId);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 296);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(768, 216);
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
			this.comboBox_stdCourse.Location = new System.Drawing.Point(135, 53);
			this.comboBox_stdCourse.Name = "comboBox_stdCourse";
			this.comboBox_stdCourse.Size = new System.Drawing.Size(413, 29);
			this.comboBox_stdCourse.TabIndex = 84;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
			this.label3.Location = new System.Drawing.Point(9, 56);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(120, 19);
			this.label3.TabIndex = 83;
			this.label3.Text = "Select Course :";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(768, 10);
			this.panel2.TabIndex = 82;
			// 
			// button3
			// 
			this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(227)))), ((int)(((byte)(34)))));
			this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.button3.Location = new System.Drawing.Point(665, 179);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(87, 32);
			this.button3.TabIndex = 79;
			this.button3.Text = "Add";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(34)))), ((int)(((byte)(55)))));
			this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.button2.Location = new System.Drawing.Point(572, 179);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(87, 32);
			this.button2.TabIndex = 78;
			this.button2.Text = "Clear";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// textBox_description
			// 
			this.textBox_description.Location = new System.Drawing.Point(135, 138);
			this.textBox_description.Multiline = true;
			this.textBox_description.Name = "textBox_description";
			this.textBox_description.Size = new System.Drawing.Size(413, 51);
			this.textBox_description.TabIndex = 77;
			// 
			// textBox_Score
			// 
			this.textBox_Score.Location = new System.Drawing.Point(135, 92);
			this.textBox_Score.Name = "textBox_Score";
			this.textBox_Score.Size = new System.Drawing.Size(159, 27);
			this.textBox_Score.TabIndex = 76;
			// 
			// textBox_StdId
			// 
			this.textBox_StdId.Location = new System.Drawing.Point(135, 20);
			this.textBox_StdId.Name = "textBox_StdId";
			this.textBox_StdId.Size = new System.Drawing.Size(159, 27);
			this.textBox_StdId.TabIndex = 75;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
			this.label5.Location = new System.Drawing.Point(27, 141);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(102, 19);
			this.label5.TabIndex = 74;
			this.label5.Text = "Description :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
			this.label2.Location = new System.Drawing.Point(69, 96);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 19);
			this.label2.TabIndex = 73;
			this.label2.Text = "Score :";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
			this.label1.Location = new System.Drawing.Point(36, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(93, 19);
			this.label1.TabIndex = 72;
			this.label1.Text = "Student Id :";
			// 
			// guna2DataGridView_StudentList
			// 
			dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
			this.guna2DataGridView_StudentList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
			this.guna2DataGridView_StudentList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.guna2DataGridView_StudentList.BackgroundColor = System.Drawing.Color.Gainsboro;
			dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.guna2DataGridView_StudentList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
			this.guna2DataGridView_StudentList.ColumnHeadersHeight = 4;
			this.guna2DataGridView_StudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.guna2DataGridView_StudentList.DefaultCellStyle = dataGridViewCellStyle15;
			this.guna2DataGridView_StudentList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.guna2DataGridView_StudentList.Location = new System.Drawing.Point(11, 3);
			this.guna2DataGridView_StudentList.Name = "guna2DataGridView_StudentList";
			this.guna2DataGridView_StudentList.ReadOnly = true;
			this.guna2DataGridView_StudentList.RowHeadersVisible = false;
			this.guna2DataGridView_StudentList.Size = new System.Drawing.Size(337, 251);
			this.guna2DataGridView_StudentList.TabIndex = 3;
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
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
			this.panel3.Controls.Add(this.label4);
			this.panel3.Controls.Add(this.label7);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(768, 45);
			this.panel3.TabIndex = 20;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(509, 12);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(110, 26);
			this.label4.TabIndex = 1;
			this.label4.Text = "Score List";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(135, 12);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(130, 26);
			this.label7.TabIndex = 0;
			this.label7.Text = "Student List";
			// 
			// panel4
			// 
			this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
			this.panel4.Location = new System.Drawing.Point(354, 45);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(10, 252);
			this.panel4.TabIndex = 22;
			// 
			// guna2DataGridView_ScoreList
			// 
			dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
			this.guna2DataGridView_ScoreList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
			this.guna2DataGridView_ScoreList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.guna2DataGridView_ScoreList.BackgroundColor = System.Drawing.Color.Gainsboro;
			dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle17.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.guna2DataGridView_ScoreList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
			this.guna2DataGridView_ScoreList.ColumnHeadersHeight = 4;
			this.guna2DataGridView_ScoreList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle18.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.guna2DataGridView_ScoreList.DefaultCellStyle = dataGridViewCellStyle18;
			this.guna2DataGridView_ScoreList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.guna2DataGridView_ScoreList.Location = new System.Drawing.Point(11, 0);
			this.guna2DataGridView_ScoreList.Name = "guna2DataGridView_ScoreList";
			this.guna2DataGridView_ScoreList.ReadOnly = true;
			this.guna2DataGridView_ScoreList.RowHeadersVisible = false;
			this.guna2DataGridView_ScoreList.Size = new System.Drawing.Size(395, 261);
			this.guna2DataGridView_ScoreList.TabIndex = 21;
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
			// panel5
			// 
			this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel5.Controls.Add(this.guna2DataGridView_StudentList);
			this.panel5.Location = new System.Drawing.Point(0, 47);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(353, 251);
			this.panel5.TabIndex = 23;
			// 
			// panel6
			// 
			this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel6.Controls.Add(this.guna2DataGridView_ScoreList);
			this.panel6.Location = new System.Drawing.Point(359, 45);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(409, 251);
			this.panel6.TabIndex = 24;
			// 
			// ScoreForm
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
			this.Name = "ScoreForm";
			this.Text = "ScoreForm";
			this.Load += new System.EventHandler(this.ScoreForm_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView_StudentList)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView_ScoreList)).EndInit();
			this.panel5.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox_description;
        private System.Windows.Forms.TextBox textBox_Score;
        private System.Windows.Forms.TextBox textBox_StdId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView_StudentList;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_stdCourse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
		private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView_ScoreList;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel6;
	}
}