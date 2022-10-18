namespace Projet_GCB_XVB
{
    partial class FormMenu
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
            this.btnMission1 = new System.Windows.Forms.Button();
            this.btnMission2 = new System.Windows.Forms.Button();
            this.btnMission3 = new System.Windows.Forms.Button();
            this.btnNotExit = new System.Windows.Forms.Button();
            this.btnNotExist = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMission1
            // 
            this.btnMission1.Location = new System.Drawing.Point(75, 165);
            this.btnMission1.Name = "btnMission1";
            this.btnMission1.Size = new System.Drawing.Size(186, 105);
            this.btnMission1.TabIndex = 1;
            this.btnMission1.Text = "Mission 1";
            this.btnMission1.UseVisualStyleBackColor = true;
            this.btnMission1.Click += new System.EventHandler(this.btnMission1_Click);
            // 
            // btnMission2
            // 
            this.btnMission2.Location = new System.Drawing.Point(305, 165);
            this.btnMission2.Name = "btnMission2";
            this.btnMission2.Size = new System.Drawing.Size(186, 105);
            this.btnMission2.TabIndex = 2;
            this.btnMission2.Text = "Mission 2";
            this.btnMission2.UseVisualStyleBackColor = true;
            this.btnMission2.Click += new System.EventHandler(this.btnMission2_Click);
            // 
            // btnMission3
            // 
            this.btnMission3.Location = new System.Drawing.Point(526, 165);
            this.btnMission3.Name = "btnMission3";
            this.btnMission3.Size = new System.Drawing.Size(186, 105);
            this.btnMission3.TabIndex = 3;
            this.btnMission3.Text = "Mission 3";
            this.btnMission3.UseVisualStyleBackColor = true;
            this.btnMission3.Click += new System.EventHandler(this.btnMission3_Click);
            // 
            // btnNotExit
            // 
            this.btnNotExit.BackColor = System.Drawing.Color.Red;
            this.btnNotExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNotExit.Location = new System.Drawing.Point(201, 302);
            this.btnNotExit.Name = "btnNotExit";
            this.btnNotExit.Size = new System.Drawing.Size(396, 77);
            this.btnNotExit.TabIndex = 4;
            this.btnNotExit.Text = "Quitter";
            this.btnNotExit.UseVisualStyleBackColor = false;
            this.btnNotExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnNotExist
            // 
            this.btnNotExist.BackColor = System.Drawing.Color.Red;
            this.btnNotExist.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotExist.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNotExist.Location = new System.Drawing.Point(201, 37);
            this.btnNotExist.Name = "btnNotExist";
            this.btnNotExist.Size = new System.Drawing.Size(396, 77);
            this.btnNotExist.TabIndex = 5;
            this.btnNotExist.Text = "Ne pas Quitter";
            this.btnNotExist.UseVisualStyleBackColor = false;
            this.btnNotExist.Click += new System.EventHandler(this.btnNotExist_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNotExist);
            this.Controls.Add(this.btnNotExit);
            this.Controls.Add(this.btnMission3);
            this.Controls.Add(this.btnMission2);
            this.Controls.Add(this.btnMission1);
            this.Name = "FormMenu";
            this.Text = "FormMENU";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMission1;
        private System.Windows.Forms.Button btnMission2;
        private System.Windows.Forms.Button btnMission3;
        private System.Windows.Forms.Button btnNotExit;
        private System.Windows.Forms.Button btnNotExist;
    }
}