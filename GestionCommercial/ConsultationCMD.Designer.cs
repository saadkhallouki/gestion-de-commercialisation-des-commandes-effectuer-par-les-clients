namespace GestionCommercial
{
    partial class ConsultationCMD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultationCMD));
            this.cmbCodeCl = new System.Windows.Forms.ComboBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.txtChiffAff = new System.Windows.Forms.TextBox();
            this.txtTotalCMD = new System.Windows.Forms.TextBox();
            this.dgvCMDclient = new System.Windows.Forms.DataGridView();
            this.clnNumCMD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDetailCMD = new System.Windows.Forms.DataGridView();
            this.clnCodeArt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDesi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnQte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnMontant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btSupprCMD = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCMDclient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailCMD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCodeCl
            // 
            this.cmbCodeCl.FormattingEnabled = true;
            this.cmbCodeCl.Location = new System.Drawing.Point(112, 12);
            this.cmbCodeCl.Name = "cmbCodeCl";
            this.cmbCodeCl.Size = new System.Drawing.Size(136, 21);
            this.cmbCodeCl.TabIndex = 0;
            this.cmbCodeCl.SelectedIndexChanged += new System.EventHandler(this.cmbCodeCl_SelectedIndexChanged);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(112, 39);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(136, 20);
            this.txtNom.TabIndex = 1;
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(112, 65);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(136, 20);
            this.txtVille.TabIndex = 2;
            // 
            // txtChiffAff
            // 
            this.txtChiffAff.Location = new System.Drawing.Point(488, 112);
            this.txtChiffAff.Name = "txtChiffAff";
            this.txtChiffAff.ReadOnly = true;
            this.txtChiffAff.Size = new System.Drawing.Size(131, 20);
            this.txtChiffAff.TabIndex = 3;
            // 
            // txtTotalCMD
            // 
            this.txtTotalCMD.Location = new System.Drawing.Point(488, 266);
            this.txtTotalCMD.Name = "txtTotalCMD";
            this.txtTotalCMD.ReadOnly = true;
            this.txtTotalCMD.Size = new System.Drawing.Size(131, 20);
            this.txtTotalCMD.TabIndex = 4;
            // 
            // dgvCMDclient
            // 
            this.dgvCMDclient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCMDclient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnNumCMD,
            this.clnDate});
            this.dgvCMDclient.Location = new System.Drawing.Point(8, 112);
            this.dgvCMDclient.Name = "dgvCMDclient";
            this.dgvCMDclient.Size = new System.Drawing.Size(304, 150);
            this.dgvCMDclient.TabIndex = 5;
            this.dgvCMDclient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCMDclient_CellContentClick);
            this.dgvCMDclient.SelectionChanged += new System.EventHandler(this.dgvCMDclient_SelectionChanged);
            // 
            // clnNumCMD
            // 
            this.clnNumCMD.HeaderText = "N°Commande";
            this.clnNumCMD.Name = "clnNumCMD";
            this.clnNumCMD.Width = 120;
            // 
            // clnDate
            // 
            this.clnDate.HeaderText = "Date";
            this.clnDate.Name = "clnDate";
            this.clnDate.Width = 140;
            // 
            // dgvDetailCMD
            // 
            this.dgvDetailCMD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailCMD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnCodeArt,
            this.clnDesi,
            this.clnPU,
            this.clnQte,
            this.clnMontant});
            this.dgvDetailCMD.Location = new System.Drawing.Point(8, 292);
            this.dgvDetailCMD.Name = "dgvDetailCMD";
            this.dgvDetailCMD.Size = new System.Drawing.Size(606, 150);
            this.dgvDetailCMD.TabIndex = 6;
            // 
            // clnCodeArt
            // 
            this.clnCodeArt.HeaderText = "Code Article";
            this.clnCodeArt.Name = "clnCodeArt";
            // 
            // clnDesi
            // 
            this.clnDesi.HeaderText = "Designation";
            this.clnDesi.Name = "clnDesi";
            this.clnDesi.Width = 140;
            // 
            // clnPU
            // 
            this.clnPU.HeaderText = "PU";
            this.clnPU.Name = "clnPU";
            // 
            // clnQte
            // 
            this.clnQte.HeaderText = "Qte";
            this.clnQte.Name = "clnQte";
            // 
            // clnMontant
            // 
            this.clnMontant.HeaderText = "Montant";
            this.clnMontant.Name = "clnMontant";
            this.clnMontant.Width = 120;
            // 
            // btSupprCMD
            // 
            this.btSupprCMD.Location = new System.Drawing.Point(343, 176);
            this.btSupprCMD.Name = "btSupprCMD";
            this.btSupprCMD.Size = new System.Drawing.Size(166, 23);
            this.btSupprCMD.TabIndex = 7;
            this.btSupprCMD.Text = "<< Supprimer une commande";
            this.btSupprCMD.UseVisualStyleBackColor = true;
            this.btSupprCMD.Click += new System.EventHandler(this.btSupprCMD_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Code Client";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ville";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(396, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Chiffres d\'affaire";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Commandes du client";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Details commande selectionnée";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(396, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Total commande";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(464, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // ConsultationCMD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(639, 451);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btSupprCMD);
            this.Controls.Add(this.dgvDetailCMD);
            this.Controls.Add(this.dgvCMDclient);
            this.Controls.Add(this.txtTotalCMD);
            this.Controls.Add(this.txtChiffAff);
            this.Controls.Add(this.txtVille);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.cmbCodeCl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultationCMD";
            this.Text = "Consultation des commandes d\'unclient";
            this.Load += new System.EventHandler(this.ConsultationCMD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCMDclient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailCMD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCodeCl;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.TextBox txtChiffAff;
        private System.Windows.Forms.TextBox txtTotalCMD;
        private System.Windows.Forms.DataGridView dgvCMDclient;
        private System.Windows.Forms.DataGridView dgvDetailCMD;
        private System.Windows.Forms.Button btSupprCMD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodeArt;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDesi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPU;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnQte;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnMontant;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNumCMD;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDate;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}