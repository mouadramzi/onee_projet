namespace ONEEprjt
{
    partial class searchbydate
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.supplink = new System.Windows.Forms.LinkLabel();
            this.modifierlink = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.link1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ndiprojet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.designation = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Financement = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.finance = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.projetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.projetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.annee1 = new System.Windows.Forms.TextBox();
            this.annee2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(4, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 568);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.DarkBlue;
            this.linkLabel2.DisabledLinkColor = System.Drawing.Color.Yellow;
            this.linkLabel2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.ForeColor = System.Drawing.Color.White;
            this.linkLabel2.LinkColor = System.Drawing.Color.Yellow;
            this.linkLabel2.Location = new System.Drawing.Point(38, 276);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(79, 21);
            this.linkLabel2.TabIndex = 6;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Rapport";
            this.linkLabel2.UseMnemonic = false;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // supplink
            // 
            this.supplink.AutoSize = true;
            this.supplink.BackColor = System.Drawing.Color.DarkBlue;
            this.supplink.DisabledLinkColor = System.Drawing.Color.Yellow;
            this.supplink.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplink.ForeColor = System.Drawing.Color.White;
            this.supplink.LinkColor = System.Drawing.Color.Yellow;
            this.supplink.Location = new System.Drawing.Point(41, 233);
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
            this.modifierlink.Location = new System.Drawing.Point(38, 158);
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
            this.linkLabel1.Location = new System.Drawing.Point(38, 196);
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
            this.link1.Location = new System.Drawing.Point(38, 114);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 110;
            this.label3.Text = "N_DI";
            // 
            // ndiprojet
            // 
            this.ndiprojet.Location = new System.Drawing.Point(274, 26);
            this.ndiprojet.Name = "ndiprojet";
            this.ndiprojet.Size = new System.Drawing.Size(100, 20);
            this.ndiprojet.TabIndex = 111;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 112;
            this.label4.Text = "Désignation ";
            // 
            // designation
            // 
            this.designation.Location = new System.Drawing.Point(274, 69);
            this.designation.Name = "designation";
            this.designation.Size = new System.Drawing.Size(100, 20);
            this.designation.TabIndex = 113;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(181, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 115;
            this.label6.Text = "Finalité ";
            // 
            // Financement
            // 
            this.Financement.AutoSize = true;
            this.Financement.Location = new System.Drawing.Point(181, 103);
            this.Financement.Name = "Financement";
            this.Financement.Size = new System.Drawing.Size(68, 13);
            this.Financement.TabIndex = 114;
            this.Financement.Text = "Financement";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(182, 173);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(41, 13);
            this.label32.TabIndex = 119;
            this.label32.Text = "Region";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(184, 211);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 13);
            this.label16.TabIndex = 118;
            this.label16.Text = "Date_mes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 124;
            this.label2.Text = "Date entrée";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(439, 211);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 23);
            this.button5.TabIndex = 125;
            this.button5.Text = "Rechercher";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(596, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 127;
            this.button1.Text = "Vider";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // finance
            // 
            this.finance.Location = new System.Drawing.Point(274, 103);
            this.finance.Name = "finance";
            this.finance.Size = new System.Drawing.Size(100, 20);
            this.finance.TabIndex = 116;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(274, 139);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(208, 21);
            this.comboBox1.TabIndex = 128;
            // 
            // projetBindingSource1
            // 
            this.projetBindingSource1.DataMember = "projet";
            // 
            // projetBindingSource
            // 
            this.projetBindingSource.DataMember = "projet";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Tanger - Tétouan - Al Hoceima",
            "Fès - Meknès",
            "L\'Oriental",
            "Rabat - Salé - Kénitra",
            "Casablanca - Settat",
            "Beni Mellal - Khénifra",
            "Marrakech - Safi",
            "Drâa - Tafilalet",
            "Souss -Massa",
            "Guelmim - Oued Noun",
            "Laâyoune - Saguia al Hamra",
            "Dakhla - Oued Ed-Dahab"});
            this.comboBox2.Location = new System.Drawing.Point(274, 173);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(208, 21);
            this.comboBox2.TabIndex = 129;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(177, 283);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(948, 202);
            this.dataGridView1.TabIndex = 131;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(502, 511);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 23);
            this.button3.TabIndex = 132;
            this.button3.Text = "Afficher tout";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(648, 511);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 23);
            this.button4.TabIndex = 133;
            this.button4.Text = "Export";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // annee1
            // 
            this.annee1.Location = new System.Drawing.Point(274, 215);
            this.annee1.Name = "annee1";
            this.annee1.Size = new System.Drawing.Size(100, 20);
            this.annee1.TabIndex = 134;
            // 
            // annee2
            // 
            this.annee2.Location = new System.Drawing.Point(274, 246);
            this.annee2.Name = "annee2";
            this.annee2.Size = new System.Drawing.Size(100, 20);
            this.annee2.TabIndex = 135;
            // 
            // searchbydate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1124, 554);
            this.Controls.Add(this.annee2);
            this.Controls.Add(this.annee1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Financement);
            this.Controls.Add(this.finance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.designation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ndiprojet);
            this.Controls.Add(this.panel1);
            this.Name = "searchbydate";
            this.Text = "searchbydate";
            this.Load += new System.EventHandler(this.searchbydate_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel supplink;
        private System.Windows.Forms.LinkLabel modifierlink;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel link1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ndiprojet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox designation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Financement;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        
        private System.Windows.Forms.TextBox finance;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource projetBindingSource;
      //  private ONEEDataSetTableAdapters.projetTableAdapter projetTableAdapter;
        //private ONEEDataSet1 oNEEDataSet1;
        private System.Windows.Forms.BindingSource projetBindingSource1;
        //private ONEEDataSet1TableAdapters.projetTableAdapter projetTableAdapter1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox annee1;
        private System.Windows.Forms.TextBox annee2;
    }
}