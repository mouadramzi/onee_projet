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
using System.Data.OleDb;
using System.IO;

namespace ONEEprjt
{
    public partial class import : Form
    {
        public import()
        {
            InitializeComponent();
        }
       // SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Model1"].ConnectionString);
        private void button1_Click(object sender, EventArgs e)
        {
        SqlConnection con1 = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Model1"].ConnectionString);



            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                SqlCommand cmd = new SqlCommand("insert into poste (N_DI , Nature_Ouvrage,[Montant_Contractuel_(kDH)],[Tensions_Transformation ], [Puissance ],unité,[Avancement ],[Statut DI],Contractant,Date_prévisionnelle_mes,date_miseenservice,dbetude, annee) values ( @N_DI , @Nature_Ouvrage,@Montant_Contractuel__kDH_,@Tensions_Transformation_, @Puissance_,@unité,@Avancement_,@Statut_DI,@Contractant,@Date_prévisionnelle_mes,@date_miseenservice,@dbetude, @annee)", con1);
                cmd.Parameters.AddWithValue("N_DI", row.Cells["N_DI"].Value.ToString());
                cmd.Parameters.AddWithValue("Nature_Ouvrage", row.Cells["Nature_Ouvrage"].Value.ToString());
                cmd.Parameters.AddWithValue("Montant_Contractuel__kDH_", row.Cells["Montant_Contractuel__kDH_"].Value.ToString());
                cmd.Parameters.AddWithValue("Tensions_Transformation_", row.Cells["Tensions_Transformation_"].Value.ToString());
                cmd.Parameters.AddWithValue("Puissance_", row.Cells["Puissance_"].Value.ToString());
                cmd.Parameters.AddWithValue("unité", row.Cells["unité"].Value.ToString());
                cmd.Parameters.AddWithValue("Avancement_", row.Cells["Avancement_"].Value.ToString());
                cmd.Parameters.AddWithValue("Statut_DI", row.Cells["Statut_DI"].Value.ToString());
                cmd.Parameters.AddWithValue("Contractant", row.Cells["Contractant"].Value.ToString());
                cmd.Parameters.AddWithValue("Date_prévisionnelle_mes", row.Cells["Date_prévisionnelle_mes"].Value.ToString());
                cmd.Parameters.AddWithValue("Date_miseenservice", row.Cells["Date_miseenservice"].Value.ToString());
                cmd.Parameters.AddWithValue("dbetude", row.Cells["dbetude"].Value.ToString());
                cmd.Parameters.AddWithValue("annee", row.Cells["annee"].Value.ToString());
                con1.Open();
                cmd.ExecuteNonQuery();
                con1.Close();

                            }
            MessageBox.Show("bon insertion");

        }

        private void import_Load(object sender, EventArgs e)
        {
          








        }

        private void button4_Click(object sender, EventArgs e)

        {


            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                string filefeuil = posttxt.Text;
                if (string.IsNullOrEmpty(filefeuil))
                {
                    filefeuil = "Feuil1";

                }

                else filefeuil = posttxt.Text;

                OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; " + @"Data source = " + file + "; Extended Properties='Excel 12.0 Xml;HDR=False' ");
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("select * from [" + filefeuil + "$] ", conn);
                OleDbDataAdapter da = new OleDbDataAdapter();

                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                dt.Clear();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }



        }

        private void button5_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                string filefeuil = lignetxt.Text;
                if (string.IsNullOrEmpty(filefeuil))
                {
                    filefeuil = "Feuil1";

                }

                else filefeuil = lignetxt.Text;

                OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; " + @"Data source = " + file + "; Extended Properties='Excel 12.0 Xml;HDR=False' ");
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("select * from [" + filefeuil + "$] ", conn);
                OleDbDataAdapter da = new OleDbDataAdapter();

                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                dt.Clear();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
                conn.Close();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                string filefeuil = prjttxt.Text;
                if (string.IsNullOrEmpty(filefeuil))
                {
                    filefeuil = "Feuil1";

                }

                else filefeuil = prjttxt.Text;

                OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; " + @"Data source = " + file + "; Extended Properties='Excel 12.0 Xml;HDR=False' ");
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("select * from [" + filefeuil + "$] ", conn);
                OleDbDataAdapter da = new OleDbDataAdapter();

                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                dt.Clear();
                da.Fill(dt);
                dataGridView3.DataSource = dt;
                conn.Close();
            }
        }

        private void link1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            import f = new import();
            this.Hide();
            f.Close();
            infoglobale fr = new infoglobale();
            fr.Show();

        }

        private void modifierlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            import f = new import();
            this.Hide();
            f.Close();
            Modfier g = new Modfier();
            g.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            import f = new import();
            this.Hide();
            f.Close();
            recherche g = new recherche();
            g.Show();
        }

        private void supplink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            import f = new import();
            this.Hide();
            f.Close();
            supprimer g = new supprimer();
            g.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            import f = new import();
            this.Hide();
            f.Close();
            rapport g = new rapport();
            g.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            import f = new import();
            this.Hide();
            f.Close();
            export g = new export();
            g.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            import f = new import();
            this.Hide();
            f.Close();
            Dashboard g = new Dashboard();
            g.Show();
        }
    }
}
