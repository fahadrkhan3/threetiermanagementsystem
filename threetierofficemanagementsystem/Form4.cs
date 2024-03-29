using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using BusinessLayer;
using Props;

namespace threetierofficemanagementsystem
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void txtsid_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            EmpProps p = new EmpProps();
            p.S_id = txtsid.Text;
            p.S_fname = txtsfname.Text;
            p.S_lname = txtslname.Text;
            p.S_since = txtssince.Text;

            EmpBL obj = new EmpBL();
            if (obj.SInsertBL(p))
            {
                MessageBox.Show("Data Inserted");
            }
            else
            {
                MessageBox.Show("Not Inserted");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            EmpProps p = new EmpProps();
            p.C_id = txtsid.Text;
            p.C_fname = txtsfname.Text;
            p.C_lname = txtslname.Text;
            p.C_since = txtssince.Text;

            try
            {
                EmpBL obj = new EmpBL();
                obj.SDeleteBL(p);
                MessageBox.Show("Record deleted Successfully");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Exception:" + ex.Message);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            EmpProps p = new EmpProps();
            p.C_id = txtsid.Text;
            p.C_fname = txtsfname.Text;
            p.C_lname = txtslname.Text;
            p.C_since = txtssince.Text;


            try
            {

                EmpBL obj = new EmpBL();
                obj.SUpdateBL(p);
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
            p.S_id = txtsid.Text;


            try
            {
                EmpBL obj = new EmpBL();
                DataTable dt = obj.SSearchBL(p);
                if (dt != null)
                {
                    txtsfname.Text = dt.Rows[0]["S_fname"].ToString();
                    txtslname.Text = dt.Rows[0]["S_lname"].ToString();
                    txtssince.Text = dt.Rows[0]["S_since"].ToString();
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
        private void LoadDataIntoDataGridView()
        {
            try
            {
                // Use a using statement for SqlConnection to ensure proper disposal
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-7E4FKNS\SQLEXPRESS;Initial Catalog=threetier;Integrated Security=True;"))
                {
                    conn.Open();

                    // Use a using statement for SqlDataAdapter to ensure proper disposal
                    using (SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Supplier", conn))
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

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtsid.Clear();
            txtsfname.Clear();
            txtslname.Clear();
            txtssince.Clear();
        }
    }
}
