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
    public partial class new_user : Form
    {
        sqlconnectio_class con;
        public new_user()
        {
            con = new sqlconnectio_class();
            InitializeComponent();
        }

        private void new_user_Load(object sender, EventArgs e)
        {
            lblprivrlege.Hide();
        }

      /*  private void textBox3_Click(object sender, EventArgs e)
        {
            lblprivrlege.Show();
        }*/

     /*   private void textBox3_MouseLeave(object sender, EventArgs e)
        {
            lblprivrlege.Hide();
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.connection();
                con.qurry("insert into log values('" + txtusername.Text + "','" + txtpass.Text + "','" + txtprivilege.Text + "');");
                con.nonqurry();
                MessageBox.Show("user created!");
                con.conclose();
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            }
            
            
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtusername.Clear();
            txtpass.Clear();
            txtprivilege.Clear();

        }

        private void txtprivilege_MouseHover(object sender, EventArgs e)
        {
            lblprivrlege.Show();
        }

        private void txtprivilege_MouseLeave(object sender, EventArgs e)
        {
            lblprivrlege.Hide();
        }
    }
}
