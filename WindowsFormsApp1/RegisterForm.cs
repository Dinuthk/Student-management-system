using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class RegisterForm : Form
    {
        SqlConnection conect = new SqlConnection("Data Source=DESKTOP-4JGGOE8\\SQLEXPRESS;Initial Catalog=Studentdb;Integrated Security=True;");
        string g;
        /*public void openconect()
        {
            if (conect.State==System.Data.ConnectionState.Closed)
                conect.Open();
        }
        public void closeconect()
        {
            if (conect.State==System.Data.ConnectionState.Open)
                conect.Close();
        }*/
        public RegisterForm()
        {
            InitializeComponent();
        }
        //upload photo
        private void button_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select photo (*.gpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox_student.Image=Image.FromFile(opf.FileName);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            BindData();
        }
        bool verify()
        {
            if ((textBox_Fname.Text =="")|| (textBox_Lname.Text == "")||(textBox_Phone.Text=="")||
                (textBox_Address.Text == ""))
            {
                return false;
            }
            else
                return true;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            
            

            //we nedd to cheack student age between 10 and 100
            int born_year = dateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;
            if((this_year - born_year)<10|| (this_year- born_year)>100)
            {
                MessageBox.Show("The student age must be between 10 and 100","Invalid BierthDate",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
            else if(verify())
            {
                if (radioButton_Male.Checked==true)
                {
                    g="Male";
                }
                else
                {
                    g="Female";
                }
                conect.Open();
                SqlCommand command = new SqlCommand("insert into Registration values ('"+int.Parse(textBox_StudentID.Text)+"','"+textBox_Fname.Text+"','"+textBox_Lname.Text+"','"+this.dateTimePicker1.Text+"','"+g+"','"+textBox_Phone.Text+"','"+textBox_Address.Text+"')", conect);
                command.ExecuteNonQuery();

                MessageBox.Show("New Student Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Student Don't add", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        /*byte[] convertimgtobytes(Image img)
        {
            using ( MemoryStream ms=new MemoryStream() ) 
            {
                img.Save(ms,System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
        public Image convertbytearraytoimg(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                return Image.FromStream(ms);
            }
        }*/
        void BindData()
        {
            SqlCommand command = new SqlCommand("Select * from Registration ",conect);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            guna2DataGridView1.DataSource = dt;

            

        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_Fname.Clear();
            textBox_Lname.Clear();
            textBox_Address.Clear();
            textBox_Phone.Clear();
            textBox_StudentID.Clear();
            radioButton_Male.Checked = true;
            dateTimePicker1.Value=DateTime.Now;

        }

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
