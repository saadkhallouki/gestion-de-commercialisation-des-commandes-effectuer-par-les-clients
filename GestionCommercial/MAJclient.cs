using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GestionCommercial
{
    public partial class MAJclient : Form
    {
        public venteDataContext dc = new venteDataContext();
        public BindingSource clientBs = new BindingSource();
        public Client clientActuel;
        public Boolean ajouter = false;
        //SqlDataAdapter da;
        //DataTable c = new DataTable("client");

        //Affichage Dans la Form
        public void afficher()
        {
            try
            {
                clientActuel = (Client)clientBs.Current;
                txtCodeCl.Text = clientActuel.codecl;
                txtNom.Text = clientActuel.nom;
                txtVille.Text = clientActuel.ville;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        public MAJclient()
        {
            InitializeComponent();
        }

        private void MAJclient_Load(object sender, EventArgs e)
        {
            clientBs.DataSource = dc.Client;
            btAjouter.Text = "nouveau";
            afficher();
            //-------------------------------------------------------
            //txtCodeCl.DataBindings.Add("text", clientBs, "codeCl");
            //txtNom.DataBindings.Add("text", clientBs, "nom");
            //txtVille.DataBindings.Add("text", clientBs, "ville");
            //dc.Refresh(System.Data.Linq.RefreshMode.KeepChanges, dc);
        }

        private void btQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btPremier_Click(object sender, EventArgs e)
        {
            //Premier
            clientBs.MoveFirst();
            afficher();
        }

        private void btPrecedent_Click(object sender, EventArgs e)
        {
            //Precedent
            clientBs.MovePrevious();
            afficher();
        }

        private void btSuivant_Click(object sender, EventArgs e)
        {
            //Suivant
            clientBs.MoveNext();
            afficher();
        }

        private void btDernier_Click(object sender, EventArgs e)
        {
            //Dernier
            clientBs.MoveLast();
            afficher();
        }

        private void btChercher_Click(object sender, EventArgs e)
        {
            //Chercher
            var cl = (from c in dc.Client
                      where c.codecl == txtCodeClCher.Text
                      select c);
            if (cl.Count() != 0)
            {
                clientBs.Position = clientBs.IndexOf(cl.First());
                afficher();
                txtCodeClCher.Clear();
            }
            else
            {
                MessageBox.Show("Client n'existe pas", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCodeClCher.Clear();
            }
        }

        private void btSupprimer_Click(object sender, EventArgs e)
        {
            //Supprimer
            try
            {
                var cl = (from c in dc.Client
                          where c.codecl == txtCodeCl.Text
                          select c);

                dc.Client.DeleteOnSubmit(cl.First());
                dc.SubmitChanges();
                clientBs.Remove(cl);
                MessageBox.Show("Client Supprimer");
                afficher();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            
            
            //--------------------------------------------------------------------
            //dc.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, cl);  
            //da.Update(c);
            //try
            //{
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{ 
            //    afficher(); 
            //}
            
            //try
            //{
            //    clientBs.RemoveCurrent();dc.SubmitChanges();
            //}
            //catch(Exception ex)
            //{

            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    afficher();
            //}
        }

        private void btModifier_Click(object sender, EventArgs e)
        {
            //Modifier
            var cl = (from c in dc.Client
                      where c.codecl == txtCodeCl.Text
                      select c).Single();
            cl.codecl = txtCodeCl.Text;
            cl.nom = txtNom.Text;
            cl.ville = txtVille.Text;
            dc.SubmitChanges(); //enregistrer BaseD
            MessageBox.Show("Bien Modifier");
            //-----------------------------------------------------
            //((client)clientBs.Current).codecl = txtCodeCl.Text;
            //((client)clientBs.Current).nom = txtNom.Text;
            //((client)clientBs.Current).ville = txtVille.Text;
            //clientBs.EndEdit();  //enregistrer dataContexte
        }

        private void btAjouter_Click(object sender, EventArgs e)
        {
            //Ajouter
            if (ajouter == false)
            {
                ajouter = true;
                btAjouter.Text = "ajouter";
                txtCodeCl.Clear();
                txtNom.Clear();
                txtVille.Clear();
                txtCodeClCher.Clear();
                //clientBs.AddNew();
                txtCodeCl.Focus();
            }
            else
            {
                Client cl = new Client();
                cl.codecl = txtCodeCl.Text;
                cl.nom= txtNom.Text;
                cl.ville = txtVille.Text;
                
                try
                {
                    clientBs.Add(cl);
                    dc.Client.InsertOnSubmit(cl);
                    dc.SubmitChanges(); //enregistrer BaseD
                    ajouter = false;
                    txtCodeCl.Clear();
                    txtNom.Clear();
                    txtVille.Clear();
                    btAjouter.Text = "nouveau";
                    afficher();
                    MessageBox.Show("Bien Enregistrer");
                }
                catch (Exception ex)
                { 
                    MessageBox.Show(ex.Message);
                      
                }
                //-----------------------------------------------
                //clientBs.EndEdit();  //enregistrer dataContexte
                //((client)clientBs.Current).codecl = txtCodeCl.Text;
                //((client)clientBs.Current).nom = txtNom.Text;
                //((client)clientBs.Current).ville = txtVille.Text;
            }
        }

        private void txtCodeClCher_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                var cl = (from c in dc.Client
                          where c.codecl == txtCodeClCher.Text
                          select c);
                if (cl.Count() != 0)
                {
                    clientBs.Position = clientBs.IndexOf(cl.First());
                    afficher();
                    txtCodeClCher.Clear();
                }
                else
                {
                    MessageBox.Show("Client n'existe pas","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txtCodeClCher.Clear();
                }
            }
        }
    }
}
