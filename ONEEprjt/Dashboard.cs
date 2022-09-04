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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Model1"].ConnectionString);
        int z;
        string y, x; 

        private void Dashboard_Load(object sender, EventArgs e)
        {
             

            postess();
            lignes();
            z = int.Parse(x) + int.Parse(y);
            prjt();
        }
        public void prjt()
        {
            //con.Open();
            //string query1 = "select count(*) from projet  ";
            //SqlCommand cmd = new SqlCommand(query1, con);

            //SqlDataReader dr = cmd.ExecuteReader();
            //while (dr.Read())
            //{
            //    string v = dr.GetValue(0).ToString();
            countprjt.Text = "le total est " + z.ToString() + " projets";
            prjtprogress.Maximum = 1000; 
                prjtprogress.Value = z;
            if (z < 10)
            {
                sommep.ForeColor = Color.Red;
            }
            else sommep.ForeColor = Color.Blue;


            //}
            //con.Close();
        }
        public void lignes()
        {
            con.Open();
            string query1 = "select count(l.N_DIL) from LIGNES l join projet p  on p.N_DI=l.N_DIL   ";
            SqlCommand cmd = new SqlCommand(query1, con);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                 y = dr.GetValue(0).ToString();
                countlignes.Text = "le total est "+ y+ " lignes";
                lignesprog.Value = int.Parse(y);
                sommep.ForeColor = Color.Blue;

            }
            con.Close();
        }


        public void postess()
        {
            con.Open();
            string query1 = "select count(l.N_DI) from poste l join projet p  on p.N_DI=l.N_DI   ";
            SqlCommand cmd = new SqlCommand(query1, con);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                x= dr.GetValue(0).ToString();
                countpostes.Text = "le total est " + x + " postes";
                postesprgrs.Value = int.Parse(x);
                 postesprgrs.ForeColor = Color.Blue;


            }
            con.Close();
        }
        string query1;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null; 

            con.Open();
            if (textBox1.Text.Length == 4  )
            {
                
                    query1 = "select count(*)   ,(cast (sum (Montant_DI) as decimal (10,2))) from projet l where l.annee=" + int.Parse(textBox1.Text);

               
               

            }
            else
            {
                  query1 = "select count(*),  (cast (sum (Montant_DI) as decimal (10,2))) from projet l where l.annee=0";
            }
            SqlCommand cmd = new SqlCommand(query1, con);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string  a ="0"; 
                string v = dr.GetValue(0).ToString();
                 a =dr.GetValue(1).ToString(); 
                somme.Text = ""+v.ToString()+" projtes avec montant  " +a.ToString() + " kDH";
                sommep.Value = int.Parse(v);
                 sommep.ForeColor = Color.BlueViolet ;


            }
            con.Close();
         //textBox1.Text = null;
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true )
            {
                comboBox1.Enabled = true;
                radioButton2.Checked = false; 
                con.Open();
                string query1 = " select count(*) from projet p join lignes l on  p.N_DI = l.N_DIl where l.Statut_DI = '" + comboBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(query1, con);

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string v = dr.GetValue(0).ToString();
                    etatl.Text = "le total est " + v + " Projet";
                    progetatl.Value = int.Parse(v);
                    if (int.Parse(v) < 10)
                    {
                        progetatl.ForeColor = Color.Red;
                    }
                    else progetatl.ForeColor = Color.Blue;

                }
                con.Close();
            }
         else    if (radioButton2.Checked == true)
            {
                comboBox1.Enabled = true;
                radioButton1.Checked = false;
                con.Open();
                string query1 = "select count(*)  from projet p join poste l on  p.N_DI = l.N_DI where l.[Statut DI] ='" + comboBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(query1, con);

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string v = dr.GetValue(0).ToString();
                    etatl.Text = "le total est " + v + " Projet";
                    progetatl.Value = int.Parse(v);

                }
                con.Close();
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                comboBox1.Enabled = true;
                radioButton2.Checked = false; 
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                comboBox1.Enabled = true;
                radioButton1.Checked = false;

            }
        }

        private void link1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dashboard d = new Dashboard();
            this.Hide();
            d.Close();
            infoglobale f = new infoglobale();
            f.Show();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            string query1 = " SELECT count(*) from projet p where p.Finalite = '"+ finalite.Text+"' ";
            SqlCommand cmd = new SqlCommand(query1, con);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string v = dr.GetValue(0).ToString();
                label10.Text = "le total est " + v + " Projet";
                progressBar1.Value = int.Parse(v);
                if (int.Parse(v) < 10)
                {
                    progressBar1.ForeColor = Color.Red;
                }
                else progressBar1.ForeColor = Color.Blue;


            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            if (textBox1.Text.Length == 4)
            {

                query1 = "select * from projet l where l.annee=" + int.Parse(textBox1.Text);




            }
            else
            {
                query1 = "select *  from projet l where l.annee=0";
            }
            SqlCommand cmd = new SqlCommand(query1, con);

            SqlDataReader dr = cmd.ExecuteReader();
            DataTable t = new DataTable();
            t.Load(dr);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = t;

            dataGridView1.DataSource = bSource;

            dr.Close();

            con.Close();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)

        {
            dataGridView1.DataSource = null;
           
                
                con.Open();
            string query1 = " select * from projet p where p.Finalite like '%" + finalite.Text + "%'";
                SqlCommand cmd = new SqlCommand(query1, con);

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

        private void modifierlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dashboard d = new Dashboard();
            this.Hide();
            d.Close();
            Modfier f = new Modfier();
            f.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dashboard d = new Dashboard();
            this.Hide();
            d.Close();
            recherche f = new recherche();
            f.Show();
        }

        private void supplink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dashboard d = new Dashboard();
            this.Hide();
            d.Close();
            supprimer f = new supprimer();
            f.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dashboard d = new Dashboard();
            this.Hide();
            d.Close();
            rapport f = new rapport();
            f.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dashboard d = new Dashboard();
            this.Hide();
            d.Close();
            export f = new export();
            f.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dashboard d = new Dashboard();
            this.Hide();
            d.Close();
            import f = new import();
            f.Show();
        }

        private void prjtprogress_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            if (radioButton1.Checked == true)
            {
                comboBox1.Enabled = true;
                radioButton2.Checked = false;
                con.Open();
                string query1 = " select * from projet p join lignes l on  p.N_DI = l.N_DIl where l.Statut_DI = '" + comboBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(query1, con);

                SqlDataReader dr = cmd.ExecuteReader();
                DataTable t = new DataTable();
                t.Load(dr);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = t;

                dataGridView1.DataSource = bSource;

                dr.Close();
                con.Close();
            }
            else if (radioButton2.Checked == true)
            {
                comboBox1.Enabled = true;
                radioButton1.Checked = false;
                con.Open();
                string query1 = "select *  from projet p join poste l on  p.N_DI = l.N_DI where l.[Statut DI] ='" + comboBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(query1, con);

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
    }
}
