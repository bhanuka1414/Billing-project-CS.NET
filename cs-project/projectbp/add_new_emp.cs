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
    public partial class add_new_emp : Form
    {
        sqlconnectio_class con;
        int pno;
        public add_new_emp()
        {
            con = new sqlconnectio_class();

            InitializeComponent();
        }

        private void add_new_emp_Load(object sender, EventArgs e)
        {

        }

        private void btn_ane_insert_Click(object sender, EventArgs e)
        {
            if (txteno.Text == "")
            {
                txteno.BackColor = Color.Red;

            }
            else
            {
                try
                {
                    pno = Convert.ToInt32(mtxt_pno.Text);


                    con.connection();
                    con.qurry("insert into employee values('" + txteno.Text + "','" + txtename.Text + "','" + txteadd.Text + "','" + pno + "','" + dtp_dob.Text + "');");
                    con.nonqurry();
                    MessageBox.Show("insert");

                    con.conclose();
                    txteno.BackColor = Color.White;
                    txteadd.Clear();
                    txtename.Clear();
                    txteno.Clear();
                    mtxt_pno.Clear();
                }
                catch (Exception EX)
                {

                    MessageBox.Show(EX.Message);
                }
            }
            
        }

        private void btn_ane_claer_Click(object sender, EventArgs e)
        {
            
            txteadd.Clear();
            txtename.Clear();
            txteno.Clear();
            mtxt_pno.Clear();
        }

        private void btn_ane_update_Click(object sender, EventArgs e)
        {
            if (txteno.Text == "")
            {
                txteno.BackColor = Color.Red;

            }
            else
            {
                try
                {
                    pno = Convert.ToInt32(mtxt_pno.Text);
                    con.connection();
                    con.qurry("update employee set ename='" + txtename.Text + "',eaddress='" + txteadd.Text + "',ephone_no='" + pno + "' where eno='" + txteno.Text + "';");
                    con.nonqurry();
                    MessageBox.Show("update");
                    con.conclose();
                    txteno.BackColor = Color.White;

                    txteadd.Clear();
                    txtename.Clear();
                    txteno.Clear();
                    mtxt_pno.Clear();
                }
                catch (Exception EX)
                {

                    MessageBox.Show(EX.Message);
                }
            }
            
        }
    }
}
