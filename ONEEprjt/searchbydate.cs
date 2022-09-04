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
        string req;
        private void button5_Click(object sender, EventArgs e)
        {
         
                dataGridView1.DataSource = null;
                con.Open();
            string n = ndiprojet.Text.ToString();
            string d = designation.Text.ToString();
            string f = finance.Text.ToString();
            string finalite = comboBox1.Text.ToString();
            string reg = comboBox2.Text.ToString();
          
            if ((string.IsNullOrEmpty(annee1.Text) ) && (string.IsNullOrEmpty(annee2.Text)))
            {

                req = "select * from projet p JOIN lignes l on l.N_DIL=p.N_DI join poste pr on pr.N_DI= l.N_DIL where p.N_DI like '%" + n + "%' AND region like '%" 
                    + reg + "%' AND p.Direction like '%" + d + "%' AND p.Finalite like '%" 
                    + finalite + "%' AND p.direction like '%" + direction.Text + "%' AND p.financement like '%" + finance.Text + "%'";

            }
            else if (!(annee1.Text == " " && annee2.Text == ""))
                    {
                req = "select * from projet p JOIN lignes l on l.N_DIL=p.N_DI join poste pr on pr.N_DI= l.N_DIL where p.N_DI like '%" + n + "%' AND region like '%" + reg + "%' AND p.Direction like '%" + d + "%' AND p.Finalite like '%" + finalite + "%' AND  p.Financement like '%" + f + "%' AND   p.annee between " + Int32.Parse(annee1.Text) + " and " + Int32.Parse(annee2.Text);

            }


            SqlCommand cmd = new SqlCommand(req , con);
             
                SqlDataReader dr = cmd.ExecuteReader();

                DataTable t = new DataTable();
                t.Load(dr);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = t;

                dataGridView1.DataSource = bSource;

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

            

            remplircombo();
          
            //foreach (System.Windows.Forms.Control c in this.Controls)
            //{
            //    if (c is System.Windows.Forms.TextBox) //Si le control est un textbox..
            //        c.Text = "-";

            //}
            
 
        }

        public void vider ()
        {
            foreach (System.Windows.Forms.Control c in this.Controls)
            {
                if (c is System.Windows.Forms.TextBox) //Si le control est un textbox..

                        c.Text = "";

            }

            dataGridView1.DataSource = null;
            comboBox1.Text = "";
            comboBox2.Text="";

        }
        private void dateentree_ValueChanged(object sender, EventArgs e)
        {
          
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            
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
            //try
            //{
            //    Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            //    excel.Visible = true;
            //    Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
            //    Microsoft.Office.Interop.Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];
            //    int StartCol = 1;
            //    int StartRow = 1;
            //    int j = 0, i = 0;

            //    //Write Headers
            //    for (j = 0; j < dataGridView1.Columns.Count; j++)
            //    {
            //        Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow, StartCol + j];
            //        myRange.Value2 = dataGridView1.Columns[j].HeaderText;
            //    }

            //    StartRow++;

            //    //Write datagridview content
            //    for (i = 0; i < dataGridView1.Rows.Count; i++)
            //    {
            //        for (j = 0; j < dataGridView1.Columns.Count; j++)
            //        {
            //            try
            //            {
            //                Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow + i, StartCol + j];
            //                myRange.Value2 = dataGridView1[j, i].Value == null ? "" : dataGridView1[j, i].Value;
            //            }
            //            catch
            //            {
            //                ;
            //            }
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}









        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
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

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            searchbydate s = new searchbydate();
            this.Hide();
            s.Close();
            export r = new export();
            r.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            searchbydate s = new searchbydate();
            this.Hide();
            s.Close();
            import ss = new import();
            s.Show();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            searchbydate s = new searchbydate();
            this.Hide();
            s.Close();
            Dashboard ss = new Dashboard();
            s.Show();
        }
    }
}
