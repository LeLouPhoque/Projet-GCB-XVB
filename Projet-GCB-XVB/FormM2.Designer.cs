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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.année = new System.Windows.Forms.CheckBox();
            this.moi = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BSmedecin = new System.Windows.Forms.BindingSource(this.components);
            this.allRapports = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.BSmedecin)).BeginInit();
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
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(159, 194);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(67, 17);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Medecin";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // année
            // 
            this.année.AutoSize = true;
            this.année.Location = new System.Drawing.Point(159, 229);
            this.année.Name = "année";
            this.année.Size = new System.Drawing.Size(57, 17);
            this.année.TabIndex = 3;
            this.année.Text = "Année";
            this.année.UseVisualStyleBackColor = true;
            // 
            // moi
            // 
            this.moi.AutoSize = true;
            this.moi.Location = new System.Drawing.Point(159, 266);
            this.moi.Name = "moi";
            this.moi.Size = new System.Drawing.Size(43, 17);
            this.moi.TabIndex = 4;
            this.moi.Text = "Moi";
            this.moi.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(245, 229);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(63, 20);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(245, 266);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(72, 20);
            this.dateTimePicker2.TabIndex = 7;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(245, 194);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // BSmedecin
            // 
            this.BSmedecin.AllowNew = true;
            // 
            // allRapports
            // 
            this.allRapports.AutoSize = true;
            this.allRapports.Location = new System.Drawing.Point(159, 94);
            this.allRapports.Name = "allRapports";
            this.allRapports.Size = new System.Drawing.Size(106, 17);
            this.allRapports.TabIndex = 9;
            this.allRapports.TabStop = true;
            this.allRapports.Text = "Tous les rapports";
            this.allRapports.UseVisualStyleBackColor = true;
            this.allRapports.CheckedChanged += new System.EventHandler(this.allRapports_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(550, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Suivant";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(159, 158);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(82, 17);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Personalisé ";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // FormM2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.allRapports);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.moi);
            this.Controls.Add(this.année);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.label1);
            this.Name = "FormM2";
            this.Text = "FormM2";
            this.Load += new System.EventHandler(this.FormM2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BSmedecin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox année;
        private System.Windows.Forms.CheckBox moi;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource BSmedecin;
        private System.Windows.Forms.RadioButton allRapports;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}