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
    public partial class emp_dalete : Form
    {
        sqlconnectio_class con;
        public emp_dalete()
        {
            con = new sqlconnectio_class();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.connection();
            con.qurry("delete from employee where eno='"+textBox1.Text+"';");
            con.nonqurry();
            MessageBox.Show("Delete!");
        }
    }
}
