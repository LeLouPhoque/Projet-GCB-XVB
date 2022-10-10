namespace Projet_GCB_XVB
{
    partial class FormM2
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rapport = new System.Windows.Forms.ToolStripMenuItem();
            this.visiteur = new System.Windows.Forms.ToolStripMenuItem();
            this.medicament = new System.Windows.Forms.ToolStripMenuItem();
            this.medecin = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(669, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Esteban Rautureau";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rapport,
            this.visiteur,
            this.medicament,
            this.medecin});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rapport
            // 
            this.rapport.Name = "rapport";
            this.rapport.Size = new System.Drawing.Size(133, 20);
            this.rapport.Text = "L’activité des visiteurs";
            this.rapport.Click += new System.EventHandler(this.medecinToolStripMenuItem_Click);
            // 
            // visiteur
            // 
            this.visiteur.Name = "visiteur";
            this.visiteur.Size = new System.Drawing.Size(138, 20);
            this.visiteur.Text = "Les Visiteurs Médicaux";
            this.visiteur.Click += new System.EventHandler(this.visiteurToolStripMenuItem_Click);
            // 
            // medicament
            // 
            this.medicament.Name = "medicament";
            this.medicament.Size = new System.Drawing.Size(111, 20);
            this.medicament.Text = "Les médicaments";
            this.medicament.Click += new System.EventHandler(this.medicament_Click);
            // 
            // medecin
            // 
            this.medecin.Name = "medecin";
            this.medecin.Size = new System.Drawing.Size(90, 20);
            this.medecin.Text = "Les médecins";
            this.medecin.Click += new System.EventHandler(this.medecin_Click);
            // 
            // FormM2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormM2";
            this.Text = "FormM2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rapport;
        private System.Windows.Forms.ToolStripMenuItem visiteur;
        private System.Windows.Forms.ToolStripMenuItem medicament;
        private System.Windows.Forms.ToolStripMenuItem medecin;
    }
}