using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ManageStudentForm : Form
    {
        public ManageStudentForm()
        {
            InitializeComponent();
        }

        private void ManageStudentForm_Load(object sender, EventArgs e)
        {
            show_table();
            BindData();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-4JGGOE8\\SQLEXPRESS;Initial Catalog=Studentdb;Integrated Security=True;");
        string g;
        private void show_table()
        {
           // SqlConnection conn = new SqlConnection("Data Source=DESKTOP-4JGGOE8\\SQLEXPRESS;Initial Catalog=Studentdb;Integrated Security=True;");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select Count(*) from Registration ", conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            SqlCommand cmdd = new SqlCommand("Select * from Registration ", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmdd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            guna2DataGridView1.DataSource = dt;
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_Idno.Text = guna2DataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox_Fname.Text = guna2DataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox_Lname.Text = guna2DataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Value = (DateTime)guna2DataGridView1.CurrentRow.Cells[3].Value;
            if (guna2DataGridView1.CurrentRow.Cells[4].Value.ToString()=="Male")
                radioButton_male.Checked = true;
            else if(guna2DataGridView1.CurrentRow.Cells[4].Value.ToString()=="Female")
                radioButton_female.Checked = true;
            textBox_phone.Text = guna2DataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox_address.Text = guna2DataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_Idno.Clear();
            textBox_Fname.Clear();
            textBox_Lname.Clear();
            textBox_address.Clear();
            textBox_phone.Clear();
            radioButton_male.Checked = true;
            dateTimePicker1.Value=DateTime.Now;
            

        }

        private void button_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select photo (*.gpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image=Image.FromFile(opf.FileName);
            }
        }
        bool verify()
        {
            if ((textBox_Fname.Text =="")|| (textBox_Lname.Text == "")||(textBox_phone.Text=="")||
                (textBox_address.Text == ""))
            {
                return false;
            }
            else
                return true;
        }

        private void button_update_Click(object sender, EventArgs e)
        {
			if (radioButton_male.Checked==true)
			{
				g="Male";
			}
			else
			{
				g="Female";
			}
			conn.Open();
            SqlCommand command = new SqlCommand("update Registration set  stdFname= '"+textBox_Fname.Text+"',stdLName='"+textBox_Lname.Text+"',birthdate = '"+DateTime.Parse(dateTimePicker1.Text)+"',gender = '"+g+"',phone='"+textBox_phone.Text+"',adress='"+textBox_address.Text+"' where stdId ='"+int.Parse(textBox_Idno.Text)+"'  ", conn);
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Successfuly Updated.");
            BindData();
        }
        void BindData()
        {
            SqlCommand command = new SqlCommand("Select * from Registration ", conn);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            guna2DataGridView1.DataSource = dt;

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure To delete ?", "Delete Record", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                conn.Open();
                SqlCommand command = new SqlCommand("Delete Registration where stdId = '"+textBox_Idno.Text+"'", conn);
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Delete is Successful", "Deleted!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                BindData();

            }
            else
            {
                MessageBox.Show("Please enter the stdId", "" +
                    "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from Registration where stdFname='"+textBox_Fname.Text+"'", conn);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            guna2DataGridView1.DataSource = dt;

            
        }
    }
}
