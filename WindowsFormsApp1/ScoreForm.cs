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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class ScoreForm : Form
    {
        SqlConnection conect = new SqlConnection("Data Source=DESKTOP-4JGGOE8\\SQLEXPRESS;Initial Catalog=Studentdb;Integrated Security=True;");
        public ScoreForm()
        {
            InitializeComponent();
        }

        private void ScoreForm_Load(object sender, EventArgs e)
        {
            BindData();
            show_table();

		}
		private void show_table()
		{
			// SqlConnection conn = new SqlConnection("Data Source=DESKTOP-4JGGOE8\\SQLEXPRESS;Initial Catalog=Studentdb;Integrated Security=True;");
			conect.Open();
			SqlCommand cmd = new SqlCommand("Select stdId, stdFname, stdLname from Registration", conect);
			cmd.ExecuteNonQuery();
			conect.Close();

			
			SqlDataAdapter sd = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			sd.Fill(dt);
			guna2DataGridView_StudentList.DataSource = dt;
		}

		bool verify()
        {
            if ((textBox_description.Text =="")|| (textBox_Score.Text == "")||(textBox_StdId.Text=="")||
                (comboBox_stdCourse.Text == ""))
            {
                return false;
            }
            else
                return true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (verify())
            {
                
                conect.Open();
                SqlCommand command = new SqlCommand("insert into Score values ('"+int.Parse(textBox_StdId.Text)+"','"+comboBox_stdCourse.Text+"','"+textBox_Score.Text+"','"+textBox_description.Text+"')", conect);
                command.ExecuteNonQuery();
                MessageBox.Show("New Score Added", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conect.Close();
                BindData();
                /*try
                {
                    if (command.ExecuteNonQuery()==1)
                    {
                        MessageBox.Show("New Student Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conect.Close();
                        BindData();
                    }
                }catch(Exception ex)
                
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conect.Close();
                }*/

            }
            else
            {
                MessageBox.Show("Score value Don't add", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        void BindData()
        {
            SqlCommand command = new SqlCommand("Select * from Score ", conect);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            guna2DataGridView_ScoreList.DataSource = dt;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox_description.Clear();
            textBox_Score.Clear();
            textBox_StdId.Clear();
        }

		private void guna2DataGridView_StudentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			textBox_StdId.Text = guna2DataGridView_StudentList.CurrentRow.Cells[0].Value.ToString();
			
		}

		private void guna2DataGridView_ScoreList_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			comboBox_stdCourse.Text = guna2DataGridView_ScoreList.CurrentRow.Cells[1].Value.ToString();
			textBox_Score.Text = guna2DataGridView_ScoreList.CurrentRow.Cells[2].Value.ToString();
			textBox_description.Text = guna2DataGridView_ScoreList.CurrentRow.Cells[3].Value.ToString();

		}
	}
}
