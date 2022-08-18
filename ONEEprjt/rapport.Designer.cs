namespace ONEEprjt
{
    partial class rapport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReport21 = new ONEEprjt.Distanceannee();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.supplink = new System.Windows.Forms.LinkLabel();
            this.modifierlink = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.link1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.CrystalReport21;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1370, 650);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.linkLabel2);
            this.panel1.Controls.Add(this.supplink);
            this.panel1.Controls.Add(this.modifierlink);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.link1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 700);
            this.panel1.TabIndex = 2;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.DarkBlue;
            this.linkLabel2.DisabledLinkColor = System.Drawing.Color.Yellow;
            this.linkLabel2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.ForeColor = System.Drawing.Color.White;
            this.linkLabel2.LinkColor = System.Drawing.Color.Yellow;
            this.linkLabel2.Location = new System.Drawing.Point(47, 251);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(79, 21);
            this.linkLabel2.TabIndex = 6;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Rapport";
            this.linkLabel2.UseMnemonic = false;
            // 
            // supplink
            // 
            this.supplink.AutoSize = true;
            this.supplink.BackColor = System.Drawing.Color.DarkBlue;
            this.supplink.DisabledLinkColor = System.Drawing.Color.Yellow;
            this.supplink.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplink.ForeColor = System.Drawing.Color.White;
            this.supplink.LinkColor = System.Drawing.Color.Yellow;
            this.supplink.Location = new System.Drawing.Point(50, 208);
            this.supplink.Name = "supplink";
            this.supplink.Size = new System.Drawing.Size(110, 21);
            this.supplink.TabIndex = 5;
            this.supplink.TabStop = true;
            this.supplink.Text = "Supprimer :";
            this.supplink.UseMnemonic = false;
            this.supplink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.supplink_LinkClicked);
            // 
            // modifierlink
            // 
            this.modifierlink.AutoSize = true;
            this.modifierlink.BackColor = System.Drawing.Color.DarkBlue;
            this.modifierlink.DisabledLinkColor = System.Drawing.Color.Yellow;
            this.modifierlink.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifierlink.ForeColor = System.Drawing.Color.White;
            this.modifierlink.LinkColor = System.Drawing.Color.Yellow;
            this.modifierlink.Location = new System.Drawing.Point(47, 133);
            this.modifierlink.Name = "modifierlink";
            this.modifierlink.Size = new System.Drawing.Size(103, 21);
            this.modifierlink.TabIndex = 4;
            this.modifierlink.TabStop = true;
            this.modifierlink.Text = "Modifier : ";
            this.modifierlink.UseMnemonic = false;
            this.modifierlink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.modifierlink_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.DarkBlue;
            this.linkLabel1.DisabledLinkColor = System.Drawing.Color.Yellow;
            this.linkLabel1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.Color.White;
            this.linkLabel1.LinkColor = System.Drawing.Color.Yellow;
            this.linkLabel1.Location = new System.Drawing.Point(47, 171);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(126, 21);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Rechercher : ";
            this.linkLabel1.UseMnemonic = false;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // link1
            // 
            this.link1.AutoSize = true;
            this.link1.BackColor = System.Drawing.Color.DarkBlue;
            this.link1.DisabledLinkColor = System.Drawing.Color.Yellow;
            this.link1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link1.ForeColor = System.Drawing.Color.White;
            this.link1.LinkColor = System.Drawing.Color.Yellow;
            this.link1.Location = new System.Drawing.Point(47, 89);
            this.link1.Name = "link1";
            this.link1.Size = new System.Drawing.Size(93, 21);
            this.link1.TabIndex = 2;
            this.link1.TabStop = true;
            this.link1.Text = "Ajouter : ";
            this.link1.UseMnemonic = false;
            this.link1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkBlue;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(47, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "ONEE";
            // 
            // rapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 650);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "rapport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "rapport";
            this.Load += new System.EventHandler(this.rapport_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private Distanceannee CrystalReport21;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel supplink;
        private System.Windows.Forms.LinkLabel modifierlink;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel link1;
        private System.Windows.Forms.Label label1;
    }
}