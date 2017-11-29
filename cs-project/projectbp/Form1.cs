using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace projectbp
{
    public partial class Form1 : Form
    {
        
        sqlconnectio_class con;
        public Form1()
        {
            con = new sqlconnectio_class();
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                con.connection();
                con.qurry("select * from log;");

                con.ad();
                String ch = "";
                ch = con.dt.Rows[0][0].ToString();
               
                
                
                   
                
            }
            catch (IndexOutOfRangeException)
            {

                
                admin a = new admin();
                a.Show();
                this.Hide();
            }
            
            

            
            


        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            try
            {
                con.connection();
                con.qurry("select * from log where UserName='" + txtu.Text + "';");

                con.ad();
                String id = "";
                String pw = "";

                

                id = con.dt.Rows[0][2].ToString();
                pw = con.dt.Rows[0][1].ToString();
                con.dt.Clear();
                con.conclose();


               

                if (pw.Equals(txtp.Text))
                {
                    if(id.Equals("1"))
                    {
                        this.Hide();
                        admin a = new admin();
                        a.Show();
                    }
                    else
                    {
                        this.Hide();
                        home h = new home();
                        h.Show();

                    }

                    
                }
                else
                {
                   
                    ep_w.Clear();
                   
                    ep_w.SetError(txtp, "enter correct password");
                }
                
            }
            
           
            
            catch (Exception)
            {
               
                ep_w.Clear();
                ep_w.SetError(txtu, "enter correct username");
                ep_w.SetError(txtp, "enter correct password");
                // MessageBox.Show("Check Your Username or Password");
            }
         
        }

       private void txtu_Leave(object sender, EventArgs e)
        {
            if(txtu.TextLength>0)
            {
                
                ep_w.Clear();
            }
            else
            {
                ep_w.SetError(txtu, "Enter user name");
            }
        }

        private void txtp_Leave(object sender, EventArgs e)
        {
            if (txtp.TextLength > 0)
            {
                
                ep_w.Clear();
            }
            else
            {
                ep_w.SetError(txtp, "Enter password");
            }
        }
    }   
}
