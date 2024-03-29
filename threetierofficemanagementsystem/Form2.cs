using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using Props;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace threetierofficemanagementsystem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmpProps p = new EmpProps();
            p.Prod_id = txtprodid.Text;
            p.Prod_name = txtprodname.Text;
            p.Prod_price = txtprodprice.Text;
            p.Prod_quantity = txtprodquantity.Text;

            EmpBL obj = new EmpBL();
            if (obj.empPInsertBL(p))
            {
                MessageBox.Show("Data Inserted");
            }
            else
            {
                MessageBox.Show("Not Inserted");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmpProps p = new EmpProps();
            p.Prod_id = txtprodid.Text;
            p.Prod_name = txtprodname.Text;
            p.Prod_price = txtprodprice.Text;
            p.Prod_quantity = txtprodquantity.Text;

            try
            {
                EmpBL obj = new EmpBL();
                obj.empPDeleteBL(p);
                MessageBox.Show("Record deleted Successfully");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Exception:" + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmpProps p = new EmpProps();
            p.Prod_id = txtprodid.Text;
            p.Prod_name = txtprodname.Text;
            p.Prod_price = txtprodprice.Text;
            p.Prod_quantity = txtprodquantity.Text;


            try
            {

                EmpBL obj = new EmpBL();
                obj.empPUpdateBL(p);
                MessageBox.Show("Record Updated Successfully");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Exception:" + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EmpProps p = new EmpProps();
            p.Prod_id = txtprodid.Text;


            try
            {
                EmpBL obj = new EmpBL();
                DataTable dt = obj.empPSearchBL(p);
                if (dt != null)
                {
                    txtprodname.Text = dt.Rows[0]["Prod_name"].ToString();
                    txtprodprice.Text = dt.Rows[0]["Prod_name"].ToString();
                    txtprodquantity.Text = dt.Rows[0]["Prod_quantity"].ToString();
                    MessageBox.Show("Records Found");
                }
                else
                {
                    MessageBox.Show("No Records Found");
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Exception:" + ex.Message);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtprodid.Clear();
            txtprodname.Clear();
            txtprodprice.Clear();
            txtprodquantity.Clear();
        }

        private void LoadDataIntoDataGridView()
        {
            try
            {
                // Use a using statement for SqlConnection to ensure proper disposal
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-7E4FKNS\SQLEXPRESS;Initial Catalog=threetier;Integrated Security=True;"))
                {
                    conn.Open();

                    // Use a using statement for SqlDataAdapter to ensure proper disposal
                    using (SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Product", conn))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            dataGridView1.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("No data found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Something is wrong " + ex.Message);
            }
        }

        private void btnviewall_Click(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
        }
    }
}
