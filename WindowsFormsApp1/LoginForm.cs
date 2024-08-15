using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
		SqlConnection connect = new SqlConnection("Data Source=DESKTOP-4JGGOE8\\SQLEXPRESS;Initial Catalog=Studentdb;Integrated Security=True;");

		public LoginForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            label2.Parent = pictureBox3;
            label2.BackColor = Color.Transparent;

            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            loging_showpass.BackColor = Color.Transparent;
            
            label5.BackColor = Color.Transparent;
            loging_registerhere.BackColor = Color.Transparent;
        }

        private void loging_registerhere_Click(object sender, EventArgs e)
        {
            SingupForm sForm = new SingupForm();
            sForm.Show();
            this.Hide();
        }

        private void loging_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loging_close_MouseEnter(object sender, EventArgs e)
        {
            loging_close.BackColor = Color.Red;
        }

        private void loging_close_MouseLeave(object sender, EventArgs e)
        {
            loging_close.ForeColor = Color.Transparent;
        }

		private void loging_showpass_CheckedChanged(object sender, EventArgs e)
		{
			if (loging_showpass.Checked)
			{
				loging__password.PasswordChar = '\0';
			}
			else
			{
				loging__password.PasswordChar= '*';
			}
		}

		private void loging_btn_Click(object sender, EventArgs e)
		{
            if(loging_username.Text==""||loging__password.Text=="")
            {
				MessageBox.Show("Please fill all blanck fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
			else
            {
                if(connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();

                        string selectData = "SELECT * FROM ADMIN WHERE username = @username AND password = @pass";
                        using(SqlCommand cmd = new SqlCommand(selectData,connect))
                        {
                            cmd.Parameters.AddWithValue("@username", loging_username.Text);
							cmd.Parameters.AddWithValue("@pass", loging__password.Text);
							SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if(table.Rows.Count >= 1)
                            {
								MessageBox.Show("Login Successfuly", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                MainForm mf = new MainForm();
                                mf.Show();
                                this.Hide();
							}
							else
                            {
								MessageBox.Show("Incorrect Username/Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

							}
						}
                    }
                    catch (Exception ex)
                    {
						MessageBox.Show("Error conecting: "+ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

					}
					finally 
                    {
                        connect.Close();
                    }
                    
                }
            }
		}
        
		private void loging_username_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
