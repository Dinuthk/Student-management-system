using Guna.UI2.WinForms;
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
    public partial class ManageCourseForm : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-4JGGOE8\\SQLEXPRESS;Initial Catalog=Studentdb;Integrated Security=True;");

        public ManageCourseForm()
        {
            InitializeComponent();
        }

        private void ManageCourseForm_Load(object sender, EventArgs e)
        {
            show_table();
            BindData();
        }
        private void show_table()
        {
            // SqlConnection conn = new SqlConnection("Data Source=DESKTOP-4JGGOE8\\SQLEXPRESS;Initial Catalog=Studentdb;Integrated Security=True;");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select Count(*) from Coursef ", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            BindData();
        }

        private void DataGridView_manageCourse_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
			textBox_CId.Text = DataGridView_manageCourse.CurrentRow.Cells[0].Value.ToString();
			comboBox1.Text = DataGridView_manageCourse.CurrentRow.Cells[1].Value.ToString();
			textBox_Chour.Text = DataGridView_manageCourse.CurrentRow.Cells[2].Value.ToString();
			textBox_description.Text = DataGridView_manageCourse.CurrentRow.Cells[3].Value.ToString();
			textBox_stdId.Text = DataGridView_manageCourse.CurrentRow.Cells[4].Value.ToString();
		}

        private void button_clear_Click_1(object sender, EventArgs e)
        {
            textBox_Chour.Clear();
            textBox_CId.Clear();
            textBox_stdId.Clear();

			textBox_description.Clear();
        }
        void BindData()
        {
            SqlCommand cmdd = new SqlCommand("Select * from Coursef ", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmdd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            DataGridView_manageCourse.DataSource = dt;
        }

        private void button_update_Click_1(object sender, EventArgs e)
        {
            conn.Open();
			SqlCommand command = new SqlCommand("update Coursef set Course_Id= '"+textBox_CId.Text+"',Course_Name='"+comboBox1.Text+"',Course_Hour = '"+textBox_Chour.Text+"', Description = '"+textBox_description.Text+"',where Student_Id='"+textBox_stdId.Text+"'  ", conn);

			command.ExecuteNonQuery();
            conn.Close();
            BindData();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure To delete ?","Delete Record",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                conn.Open();
                SqlCommand command = new SqlCommand("Delete Coursef where Course_Id = '"+textBox_CId.Text+"'", conn);
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Delete is Successful", "Deleted!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                BindData();
                
            }
            else
            {
                MessageBox.Show("Please enter the Course Id", "" +
                    "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
