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
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Model1"].ConnectionString);


        private void Modfier_Load(object sender, EventArgs e)
        {
             
        }

       
        private void recherchel_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                searchl();
            //    try
            //    { 
            //        cmd = new SqlCommand("select * from lignes where n_dil=108", con);
            //        con.Open();
            //        rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            //        rdr.Read();
            //        lnature.Text = rdr[1].ToString();
            //        lmontant.Text = rdr[2].ToString();
            //    }
            //    catch (Exception ex)
            //    {
                     
            //    }
            //    finally
            //    {
            //        rdr.Close();
            //        con.Close();
            //    }








            }
            else if (radioButton2.Checked==true)
            {
                searchp();
            }
        }
         
       public void searchl()
        {
            con.Open();
            string req = " select * from lignes where n_dil ='" + ndi.Text + "'";
            SqlCommand cmd = new SqlCommand(req, con);
             
             

                SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();

               lnature.Text = dr[1].ToString();

            lmontant.Text = dr[2].ToString();
            lcaracteristique.Text = dr[3].ToString();
            ldistance.Text = dr[4].ToString();
            lavancement.Text = dr[5].ToString();
            lreference.Text = dr[6].ToString();
            comboBox1.Text = dr[7].ToString();
            contractantl.Text = dr[8].ToString();
            datepreservel.Text = dr[9].ToString();
            daterefl.Text = dr[10].ToString();

            con.Close();



        }
       
        public void searchp()
        {
            con.Open();
            string req = "select * from poste where n_di ='" + ndi.Text + "'";
            SqlCommand cmd = new SqlCommand(req, con);



            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();

            pnature.Text = dr[1].ToString();

            pmontant.Text = dr[2].ToString();
            ptension.Text = dr[3].ToString();
            ppuissnace.Text = dr[4].ToString();
            punite.Text = dr[5].ToString();
            pavancement.Text = dr[6].ToString();
            comboBox2.Text = dr[7].ToString();
            pcontractant.Text = dr[8].ToString();
            pdateprevision.Text = dr[9].ToString();
            pdateref.Text = dr[10].ToString();

            con.Close();




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
                string req1 = "update poste   set  [Statut DI]  ='" + comboBox2.Text + "'" + " , dfetudes =  GETDATE() ,  dbconsultation =  GETDATE() where n_di ='" + ndi.Text + "'";
                SqlCommand cmd = new SqlCommand(req1, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("la modification est fait avec succee");
                con.Close();
            }

            if (comboBox2.Text == "Etudes")
            {
                con.Open();
                string req1 = "update poste set [Statut DI]  ='" + comboBox2.Text + "'" + " , dbetudes =  GETDATE()  where n_di ='" + ndi.Text + "'";
                SqlCommand cmd = new SqlCommand(req1, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("la modification est fait avec succee");
                con.Close();
            }


              if (comboBox2.Text == "Realisation")
            {
                con.Open();
                string req1 = "update poste set [Statut DI]  ='" + comboBox2.Text + "'" + ", dfconsultation =  GETDATE() ,  dbrealisation =  GETDATE() where n_di ='" + ndi.Text + "'";
                SqlCommand cmd = new SqlCommand(req1, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("la modification est fait avec succee");
                con.Close();
            }
              if (comboBox2.Text == "Realiser")
            {
                con.Open();
                string req1 = "update poste set [Statut DI]  ='" + comboBox2.Text + "'" + " , dfrealisation =  GETDATE() ,  dbrealiser =  GETDATE() where n_di ='" + ndi.Text + "'";
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

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Modfier sf = new Modfier();
            this.Hide();
            sf.Close();
            export sp = new export();
            sp.Show();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Modfier sf = new Modfier();
            this.Hide();
            sf.Close();
            import sp = new import();
            sp.Show();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Modfier sf = new Modfier();
            this.Hide();
            sf.Close();
            Dashboard v = new Dashboard();
            v.Show();
        }
    }
}
