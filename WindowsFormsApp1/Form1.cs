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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            customizeDesign();
        }


        

        private void Form1_Load(object sender, EventArgs e)
        {
            //count 
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-4JGGOE8\\SQLEXPRESS;Initial Catalog=Studentdb;Integrated Security=True;");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select Count(*) from Registration ", conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            SqlCommand cmdd = new SqlCommand("Select * from Registration ", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmdd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            var totalst = dt.Rows.Count;
            label_totalStudent.Text = "Total Student :  "+ totalst.ToString();

            

            /*SqlConnection conn = new SqlConnection("Data Source=DESKTOP-4JGGOE8\\SQLEXPRESS;Initial Catalog=Studentdb;Integrated Security=True;");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select Count(*) from Registration ", conn);
            var totalst = cmd.ExecuteNonQuery();
            label_totalStudent.Text = "Total Student :  "+ totalst.ToString();
            conn.Close();*/

            
        }
        private void customizeDesign()
        {
            panel_stdsubmenu.Visible = false;
            panel_courseSubmenu.Visible = false;
            panel_scoreSubmenu.Visible = false;
        }
        private void hideSubmenu()
        {
            if(panel_stdsubmenu.Visible==true) 
            {
                panel_stdsubmenu.Visible = false;
            }
            if(panel_courseSubmenu.Visible==true)
            {
                panel_courseSubmenu.Visible = false;
            }
            if(panel_scoreSubmenu.Visible ==true)
            {
                panel_scoreSubmenu.Visible = false;
            }
        }

        private void showSubmenu(Panel submenu)
        {
            if(submenu.Visible==false) 
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        //Student Button and panel
        private void button_std_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_stdsubmenu);
        }
        #region stdSubmenu
        private void button_Registration_Click(object sender, EventArgs e)
        {
            openChildForm(new RegisterForm());

            hideSubmenu();
        }

        private void button_manageStd_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageStudentForm());

            hideSubmenu();
        }

        private void button_status_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void button_stdPrint_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }
        #endregion stdSubmenu

        //Course Button and panel
        private void button_course_Click(object sender, EventArgs e)
        {
           

            showSubmenu(panel_courseSubmenu);
        }
        #region CourseSubmenu
        private void button_newCourse_Click(object sender, EventArgs e)
        {
            openChildForm(new CourseForm());
            hideSubmenu();
        }

        private void button_manageCourse_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageCourseForm());
            hideSubmenu();
        }

        private void button_corsePrint_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }
        #endregion Courseubmenu

        //score Button and panel
        private void button_score_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_scoreSubmenu);
        }
        #region Scoresubmenu
        private void button_newScore_Click(object sender, EventArgs e)
        {
            openChildForm(new ScoreForm());
            hideSubmenu();
        }

        private void button_managescore_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageScoreForm());
            hideSubmenu();
        }

        private void button1_scorePrint_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }
        #endregion Scoresubmenu

        //to show registration form in mainform

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_main.Controls.Add(childForm);
            panel_main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
        }

        private void button_DashBoard_Click(object sender, EventArgs e)
        {
            if(activeForm !=null)
                activeForm.Close();
            panel_main.Controls.Add(panel_Cover);
        }

		private void button_Exit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		
	}
}
