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
    public partial class rapport : Form
    {
        public rapport()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            CrystalReport2 crystal = new CrystalReport2();
            crystalReportViewer1.ReportSource = crystal;
        }

        private void link1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            rapport rp = new rapport();
            this.Hide();
            rp.Close();
            infoglobale f = new infoglobale();
            f.Show();
        }

        private void modifierlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            rapport rp = new rapport();
            this.Hide();
            rp.Close();
              Modfier sf = new Modfier();
            sf.Show();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            rapport rp = new rapport();
            this.Hide();
            rp.Close();
            recherche r = new recherche();
            r.Show();
        }

        private void supplink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            rapport rp = new rapport();
            this.Hide();
            rp.Close();
            supprimer dp = new supprimer();
            dp.Show();
        }
    }
}
