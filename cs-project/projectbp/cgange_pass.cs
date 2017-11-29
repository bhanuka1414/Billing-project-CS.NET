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
    public partial class cgange_pass : Form
    {
        sqlconnectio_class con;
        public cgange_pass()
        {
            con = new sqlconnectio_class();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.connection();
                con.qurry("select * from log where UserName='" + txtuser4.Text + "';");
                con.ad();
                String pw = "";

                pw = con.dt.Rows[0][1].ToString();
                //con.dt.Clear();

                if (pw.Equals(txtoldpass2.Text))
                {

                    con.qurry("update log set password='" + txtnewpass1.Text + "' where UserName='" + txtuser4.Text + "';");
                    con.nonqurry();
                    MessageBox.Show("Password Change!");
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
            txtuser4.Clear();
            txtoldpass2.Clear();
            txtnewpass1.Clear();
        }
    }
}
