namespace GestionCommercial
{
    partial class Gestion_Commercial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestion_Commercial));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.miseAJourClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miseAJourAricleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionCommandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultationDesCommandesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimmerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientParVilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miseAJourClientToolStripMenuItem,
            this.miseAJourAricleToolStripMenuItem,
            this.gestionCommandeToolStripMenuItem,
            this.consultationDesCommandesToolStripMenuItem,
            this.imprimmerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(761, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // miseAJourClientToolStripMenuItem
            // 
            this.miseAJourClientToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.miseAJourClientToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.miseAJourClientToolStripMenuItem.Name = "miseAJourClientToolStripMenuItem";
            this.miseAJourClientToolStripMenuItem.ShowShortcutKeys = false;
            this.miseAJourClientToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.miseAJourClientToolStripMenuItem.Text = "Mise a jour client";
            this.miseAJourClientToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.miseAJourClientToolStripMenuItem.Click += new System.EventHandler(this.miseAJourClientToolStripMenuItem_Click);
            // 
            // miseAJourAricleToolStripMenuItem
            // 
            this.miseAJourAricleToolStripMenuItem.Name = "miseAJourAricleToolStripMenuItem";
            this.miseAJourAricleToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.miseAJourAricleToolStripMenuItem.Text = "Mise a jour Aricle";
            this.miseAJourAricleToolStripMenuItem.Click += new System.EventHandler(this.miseAJourAricleToolStripMenuItem_Click);
            // 
            // gestionCommandeToolStripMenuItem
            // 
            this.gestionCommandeToolStripMenuItem.Name = "gestionCommandeToolStripMenuItem";
            this.gestionCommandeToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.gestionCommandeToolStripMenuItem.Text = "Gestion commande";
            this.gestionCommandeToolStripMenuItem.Click += new System.EventHandler(this.gestionCommandeToolStripMenuItem_Click);
            // 
            // consultationDesCommandesToolStripMenuItem
            // 
            this.consultationDesCommandesToolStripMenuItem.Name = "consultationDesCommandesToolStripMenuItem";
            this.consultationDesCommandesToolStripMenuItem.Size = new System.Drawing.Size(177, 20);
            this.consultationDesCommandesToolStripMenuItem.Text = "Consultation des commandes";
            this.consultationDesCommandesToolStripMenuItem.Click += new System.EventHandler(this.consultationDesCommandesToolStripMenuItem_Click);
            // 
            // imprimmerToolStripMenuItem
            // 
            this.imprimmerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientParVilleToolStripMenuItem});
            this.imprimmerToolStripMenuItem.Name = "imprimmerToolStripMenuItem";
            this.imprimmerToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.imprimmerToolStripMenuItem.Text = "Imprimer";
            // 
            // clientParVilleToolStripMenuItem
            // 
            this.clientParVilleToolStripMenuItem.Name = "clientParVilleToolStripMenuItem";
            this.clientParVilleToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.clientParVilleToolStripMenuItem.Text = "Client Par Ville";
            this.clientParVilleToolStripMenuItem.Click += new System.EventHandler(this.clientParVilleToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(761, 413);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 387);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // Gestion_Commercial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 437);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Gestion_Commercial";
            this.Text = "Gestion_Commercial";
            this.Load += new System.EventHandler(this.Gestion_Commercial_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miseAJourClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionCommandeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultationDesCommandesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miseAJourAricleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimmerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientParVilleToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}