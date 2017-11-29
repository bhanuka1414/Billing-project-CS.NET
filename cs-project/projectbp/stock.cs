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
    public partial class stock : Form
    {
        public stock()
        {
            InitializeComponent();
        }

        private void stock_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            stock_in si = new stock_in();
            si.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stock_in si2 = new stock_in();
            si2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            item_delete id = new item_delete();
            id.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            stock_view sv = new stock_view();
            sv.Show();
        }
    }
}
