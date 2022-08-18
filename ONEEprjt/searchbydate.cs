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
using Excel = Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;

namespace ONEEprjt
{
    public partial class searchbydate : Form
    {
        public searchbydate()
        {
            InitializeComponent();
        }
        ONEEEntities4 o = new ONEEEntities4();
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Model1"].ConnectionString);

        private void button5_Click(object sender, EventArgs e)
        {
         
                dataGridView3.DataSource = null;
                con.Open();
                
                string req = "select * from projet p  join poste l on p.N_DI = l.N_DI where p.N_DI = '" +  ndiprojet.Text+"' or '" + dateentree.Text +"'" +"between l.dbetude and GETDATE() or finalite = '"+comboBox1.Text +"' or region like '"+comboBox2.Text+ "' or Date_prévisionnelle_mes like'" + dateTimePicker2.Text.ToString()+"'";


                SqlCommand cmd = new SqlCommand(req , con);
             
                SqlDataReader dr = cmd.ExecuteReader();

                DataTable t = new DataTable();
                t.Load(dr);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = t;

                dataGridView3.DataSource = bSource;

                dr.Close();

                con.Close();
           
            
        }
        public void remplircombo ()
        {
            con.Open();
            string requete = "SELECT distinct(Finalite) from dbo.projet where finalite is not null";
            SqlCommand cmd = new SqlCommand(requete, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr.GetString(0));
                comboBox1.DisplayMember = "Finalite";
                comboBox1.ValueMember = "Finalite";
            }
            con.Close();
        }

        private void searchbydate_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "-";
            comboBox2.Text = "-";

            remplircombo();
             
         
            
            foreach (System.Windows.Forms.Control c in this.Controls)
            {
                if (c is System.Windows.Forms.TextBox) //Si le control est un textbox..
                    c.Text = "-";

            }
            comboBox1.Text = "";
             
            dateTimePicker2.CustomFormat = "1900-01-01";
dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateentree.CustomFormat = "1900-01-01";
            dateentree.Format = DateTimePickerFormat.Custom;
        }

        public void vider ()
        {
            foreach (System.Windows.Forms.Control c in this.Controls)
            {
                if (c is System.Windows.Forms.TextBox) //Si le control est un textbox..
                    c.Text = "-";

            }
            dateTimePicker2_ValueChanged(dateTimePicker2, null);
            dateentree_ValueChanged(dateentree, null);
            dateTimePicker2.CustomFormat = "1900-01-01";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateentree.CustomFormat = "1900-01-01";
            dateentree.Format = DateTimePickerFormat.Custom;
            dataGridView3.DataSource = null;

        }
        private void dateentree_ValueChanged(object sender, EventArgs e)
        {
            dateentree.CustomFormat = "dd/MM/yyyy hh:mm:ss";
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.CustomFormat = "dd/MM/yyyy hh:mm:ss";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            vider();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
             

        }
      
        private void button2_Click(object sender, EventArgs e)
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
                for (j = 0; j < dataGridView3.Columns.Count; j++)
                {
                    Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow, StartCol + j];
                    myRange.Value2 = dataGridView3.Columns[j].HeaderText;
                }

                StartRow++;

                //Write datagridview content
                for (i = 0; i < dataGridView3.Rows.Count; i++)
                {
                    for (j = 0; j < dataGridView3.Columns.Count; j++)
                    {
                        try
                        {
                            Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow + i, StartCol + j];
                            myRange.Value2 = dataGridView3[j, i].Value == null ? "" : dataGridView3[j, i].Value;
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

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView3.DataSource = null;
            con.Open();

            string req = "select * from projet p join lignes l on p.N_DI=l.N_DIL join poste pp on pp.N_DI=l.N_DIL";


            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = req;
            SqlDataReader dr = cmd.ExecuteReader();

            DataTable t = new DataTable();
            t.Load(dr);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = t;

            dataGridView1.DataSource = bSource;

            dr.Close();

            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
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

        private void link1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            searchbydate s = new searchbydate();
            this.Hide();
            s.Close();
            infoglobale b = new infoglobale();
            b.Show();
        }

        private void modifierlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            searchbydate s = new searchbydate();
            this.Hide();
            s.Close();
            Modfier m = new Modfier();
            m.Show();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            searchbydate s = new searchbydate();
            this.Hide();
            s.Close();
            recherche r = new recherche();
            r.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void supplink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            searchbydate s = new searchbydate();
            this.Hide();
            s.Close();
            supprimer ss = new supprimer();
            s.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            searchbydate s = new searchbydate();
            this.Hide();
            s.Close();
            rapport r = new rapport();
            r.Show();
        }
    }
}
