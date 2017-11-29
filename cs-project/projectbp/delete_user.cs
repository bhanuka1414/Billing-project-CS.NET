using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectbp
{
    public partial class delete_user : Form
    {
        sqlconnectio_class con;
        public delete_user()
        {
            con = new sqlconnectio_class();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.connection();
                con.qurry("select * from log where UserName='" + txtusername2.Text + "';");
                con.ad();
                String pw = "";

                pw = con.dt.Rows[0][1].ToString();
                //con.dt.Clear();

                if (pw.Equals(txtpass2.Text))
                {

                    con.qurry("delete from log where UserName='" + txtusername2.Text + "';");
                    con.nonqurry();
                    MessageBox.Show("User Deleted!");
                }
                else
                {
                    MessageBox.Show("Check Ysername or Password");
                }
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            }
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtusername2.Clear();
            txtpass2.Clear();
        }
    }
}
