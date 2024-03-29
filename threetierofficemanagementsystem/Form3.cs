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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmpProps p = new EmpProps();
            p.C_id = txtcid.Text;
            p.C_fname = txtcfname.Text;
            p.C_lname = txtclname.Text;
            p.C_since = txtcsince.Text;

            EmpBL obj = new EmpBL();
            if (obj.CInsertBL(p))
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
            p.C_id = txtcid.Text;
            p.C_fname = txtcfname.Text;
            p.C_lname = txtclname.Text;
            p.C_since = txtcsince.Text;

            try
            {
                EmpBL obj = new EmpBL();
                obj.CDeleteBL(p);
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
            p.C_id = txtcid.Text;
            p.C_fname = txtcfname.Text;
            p.C_lname = txtclname.Text;
            p.C_since = txtcsince.Text;


            try
            {

                EmpBL obj = new EmpBL();
                obj.CUpdateBL(p);
                MessageBox.Show("Record Updated Successfully");
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
                    using (SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Customer", conn))
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

        private void btnsearch_Click(object sender, EventArgs e)
        {
            EmpProps p = new EmpProps();
            p.C_id = txtcid.Text;


            try
            {
                EmpBL obj = new EmpBL();
                DataTable dt = obj.CSearchBL(p);
                if (dt != null)
                {
                    txtcfname.Text = dt.Rows[0]["c_fname"].ToString();
                    txtclname.Text = dt.Rows[0]["c_lname"].ToString();
                    txtcsince.Text = dt.Rows[0]["c_since"].ToString();
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

        private void btnviewall_Click(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtcid.Clear();
            txtcfname.Clear();
            txtclname.Clear();
            txtcsince.Clear();
        }
    }
}
