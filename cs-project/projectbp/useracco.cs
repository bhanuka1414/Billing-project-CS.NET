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
    public partial class useracco : Form
    {
        public useracco()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new_user nu = new new_user();
            nu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            change_uname cun = new change_uname();
            cun.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cgange_pass cp = new cgange_pass();
            cp.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            delete_user du = new delete_user();
            du.Show();

        }
    }
}
