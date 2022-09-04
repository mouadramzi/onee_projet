using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace ONEEprjt
{
    public partial class recherche : Form
    {
        ONEEEntities4 o = new ONEEEntities4();
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Model1"].ConnectionString); 

        public recherche()
        {
            InitializeComponent();
        }

        private void link1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            recherche sf = new recherche();
            infoglobale if1 = new infoglobale();
            sf.Hide();
            sf.Close();
            
            if1.Show();
        }

        private void link1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            recherche sf = new recherche();
           
            this.Hide();
            sf.Close();
            infoglobale if1 = new infoglobale();
      
           if1.Show();

        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        void naviguer(int i=0)
        {

             lignes em = o.lignes.ToList().ElementAt(i);

            dataGridView1.ClearSelection();
            


            dataGridView1.Rows[i].Selected = true;
            dataGridView2.ClearSelection();



            dataGridView2.Rows[i].Selected = true;

        }

        private void recherchel_Click(object sender, EventArgs e)
        {

            con.Open();
            string req = "select * from lignes where N_DIL like '%" +ndi.Text +"%' And Montant_Contractuel like '%" 
                + pmontant.Text+ "%' And Caractéristiques like '%"
                +lcaracteristique.Text+ "%' And Distance_km  like '%"
                +ldistance.Text+ "%' And Avancement like '%"
                +lavancement.Text+"%' And  Reference_ouvrage like '%" 
                +lreference.Text+"%' And statut_di like '%"
                + lstatut.Text +"%'" ;
                 SqlCommand cmd = new SqlCommand();
             
            cmd.Connection = con;
            cmd.CommandText = req;
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable t = new DataTable();
            t.Load(dr);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = t;
           
            dr.Close();
 
            con.Close();
        }

        private void recherche_Load(object sender, EventArgs e)
        {
          

            dataGridView2.DataSource = o.poste.ToList();
             dataGridView1.DataSource = o.lignes.ToList();
             
            naviguer(0);
        
            recherche fm = new recherche();
            foreach (Control c in this.Controls)
            {
                if (c is System.Windows.Forms.TextBox) //Si le control est un textbox..
                    c.Text = "-";

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = null;
            dataGridView1.DataSource = o.lignes.ToList();
            naviguer(0);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
          

            string req1= "select * from poste where N_DI like '%" + ndip.Text + "%' And Nature_Ouvrage like '%"
               + pnature.Text + "%' And [Montant_Contractuel_(kDH)]  like '%"
               + pmontant.Text + "%' And Tensions_Transformation  like '%"
               + ptension.Text + "%' And Puissance like '%"
               + ppuissnace.Text + "%' And  unité like '%"
               + punite.Text + "%' And Avancement like '%"
               + pavancement.Text + "%'";







            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = req1;
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable t = new DataTable();
            t.Load(dr);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = t;

            dr.Close();

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.dataGridView2.DataSource = null;
            dataGridView1.DataSource = o.poste.ToList();
            naviguer(0);
        }


        private void modifierlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            recherche sf = new recherche();

            this.Hide();
            sf.Close();
            Modfier if1 = new Modfier();

            if1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
         
        }

        private void finance_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            recherche r = new recherche();
            this.Hide();

            r.Close();
            supprimer sp = new supprimer();
            sp.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            recherche r = new recherche();
            this.Hide();

            r.Close();
            rapport r1 = new rapport();
            r1.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            recherche r = new recherche();
            this.Hide();

            r.Close();
            Modfier sf = new Modfier();
            sf.Show();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
          



                        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
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
                for (j = 0; j < dataGridView2.Columns.Count; j++)
                {
                    Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow, StartCol + j];
                    myRange.Value2 = dataGridView2.Columns[j].HeaderText;
                }

                StartRow++;

                //Write datagridview content
                for (i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    for (j = 0; j < dataGridView2.Columns.Count; j++)
                    {
                        try
                        {
                            Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow + i, StartCol + j];
                            myRange.Value2 = dataGridView2[j, i].Value == null ? "" : dataGridView2[j, i].Value;
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

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            recherche r = new recherche();
            this.Hide();
            r.Close();
            export sf = new export();
            sf.Show();

        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            recherche r = new recherche();
            this.Hide();
            r.Close();
            import sf = new import();
            sf.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            recherche r = new recherche();
            this.Hide();
            r.Close();
            Dashboard sf = new Dashboard();
            sf.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            recherche r = new recherche();
            this.Hide();
            r.Close();
            searchbydate sf = new searchbydate();
            sf.Show();
        }
    }
}
