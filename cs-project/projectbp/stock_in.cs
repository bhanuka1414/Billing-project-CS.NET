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
    public partial class stock_in : Form
    {
        sqlconnectio_class con;
        public stock_in()
        {
            con = new sqlconnectio_class();
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.connection();
                con.qurry("insert into item values('"+txtino.Text+"','"+txtiname.Text+"','"+txtiprice.Text+"','"+txticost.Text+"','"+txtqty.Text+"');");
                con.nonqurry();
                con.qurry("insert into sales_s values('"+txtino.Text+"','"+txtiname.Text+"',0,0,0);");
                con.nonqurry();
                MessageBox.Show("insert");
                con.conclose();
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txticost.Clear();
            txtiname.Clear();
            txtino.Clear();
            txtiprice.Clear();
            txtqty.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.connection();
                con.qurry("update item set iname='"+txtiname.Text+"',iprice='"+txtiprice.Text+"',icost='"+txticost.Text+"',no_of_item='"+txtqty.Text+"'where ino='"+txtino.Text+"';");
                con.nonqurry();
                MessageBox.Show("updated!");
                con.conclose();
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            }
        }
    }
}
