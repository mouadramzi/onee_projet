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
    public partial class supprimer : Form
    {
        public supprimer()
        {
            InitializeComponent();
        } 
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Model1"].ConnectionString);

        private void recherchel_Click(object sender, EventArgs e)
        {
            con.Open();
            string req = "select * from projet where N_DI ='" + ndi.Text  + "'";
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

        private void suppbtn_Click(object sender, EventArgs e)
        {
             
            if (MessageBox.Show("Sure?", "Title", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                con.Open();
                string req1 = "delete from projet where N_DI ='" + ndi.Text + "'";
                SqlCommand cm1 = new SqlCommand(req1, con);
                cm1.ExecuteNonQuery();
                con.Close();
                con.Open();
                string req = "select * from projet where N_DI ='" + ndi.Text + "'";
                SqlCommand cmd = new SqlCommand(req, con);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable t = new DataTable();
                t.Load(dr);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = t;

                dr.Close();

                con.Close();
            }
            else return;
        }

        private void modifierlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            supprimer sp = new supprimer();
            this.Hide();
            sp.Close();
            Modfier sf = new Modfier();
            sf.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            supprimer sp = new supprimer();
            this.Hide();
            sp.Close();
            recherche r = new recherche();
            r.Show();
        }

        private void supplink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void link1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            supprimer sp = new supprimer();
            this.Hide();
            sp.Close();
            infoglobale f = new infoglobale();
            f.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            supprimer sp = new supprimer();
            this.Hide();
            sp.Close();
            rapport r = new rapport();
            r.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            supprimer sp = new supprimer();
            this.Hide();
            sp.Close();
            export r = new export();
            r.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            supprimer sp = new supprimer();
            this.Hide();
            sp.Close();
            import r = new import();
            r.Show();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            supprimer sp = new supprimer();
            this.Hide();
            sp.Close();
            Dashboard r = new Dashboard();
            r.Show();
        }
    }
}
