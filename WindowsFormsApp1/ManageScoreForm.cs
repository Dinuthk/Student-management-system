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
    public partial class ManageScoreForm : Form
    {
		SqlConnection conect = new SqlConnection("Data Source=DESKTOP-4JGGOE8\\SQLEXPRESS;Initial Catalog=Studentdb;Integrated Security=True;");

		public ManageScoreForm()
        {
            InitializeComponent();
        }
		private void ManageScoreForm_Load(object sender, EventArgs e)
		{
			show_table1();
			show_table2();
			BindData();
		}
		private void show_table1()
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
		private void show_table2()
		{
			// SqlConnection conn = new SqlConnection("Data Source=DESKTOP-4JGGOE8\\SQLEXPRESS;Initial Catalog=Studentdb;Integrated Security=True;");
			conect.Open();
			SqlCommand cmd = new SqlCommand("Select Count(*) from Score", conect);
			cmd.ExecuteNonQuery();
			conect.Close();	
		}
		void BindData()
		{
			SqlCommand cmdd = new SqlCommand("Select * from Score ", conect);
			SqlDataAdapter sd = new SqlDataAdapter(cmdd);
			DataTable dt = new DataTable();
			sd.Fill(dt);
			guna2DataGridView_ScoreList.DataSource = dt;
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

		private void button_clear_Click(object sender, EventArgs e)
		{
			textBox_StdId.Clear();
			textBox_Score.Clear();
			textBox_description.Clear();

			
		}

		private void button_delete_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure To delete ?", "Delete Record", MessageBoxButtons.YesNo)==DialogResult.Yes)
			{
				conect.Open();
				SqlCommand command = new SqlCommand("Delete Score where Score = '"+textBox_Score.Text+"'", conect);
				command.ExecuteNonQuery();
				conect.Close();
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
