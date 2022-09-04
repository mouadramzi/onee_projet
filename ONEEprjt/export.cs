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

namespace ONEEprjt
{
    public partial class export : Form
    {
        public export()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = true;
                Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
                Microsoft.Office.Interop.Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];
                int StartCol = 1;
                int StartRow = 1;
                int j = 0, i = 0;

                //Write Headers
                for (j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow, StartCol + j];
                    myRange.Value2 = dataGridView1.Columns[j].HeaderText;
                }

                StartRow++;

                //Write datagridview content
                for (i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        try
                        {
                            Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow + i, StartCol + j];
                            myRange.Value2 = dataGridView1[j, i].Value == null ? "" : dataGridView1[j, i].Value;
                        }
                        catch
                        {
                            ;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(radioButton1.Checked == false)
                {
                    SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Model1"].ConnectionString);

                    dataGridView1.DataSource = null;
                    con.Open();
                    string req = "select * from " + comboBox1.Text.ToString();
                    SqlCommand cmd = new SqlCommand(req, con);

                    SqlDataReader dr = cmd.ExecuteReader();

                    DataTable t = new DataTable();
                    t.Load(dr);
                    BindingSource bSource = new BindingSource();
                    bSource.DataSource = t;

                    dataGridView1.DataSource = bSource;

                    dr.Close();

                    con.Close();
                }
                else if (radioButton1.Checked== true)
                {
                    SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Model1"].ConnectionString);

                    dataGridView1.DataSource = null;
                    con.Open();
                    string req = "select * from " + comboBox1.Text.ToString()+ " where 1=2";
                    SqlCommand cmd = new SqlCommand(req, con);

                    SqlDataReader dr = cmd.ExecuteReader();

                    DataTable t = new DataTable();
                    t.Load(dr);
                    BindingSource bSource = new BindingSource();
                    bSource.DataSource = t;

                    dataGridView1.DataSource = bSource;

                    dr.Close();

                    con.Close();
                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void export_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            comboBox1.ResetText();
            radioButton1.Checked = false; 

        }

        private void link1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            export x = new export();
            this.Hide();
            x.Close();
            infoglobale f = new infoglobale();
            f.Show();

        }

        private void modifierlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            export x = new export();
            this.Hide();
            x.Close();
            Modfier f = new Modfier();
            f.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            export x = new export();
            this.Hide();
            x.Close();
            recherche f = new recherche();
                f.Show();
        }

        private void supplink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            export x = new export();
            this.Hide();
            x.Close();
            supprimer f = new supprimer();
            f.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            export x = new export();
            this.Hide();
            x.Close();
            rapport f = new rapport();
            f.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            export x = new export();
            this.Hide();
            x.Close();
            import f = new import();
            f.Show();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            export x = new export();
            this.Hide();
            x.Close();
            Dashboard f = new Dashboard();
            f.Show();
        }
    }
}
