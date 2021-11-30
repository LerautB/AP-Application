
namespace AP_Estudia.Fenetres
{
    partial class CreationPersonnel
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
            this.nom = new System.Windows.Forms.TextBox();
            this.prenom = new System.Windows.Forms.MaskedTextBox();
            this.mail = new System.Windows.Forms.MaskedTextBox();
            this.poste = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.matiere = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nom
            // 
            this.nom.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.nom.Location = new System.Drawing.Point(31, 101);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(182, 27);
            this.nom.TabIndex = 0;
            // 
            // prenom
            // 
            this.prenom.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.prenom.Location = new System.Drawing.Point(299, 101);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(182, 27);
            this.prenom.TabIndex = 1;
            // 
            // mail
            // 
            this.mail.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.mail.Location = new System.Drawing.Point(29, 205);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(182, 27);
            this.mail.TabIndex = 2;
            // 
            // poste
            // 
            this.poste.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poste.FormattingEnabled = true;
            this.poste.Items.AddRange(new object[] {
            "Professeur",
            "Administration"});
            this.poste.Location = new System.Drawing.Point(299, 204);
            this.poste.Name = "poste";
            this.poste.Size = new System.Drawing.Size(182, 28);
            this.poste.TabIndex = 3;
            this.poste.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Poste";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Adresse mail (facultatif)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(295, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Prénom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nom";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(31, 302);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(182, 20);
            this.date.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.button1.Location = new System.Drawing.Point(442, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // matiere
            // 
            this.matiere.FormattingEnabled = true;
            this.matiere.Location = new System.Drawing.Point(299, 301);
            this.matiere.Name = "matiere";
            this.matiere.Size = new System.Drawing.Size(182, 21);
            this.matiere.TabIndex = 10;
            this.matiere.Visible = false;
            this.matiere.SelectedIndexChanged += new System.EventHandler(this.matiere_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(12, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(404, 77);
            this.label5.TabIndex = 11;
            this.label5.Text = "label5";
            // 
            // CreationPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(543, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.matiere);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.poste);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.nom);
            this.Name = "CreationPersonnel";
            this.Text = "CreationPersonnel";
            this.Load += new System.EventHandler(this.CreationPersonnel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.MaskedTextBox prenom;
        private System.Windows.Forms.MaskedTextBox mail;
        private System.Windows.Forms.ComboBox poste;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox matiere;
        private System.Windows.Forms.Label label5;
    }
}