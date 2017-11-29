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
    public partial class home : Form
    {
        
        
        sqlconnectio_class con;
        decimal cash;
        decimal gtot;
        decimal d;
        Double firstnum;
        Double secondtnum;
        Double answer;
        String ope;
        public home()
        {
            con = new sqlconnectio_class();
            
            InitializeComponent();
            lst_bill.SelectionMode = SelectionMode.MultiExtended;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lst_bill.Hide();
            pnlcal.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pnlcal.Hide();
            lst_bill.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (txtcaldis.Text == "0")
            {
                txtcaldis.Text = b.Text;
            }
            else
            {
                txtcaldis.Text = txtcaldis.Text + b.Text;
            }
            
        }

        private void button23_Click(object sender, EventArgs e)
        {
            txtcaldis.Clear();
            lblcal.Text = "";
        }

        private void operation_click(object sender, EventArgs e)
        {
            Button ops = (Button)sender;
            firstnum = Double.Parse(txtcaldis.Text);
            txtcaldis.Text = "";
            ope = ops.Text;
            lblcal.Text = System.Convert.ToString(firstnum) + "" + ope;

        }

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                secondtnum = Double.Parse(txtcaldis.Text);
                lblcal.Text = "";
                switch (ope)
                {
                    case "+":
                        answer = (firstnum + secondtnum);
                        txtcaldis.Text = Convert.ToString(answer);
                        break;
                    case "-":
                        answer = (firstnum - secondtnum);
                        txtcaldis.Text = Convert.ToString(answer);
                        break;
                    case "/":
                        answer = (firstnum / secondtnum);
                        txtcaldis.Text = Convert.ToString(answer);
                        break;
                    case "*":
                        answer = (firstnum * secondtnum);
                        txtcaldis.Text = Convert.ToString(answer);
                        break;
                    default:
                        break;


                }
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            }


        }

        private void button22_Click(object sender, EventArgs e)
        {
            if(txtcaldis.Text.Length>0)
            {
                txtcaldis.Text = txtcaldis.Text.Remove(txtcaldis.Text.Length - 1, 1);
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Button ops = (Button)sender;
            if(ops.Text==".")
            {
                if (!txtcaldis.Text.Contains("."))

                    txtcaldis.Text =txtcaldis.Text+ops.Text;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnstk_Click(object sender, EventArgs e)
        {
            btnstk.Hide();
            pnlstk.Show();
        }

        private void home_Load(object sender, EventArgs e)
        {
            dateTimePicker2.Value.TimeOfDay.ToString();
            pnlstk.Hide();
            lst_bill.Hide();
            lst_bill.Items.Add(string.Format("                           Welcome    "));
            lst_bill.Items.Add(string.Format("------------------------------------------------------"));
            lst_bill.Items.Add(string.Format("------------------------------------------------------"));
            lst_bill.Items.Add(string.Format("                         << name >>   "));
            lst_bill.Items.Add(string.Format("------------------------------------------------------"));
            lst_bill.Items.Add(string.Format("Item"));
            lst_bill.Items.Add(string.Format("------------------------------------------------------"));
        }

        private void button25_Click(object sender, EventArgs e)
        {
            pnlstk.Hide();
            btnstk.Show();
            rbinsert.Checked = false;
            rbupdate.Checked = false;
            rbview.Checked = false;



        }

        private void button28_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dateTimePicker2_MouseHover(object sender, EventArgs e)
        {
            lbltime.Text = System.DateTime.Now.ToShortTimeString();
        }

        private void dateTimePicker2_MouseLeave(object sender, EventArgs e)
        {
            lbltime.Text = "";
        }

        private void button29_Click(object sender, EventArgs e)
        {
           
            Form1 g = new Form1();
            
            this.Hide();
            g.Show();
        }

        private void rbinsert_CheckedChanged(object sender, EventArgs e)
        {
if(rbinsert.Checked==true)
            { stock_in i= new stock_in();
                i.Show();
            }
        }

        private void rbupdate_CheckedChanged(object sender, EventArgs e)
        {
            if (rbupdate.Checked == true)
            {
                stock_in i2 = new stock_in();
                i2.Show();
            }
        }

        private void rbview_CheckedChanged(object sender, EventArgs e)
        {
            if (rbview.Checked == true)
            {
                stock_view sv = new stock_view();
                sv.Show();
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            try
            {
                con.connection();
                con.qurry("select * from item where ino='" + txtino.Text + "';");
                String price = "";

                String cost = "";

                String name = "";


                int q1 = Convert.ToInt32(txtqty.Text);
                con.ad();
                price = con.dt.Rows[0][2].ToString();
                cost = con.dt.Rows[0][3].ToString();
                name = con.dt.Rows[0][1].ToString();
                double p = double.Parse(price);
                double c = double.Parse(cost);
                double totcost = (c * q1);
                double subtotal = (p * q1);
                decimal tcc = (decimal)totcost;
                decimal stt = (decimal)subtotal;

                gtot = gtot + stt;


                

                txtiname.Text = name;
                txt_gross_amo.Text = gtot.ToString();

                txtsubtot.Text = subtotal.ToString();



                con.qurry("update item set no_of_item=(no_of_item-'" + txtqty.Text + "') where ino='" + txtino.Text + "';");
                con.nonqurry();
                con.qurry("update sales_s set item_name='" + txtiname.Text + "', item_price=(item_price+ '" + stt + "') ,item_cost=(item_cost+ '" + tcc + "'),no_of_s=(no_of_s+ '" + q1 + "') where item_no='" + txtino.Text + "';");
                con.nonqurry();


                lst_bill.Items.Add(string.Format("{0}  ", txtiname.Text));

                lst_bill.Items.Add(string.Format("      X {0}          RS.{1}   ",txtqty.Text, txtsubtot.Text));
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            }
            
            



        }

        private void btn_cal_tot_Click(object sender, EventArgs e)
        {
            try
            {
                d = decimal.Parse(txtdis.Text);

                decimal dis = (gtot * d) / 100;
               // txtdis.Text = dis.ToString();
                decimal net = gtot - dis;
                txtnetamo.Text = net.ToString();
                cash = Convert.ToInt32(txtcash.Text);
                decimal c = (decimal)cash;
                if(c >= net)
                {
                    decimal change = c - net;
                    txtchange.Text = change.ToString();


                    lst_bill.Items.Add(string.Format("------------------------------------------------------"));
                    lst_bill.Items.Add(string.Format("------------------------------------------------------"));
                    lst_bill.Items.Add(string.Format("Gross Amount: {0}    ", txt_gross_amo.Text));
                    lst_bill.Items.Add(string.Format("Bill Disc:    {0}    ", dis));
                    lst_bill.Items.Add(string.Format("NET Amount:   {0}    ", txtnetamo.Text));
                    lst_bill.Items.Add(string.Format("CASH:      RS.{0}    ", txtcash.Text));
                    lst_bill.Items.Add(string.Format("CHANGE:    RS.{0}    ", txtchange.Text));
                    lst_bill.Items.Add(string.Format("------------------------------------------------------"));
                    lst_bill.Items.Add(string.Format("------------------------------------------------------"));
                    lst_bill.Items.Add(string.Format("  {0}       ", dateTimePicker2.Text));
                    lst_bill.Items.Add(string.Format("                  Thankyou    "));
                }
                else
                {
                    MessageBox.Show("Cash not enough");
                }
                


               

            }
            catch (Exception)
            {

                txtcash.BackColor = Color.Red;
            } 
            


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtiname.Clear();
            txtino.Clear();
            txtqty.Clear();
            txtsubtot.Clear();
            txtino.Focus();
        }

        private void txtcash_TextChanged(object sender, EventArgs e)
        {
            txtcash.BackColor = Color.White;
        }

        private void txtdis_Click(object sender, EventArgs e)
        {
            txtdis.Text = "";
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txtcash.Clear();
            txtchange.Clear();
            txtdis.Text = "0";
            txtiname.Clear();
            txtino.Clear();
            txtnetamo.Clear();
            txtqty.Clear();
            txtsubtot.Clear();
            txt_gross_amo.Clear();
            lst_bill.Items.Clear();


            lst_bill.Items.Add(string.Format("                           Welcome    "));
            lst_bill.Items.Add(string.Format("------------------------------------------------------"));
            lst_bill.Items.Add(string.Format("------------------------------------------------------"));
            lst_bill.Items.Add(string.Format("                          << name >>   "));
            lst_bill.Items.Add(string.Format("------------------------------------------------------"));
            lst_bill.Items.Add(string.Format("Item"));
            lst_bill.Items.Add(string.Format("------------------------------------------------------"));

        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            if(printDialog1.ShowDialog()==DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int x = 10, y = 10, i = 0;
            foreach (string str in lst_bill.Items)
            {
                e.Graphics.DrawString(str, new Font("Arial", 20), Brushes.Black, x, y);
                y += 25;
                i+=2;
            }
                     // e.Graphics.DrawString(lst_bill.SelectedItem.ToString(), new Font("Arial", 25), Brushes.Black, 150, 125);
        }

        private void button2_Click(object sender, EventArgs e)
        {
              
        }

        private void button27_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contact Us -\n \n Bhanuka: 0713763355 \n Dishni: 0772912445 \n Zainab: 0773665559 \n Sammy: 0776702306 \n Marz: 0723921654");
        }
    }
}
