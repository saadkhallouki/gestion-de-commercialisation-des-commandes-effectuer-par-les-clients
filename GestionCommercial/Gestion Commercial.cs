using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GestionCommercial
{
    public partial class Gestion_Commercial : Form
    {
        public Gestion_Commercial()
        {
            InitializeComponent();
        }

        private void miseAJourClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MAJclient Fclient = new MAJclient();
            Fclient.Show();
        }

        private void gestionCommandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionCMD Fcmd = new GestionCMD();
            Fcmd.Show();
            
        }

        private void consultationDesCommandesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultationCMD Fcons = new ConsultationCMD();
            Fcons.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Gestion_Commercial_Load(object sender, EventArgs e)
        {

        }

        private void miseAJourAricleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MAJarticle Fart = new MAJarticle();
            Fart.Show();
        }

        private void clientParVilleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clientsParVille cl = new clientsParVille();
            cl.Show();
        }
    }
}
