using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace projectbp
{
    class sqlconnectio_class
    {
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataAdapter sda;
        public SqlDataReader dr;
        public DataTable dt;
        public void connection()
        {
            
            con=new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\cs\projectbp\projectbp\Database1.mdf;Integrated Security=True");

            con.Open(); 

          /*  con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\cs\projectbp\projectbp\database1\csproject.mdf;Integrated Security=True;Connect Timeout=30");

            con.Open(); */
        }


        public void conclose()
        {

            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\cs\projectbp\projectbp\Database1.mdf;Integrated Security=True");

            con.Close();

            /* con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\cs\projectbp\projectbp\database1\csproject.mdf;Integrated Security=True;Connect Timeout=30");

             con.Close();  */
        }
        public void qurry(string qtxt)
        {
            cmd = new SqlCommand(qtxt, con);
        }
        public DataTable ad()
        {
            sda = new SqlDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public void nonqurry()
        {
cmd.ExecuteNonQuery();
        }
        public SqlDataReader ddr()
        {
            dr = cmd.ExecuteReader();
            return dr;
        }

    }
}
