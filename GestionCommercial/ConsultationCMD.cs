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
    public partial class ConsultationCMD : Form
    {
        public venteDataContext dc = new venteDataContext();
        public BindingSource Bs = new BindingSource();
        
        public ConsultationCMD()
        {
            InitializeComponent();
        }

        private void ConsultationCMD_Load(object sender, EventArgs e)
        {
            Bs.DataSource = dc.article;
            Bs.DataSource = dc.commande;
            Bs.DataSource = dc.detail;
            Bs.DataSource = dc.Client;
            //Remplissage ComboCodeClient
            var cl = (from c in dc.Client
                      select c.codecl);
            cmbCodeCl.Items.AddRange(cl.ToArray());
            txtNom.ReadOnly = true;
            txtVille.ReadOnly = true;
        }

        private void cmbCodeCl_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvCMDclient.Rows.Clear();
            //Remplire TxtNom et TxtVille De client
            var c = (from cl in dc.Client
                     where cl.codecl == cmbCodeCl.Text
                     select cl).First();
            txtNom.Text = c.nom;
            txtVille.Text = c.ville;
            //Ajouter Les Commandes Dgv
            var cmds = (from com in dc.commande
                     where com.codecl == cmbCodeCl.Text
                     select com);
            if (cmds.Count() != 0)
            {
                //Ajouter Les Commandes Dgv
                foreach (commande com in cmds.ToArray())
                {
                    string[] ligne = { com.NumCom, com.dateCom.ToString() };
                    dgvCMDclient.Rows.Add(ligne);
                }
                //Calculer Chiffre Affaire
                decimal ca = (from d in dc.detail
                              where d.commande.codecl == cmbCodeCl.Text
                              select (decimal)d.article.Pu * (decimal)d.Qte).Sum();
                txtChiffAff.Text = ca.ToString("f2");
            }
            else
            {
                MessageBox.Show("ancun commande a cette client","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            //------------------------------------------------------------------
            //dgvCMDclient.DataSource = cmds;
            //double montant;
            //double m;
            //string[] ligne = { cmd.NumCom ,cmd.Datecom.ToString() };
            //dgvCMDclient.Rows.Add(cmds.ToArray());
        }

        private void btSupprCMD_Click(object sender, EventArgs e)
        {
            
            if (dgvCMDclient.Rows.Count != 1)
            {
                if (dgvDetailCMD.Rows.Count != 1)
                {
                    //Supprimer une Commande a Partir Table Detail
                    var dt = (from d in dc.detail
                              where d.NumCom == dgvCMDclient.SelectedRows[0].Cells[0].Value.ToString()
                              select d).Single();
                    dc.detail.DeleteOnSubmit(dt);
                    //Supprimer une Commande a Partir Table Commande
                    var cmd = (from com in dc.commande
                               where com.NumCom == dgvCMDclient.SelectedRows[0].Cells[0].Value.ToString()
                               select com);
                    dc.commande.DeleteOnSubmit(cmd.First());
                    dc.SubmitChanges();
                    //Supprimer commande Dgv
                    dgvCMDclient.Rows.RemoveAt(dgvCMDclient.CurrentRow.Index);
                }
                else
                {
                    //Supprimer une Commande a Partir Table Commande
                    var cmd = (from com in dc.commande
                               where com.NumCom == dgvCMDclient.SelectedRows[0].Cells[0].Value.ToString()
                               select com);
                    dc.commande.DeleteOnSubmit(cmd.First());
                    dc.SubmitChanges();
                    //Supprimer commande Dgv
                    dgvCMDclient.Rows.RemoveAt(dgvCMDclient.CurrentRow.Index);
                }
            }
            else
            {
                MessageBox.Show("Sélectioner une ligne pour supprimer !!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //------------------------------------------------------------------
            //MessageBox.Show(dgvCMDclient.SelectedRows[0].Cells[0].Value.ToString());
        }

        private void dgvCMDclient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //var dt = (from d in dc.Detail 
            //          where d.NumCom == dgvCMDclient.SelectedRows[0].Cells[1].Value.ToString() 
            //          select d);
        }

        private void dgvCMDclient_SelectionChanged(object sender, EventArgs e)
        {
            decimal TotalCom = 0;
            dgvDetailCMD.Rows.Clear();
            //Remplire Dgv par des Commandes des Clients 
            if (dgvCMDclient.Rows.Count != 1)
            {
                try
                {
                    string s = (string)dgvCMDclient.SelectedRows[0].Cells[0].Value;
                    var det = (from c in dc.detail
                               where s == c.NumCom
                               select c);
                    foreach (detail d in det.ToArray())
                    {
                        var art = (from a in dc.article
                                   where a.codeart == d.codeart
                                   select a).First();
                        dgvDetailCMD.Rows.Add(art.codeart, art.desi, art.Pu, d.Qte, d.Qte * art.Pu);
                        TotalCom = TotalCom + (decimal.Parse(d.Qte.ToString()) * decimal.Parse(art.Pu.ToString()));
                        txtTotalCMD.Text = TotalCom.ToString("f2"); 
                    }
                }
                catch 
                {
                    TotalCom = 0;
                }
            }
           
            
        }
    }
}
