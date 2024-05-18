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
    public partial class MAJarticle : Form
    {
        public venteDataContext dc = new venteDataContext();
        public BindingSource artBs = new BindingSource();
        public article artActuel;
        public Boolean ajouter = false;
        
        
        public MAJarticle()
        {
            InitializeComponent();
        }

        public void afficher()
        {
            try
            {
                artActuel = (article)artBs.Current;
                txtCodeArt.Text = artActuel.codeart;
                txtDesi.Text = artActuel.desi;
                txtPU.Text = artActuel.Pu.ToString();
                txtQte.Text = artActuel.Qdipo.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MAJarticle_Load(object sender, EventArgs e)
        {
            artBs.DataSource = dc.article;
            btAjouter.Text = "nouveau";
            afficher();
        }

        private void btPremier_Click(object sender, EventArgs e)
        {
            artBs.MoveFirst();
            afficher();
        }

        private void btPrecedent_Click(object sender, EventArgs e)
        {
            artBs.MovePrevious();
            afficher();
        }

        private void btSuivant_Click(object sender, EventArgs e)
        {
            artBs.MoveNext();
            afficher();
        }

        private void btDernier_Click(object sender, EventArgs e)
        {
            artBs.MoveLast();
            afficher();
        }

        private void btAjouter_Click(object sender, EventArgs e)
        {
            if (ajouter == false)
            {
                ajouter = true;
                btAjouter.Text = "ajouter";
                txtCodeArt.Clear();
                txtDesi.Clear();
                txtQte.Clear();
                txtPU.Clear();
                txtCodeArtCher.Clear();
                
                txtCodeArt.Focus();
            }
            else
            {
                article art = new article();
                art.codeart = txtCodeArt.Text;
                art.desi = txtDesi.Text;
                art.Pu = decimal.Parse(txtPU.Text);
                art.Qdipo = int.Parse(txtQte.Text);
                
                try
                {
                    artBs.Add(art);
                    dc.article.InsertOnSubmit(art);
                    dc.SubmitChanges(); //enregistrer BaseD
                    ajouter = false;
                    txtCodeArt.Clear();
                    txtDesi.Clear();
                    txtQte.Clear();
                    txtCodeArtCher.Clear();
                    btAjouter.Text = "nouveau";
                    afficher();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    
                }
            }
        }

        private void btChercher_Click(object sender, EventArgs e)
        {
            var art = (from a in dc.article
                      where a.codeart == txtCodeArtCher.Text
                      select a);
            if (art.Count() != 0)
            {
                artBs.Position = artBs.IndexOf(art.First());
                afficher();
                txtCodeArtCher.Clear();
            }
            else
            {
                MessageBox.Show("Client n'existe pas", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCodeArtCher.Clear();
            }
        }

        private void btModifier_Click(object sender, EventArgs e)
        {
            //Modifier
            var art = (from a in dc.article
                      where a.codeart == txtCodeArt.Text
                      select a).Single();
            art.codeart = txtCodeArt.Text;
            art.desi = txtDesi.Text;
            art.Pu = decimal.Parse(txtPU.Text);
            art.Qdipo = int.Parse(txtQte.Text);
            dc.SubmitChanges(); //enregistrer BaseD
        }

        private void btSupprimer_Click(object sender, EventArgs e)
        {
            //Supprimer
            try
            {
                var art = (from a in dc.article
                           where a.codeart == txtCodeArt.Text
                           select a);

                dc.article.DeleteOnSubmit(art.First());
                dc.SubmitChanges();
                afficher();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void txtCodeArtCher_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                var art = (from a in dc.article
                           where a.codeart == txtCodeArtCher.Text
                           select a);
                if (art.Count() != 0)
                {
                    artBs.Position = artBs.IndexOf(art.First());
                    afficher();
                    txtCodeArtCher.Clear();
                }
                else
                {
                    MessageBox.Show("Client n'existe pas", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCodeArtCher.Clear();
                }
            }
        }

       
    }
}
