using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class DBconecter
    {
        SqlConnection conect = new SqlConnection("Data Source=DESKTOP-4JGGOE8\\SQLEXPRESS;Initial Catalog=Studentdb;Integrated Security=True;");
        public void openconect()
        { 
            if(conect.State==System.Data.ConnectionState.Closed)
                conect.Open();
        }
        public void closeconect()
        {
            if(conect.State==System.Data.ConnectionState.Open)
                conect.Close();
        }

    }
}
