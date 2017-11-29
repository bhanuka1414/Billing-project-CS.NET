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
    public partial class item_delete : Form
    {
        sqlconnectio_class con;
        public item_delete()
        {
            con = new sqlconnectio_class();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.connection();
                con.qurry("delete from item where ino='"+txtino2.Text+"';");
                con.nonqurry();
                
                con.conclose();
                MessageBox.Show("Deleted!");
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            }
            finally
            {
                txtino2.Clear();
                txtino2.Focus();
            }
        }
    }
}
