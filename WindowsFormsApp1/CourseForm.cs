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
    public partial class CourseForm : Form
    {
        SqlConnection conect = new SqlConnection("Data Source=DESKTOP-4JGGOE8\\SQLEXPRESS;Initial Catalog=Studentdb;Integrated Security=True;");

        public CourseForm()
        {
            InitializeComponent();
        }

        private void CourseForm_Load(object sender, EventArgs e)
        {
            BindData();
        }
        bool verify()
        {
            if ((comboBox1.Text =="")|| (textBox_cId.Text == "")||(textBox_description.Text=="")||
                (textBox_Chour.Text == "")||(textBox_stdId.Text==""))
            {
                return false;
            }
            else
                return true;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if(verify())
            {
                conect.Open();
                SqlCommand command = new SqlCommand("insert into Coursef values ('"+int.Parse(textBox_cId.Text)+"','"+comboBox1.Text+"','"+textBox_Chour.Text+"','"+textBox_description.Text+"','"+textBox_stdId.Text+"')", conect);
                
                try
                {
                    if (command.ExecuteNonQuery()==1)
                    {
                        MessageBox.Show("New Course Added", "Add Coursef", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conect.Close();
                        BindData();
                    }
                }
                catch (Exception ex)

                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conect.Close();
                }

            }
            else
            {
                MessageBox.Show("Cours Can't add", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        void BindData()
        {
            SqlCommand command = new SqlCommand("Select * from Coursef ", conect);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            guna2DataGridView1.DataSource = dt;

        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_Chour.Clear();
            textBox_cId.Clear();
            
            textBox_description.Clear();
        }
    }
}
