namespace GestionCommercial
{
    partial class MAJarticle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MAJarticle));
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodeArtCher = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPU = new System.Windows.Forms.TextBox();
            this.txtDesi = new System.Windows.Forms.TextBox();
            this.txtCodeArt = new System.Windows.Forms.TextBox();
            this.btQuitter = new System.Windows.Forms.Button();
            this.btChercher = new System.Windows.Forms.Button();
            this.btSupprimer = new System.Windows.Forms.Button();
            this.btModifier = new System.Windows.Forms.Button();
            this.btAjouter = new System.Windows.Forms.Button();
            this.btPremier = new System.Windows.Forms.Button();
            this.btPrecedent = new System.Windows.Forms.Button();
            this.btSuivant = new System.Windows.Forms.Button();
            this.btDernier = new System.Windows.Forms.Button();
            this.txtQte = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "Code Article";
            // 
            // txtCodeArtCher
            // 
            this.txtCodeArtCher.Location = new System.Drawing.Point(420, 190);
            this.txtCodeArtCher.Name = "txtCodeArtCher";
            this.txtCodeArtCher.Size = new System.Drawing.Size(78, 20);
            this.txtCodeArtCher.TabIndex = 52;
            this.txtCodeArtCher.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodeArtCher_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Thistle;
            this.label4.Location = new System.Drawing.Point(128, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 31);
            this.label4.TabIndex = 51;
            this.label4.Text = "Mise a jour Article";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Prix Unitaire";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Designation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Code article";
            // 
            // txtPU
            // 
            this.txtPU.Location = new System.Drawing.Point(153, 115);
            this.txtPU.Name = "txtPU";
            this.txtPU.Size = new System.Drawing.Size(181, 20);
            this.txtPU.TabIndex = 47;
            // 
            // txtDesi
            // 
            this.txtDesi.Location = new System.Drawing.Point(153, 89);
            this.txtDesi.Name = "txtDesi";
            this.txtDesi.Size = new System.Drawing.Size(181, 20);
            this.txtDesi.TabIndex = 46;
            // 
            // txtCodeArt
            // 
            this.txtCodeArt.Location = new System.Drawing.Point(153, 60);
            this.txtCodeArt.Name = "txtCodeArt";
            this.txtCodeArt.Size = new System.Drawing.Size(181, 20);
            this.txtCodeArt.TabIndex = 45;
            // 
            // btQuitter
            // 
            this.btQuitter.Location = new System.Drawing.Point(422, 248);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(75, 23);
            this.btQuitter.TabIndex = 44;
            this.btQuitter.Text = "&Quitter";
            this.btQuitter.UseVisualStyleBackColor = true;
            this.btQuitter.Click += new System.EventHandler(this.btQuitter_Click);
            // 
            // btChercher
            // 
            this.btChercher.Location = new System.Drawing.Point(422, 216);
            this.btChercher.Name = "btChercher";
            this.btChercher.Size = new System.Drawing.Size(75, 23);
            this.btChercher.TabIndex = 43;
            this.btChercher.Text = "&Chercher";
            this.btChercher.UseVisualStyleBackColor = true;
            this.btChercher.Click += new System.EventHandler(this.btChercher_Click);
            // 
            // btSupprimer
            // 
            this.btSupprimer.Location = new System.Drawing.Point(410, 118);
            this.btSupprimer.Name = "btSupprimer";
            this.btSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btSupprimer.TabIndex = 42;
            this.btSupprimer.Text = "&Supprimer";
            this.btSupprimer.UseVisualStyleBackColor = true;
            this.btSupprimer.Click += new System.EventHandler(this.btSupprimer_Click);
            // 
            // btModifier
            // 
            this.btModifier.Location = new System.Drawing.Point(410, 89);
            this.btModifier.Name = "btModifier";
            this.btModifier.Size = new System.Drawing.Size(75, 23);
            this.btModifier.TabIndex = 41;
            this.btModifier.Text = "&Modifier";
            this.btModifier.UseVisualStyleBackColor = true;
            this.btModifier.Click += new System.EventHandler(this.btModifier_Click);
            // 
            // btAjouter
            // 
            this.btAjouter.Location = new System.Drawing.Point(410, 60);
            this.btAjouter.Name = "btAjouter";
            this.btAjouter.Size = new System.Drawing.Size(75, 23);
            this.btAjouter.TabIndex = 40;
            this.btAjouter.Text = "&Ajouter";
            this.btAjouter.UseVisualStyleBackColor = true;
            this.btAjouter.Click += new System.EventHandler(this.btAjouter_Click);
            // 
            // btPremier
            // 
            this.btPremier.Location = new System.Drawing.Point(16, 174);
            this.btPremier.Name = "btPremier";
            this.btPremier.Size = new System.Drawing.Size(75, 23);
            this.btPremier.TabIndex = 39;
            this.btPremier.Text = "<<";
            this.btPremier.UseVisualStyleBackColor = true;
            this.btPremier.Click += new System.EventHandler(this.btPremier_Click);
            // 
            // btPrecedent
            // 
            this.btPrecedent.Location = new System.Drawing.Point(97, 174);
            this.btPrecedent.Name = "btPrecedent";
            this.btPrecedent.Size = new System.Drawing.Size(75, 23);
            this.btPrecedent.TabIndex = 38;
            this.btPrecedent.Text = "<";
            this.btPrecedent.UseVisualStyleBackColor = true;
            this.btPrecedent.Click += new System.EventHandler(this.btPrecedent_Click);
            // 
            // btSuivant
            // 
            this.btSuivant.Location = new System.Drawing.Point(178, 174);
            this.btSuivant.Name = "btSuivant";
            this.btSuivant.Size = new System.Drawing.Size(75, 23);
            this.btSuivant.TabIndex = 37;
            this.btSuivant.Text = ">";
            this.btSuivant.UseVisualStyleBackColor = true;
            this.btSuivant.Click += new System.EventHandler(this.btSuivant_Click);
            // 
            // btDernier
            // 
            this.btDernier.Location = new System.Drawing.Point(259, 174);
            this.btDernier.Name = "btDernier";
            this.btDernier.Size = new System.Drawing.Size(75, 23);
            this.btDernier.TabIndex = 36;
            this.btDernier.Text = ">>";
            this.btDernier.UseVisualStyleBackColor = true;
            this.btDernier.Click += new System.EventHandler(this.btDernier_Click);
            // 
            // txtQte
            // 
            this.txtQte.Location = new System.Drawing.Point(153, 141);
            this.txtQte.Name = "txtQte";
            this.txtQte.Size = new System.Drawing.Size(181, 20);
            this.txtQte.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Quantité";
            // 
            // MAJarticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(508, 279);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCodeArtCher);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQte);
            this.Controls.Add(this.txtPU);
            this.Controls.Add(this.txtDesi);
            this.Controls.Add(this.txtCodeArt);
            this.Controls.Add(this.btQuitter);
            this.Controls.Add(this.btChercher);
            this.Controls.Add(this.btSupprimer);
            this.Controls.Add(this.btModifier);
            this.Controls.Add(this.btAjouter);
            this.Controls.Add(this.btPremier);
            this.Controls.Add(this.btPrecedent);
            this.Controls.Add(this.btSuivant);
            this.Controls.Add(this.btDernier);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MAJarticle";
            this.Text = "Mise a jour Article";
            this.Load += new System.EventHandler(this.MAJarticle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodeArtCher;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPU;
        private System.Windows.Forms.TextBox txtDesi;
        private System.Windows.Forms.TextBox txtCodeArt;
        private System.Windows.Forms.Button btQuitter;
        private System.Windows.Forms.Button btChercher;
        private System.Windows.Forms.Button btSupprimer;
        private System.Windows.Forms.Button btModifier;
        private System.Windows.Forms.Button btAjouter;
        private System.Windows.Forms.Button btPremier;
        private System.Windows.Forms.Button btPrecedent;
        private System.Windows.Forms.Button btSuivant;
        private System.Windows.Forms.Button btDernier;
        private System.Windows.Forms.TextBox txtQte;
        private System.Windows.Forms.Label label6;
    }
}