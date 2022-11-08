namespace Projet_GCB_XVB
{
    partial class FInformationNominative
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bsInformationNominative = new System.Windows.Forms.BindingSource(this.components);
            this.txtPrenom = new System.Windows.Forms.RichTextBox();
            this.txtVille = new System.Windows.Forms.RichTextBox();
            this.txtRue = new System.Windows.Forms.RichTextBox();
            this.txtCP = new System.Windows.Forms.RichTextBox();
            this.txtNom = new System.Windows.Forms.RichTextBox();
            this.bsVisiteur = new System.Windows.Forms.BindingSource(this.components);
            this.btnOk = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsInformationNominative)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(455, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prénom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rue :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(455, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "CP :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ville :";
            // 
            // bsInformationNominative
            // 
            this.bsInformationNominative.CurrentChanged += new System.EventHandler(this.bsInformationNominative_CurrentChanged);
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(510, 72);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(143, 19);
            this.txtPrenom.TabIndex = 6;
            this.txtPrenom.Text = "";
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(154, 201);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(143, 19);
            this.txtVille.TabIndex = 8;
            this.txtVille.Text = "";
            // 
            // txtRue
            // 
            this.txtRue.Location = new System.Drawing.Point(155, 157);
            this.txtRue.Name = "txtRue";
            this.txtRue.Size = new System.Drawing.Size(273, 19);
            this.txtRue.TabIndex = 9;
            this.txtRue.Text = "";
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(510, 157);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(143, 19);
            this.txtCP.TabIndex = 10;
            this.txtCP.Text = "";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(154, 72);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(143, 19);
            this.txtNom.TabIndex = 11;
            this.txtNom.Text = "";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(421, 310);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(83, 23);
            this.btnOk.TabIndex = 12;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(260, 310);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(83, 23);
            this.btnModifier.TabIndex = 13;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FInformationNominative
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtCP);
            this.Controls.Add(this.txtRue);
            this.Controls.Add(this.txtVille);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FInformationNominative";
            this.Text = "FInformationNominative";
            this.Load += new System.EventHandler(this.FVisiteur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsInformationNominative)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource bsInformationNominative;
        private System.Windows.Forms.RichTextBox txtPrenom;
        private System.Windows.Forms.RichTextBox txtVille;
        private System.Windows.Forms.RichTextBox txtRue;
        private System.Windows.Forms.RichTextBox txtCP;
        private System.Windows.Forms.RichTextBox txtNom;
        private System.Windows.Forms.BindingSource bsVisiteur;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button button1;
    }
}