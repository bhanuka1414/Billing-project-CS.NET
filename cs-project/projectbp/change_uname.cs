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
    public partial class change_uname : Form
    {
        sqlconnectio_class con;
        public change_uname()
        {
            con = new sqlconnectio_class();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.connection();
                con.qurry("select * from log where UserName='" + txtusername3.Text + "';");
                con.ad();
                String pw = "";

                pw = con.dt.Rows[0][1].ToString();
                //con.dt.Clear();

                if (pw.Equals(txtoldpass.Text))
                {

                    con.qurry("update log set UserName='"+txtnewuser.Text+"' where UserName='"+txtusername3.Text+"';");
                    con.nonqurry();
                    MessageBox.Show("Username Change!");
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
            txtusername3.Clear();
            txtnewuser.Clear();
            txtoldpass.Clear();
        }
    }
}
