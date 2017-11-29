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
    public partial class stock_view : Form
    {
        sqlconnectio_class con;
        public stock_view()
        {
            con = new sqlconnectio_class();
            InitializeComponent();
        }

        private void stock_view_Load(object sender, EventArgs e)
        {
            con.connection();
            con.qurry("select ino as 'Item ON',iname as 'Item Name',iprice as 'Item Price',icost as 'Item Cost',no_of_item as 'NO of Items' from item;");
            con.ad();
            dataGridView1.DataSource = con.dt;
            con.conclose();
        }

        private void toolStripTextBox1_Leave(object sender, EventArgs e)
        {
            toolStripTxt_search.Text = toolStripTxt_search.Text;
        }

        private void toolStripTxt_search_Click(object sender, EventArgs e)
        {
            toolStripTxt_search.Text = "";
            toolStripTxt_search.ForeColor = Color.Black;
        }

        private void toolStripbtn_search_Click(object sender, EventArgs e)
        {
            try
            {
                con.connection();
                con.qurry("select ino as 'Item ON',iname as 'Item Name',iprice as 'Item Price',icost as 'Item Cost',no_of_item as 'NO of Items' from item where ino='" + toolStripTxt_search.Text + "';");
                con.ad();
                dataGridView1.DataSource = con.dt;
                con.conclose();
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            }
            
        }

        private void priceHighLowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                con.connection();
                con.qurry("select ino as 'Item ON',iname as 'Item Name',iprice as 'Item Price',icost as 'Item Cost',no_of_item as 'NO of Items' from item order by iprice desc;");
                con.ad();
                dataGridView1.DataSource = con.dt;
                con.conclose();
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            }
        }

        private void priceLowHighToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                con.connection();
                con.qurry("select ino as 'Item ON',iname as 'Item Name',iprice as 'Item Price',icost as 'Item Cost',no_of_item as 'NO of Items' from item order by iprice;");
                con.ad();
                dataGridView1.DataSource = con.dt;
                con.conclose();
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            }
        }

        private void sortByNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                con.connection();
                con.qurry("select ino as 'Item ON',iname as 'Item Name',iprice as 'Item Price',icost as 'Item Cost',no_of_item as 'NO of Items' from item order by iname;");
                con.ad();
                dataGridView1.DataSource = con.dt;
                con.conclose();
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            }
        }
    }
}
