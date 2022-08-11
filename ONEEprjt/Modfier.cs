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
    public partial class Modfier : Form
    {
        public Modfier()
        {
            InitializeComponent();
        }
        ONEEEntities4 o = new ONEEEntities4();
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Model1"].ConnectionString);


        private void Modfier_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = o.lignes.ToList();
            naviguer(0);
        }
        void naviguer(int i)
        {

            lignes em = o.lignes.ToList().ElementAt(i);

            dataGridView1.ClearSelection();
            lnature.Text = em.Nature_Ouvrage.ToString();
            lmontant.Text = em.Montant_Contractuel.ToString();
            lcaracteristique.Text = em.Caractéristiques_.ToString();
            ldistance.Text = em.Distance_km.ToString();
            lavancement.Text = em.Avancement.ToString();
            lreference.Text = em.Reference_ouvrage_.ToString();
            comboBox1.Text = em.Statut_DI.ToString();
            contractantl.Text = em.Contractant.ToString();
            datepreservel.Text = em.Date_prévisionnelle_mes.ToString();
            daterefl.Text = em.Date_référence.ToString();

            dataGridView1.Rows[i].Selected = true;

        }
        void naviguerp(int i)
        {

            poste em = o.poste.ToList().ElementAt(i);

            dataGridView1.ClearSelection();
           pnature.Text = em.Nature_Ouvrage.ToString();
            pmontant.Text = em.Montant_Contractuel__kDH_.ToString();
            punite.Text = em.unité.ToString();
            comboBox2.Text = em.Statut_DI.ToString();
            pavancement.Text = em.Avancement_.ToString();
            ppuissnace.Text = em.Puissance_.ToString();
            ptension.Text = em.Tensions_Transformation_.ToString();
            pdateprevision.Text = em.Date_prévisionnelle_mes.ToString();
            pdateref.Text = em.Date_référence.ToString();
            
            dataGridView1.Rows[i].Selected = true;

        }
        int pos; 
        private void recherchel_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                searchl();
            }
            else if (radioButton2.Checked==true)
            {
                searchp();
            }
        }
         
       public void searchl()
        {
            bool tr = false;
            foreach (lignes ad in o.lignes.ToList())

                if (ad.N_DIL == ndi.Text)
                {
                    dataGridView1.Rows[pos].Selected = false;
                    pos = o.lignes.ToList().IndexOf(ad);
                    naviguer(pos);
                    tr = true;
                    break;

                }

            if (tr == false)
            {
                MessageBox.Show("n'existe pas");
                dataGridView1.ClearSelection();

            }

        }
        public void searchp()
        {
            bool tr = false;
            foreach (poste ad1 in o.poste.ToList())

                if (ad1.N_DI == ndi.Text)
                {
                    dataGridView1.Rows[pos].Selected = false;
                    pos = o.poste.ToList().IndexOf(ad1);
                    naviguerp(pos);
                    tr = true;
                    break;

                }

            if (tr == false)
            {
                MessageBox.Show("n'existe pas");
                dataGridView1.ClearSelection();

            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Consultation")
            {
                con.Open();
                string req1 = "update lignes set Statut_DI ='" + comboBox1.Text + "'" + " , dfetudes =  GETDATE() ,  dbconsultation =  GETDATE() where N_DIL ='" + ndi.Text + "'";
                SqlCommand cmd = new SqlCommand(req1, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("la modification est fait avec succee");
                con.Close();
            }

            else if (comboBox1.Text == "Realisation")
            {
                con.Open();
                string req1 = "update lignes set Statut_DI ='" + comboBox1.Text + "'" + ", dfconsultation =  GETDATE() ,  dbrealisation =  GETDATE() where N_DIL ='" + ndi.Text + "'";
                SqlCommand cmd = new SqlCommand(req1, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("la modification est fait avec succee");
                con.Close();
            }
            else if (comboBox1.Text == "Realiser")
            {
                con.Open();
                string req1 = "update lignes set Statut_DI ='" + comboBox1.Text + "'" + " , dfrealisation =  GETDATE() ,  dbrealiser =  GETDATE() where N_DIL ='" + ndi.Text + "'";
                SqlCommand cmd = new SqlCommand(req1, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("la modification est fait avec succee");
                con.Close();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Consultation")
            {
                con.Open();
                string req1 = "update poste et Statut_DI ='" + comboBox2.Text + "'" + " , dfetudes =  GETDATE() ,  dbconsultation =  GETDATE() where n_di ='" + ndi.Text + "'";
                SqlCommand cmd = new SqlCommand(req1, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("la modification est fait avec succee");
                con.Close();
            }

            else if (comboBox2.Text == "Realisation")
            {
                con.Open();
                string req1 = "update poste set Statut_DI ='" + comboBox2.Text + "'" + ", dfconsultation =  GETDATE() ,  dbrealisation =  GETDATE() where n_di ='" + ndi.Text + "'";
                SqlCommand cmd = new SqlCommand(req1, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("la modification est fait avec succee");
                con.Close();
            }
            else if (comboBox2.Text == "Realiser")
            {
                con.Open();
                string req1 = "update poste set Statut_DI ='" + comboBox2.Text + "'" + " , dfrealisation =  GETDATE() ,  dbrealiser =  GETDATE() where n_di ='" + ndi.Text + "'";
                SqlCommand cmd = new SqlCommand(req1, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("la modification est fait avec succee");
                con.Close();
            }


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                groupBox1.Enabled = true;
                groupBox2.Enabled = false;

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                groupBox2.Enabled = true;
                groupBox1.Enabled = false;
            }

        }

        private void modifierlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Modfier f = new Modfier();
            this.Hide();
            f.Close();
            Modfier fs = new Modfier();
            fs.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Modfier if1 = new Modfier();
            this.Hide();
            if1.Close();
            recherche sf = new recherche();
            sf.Show();
        }

        private void link1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Modfier sf = new Modfier();
            infoglobale if1 = new infoglobale();
           this.Hide();
            sf.Close();

            if1.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Modfier sf = new Modfier();
            this.Hide();
            sf.Close();
            rapport r = new rapport();
            r.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Modfier sf = new Modfier();
            this.Hide();
            sf.Close();
            supprimer sp = new supprimer();
            sp.Show();
        }
    }
}
