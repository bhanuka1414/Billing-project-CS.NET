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
    public partial class emp_view : Form
    {
        sqlconnectio_class con;
        public emp_view()
        {
            con = new sqlconnectio_class();
            InitializeComponent();
        }

        private void emp_view_Load(object sender, EventArgs e)
        {
            con.connection();
            con.qurry("select eno as 'Employee NO',ename as 'Name', eaddress as 'Address',ephone_no as 'Phone NO',dob as 'Date of birth' from employee;");
            con.ad();
            dataGridView1.DataSource = con.dt;
            con.conclose();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                con.connection();
                con.qurry("select eno as 'Employee NO',ename as 'Name', eaddress as 'Address',ephone_no as 'Phone NO',dob as 'Date of birth' from employee where eno='"+ toolStripTextBox1.Text+"';");
                con.ad();
                dataGridView1.DataSource = con.dt;
                con.conclose();
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.connection();
            con.qurry("select * from employee;");
            con.ad();
            dataGridView1.DataSource = con.dt;
            con.conclose();
            toolStripTextBox1.Text = "";
        }
    }
}
