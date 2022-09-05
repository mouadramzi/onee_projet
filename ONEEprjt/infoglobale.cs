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
    public partial class infoglobale : Form
    {
       
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Model1"].ConnectionString);

        public infoglobale()
        {
            InitializeComponent();
        }

        public  void rempliregrid ()
        {
            dataGridView1.DataSource = null;
            con.Open();
            string req = "select * from projet ";
            SqlCommand cmd = new SqlCommand(req,con);
             
            SqlDataReader dr = cmd.ExecuteReader();

            DataTable t = new DataTable();
            t.Load(dr);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = t;

            dataGridView1.DataSource = bSource;

            dr.Close();

            con.Close();
        }
        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                groupBox2.Enabled = false;
                groupBox1.Enabled = true;
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                groupBox1.Enabled = false;
                groupBox2.Enabled = true;

            }
        }
        
        public void remplircombo()
        {
            con.Open();
            string requete = "SELECT distinct(Finalite) from dbo.projet where finalite is not null";
            SqlCommand cmd = new SqlCommand(requete, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                finalite.Items.Add(dr.GetString(0));
                finalite.DisplayMember = "Finalite";
                finalite.ValueMember = "Finalite";
            }
            con.Close();
        }
        private void infoglobale_Load(object sender, EventArgs e)
        {
            textBox1.Hide();

            rempliregrid();
            foreach (System.Windows.Forms.Control c in this.Controls)
            {
                if (c is System.Windows.Forms.TextBox)
                {
 c.Text = "-";
                }
                 


            }
            remplircombo();





            if (radioButton1.Checked is false && radioButton2.Checked is false)
            {
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
            }
        }
        public void lignesinfo()
        {
            DateTime now1 = DateTime.Now;
            try
            {
                if (comboBox1.Text == "Etudes")
                {
                    DateTime now = DateTime.Now;
                    int year1 = datemesl.Value.Year;
                    con.Open();
                    string req1 = "insert into lignes (N_DIL , [Nature Ouvrage],Montant_Contractuel,[Caractéristiques ], " +
                        "Distance_km,Avancement,[Reference_ouvrage ],Statut_DI,Contractant,Date_prévisionnelle_mes," +
                        "date_miseenservice,dbetude , annee) values ('" +
                                           ndi.Text + " ' , '" + lnature.Text + " ' , " + double.Parse(lmontant.Text) + "   , '" +
                                          lcaracteristique.Text + " ' ,  " + double.Parse(ldistance.Text) + "   ,  " +
                                           double.Parse(lavancement.Text) + "  ,  '" + lreference.Text + "  ' , '" +
                                           comboBox1.Text + " ' , '" + contractantl.Text + "  ' , '" + datepreservl.Text + " ' , '" +
                                           datemesl.Text + " ' ,' " + now.ToString("yyyy/MM/dd") + " '," + year1 + ")"; 

                    SqlCommand cmd = new SqlCommand(req1, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("l'ajout de ligne est fait avec succee");
                    con.Close();
                    return;
                }
                if (comboBox1.Text == "Realisation")
                {
                    DateTime now = DateTime.Now;
                    int year1 = datemesl.Value.Year;
                    con.Open();
                    string req1 = "insert into lignes (N_DIL , [Nature Ouvrage],Montant_Contractuel,[Caractéristiques ], " +
                        "Distance_km,Avancement,[Reference_ouvrage ],Statut_DI,Contractant,Date_prévisionnelle_mes," +
                        "date_miseenservice,dbrealisation , annee) values ('" +
                                           ndi.Text + " ' , '" + lnature.Text + " ' , " + double.Parse(lmontant.Text) + "   , '" +
                                          lcaracteristique.Text + " ' ,  " + double.Parse(ldistance.Text) + "   ,  " +
                                           double.Parse(lavancement.Text) + "  ,  '" + lreference.Text + "  ' , '" +
                                           comboBox1.Text + " ' , '" + contractantl.Text + "  ' , '" + datepreservl.Text + " ' , '" +
                                           datemesl.Text + " ' ,' " + now.ToString("yyyy/MM/dd") + " '," + year1 + ")";

                    SqlCommand cmd = new SqlCommand(req1, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("l'ajout de ligne est fait avec succee");
                    con.Close();
                    return;
                }
                if (comboBox1.Text == "Consultation")
                {
                    DateTime now = DateTime.Now;
                    int year1 = datemesl.Value.Year;
                    con.Open();
                    string req1 = "insert into lignes (N_DIL , [Nature Ouvrage],Montant_Contractuel,[Caractéristiques ], " +
                        "Distance_km,Avancement,[Reference_ouvrage ],Statut_DI,Contractant,Date_prévisionnelle_mes," +
                        "date_miseenservice,dbconsultation , annee) values ('" +
                                           ndi.Text + " ' , '" + lnature.Text + " ' , " + double.Parse(lmontant.Text) + "   , '" +
                                          lcaracteristique.Text + " ' ,  " + double.Parse(ldistance.Text) + "   ,  " +
                                           double.Parse(lavancement.Text) + "  ,  '" + lreference.Text + "  ' , '" +
                                           comboBox1.Text + " ' , '" + contractantl.Text + "  ' , '" + datepreservl.Text + " ' , '" +
                                           datemesl.Text + " ' ,' " + now.ToString("yyyy/MM/dd") + " '," + year1 + ")";

                    SqlCommand cmd = new SqlCommand(req1, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("l'ajout de ligne est fait avec succee");
                    con.Close();
                    return;
                }
                if (comboBox1.Text == "Realiser")
                {
                    DateTime now = DateTime.Now;
                    int year1 = datemesl.Value.Year;
                    con.Open();
                    string req1 = "insert into lignes (N_DIL , [Nature Ouvrage],Montant_Contractuel,[Caractéristiques ], " +
                        "Distance_km,Avancement,[Reference_ouvrage ],Statut_DI,Contractant,Date_prévisionnelle_mes," +
                        "date_miseenservice,dbrealiser , annee) values ('" +
                                           ndi.Text + " ' , '" + lnature.Text + " ' , " + double.Parse(lmontant.Text) + "   , '" +
                                          lcaracteristique.Text + " ' ,  " + double.Parse(ldistance.Text) + "   ,  " +
                                           double.Parse(lavancement.Text) + "  ,  '" + lreference.Text + "  ' , '" +
                                           comboBox1.Text + " ' , '" + contractantl.Text + "  ' , '" + datepreservl.Text + " ' , '" +
                                           datemesl.Text + " ' ,' " + now.ToString("yyyy/MM/dd") + " '," + year1 + ")";

                    SqlCommand cmd = new SqlCommand(req1, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("l'ajout de ligne est fait avec succee");
                    con.Close();
                    return;
                }











            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
        public void postesinfo()
        {

            try
            {
                
                if (comboBox2.Text == "Etudes")
                {
                    DateTime now = DateTime.Now;
                    int year1 = datemesp.Value.Year;
                    con.Open();
 string req1 = "insert into poste (N_DI , Nature_Ouvrage,[Montant_Contractuel_(kDH)],[Tensions_Transformation ], [Puissance ],unité,[Avancement ],[Statut DI],Contractant,Date_prévisionnelle_mes,date_miseenservice,dbetude, annee) values ('" +
                        ndi.Text + " ' , '" + pnature.Text + " ' , " + double.Parse(pmontant.Text) + "  , '" +
                        ptension.Text + " ' ,  " + double.Parse(ppuissnace.Text) + "   , '" +
                        punite.Text + " ' ,  " + double.Parse(pavancement.Text) + "  , '" +
                        comboBox2.Text + " ' , '" + contractantp.Text+ "  ' , '" + dateperevisionp.Text + " ' , '" +
                        datemesp.Text + " ' , '" + now.ToString("yyyy/MM/dd") + "'," + year1+")";

                    SqlCommand cmd = new SqlCommand(req1, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("l'ajout de poste est fait avec succee");
                    con.Close();
                    return;
                }
                if (comboBox2.Text == "Consultation")
                {
                    DateTime now = DateTime.Now;
                    int year1 = datemesp.Value.Year;
                    con.Open();
                    string req1 = "insert into poste (N_DI , Nature_Ouvrage,[Montant_Contractuel_(kDH)],[Tensions_Transformation ], [Puissance ],unité,[Avancement ],[Statut DI],Contractant,Date_prévisionnelle_mes,date_miseenservice,dbconsultation, annee) values ('" +
                                           ndi.Text + " ' , '" + pnature.Text + " ' , " + double.Parse(pmontant.Text) + "  , '" +
                                           ptension.Text + " ' ,  " + double.Parse(ppuissnace.Text) + "   , '" +
                                           punite.Text + " ' ,  " + double.Parse(pavancement.Text) + "  , '" +
                                           comboBox2.Text + " ' , '" + contractantp.Text + "  ' , '" + dateperevisionp.Text + " ' , '" +
                                           datemesp.Text + " ' , '" + now.ToString("yyyy/MM/dd") + "'," + year1 + ")";

                    SqlCommand cmd = new SqlCommand(req1, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("l'ajout de poste est fait avec succee");
                    con.Close();
                    return;
                }
                if (comboBox2.Text == "Realisation")
                {
                    DateTime now = DateTime.Now;
                    int year1 = datemesp.Value.Year;
                    con.Open();
                    string req1 = "insert into poste (N_DI , Nature_Ouvrage,[Montant_Contractuel_(kDH)],[Tensions_Transformation ], [Puissance ],unité,[Avancement ],[Statut DI],Contractant,Date_prévisionnelle_mes,date_miseenservice,dbrealisation, annee) values ('" +
                                           ndi.Text + " ' , '" + pnature.Text + " ' , " + double.Parse(pmontant.Text) + "  , '" +
                                           ptension.Text + " ' ,  " + double.Parse(ppuissnace.Text) + "   , '" +
                                           punite.Text + " ' ,  " + double.Parse(pavancement.Text) + "  , '" +
                                           comboBox2.Text + " ' , '" + contractantp.Text + "  ' , '" + dateperevisionp.Text + " ' , '" +
                                           datemesp.Text + " ' , '" + now.ToString("yyyy/MM/dd") + "'," + year1 + ")";

                    SqlCommand cmd = new SqlCommand(req1, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("l'ajout de poste est fait avec succee");
                    con.Close();
                    return;
                }


                if (comboBox2.Text == "Realiser")
                {
                    DateTime now = DateTime.Now;
                    int year1 = datemesp.Value.Year;
                    con.Open();
                    string req1 = "insert into poste (N_DI , Nature_Ouvrage,[Montant_Contractuel_(kDH)],[Tensions_Transformation ], [Puissance ],unité,[Avancement ],[Statut DI],Contractant,Date_prévisionnelle_mes,date_miseenservice,dbrealiser, annee) values ('" +
                                           ndi.Text + " ' , '" + pnature.Text + " ' , " + double.Parse(pmontant.Text) + "  , '" +
                                           ptension.Text + " ' ,  " + double.Parse(ppuissnace.Text) + "   , '" +
                                           punite.Text + " ' ,  " + double.Parse(pavancement.Text) + "  , '" +
                                           comboBox2.Text + " ' , '" + contractantp.Text + "  ' , '" + dateperevisionp.Text + " ' , '" +
                                           datemesp.Text + " ' , '" + now.ToString("yyyy/MM/dd") + "'," + year1 + ")";

                    SqlCommand cmd = new SqlCommand(req1, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("l'ajout de poste est fait avec succee");
                    con.Close();
                    return;
                }

























            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
        private void button1_Click(object sender, EventArgs e)
        {
           
        }


        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns["N_DI"], ListSortDirection.Ascending);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            infoglobale if1 = new infoglobale();
            this.Hide();
            if1.Close();
            recherche sf = new recherche();
            sf.Show();

        }
        //List<projet> l = new List<projet>();
        //projet Search(string code)
        //{
        //    foreach (projet x in l)
        //        if (code == x.N_DI)
        //            return x;
        //    return null;
        //}


        private void button1_Click_1(object sender, EventArgs e)
        {
 
            try
            {
                if (!(ndi.Text == ""))
                {
                     
                        if (radioButton1.Checked) { lignesinfo(); }
                        else if (radioButton2.Checked) { postesinfo(); }
                    int year1 = datemes.Value.Year;
                    con.Open();
                    string req1 = "insert into projet (N_DI , Direction,DESIGNATION,Finalite, sous_finalite,region,Financement,FICHE,Montant_DI,Observations,date_miseenservice,taux_avancement ,annee ) values ('" +
                        ndi.Text + " ' , '" + direction.Text + " ' , '" + designation.Text + " ' , '" + finalite.Text + " ' , '" + sousfinalite.Text + " ' , '" +
                        region.Text + " ' , '" + finance.Text + " ' , '" + fiche.Text + " ' , " + double.Parse(montant.Text) + "  , '" + observation.Text + " ' , '" + datemes.Text + " ' , " + double.Parse(tauxavancement.Text) + "," +year1+")";

                    SqlCommand cmd = new SqlCommand(req1, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("l'ajout de projet est fait avec succee");
                    con.Close();
                    return;
                   

                }
                else
                    MessageBox.Show("enter le N_DI");
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void modifierlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            infoglobale f = new infoglobale();
            this.Hide();
            f.Close();
            Modfier fs = new Modfier();
            fs.Show();
        }

        private void link1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            recherche sf = new recherche();
            infoglobale if1 = new infoglobale();
            this.Hide();
            sf.Close();

            if1.Show();
        }

        private void datemes_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            infoglobale f = new infoglobale();
            this.Hide();
            f.Close();
            rapport r = new rapport();
            r.Show();
              
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void supplink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            infoglobale f = new infoglobale();
            this.Hide();
            f.Close();
            supprimer sp = new supprimer();
            sp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //int year1 = datemes.Value.Year;
            //con.Open();
            //string req1 = "insert into projet (N_DI , Direction,DESIGNATION,Finalite, sous_finalite,region,Financement,FICHE,Montant_DI,Observations,date_miseenservice,taux_avancement, annee) values ('" +
            //    ndi.Text + " ' , '" + direction.Text + " ' , '" + designation.Text + " ' , '" + finalite.Text + " ' , '" + sousfinalite.Text + " ' , '" +
            //    region.Text + " ' , '" + finance.Text + " ' , '" + fiche.Text + " ' , " + double.Parse(montant.Text) + "  , '" + observation.Text + " ' , '" + datemes.Text + " ' , " + double.Parse(tauxavancement.Text)+year1; 

            //SqlCommand cmd = new SqlCommand(req1, con);
            //cmd.ExecuteNonQuery();
            //MessageBox.Show("l'ajout est fait avec succee");
            //con.Close();











        }

        private void datemes_ValueChanged_1(object sender, EventArgs e)
        {
            datemes.CustomFormat = "yyyy/MM/dd";
        }

        private void datepreservl_ValueChanged(object sender, EventArgs e)
        {
            datepreservl.CustomFormat = "yyyy/MM/dd";
        }

        private void datemesl_ValueChanged(object sender, EventArgs e)
        {
            datemesl.CustomFormat = "yyyy/MM/dd";
        }

        private void dateperevisionp_ValueChanged(object sender, EventArgs e)
        {
            dateperevisionp.CustomFormat = "yyyy/MM/dd";
        }

        private void datemesp_ValueChanged(object sender, EventArgs e)
        {
            datemesp.CustomFormat = "yyyy/MM/dd";
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            infoglobale f = new infoglobale();
          
            this.Hide();
            f.Close();
            export f1 = new export();
            f1.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            infoglobale f = new infoglobale();

            this.Hide();
            f.Close();
            import f1 = new import();
            f1.Show();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            infoglobale f = new infoglobale();

            this.Hide();
            f.Close();
            Dashboard d = new Dashboard();
            d.Show();

        }

        private void label34_Click(object sender, EventArgs e)
        {
            if (label34.Text == "Autre")
            {
                finalite.Hide();
                textBox1.Show();
                label34.Text = "Ajouter ";
            }
            if(label34.Text=="Ajouter ")
            {
                if (textBox1.Text == "-")
                {

                }
                else if (!(textBox1.Text  == "-"))
                {
                    finalite.Items.Add(textBox1.Text);
                    finalite.Show();
                    textBox1.Hide();
                    label34.Text = "Autre";
                }
             
            }
            
        }

        private void punite_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            foreach (System.Windows.Forms.Control c in this.Controls)
            {
                if (c is System.Windows.Forms.TextBox) //Si le control est un textbox..

                    c.Text = "";

            }
            foreach (System.Windows.Forms.Control c in this.Controls)
            {
                if (c is System.Windows.Forms.ComboBox) //Si le control est un textbox..

                    c.Text = "";

            }
        }
    }
}
