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
    public partial class sales : Form
    {
        sqlconnectio_class con;
        public sales()
        {
            con = new sqlconnectio_class();
            InitializeComponent();
        }

        private void sales_Load(object sender, EventArgs e)
        {
            try
            {
                con.connection();
                con.qurry("select item_no as 'Item NO',item_name as 'Item Name',item_price as 'Total Income',item_cost as 'Total Cost',no_of_s as 'Sold Items' from sales_s;");
                con.ad();
                dataGridView1.DataSource = con.dt;
                con.conclose();
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            }
            
        }

        private void toolStripbtn_search_Click(object sender, EventArgs e)
        {
            
            try
            {
                con.connection();
                con.qurry("select item_no as 'Item NO',item_name as 'Item Name',item_price as 'Item Price',item_cost as 'Total Cost',no_of_s as 'Sold Items' from sales_s where item_no='" + toolStriptxtsearch.Text+"';");
                con.ad();
                dataGridView1.DataSource = con.dt;
                con.conclose();
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                try
                {
                    con.connection();
                    con.qurry("select item_no as 'Item NO',item_name as 'Item Name',item_price as 'Total Income',item_cost as 'Total Cost',no_of_s as 'Sold Items' from sales_s order by no_of_s desc;");
                    con.ad();
                    dataGridView1.DataSource = con.dt;
                    con.conclose();
                }
                catch (Exception EX)
                {

                    MessageBox.Show(EX.Message);
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                try
                {
                    con.connection();
                    con.qurry("select item_no as 'Item NO',item_name as 'Item Name',item_price as 'Total Income',item_cost as 'Total Cost',no_of_s as 'Sold Items' from sales_s order by no_of_s ASC;");
                    con.ad();
                    dataGridView1.DataSource = con.dt;
                    con.conclose();
                }
                catch (Exception EX)
                {

                    MessageBox.Show(EX.Message);
                }
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                try
                {
                    con.connection();
                    con.qurry("select item_no as 'Item NO',item_name as 'Item Name',item_price as 'Total Income',item_cost as 'Total Cost',no_of_s as 'Sold Items' from sales_s order by item_price desc;");
                    con.ad();
                    dataGridView1.DataSource = con.dt;
                    con.conclose();
                }
                catch (Exception EX)
                {

                    MessageBox.Show(EX.Message);
                }
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true)
            {
                try
                {
                    con.connection();
                    con.qurry("select item_no as 'Item NO',item_name as 'Item Name',item_price as 'Total Income',item_cost as 'Total Cost',no_of_s as 'Sold Items' from sales_s order by item_price;");
                    con.ad();
                    dataGridView1.DataSource = con.dt;
                    con.conclose();
                }
                catch (Exception EX)
                {

                    MessageBox.Show(EX.Message);
                }
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                try
                {
                    con.connection();
                    con.qurry("select item_no as 'Item NO',item_name as 'Item Name',item_price as 'Total Income',item_cost as 'Total Cost',no_of_s as 'Sold Items' from sales_s order by item_cost desc;");
                    con.ad();
                    dataGridView1.DataSource = con.dt;
                    con.conclose();
                }
                catch (Exception EX)
                {

                    MessageBox.Show(EX.Message);
                }
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                try
                {
                    con.connection();
                    con.qurry("select item_no as 'Item NO',item_name as 'Item Name',item_price as 'Total Income',item_cost as 'Total Cost',no_of_s as 'Sold Items' from sales_s order by item_cost;");
                    con.ad();
                    dataGridView1.DataSource = con.dt;
                    con.conclose();
                }
                catch (Exception EX)
                {

                    MessageBox.Show(EX.Message);
                }
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true)
            {
                try
                {
                    con.connection();
                    con.qurry("select item_no as 'Item NO',item_name as 'Item Name',item_price as 'Total Income',item_cost as 'Total Cost',no_of_s as 'Sold Items' from sales_s order by item_name;");
                    con.ad();
                    dataGridView1.DataSource = con.dt;
                    con.conclose();
                }
                catch (Exception EX)
                {

                    MessageBox.Show(EX.Message);
                }
            }
        }

        private void toolStriptxtsearch_Click(object sender, EventArgs e)
        {
            toolStriptxtsearch.Text = "";
            toolStriptxtsearch.ForeColor = Color.Black;
        }

        private void txtmin_Click(object sender, EventArgs e)
        {
            txtmin.Text = "";
            txtmin.ForeColor = Color.Black;
        }

        private void txtmax_Click(object sender, EventArgs e)
        {
            txtmax.Text = "";
            txtmax.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtmin.Equals(""))
                {
                    txtmin.Text = "0";
                }
                if(txtmax.Equals(""))
                {
                    txtmax.Text = "0";
                }
                con.connection();
                con.qurry("select item_no as 'Item NO',item_name as 'Item Name',item_price as 'Total Income',item_cost as 'Total Cost',no_of_s as 'Sold Items' from sales_s where item_price between '" + txtmin.Text+"' and '"+txtmax.Text+"';");
                con.ad();
                dataGridView1.DataSource = con.dt;
                con.conclose();
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmin.Equals(""))
                {
                    txtmin.Text = "0";
                }
                if (txtmax.Equals(""))
                {
                    txtmax.Text = "0";
                }
                con.connection();
                con.qurry("select item_no as 'Item NO',item_name as 'Item Name',item_price as 'Total Income',item_cost as 'Total Cost',no_of_s as 'Sold Items' from sales_s where item_cost between '" + txtmin.Text + "' and '" + txtmax.Text + "';");
                con.ad();
                dataGridView1.DataSource = con.dt;
                con.conclose();
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmin.Equals(""))
                {
                    txtmin.Text = "0";
                }
                if (txtmax.Equals(""))
                {
                    txtmax.Text = "0";
                }
                con.connection();
                con.qurry("select item_no as 'Item NO',item_name as 'Item Name',item_price as 'Total Income',item_cost as 'Total Cost',no_of_s as 'Sold Items' from sales_s where no_of_s between '" + txtmin.Text + "' and '" + txtmax.Text + "';");
                con.ad();
                dataGridView1.DataSource = con.dt;
                con.conclose();
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to Reset Data?", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                    Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                    Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                    app.Visible = true;
                    worksheet = workbook.Sheets["Sheet1"];
                    worksheet = workbook.ActiveSheet;
                    for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                    {
                        worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                    }
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            if (dataGridView1.Rows[i].Cells[j].Value != null)
                            {
                                worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                            }
                            else
                            {
                                worksheet.Cells[i + 2, j + 1] = "";
                            }
                        }
                    }


                    con.connection();
                    con.qurry("update sales_s set item_price=0,item_cost=0,no_of_s=0;");
                    con.nonqurry();
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("aaaaaaaaaaa");
                }
                
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            }
           
        }
    }
}
