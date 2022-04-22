namespace AP_estudia.Fenetres
{
    partial class visuEdt
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
            this.Salle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Professeur = new System.Windows.Forms.ComboBox();
            this.Sallee = new System.Windows.Forms.ComboBox();
            this.Classee = new System.Windows.Forms.ComboBox();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.HoraireDebut = new System.Windows.Forms.TextBox();
            this.HoraireFin = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ValideCours = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.verifInsertion = new System.Windows.Forms.Label();
            this.matiereProf = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Professeur : ";
            // 
            // Salle
            // 
            this.Salle.AutoSize = true;
            this.Salle.Location = new System.Drawing.Point(167, 30);
            this.Salle.Name = "Salle";
            this.Salle.Size = new System.Drawing.Size(36, 13);
            this.Salle.TabIndex = 2;
            this.Salle.Text = "Salle :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Classe :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Matière :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Horaire de début :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(167, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Horaire de fin :";
            // 
            // Professeur
            // 
            this.Professeur.FormattingEnabled = true;
            this.Professeur.Location = new System.Drawing.Point(12, 59);
            this.Professeur.Name = "Professeur";
            this.Professeur.Size = new System.Drawing.Size(120, 21);
            this.Professeur.TabIndex = 8;
            this.Professeur.SelectedIndexChanged += new System.EventHandler(this.Professeur_SelectedIndexChanged);
            this.Load += new System.EventHandler(this.Professeur_Load);

            // 
            // Sallee
            // 
            this.Sallee.FormattingEnabled = true;
            this.Sallee.Location = new System.Drawing.Point(170, 59);
            this.Sallee.Name = "Sallee";
            this.Sallee.Size = new System.Drawing.Size(122, 21);
            this.Sallee.TabIndex = 9;
            this.Load += new System.EventHandler(this.Salle_Load);

            // 
            // Classee
            // 
            this.Classee.FormattingEnabled = true;
            this.Classee.Location = new System.Drawing.Point(12, 144);
            this.Classee.Name = "Classee";
            this.Classee.Size = new System.Drawing.Size(120, 21);
            this.Classee.TabIndex = 10;
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(12, 327);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(179, 20);
            this.Date.TabIndex = 11;
            // 
            // HoraireDebut
            // 
            this.HoraireDebut.Location = new System.Drawing.Point(12, 242);
            this.HoraireDebut.Name = "HoraireDebut";
            this.HoraireDebut.Size = new System.Drawing.Size(120, 20);
            this.HoraireDebut.TabIndex = 13;
            // 
            // HoraireFin
            // 
            this.HoraireFin.Location = new System.Drawing.Point(170, 242);
            this.HoraireFin.Name = "HoraireFin";
            this.HoraireFin.Size = new System.Drawing.Size(122, 20);
            this.HoraireFin.TabIndex = 14;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(371, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(724, 466);
            this.dataGridView.TabIndex = 15;
            // 
            // ValideCours
            // 
            this.ValideCours.Location = new System.Drawing.Point(12, 382);
            this.ValideCours.Name = "ValideCours";
            this.ValideCours.Size = new System.Drawing.Size(176, 23);
            this.ValideCours.TabIndex = 16;
            this.ValideCours.Text = "Valider le cours";
            this.ValideCours.UseVisualStyleBackColor = true;
            this.ValideCours.Click += new System.EventHandler(this.ValideCours_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(368, 535);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Valider les cours";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // verifInsertion
            // 
            this.verifInsertion.AutoSize = true;
            this.verifInsertion.Location = new System.Drawing.Point(365, 382);
            this.verifInsertion.Name = "verifInsertion";
            this.verifInsertion.Size = new System.Drawing.Size(0, 13);
            this.verifInsertion.TabIndex = 19;
            // 
            // matiereProf
            // 
            this.matiereProf.AutoSize = true;
            this.matiereProf.Location = new System.Drawing.Point(168, 147);
            this.matiereProf.Name = "matiereProf";
            this.matiereProf.Size = new System.Drawing.Size(35, 13);
            this.matiereProf.TabIndex = 20;
            this.matiereProf.Text = "label7";
            // 
            // visuEdt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 638);
            this.Controls.Add(this.matiereProf);
            this.Controls.Add(this.verifInsertion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ValideCours);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.HoraireFin);
            this.Controls.Add(this.HoraireDebut);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Classee);
            this.Controls.Add(this.Sallee);
            this.Controls.Add(this.Professeur);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Salle);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "visuEdt";
            this.Text = "visuEdt";
            this.Load += new System.EventHandler(this.Classee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Salle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Professeur;
        private System.Windows.Forms.ComboBox Sallee;
        private System.Windows.Forms.ComboBox Classee;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.TextBox HoraireDebut;
        private System.Windows.Forms.TextBox HoraireFin;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button ValideCours;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label verifInsertion;
        private System.Windows.Forms.Label matiereProf;
    }
}