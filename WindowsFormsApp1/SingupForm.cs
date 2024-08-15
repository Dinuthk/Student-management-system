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
    public partial class SingupForm : Form
    {
        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-4JGGOE8\\SQLEXPRESS;Initial Catalog=Studentdb;Integrated Security=True;");

        public SingupForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void signup_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signup_close_MouseEnter(object sender, EventArgs e)
        {
            signup_close.BackColor = Color.Red;

        }

        private void signup_close_MouseClick(object sender, MouseEventArgs e)
        {
            signup_close.ForeColor = Color.Transparent;
        }

        private void signup_loginghere_Click(object sender, EventArgs e)
        {
            LoginForm lg = new LoginForm();
            lg.Show();
            this.Hide();
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            if (signup_emailaddress.Text==""|| signup_password.Text==""|| signup_username.Text=="")
            {
                MessageBox.Show("Please fill all blanck fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        string checkUsername = "SELECT* FROM ADMIN WHERE username='"+signup_username.Text
                            .Trim()+"'";
                        using (SqlCommand checkuser = new SqlCommand(checkUsername, connect))
                        {
                            SqlDataAdapter dataAdapter = new SqlDataAdapter(checkuser);
                            DataTable table = new DataTable();
                            dataAdapter.Fill(table);
                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show(signup_username.Text+"is already exist", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO ADMIN(email,username,password,date_created) VALUES(@email,@username,@pass,@date)";

                                DateTime date = DateTime.Today;

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@email", signup_emailaddress.Text.Trim());
                                    cmd.Parameters.AddWithValue("@username", signup_username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@pass", signup_password.Text.Trim());
                                    cmd.Parameters.AddWithValue("@date", date);

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Registered successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    //to switch the form
                                    LoginForm lg = new LoginForm();
                                    lg.Show();
                                    this.Show();
                                }

                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Conecting Database " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            
        }

        private void signup_showpass_CheckedChanged(object sender, EventArgs e)
        {
            
            if(signup_showpass.Checked)
            {
                signup_password.PasswordChar = '\0';
            }
            else
            {
                signup_password.PasswordChar= '*';
            }
        }

		private void SingupForm_Load(object sender, EventArgs e)
		{
            
		}

		
	}
}
