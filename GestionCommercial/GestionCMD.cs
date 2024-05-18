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
    public partial class GestionCMD : Form
    {
        public venteDataContext dc = new venteDataContext();
        public BindingSource cmdBs = new BindingSource();
        public commande CmdActuel;
        public int QteDisp;
        
        
        public GestionCMD()
        {
            InitializeComponent();
        }

        public void afficher()
        {
            
        try
            {
                CmdActuel = (commande)cmdBs.Current;
                txtNcmd.Text = CmdActuel.NumCom;
                dateCMD.Text = CmdActuel.dateCom.ToString();
                cmbCodeClient.Text = CmdActuel.codecl;

                var det = (from c in dc.detail
                           where txtNcmd.Text == c.NumCom
                           select c);
                
                foreach (detail d in det.ToArray())
                {
                    var art = (from a in dc.article
                               where a.codeart == d.codeart
                               select a).First();
                    
                    dgvCMD.Rows.Add(art.codeart, art.desi, art.Pu, d.Qte, d.Qte * art.Pu);
                    double montant = double.Parse(art.Pu.ToString()) * int.Parse(d.Qte.ToString());
                    txtTotal.Text = (double.Parse(txtTotal.Text) + montant).ToString();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btQuitter_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void GestionCMD_Load(object sender, EventArgs e)
        {
            //Commentaire button
            toolTip1.SetToolTip(btSuivant, "Suivant");
            toolTip1.SetToolTip(btPrecedent, "Précedent");
            toolTip1.SetToolTip(btPremier, "Premier");
            toolTip1.SetToolTip(btDernier, "Dérnier");
            toolTip1.SetToolTip(txtQteArt, "Entrer Quantité");

            btSaveCMD.Text = "Nouveau";

            cmdBs.DataSource = dc.commande;
            txtTotal.Text = "0"; 
            //Remplire ComboCodeClient
            
            var cl = (from c in dc.Client
                      select c.codecl);
            cmbCodeClient.Items.AddRange(cl.ToArray());
            //Remplire ComboArticle
            var ar = (from a in dc.article
                      select a.codeart);
            cmbArticle.Items.AddRange(ar.ToArray());
            afficher();
        }

        private void cmbCodeClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Remplire TxtNom et TxtVille
            var c = (from cl in dc.Client
                     where cl.codecl == cmbCodeClient.Text
                     select cl).First();
            txtNom.Text = c.nom;
            txtVille.Text = c.ville;
        }

        private void cmbArticle_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Remplire TxtDesi et TxtPU
            var a = (from ar in dc.article
                     where ar.codeart == cmbArticle.Text
                     select ar).Single();
            if (a != null)
            {
                txtDesiArt.Text = a.desi;
                txtPuArt.Text = a.Pu.ToString();
                txtQteArt.Clear();
                QteDisp = Convert.ToInt32(a.Qdipo);
                txtQteArt.Focus();
            }
            
        }

        private void btAjouterLigne_Click(object sender, EventArgs e)
        {
            //Remplire Dgv avec Test de Qte et test des champs vide
            if (txtQteArt.Text == "")
            {
                MessageBox.Show("Entrer Qte ou Sélectionner Code Article!!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
               
                if (int.Parse(txtQteArt.Text) > QteDisp)
                { 
                    labelMessage.Text = "Stock insuffisant";
                    txtQteArt.Text = QteDisp.ToString();
                    labelMessage.Visible = true;
                }
                else
                {
                    labelMessage.Visible = false;
                    double montant = double.Parse(txtPuArt.Text) * int.Parse(txtQteArt.Text);
                    string[] ligne = { cmbArticle.Text, txtDesiArt.Text, txtPuArt.Text, txtQteArt.Text, montant.ToString() };
                    dgvCMD.Rows.Add(ligne);
                    txtTotal.Text = (double.Parse(txtTotal.Text) + montant).ToString();
                    txtDesiArt.Clear();
                    txtPuArt.Clear();
                    txtQteArt.Clear();
                    cmbArticle.Items.RemoveAt(cmbArticle.SelectedIndex);
                    dc.SubmitChanges();
                    //-----------------------------------------------------
                    //double total = montant + 0;
                    //var art = (from a in dc.Article
                    //           where a.codea == cmbArticle.Text
                    //           select a).First();
                    //art.Qdesp = int.Parse(txtQteArt.Text);   
                }
            }  
        }

        private void btSupprLigne_Click(object sender, EventArgs e)
        {
            //Supprimer article apartir Dgv 
            if (dgvCMD.Rows.Count != 1)
            {
                txtTotal.Text = (double.Parse(txtTotal.Text) - double.Parse(dgvCMD.SelectedRows[0].Cells[4].Value.ToString())).ToString();
                cmbArticle.Items.Add(dgvCMD.CurrentRow.Cells[0].Value);
                dgvCMD.Rows.RemoveAt(dgvCMD.CurrentRow.Index);
                cmbArticle.Sorted = true;
            }
            else
            {
                MessageBox.Show("Sélectioner une ligne pour supprimer !!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btSaveCMD_Click(object sender, EventArgs e)
        {
            //Enregister a Base Données Detail et Commande
            if (btSaveCMD.Text == "Nouveau")
            {
                txtNcmd.Clear();
                cmbCodeClient.Text = " ";
                cmbArticle.Text = " ";
                txtNom.Clear();
                txtVille.Clear();
                dateCMD.Text = DateTime.Now.ToString();
                dgvCMD.Rows.Clear();
                txtTotal.Text = "0";
                btSaveCMD.Text = "Enregistrer";
            }
            else
            {
            if (cmbCodeClient.Text=="" || txtNcmd.Text=="" || dgvCMD.Rows.Count==1)
            {
                MessageBox.Show("Un champ Est Vide !!!","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
            commande c = new commande();
            c.NumCom = txtNcmd.Text;
            c.dateCom = DateTime.Parse(dateCMD.Text);
            c.codecl = cmbCodeClient.Text;
            cmdBs.Add(c);
            dc.commande.InsertOnSubmit(c);
            //-------------------------------------------------------
            for (int i = 0; i < dgvCMD.Rows.Count - 1; i++)
            {
                detail d = new detail();
                d.codeart = dgvCMD.Rows[i].Cells[0].Value.ToString();
                d.NumCom = txtNcmd.Text;
                d.Qte = int.Parse(dgvCMD.Rows[i].Cells[3].Value.ToString());
                dc.detail.InsertOnSubmit(d);

                //int k = i;
                var art = (from a in dc.article
                           where a.codeart == dgvCMD.Rows[i].Cells[0].Value.ToString()
                           select a).First();
                art.Qdipo = art.Qdipo - int.Parse(dgvCMD.Rows[i].Cells[3].Value.ToString());

            }
            dc.SubmitChanges();
                MessageBox.Show("Commande Enregistrer", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btSaveCMD.Text = "Nouveau";
            }
                //Detail d = new Detail();
                //d.codea = dgvCMD.Rows[0].Cells[0].Value.ToString();
                //d.NumCom = txtNcmd.Text;
                //d.Qte = int.Parse(dgvCMD.Rows[0].Cells[3].Value.ToString());
                //dc.Detail.InsertOnSubmit(d);
                //d.Qte = int.Parse(txtQteArt.Text);//d.codea = cmbArticle.Text;
            }
            
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQteArt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtQteArt.Text == "")
                {
                    MessageBox.Show("Entrer Qte ou Sélectionner Code Article!!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (int.Parse(txtQteArt.Text) > QteDisp)
                    {
                        labelMessage.Text = "Stock insuffisant";
                        txtQteArt.Text = QteDisp.ToString();
                        labelMessage.Visible = true;
                    }
                    else
                    {
                        labelMessage.Visible = false;
                        double montant = double.Parse(txtPuArt.Text) * int.Parse(txtQteArt.Text);
                        string[] ligne = { cmbArticle.Text, txtDesiArt.Text, txtPuArt.Text, txtQteArt.Text, montant.ToString() };
                        dgvCMD.Rows.Add(ligne);
                        txtTotal.Text = (double.Parse(txtTotal.Text) + montant).ToString();
                        txtDesiArt.Clear();
                        txtPuArt.Clear();
                        txtQteArt.Clear();
                        cmbArticle.Items.RemoveAt(cmbArticle.SelectedIndex);
                        dc.SubmitChanges();
                        //-----------------------------------------------------
                        //double total = montant + 0;
                        //var art = (from a in dc.Article
                        //           where a.codea == cmbArticle.Text
                        //           select a).First();
                        //art.Qdesp = int.Parse(txtQteArt.Text);   
                    }
                }  
            }
        }

        private void dgvCMD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Delete)
            {
                if (dgvCMD.Rows.Count != 1)
                {
                    txtTotal.Text = (double.Parse(txtTotal.Text) - double.Parse(dgvCMD.SelectedRows[0].Cells[4].Value.ToString())).ToString();
                    cmbArticle.Items.Add(dgvCMD.CurrentRow.Cells[0].Value);
                    dgvCMD.Rows.RemoveAt(dgvCMD.CurrentRow.Index);
                    cmbArticle.Sorted = true;
                }
                else
                {
                    MessageBox.Show("Sélectioner une ligne pour supprimer !!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btSuivant_Click(object sender, EventArgs e)
        {
            txtTotal.Text = "0";
            dgvCMD.Rows.Clear();
            cmdBs.MoveNext();
            afficher();
        }

        private void btPrecedent_Click(object sender, EventArgs e)
        {
            txtTotal.Text = "0"; 
            dgvCMD.Rows.Clear();
            cmdBs.MovePrevious();
            afficher();
        }

        private void btPremier_Click(object sender, EventArgs e)
        {
            txtTotal.Text = "0";
            dgvCMD.Rows.Clear();
            cmdBs.MoveFirst();
            afficher();
        }

        private void btDernier_Click(object sender, EventArgs e)
        {
            txtTotal.Text = "0";
            dgvCMD.Rows.Clear();
            cmdBs.MoveLast();
            afficher();
        }

        private void btSupprimer_Click(object sender, EventArgs e)
        {
            if (txtNcmd.Text != null)
            {
                if (dgvCMD.Rows.Count == 1)
                {
                    //Supprimer une Commande a Partir Table Commande
                    var cmd = (from com in dc.commande
                               where com.NumCom == txtNcmd.Text
                               select com);
                    dc.commande.DeleteOnSubmit(cmd.First());
                    dc.SubmitChanges();
                    txtNcmd.Clear();
                    cmbCodeClient.Text = " ";
                    cmbArticle.Text = " ";
                    txtNom.Clear();
                    txtVille.Clear();
                    dateCMD.Text = DateTime.Now.ToString();
                    dgvCMD.Rows.Clear();
                    txtTotal.Text = "0";
                    
                }
                else
                {
                    //Supprimer une Commande a Partir Table Detail
                    var dt = (from d in dc.detail
                              where d.NumCom == txtNcmd.Text
                              select d).Single();
                    dc.detail.DeleteOnSubmit(dt);
                    //Supprimer une Commande a Partir Table Commande
                    var cmd = (from com in dc.commande
                               where com.NumCom == txtNcmd.Text
                               select com);
                    dc.commande.DeleteOnSubmit(cmd.First());
                    dc.SubmitChanges();
                    txtNcmd.Clear();
                    cmbCodeClient.Text = " ";
                    cmbArticle.Text = " ";
                    txtNom.Clear();
                    txtVille.Clear();
                    dateCMD.Text = DateTime.Now.ToString();
                    dgvCMD.Rows.Clear();
                    txtTotal.Text = "0";
                }
            }
            else
            {
                MessageBox.Show("Entrer Numero Commande", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        

        
    }
}
