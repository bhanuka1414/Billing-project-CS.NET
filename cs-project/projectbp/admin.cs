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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            home h1 = new home();
            h1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            useracco u = new useracco();
            u.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            employee e2 = new employee();
            e2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            stock s1 = new stock();
            s1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sales ss2 = new sales();
            ss2.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contact Us -\n \n Bhanuka: 0713763355 \n Dishni: 0772912445 \n Zainab: 0773665559 \n Sammy: 0776702306 \n Marz: 0723921654");
        }

        private void admin_Load(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Hide();
        }
    }
}
