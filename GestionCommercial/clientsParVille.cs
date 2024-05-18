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
    public partial class clientsParVille : Form
    {
        public venteDataContext dc = new venteDataContext();
        
        public clientsParVille()
        {
            InitializeComponent();
        }

        private void clientsParVille_Load(object sender, EventArgs e)
        {
            var c = (from cl in dc.Client
                     select cl.ville).Distinct().ToArray();
            cmbVille.Items.AddRange(c);
            //lesClientsParVille1.SetDataSource(dc.Client);
            crystalReportViewer1.RefreshReport();
           
        }

        private void cmbVille_SelectedIndexChanged(object sender, EventArgs e)
        {
            var c = (from cl in dc.Client
                     where cl.ville == cmbVille.Text
                     select cl);
            lesClientsParVille1.SetDataSource(c);
            crystalReportViewer1.RefreshReport();
        }
    }
}
