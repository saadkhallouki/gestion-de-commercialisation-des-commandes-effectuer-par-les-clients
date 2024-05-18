namespace GestionCommercial
{
    partial class MAJclient
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MAJclient));
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodeClCher = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtCodeCl = new System.Windows.Forms.TextBox();
            this.btQuitter = new System.Windows.Forms.Button();
            this.btChercher = new System.Windows.Forms.Button();
            this.btSupprimer = new System.Windows.Forms.Button();
            this.btModifier = new System.Windows.Forms.Button();
            this.btAjouter = new System.Windows.Forms.Button();
            this.btPremier = new System.Windows.Forms.Button();
            this.btPrecedent = new System.Windows.Forms.Button();
            this.btSuivant = new System.Windows.Forms.Button();
            this.btDernier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(471, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Code Client";
            // 
            // txtCodeClCher
            // 
            this.txtCodeClCher.Location = new System.Drawing.Point(464, 91);
            this.txtCodeClCher.Name = "txtCodeClCher";
            this.txtCodeClCher.Size = new System.Drawing.Size(75, 20);
            this.txtCodeClCher.TabIndex = 34;
            this.txtCodeClCher.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodeClCher_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(124, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 31);
            this.label4.TabIndex = 33;
            this.label4.Text = "Mise a jour Client";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Ville";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Nom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Code client";
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(130, 121);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(215, 20);
            this.txtVille.TabIndex = 29;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(130, 95);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(215, 20);
            this.txtNom.TabIndex = 28;
            // 
            // txtCodeCl
            // 
            this.txtCodeCl.Location = new System.Drawing.Point(130, 66);
            this.txtCodeCl.Name = "txtCodeCl";
            this.txtCodeCl.Size = new System.Drawing.Size(215, 20);
            this.txtCodeCl.TabIndex = 27;
            // 
            // btQuitter
            // 
            this.btQuitter.Location = new System.Drawing.Point(474, 272);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(75, 33);
            this.btQuitter.TabIndex = 26;
            this.btQuitter.Text = "&Quitter";
            this.btQuitter.UseVisualStyleBackColor = true;
            this.btQuitter.Click += new System.EventHandler(this.btQuitter_Click);
            // 
            // btChercher
            // 
            this.btChercher.Location = new System.Drawing.Point(464, 114);
            this.btChercher.Name = "btChercher";
            this.btChercher.Size = new System.Drawing.Size(75, 23);
            this.btChercher.TabIndex = 25;
            this.btChercher.Text = "&Chercher";
            this.btChercher.UseVisualStyleBackColor = true;
            this.btChercher.Click += new System.EventHandler(this.btChercher_Click);
            // 
            // btSupprimer
            // 
            this.btSupprimer.Location = new System.Drawing.Point(294, 193);
            this.btSupprimer.Name = "btSupprimer";
            this.btSupprimer.Size = new System.Drawing.Size(127, 33);
            this.btSupprimer.TabIndex = 24;
            this.btSupprimer.Text = "&Supprimer";
            this.btSupprimer.UseVisualStyleBackColor = true;
            this.btSupprimer.Click += new System.EventHandler(this.btSupprimer_Click);
            // 
            // btModifier
            // 
            this.btModifier.Location = new System.Drawing.Point(161, 193);
            this.btModifier.Name = "btModifier";
            this.btModifier.Size = new System.Drawing.Size(127, 33);
            this.btModifier.TabIndex = 23;
            this.btModifier.Text = "&Modifier";
            this.btModifier.UseVisualStyleBackColor = true;
            this.btModifier.Click += new System.EventHandler(this.btModifier_Click);
            // 
            // btAjouter
            // 
            this.btAjouter.Location = new System.Drawing.Point(25, 193);
            this.btAjouter.Name = "btAjouter";
            this.btAjouter.Size = new System.Drawing.Size(127, 33);
            this.btAjouter.TabIndex = 22;
            this.btAjouter.Text = "&Ajouter";
            this.btAjouter.UseVisualStyleBackColor = true;
            this.btAjouter.Click += new System.EventHandler(this.btAjouter_Click);
            // 
            // btPremier
            // 
            this.btPremier.Location = new System.Drawing.Point(67, 243);
            this.btPremier.Name = "btPremier";
            this.btPremier.Size = new System.Drawing.Size(75, 35);
            this.btPremier.TabIndex = 21;
            this.btPremier.Text = "<<";
            this.btPremier.UseVisualStyleBackColor = true;
            this.btPremier.Click += new System.EventHandler(this.btPremier_Click);
            // 
            // btPrecedent
            // 
            this.btPrecedent.Location = new System.Drawing.Point(148, 243);
            this.btPrecedent.Name = "btPrecedent";
            this.btPrecedent.Size = new System.Drawing.Size(75, 35);
            this.btPrecedent.TabIndex = 20;
            this.btPrecedent.Text = "<";
            this.btPrecedent.UseVisualStyleBackColor = true;
            this.btPrecedent.Click += new System.EventHandler(this.btPrecedent_Click);
            // 
            // btSuivant
            // 
            this.btSuivant.Location = new System.Drawing.Point(229, 243);
            this.btSuivant.Name = "btSuivant";
            this.btSuivant.Size = new System.Drawing.Size(75, 35);
            this.btSuivant.TabIndex = 19;
            this.btSuivant.Text = ">";
            this.btSuivant.UseVisualStyleBackColor = true;
            this.btSuivant.Click += new System.EventHandler(this.btSuivant_Click);
            // 
            // btDernier
            // 
            this.btDernier.Location = new System.Drawing.Point(310, 243);
            this.btDernier.Name = "btDernier";
            this.btDernier.Size = new System.Drawing.Size(75, 35);
            this.btDernier.TabIndex = 18;
            this.btDernier.Text = ">>";
            this.btDernier.UseVisualStyleBackColor = true;
            this.btDernier.Click += new System.EventHandler(this.btDernier_Click);
            // 
            // MAJclient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(562, 309);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCodeClCher);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVille);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtCodeCl);
            this.Controls.Add(this.btQuitter);
            this.Controls.Add(this.btChercher);
            this.Controls.Add(this.btSupprimer);
            this.Controls.Add(this.btModifier);
            this.Controls.Add(this.btAjouter);
            this.Controls.Add(this.btPremier);
            this.Controls.Add(this.btPrecedent);
            this.Controls.Add(this.btSuivant);
            this.Controls.Add(this.btDernier);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MAJclient";
            this.Text = "Mise a jour Client";
            this.Load += new System.EventHandler(this.MAJclient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodeClCher;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtCodeCl;
        private System.Windows.Forms.Button btQuitter;
        private System.Windows.Forms.Button btChercher;
        private System.Windows.Forms.Button btSupprimer;
        private System.Windows.Forms.Button btModifier;
        private System.Windows.Forms.Button btAjouter;
        private System.Windows.Forms.Button btPremier;
        private System.Windows.Forms.Button btPrecedent;
        private System.Windows.Forms.Button btSuivant;
        private System.Windows.Forms.Button btDernier;
    }
}

