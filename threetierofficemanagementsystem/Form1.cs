using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Props;
using BusinessLayer;
using System.Data.SqlClient;

namespace threetierofficemanagementsystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            EmpProps p = new EmpProps();
            p.Emp_id = txtempID.Text;
            p.Emp_name = txtname.Text;
            p.Emp_cell = txtCN.Text;
            p.Emp_address = txtadrs.Text;

            EmpBL obj = new EmpBL();
            if (obj.empInsertBL(p))
            {
                MessageBox.Show("Data Inserted");
            }
            else
            {
                MessageBox.Show("Not Inserted");
            }
        }

        private void txtempID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            EmpProps p = new EmpProps();
            p.Emp_id = txtempID.Text;
            p.Emp_name = txtname.Text;
            p.Emp_cell = txtCN.Text;
            p.Emp_address = txtadrs.Text;

            
            try
            {
                
                EmpBL obj = new EmpBL();
                obj.empUpdateBL(p);
                    MessageBox.Show("Record Updated Successfully");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Exception:" + ex.Message);
            }
            
        }

        private void btnsearch_Click(object sender, EventArgs e)
        { 
            EmpProps p = new EmpProps();
            p.Emp_id = txtempID.Text;
            
            
            try
            {
                EmpBL obj = new EmpBL();
                DataTable dt = obj.empSearchBL(p);
                if (dt != null)
                {
                     txtname.Text = dt.Rows[0]["name"].ToString();
                     txtCN.Text = dt.Rows[0]["cell"].ToString();
                     txtadrs.Text = dt.Rows[0]["address"].ToString();
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

        private void delbtn_Click(object sender, EventArgs e)
        {
            EmpProps p = new EmpProps();
            p.Emp_id = txtempID.Text;
            p.Emp_name = txtname.Text;
            p.Emp_cell = txtCN.Text;
            p.Emp_address = txtadrs.Text;

            try
            {
                EmpBL obj = new EmpBL();
                obj.empDeleteBL(p);
                MessageBox.Show("Record deleted Successfully");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Exception:" + ex.Message);
            }
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form2 form2 = new Form2();

            form2.Show();
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
                    using (SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Employee", conn))
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

        private void button2_Click(object sender, EventArgs e)
        {
            txtempID.Clear();
            txtname.Clear();
            txtCN.Clear();
            txtadrs.Clear();
        }

        private void btnviewall_Click(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();

            form3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();

            form4.Show();
        }
    }
}
