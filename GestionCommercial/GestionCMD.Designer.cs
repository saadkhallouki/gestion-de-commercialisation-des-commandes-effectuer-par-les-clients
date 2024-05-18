namespace GestionCommercial
{
    partial class GestionCMD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionCMD));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelMessage = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNcmd = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.txtDesiArt = new System.Windows.Forms.TextBox();
            this.txtPuArt = new System.Windows.Forms.TextBox();
            this.txtQteArt = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.cmbCodeClient = new System.Windows.Forms.ComboBox();
            this.cmbArticle = new System.Windows.Forms.ComboBox();
            this.btAjouterLigne = new System.Windows.Forms.Button();
            this.btSupprLigne = new System.Windows.Forms.Button();
            this.btSaveCMD = new System.Windows.Forms.Button();
            this.btQuitter = new System.Windows.Forms.Button();
            this.dgvCMD = new System.Windows.Forms.DataGridView();
            this.clnCodeART = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDesi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnQte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnMontant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCMD = new System.Windows.Forms.DateTimePicker();
            this.btPremier = new System.Windows.Forms.Button();
            this.btPrecedent = new System.Windows.Forms.Button();
            this.btSuivant = new System.Windows.Forms.Button();
            this.btDernier = new System.Windows.Forms.Button();
            this.btChercher = new System.Windows.Forms.Button();
            this.btSupprimer = new System.Windows.Forms.Button();
            this.btModifier = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCMD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Location = new System.Drawing.Point(131, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion des commandes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "N° Commande";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date commande";
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.ForeColor = System.Drawing.Color.Red;
            this.labelMessage.Location = new System.Drawing.Point(435, 163);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(0, 18);
            this.labelMessage.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(352, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Code client";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(352, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nom";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(352, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ville";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(350, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Total :";
            // 
            // txtNcmd
            // 
            this.txtNcmd.Location = new System.Drawing.Point(103, 63);
            this.txtNcmd.Name = "txtNcmd";
            this.txtNcmd.Size = new System.Drawing.Size(179, 20);
            this.txtNcmd.TabIndex = 8;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(415, 89);
            this.txtNom.Name = "txtNom";
            this.txtNom.ReadOnly = true;
            this.txtNom.Size = new System.Drawing.Size(156, 20);
            this.txtNom.TabIndex = 9;
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(415, 119);
            this.txtVille.Name = "txtVille";
            this.txtVille.ReadOnly = true;
            this.txtVille.Size = new System.Drawing.Size(156, 20);
            this.txtVille.TabIndex = 10;
            // 
            // txtDesiArt
            // 
            this.txtDesiArt.Location = new System.Drawing.Point(136, 160);
            this.txtDesiArt.Name = "txtDesiArt";
            this.txtDesiArt.ReadOnly = true;
            this.txtDesiArt.Size = new System.Drawing.Size(100, 20);
            this.txtDesiArt.TabIndex = 11;
            // 
            // txtPuArt
            // 
            this.txtPuArt.Location = new System.Drawing.Point(243, 160);
            this.txtPuArt.Name = "txtPuArt";
            this.txtPuArt.ReadOnly = true;
            this.txtPuArt.Size = new System.Drawing.Size(76, 20);
            this.txtPuArt.TabIndex = 12;
            // 
            // txtQteArt
            // 
            this.txtQteArt.Location = new System.Drawing.Point(325, 160);
            this.txtQteArt.Name = "txtQteArt";
            this.txtQteArt.Size = new System.Drawing.Size(104, 20);
            this.txtQteArt.TabIndex = 13;
            this.txtQteArt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQteArt_KeyPress);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(390, 326);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 14;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // cmbCodeClient
            // 
            this.cmbCodeClient.FormattingEnabled = true;
            this.cmbCodeClient.Location = new System.Drawing.Point(415, 63);
            this.cmbCodeClient.Name = "cmbCodeClient";
            this.cmbCodeClient.Size = new System.Drawing.Size(121, 21);
            this.cmbCodeClient.TabIndex = 16;
            this.cmbCodeClient.SelectedIndexChanged += new System.EventHandler(this.cmbCodeClient_SelectedIndexChanged);
            // 
            // cmbArticle
            // 
            this.cmbArticle.FormattingEnabled = true;
            this.cmbArticle.Location = new System.Drawing.Point(12, 160);
            this.cmbArticle.Name = "cmbArticle";
            this.cmbArticle.Size = new System.Drawing.Size(118, 21);
            this.cmbArticle.TabIndex = 17;
            this.cmbArticle.SelectedIndexChanged += new System.EventHandler(this.cmbArticle_SelectedIndexChanged);
            // 
            // btAjouterLigne
            // 
            this.btAjouterLigne.Location = new System.Drawing.Point(12, 324);
            this.btAjouterLigne.Name = "btAjouterLigne";
            this.btAjouterLigne.Size = new System.Drawing.Size(131, 23);
            this.btAjouterLigne.TabIndex = 18;
            this.btAjouterLigne.Text = "&Ajouter Ligne";
            this.btAjouterLigne.UseVisualStyleBackColor = true;
            this.btAjouterLigne.Click += new System.EventHandler(this.btAjouterLigne_Click);
            // 
            // btSupprLigne
            // 
            this.btSupprLigne.Location = new System.Drawing.Point(149, 324);
            this.btSupprLigne.Name = "btSupprLigne";
            this.btSupprLigne.Size = new System.Drawing.Size(131, 23);
            this.btSupprLigne.TabIndex = 19;
            this.btSupprLigne.Text = "&Supprimer Ligne";
            this.btSupprLigne.UseVisualStyleBackColor = true;
            this.btSupprLigne.Click += new System.EventHandler(this.btSupprLigne_Click);
            // 
            // btSaveCMD
            // 
            this.btSaveCMD.Location = new System.Drawing.Point(496, 187);
            this.btSaveCMD.Name = "btSaveCMD";
            this.btSaveCMD.Size = new System.Drawing.Size(131, 23);
            this.btSaveCMD.TabIndex = 20;
            this.btSaveCMD.Text = "&Enregistrer";
            this.btSaveCMD.UseVisualStyleBackColor = true;
            this.btSaveCMD.Click += new System.EventHandler(this.btSaveCMD_Click);
            // 
            // btQuitter
            // 
            this.btQuitter.Location = new System.Drawing.Point(496, 324);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(131, 23);
            this.btQuitter.TabIndex = 21;
            this.btQuitter.Text = "&Quitter";
            this.btQuitter.UseVisualStyleBackColor = true;
            this.btQuitter.Click += new System.EventHandler(this.btQuitter_Click);
            // 
            // dgvCMD
            // 
            this.dgvCMD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCMD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnCodeART,
            this.clnDesi,
            this.clnPU,
            this.clnQte,
            this.clnMontant});
            this.dgvCMD.Location = new System.Drawing.Point(12, 187);
            this.dgvCMD.Name = "dgvCMD";
            this.dgvCMD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCMD.Size = new System.Drawing.Size(478, 133);
            this.dgvCMD.TabIndex = 22;
            this.dgvCMD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvCMD_KeyPress);
            // 
            // clnCodeART
            // 
            this.clnCodeART.HeaderText = "Code Article";
            this.clnCodeART.Name = "clnCodeART";
            // 
            // clnDesi
            // 
            this.clnDesi.HeaderText = "Designation";
            this.clnDesi.Name = "clnDesi";
            // 
            // clnPU
            // 
            this.clnPU.HeaderText = "PU";
            this.clnPU.Name = "clnPU";
            this.clnPU.Width = 75;
            // 
            // clnQte
            // 
            this.clnQte.HeaderText = "Quantité";
            this.clnQte.Name = "clnQte";
            this.clnQte.Width = 60;
            // 
            // clnMontant
            // 
            this.clnMontant.HeaderText = "Montant";
            this.clnMontant.Name = "clnMontant";
            // 
            // dateCMD
            // 
            this.dateCMD.Location = new System.Drawing.Point(103, 90);
            this.dateCMD.Name = "dateCMD";
            this.dateCMD.Size = new System.Drawing.Size(179, 20);
            this.dateCMD.TabIndex = 23;
            // 
            // btPremier
            // 
            this.btPremier.Location = new System.Drawing.Point(15, 117);
            this.btPremier.Name = "btPremier";
            this.btPremier.Size = new System.Drawing.Size(33, 23);
            this.btPremier.TabIndex = 43;
            this.btPremier.Text = "<<";
            this.btPremier.UseVisualStyleBackColor = true;
            this.btPremier.Click += new System.EventHandler(this.btPremier_Click);
            // 
            // btPrecedent
            // 
            this.btPrecedent.Location = new System.Drawing.Point(96, 117);
            this.btPrecedent.Name = "btPrecedent";
            this.btPrecedent.Size = new System.Drawing.Size(33, 23);
            this.btPrecedent.TabIndex = 42;
            this.btPrecedent.Text = "<";
            this.btPrecedent.UseVisualStyleBackColor = true;
            this.btPrecedent.Click += new System.EventHandler(this.btPrecedent_Click);
            // 
            // btSuivant
            // 
            this.btSuivant.Location = new System.Drawing.Point(177, 117);
            this.btSuivant.Name = "btSuivant";
            this.btSuivant.Size = new System.Drawing.Size(33, 23);
            this.btSuivant.TabIndex = 41;
            this.btSuivant.Text = ">";
            this.btSuivant.UseVisualStyleBackColor = true;
            this.btSuivant.Click += new System.EventHandler(this.btSuivant_Click);
            // 
            // btDernier
            // 
            this.btDernier.Location = new System.Drawing.Point(258, 117);
            this.btDernier.Name = "btDernier";
            this.btDernier.Size = new System.Drawing.Size(33, 23);
            this.btDernier.TabIndex = 40;
            this.btDernier.Text = ">>";
            this.btDernier.UseVisualStyleBackColor = true;
            this.btDernier.Click += new System.EventHandler(this.btDernier_Click);
            // 
            // btChercher
            // 
            this.btChercher.Location = new System.Drawing.Point(496, 274);
            this.btChercher.Name = "btChercher";
            this.btChercher.Size = new System.Drawing.Size(131, 23);
            this.btChercher.TabIndex = 46;
            this.btChercher.Text = "&Chercher";
            this.btChercher.UseVisualStyleBackColor = true;
            // 
            // btSupprimer
            // 
            this.btSupprimer.Location = new System.Drawing.Point(496, 245);
            this.btSupprimer.Name = "btSupprimer";
            this.btSupprimer.Size = new System.Drawing.Size(131, 23);
            this.btSupprimer.TabIndex = 45;
            this.btSupprimer.Text = "&Supprimer";
            this.btSupprimer.UseVisualStyleBackColor = true;
            this.btSupprimer.Click += new System.EventHandler(this.btSupprimer_Click);
            // 
            // btModifier
            // 
            this.btModifier.Location = new System.Drawing.Point(496, 216);
            this.btModifier.Name = "btModifier";
            this.btModifier.Size = new System.Drawing.Size(131, 23);
            this.btModifier.TabIndex = 44;
            this.btModifier.Text = "&Modifier";
            this.btModifier.UseVisualStyleBackColor = true;
            // 
            // toolTip1
            // 
            this.toolTip1.ForeColor = System.Drawing.Color.Black;
            // 
            // GestionCMD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(630, 350);
            this.ControlBox = false;
            this.Controls.Add(this.btChercher);
            this.Controls.Add(this.btSupprimer);
            this.Controls.Add(this.btModifier);
            this.Controls.Add(this.btPremier);
            this.Controls.Add(this.btPrecedent);
            this.Controls.Add(this.btSuivant);
            this.Controls.Add(this.btDernier);
            this.Controls.Add(this.dateCMD);
            this.Controls.Add(this.dgvCMD);
            this.Controls.Add(this.btQuitter);
            this.Controls.Add(this.btSaveCMD);
            this.Controls.Add(this.btSupprLigne);
            this.Controls.Add(this.btAjouterLigne);
            this.Controls.Add(this.cmbArticle);
            this.Controls.Add(this.cmbCodeClient);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtQteArt);
            this.Controls.Add(this.txtPuArt);
            this.Controls.Add(this.txtDesiArt);
            this.Controls.Add(this.txtVille);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtNcmd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GestionCMD";
            this.Text = " Gestion des commandes";
            this.Load += new System.EventHandler(this.GestionCMD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCMD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNcmd;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.TextBox txtDesiArt;
        private System.Windows.Forms.TextBox txtPuArt;
        private System.Windows.Forms.TextBox txtQteArt;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.ComboBox cmbCodeClient;
        private System.Windows.Forms.ComboBox cmbArticle;
        private System.Windows.Forms.Button btAjouterLigne;
        private System.Windows.Forms.Button btSupprLigne;
        private System.Windows.Forms.Button btSaveCMD;
        private System.Windows.Forms.Button btQuitter;
        private System.Windows.Forms.DataGridView dgvCMD;
        private System.Windows.Forms.DateTimePicker dateCMD;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodeART;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDesi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPU;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnQte;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnMontant;
        private System.Windows.Forms.Button btPremier;
        private System.Windows.Forms.Button btPrecedent;
        private System.Windows.Forms.Button btSuivant;
        private System.Windows.Forms.Button btDernier;
        private System.Windows.Forms.Button btChercher;
        private System.Windows.Forms.Button btSupprimer;
        private System.Windows.Forms.Button btModifier;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}