using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ONEEprjt
{
    public partial class infoglobale : Form
    {
        ONEEEntities4 o = new ONEEEntities4();

        public infoglobale()
        {
            InitializeComponent();
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
        public void remplir()
        {
          //  dataGridView1.DataSource = o.projet.ToList();
        }

        private void infoglobale_Load(object sender, EventArgs e)
        {
            
           dataGridView1.DataSource = o.projet.ToList();
      
         
            DateTime now = DateTime.Now;
            

             
            

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
                if (comboBox1.Text == "Etudes ")
                {
                    lignes li = new lignes
                    {

                        N_DIL = ndi.Text,
                        Nature_Ouvrage = lnature.Text,
                        Montant_Contractuel = double.Parse(lmontant.Text),
                        Caractéristiques_ = lcaracteristique.Text,
                        Distance_km = double.Parse(ldistance.Text),
                        Avancement = double.Parse(lavancement.Text),
                        Reference_ouvrage_ = lreference.Text
                        ,
                        dbetude = now1
                        ,
                        Statut_DI = comboBox1.Text
                        ,
                        Contractant = contractantl.Text
                        ,
                        Date_prévisionnelle_mes = datepreservel.Text
                        ,
                        Date_référence = daterefl.Text
                    };
                    o.lignes.Add(li);
                    o.SaveChanges();
                    List<lignes> ligness = new List<lignes>();
                    ligness = o.lignes.ToList();
                       dataGridView1.DataSource = ligness;
                    MessageBox.Show("Bien Ajouter lignes ");
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
                DateTime now1 = DateTime.Now;
                if (comboBox2.Text == "Etudes ")
                {
                    poste po = new poste
                    {
                        N_DI = ndi.Text,
                        Nature_Ouvrage = pnature.Text,
                        Montant_Contractuel__kDH_ = pmontant.Text,
                        Tensions_Transformation_ = ptension.Text,
                        unité = punite.Text,
                        Avancement_ = double.Parse(pavancement.Text),
                        Puissance_ = ppuissnace.Text,
                        dbetude = now1   ,
                        Statut_DI = comboBox2.Text,
                        Date_prévisionnelle_mes = double.Parse(dateperevisionp.Text),
                        Date_référence=daterefp.Text

                    };
                    o.poste.Add(po);
                    o.SaveChanges();
                    List<projet> infos = new List<projet>();
                    infos = o.projet.ToList(); 

                    MessageBox.Show("Bien Ajouter");
                    return;
                }


                //  dataGridView1.DataSource = ligness;

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

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!(ndi.Text == ""))
                {


                    if (radioButton1.Checked) { lignesinfo(); }
                    else if (radioButton2.Checked) { postesinfo(); }

                    projet i = new projet
                    {

                        Direction = direction.Text,
                        DESIGNATION = designation.Text,
                        Financement = finance.Text,
                        Finalite = finalite.Text,
                        N_DI = ndi.Text,
                        FICHE = fiche.Text,
                        Montant_DI = double.Parse(montant.Text),
                         region = region.Text,
                        annee = datemes.Text,
                        Observations = observation.Text


                    };
                    o.projet.Add(i);
                    o.SaveChanges();
                    List<projet> infos = new List<projet>();
                    infos = o.projet.ToList();
                    dataGridView1.DataSource = o.projet.ToList();

                    MessageBox.Show("Bien Ajouter");
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
    }
}
