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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user, pass;
            user = username.Text.ToString();
            pass = password.Text.ToString();
            if (user == "admin" && pass == " ")
            {
                Form1 f = new Form1();
                this.Hide();
                f.Close();
                infoglobale f1 = new infoglobale();
                f1.Show();

            }
            else
            {
                error.Text = "connexion echoue";
                MessageBox.Show( "Username ou mot de passe incorrect", "Connection",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Form1_Load(sender, e);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
