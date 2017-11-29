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
    public partial class employee : Form
    {
        


        public employee()
        {
            

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            add_new_emp a = new add_new_emp();
            a.Show();
            
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            add_new_emp b = new add_new_emp();
            b.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            emp_dalete d = new emp_dalete();
            d.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            emp_view v = new emp_view();
            v.Show();
        }
    }
}
