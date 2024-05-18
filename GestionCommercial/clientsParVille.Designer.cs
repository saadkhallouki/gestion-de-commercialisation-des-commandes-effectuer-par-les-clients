namespace GestionCommercial
{
    partial class clientsParVille
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
            this.cmbVille = new System.Windows.Forms.ComboBox();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.lesClientsParVille1 = new GestionCommercial.lesClientsParVille();
            this.SuspendLayout();
            // 
            // cmbVille
            // 
            this.cmbVille.FormattingEnabled = true;
            this.cmbVille.Location = new System.Drawing.Point(391, 31);
            this.cmbVille.Name = "cmbVille";
            this.cmbVille.Size = new System.Drawing.Size(143, 21);
            this.cmbVille.TabIndex = 1;
            this.cmbVille.SelectedIndexChanged += new System.EventHandler(this.cmbVille_SelectedIndexChanged);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(12, 78);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.lesClientsParVille1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1019, 363);
            this.crystalReportViewer1.TabIndex = 2;
            // 
            // clientsParVille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 471);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.cmbVille);
            this.Name = "clientsParVille";
            this.Text = "clientsParVille";
            this.Load += new System.EventHandler(this.clientsParVille_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbVille;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private lesClientsParVille lesClientsParVille1;
    }
}