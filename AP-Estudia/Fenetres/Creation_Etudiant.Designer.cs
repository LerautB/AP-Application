
namespace AP_estudia.Fenetres
{
    partial class Creation_Etudiant
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.prenom = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.mail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.vailder = new System.Windows.Forms.Button();
            this.l2 = new System.Windows.Forms.Label();
            this.niveau = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.filiere = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nom
            // 
            this.nom.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom.Location = new System.Drawing.Point(42, 119);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(252, 27);
            this.nom.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(352, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prénom";
            // 
            // prenom
            // 
            this.prenom.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenom.Location = new System.Drawing.Point(356, 119);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(252, 27);
            this.prenom.TabIndex = 3;
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(42, 223);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(252, 27);
            this.date.TabIndex = 4;
            // 
            // mail
            // 
            this.mail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mail.Location = new System.Drawing.Point(677, 119);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(252, 27);
            this.mail.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(673, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Adresse mail ( Facultative )";
            // 
            // vailder
            // 
            this.vailder.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vailder.Location = new System.Drawing.Point(42, 323);
            this.vailder.Name = "vailder";
            this.vailder.Size = new System.Drawing.Size(87, 53);
            this.vailder.TabIndex = 7;
            this.vailder.Text = "Valider";
            this.vailder.UseVisualStyleBackColor = true;
            this.vailder.Click += new System.EventHandler(this.valider_Click);
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2.Location = new System.Drawing.Point(352, 188);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(49, 20);
            this.l2.TabIndex = 9;
            this.l2.Text = "Filière";
            // 
            // niveau
            // 
            this.niveau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.niveau.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.niveau.FormattingEnabled = true;
            this.niveau.Location = new System.Drawing.Point(677, 222);
            this.niveau.Name = "niveau";
            this.niveau.Size = new System.Drawing.Size(252, 28);
            this.niveau.TabIndex = 10;
            this.niveau.Visible = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(256, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(543, 77);
            this.label5.TabIndex = 12;
            // 
            // filiere
            // 
            this.filiere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filiere.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filiere.FormattingEnabled = true;
            this.filiere.Location = new System.Drawing.Point(356, 222);
            this.filiere.Name = "filiere";
            this.filiere.Size = new System.Drawing.Size(252, 28);
            this.filiere.TabIndex = 8;
            this.filiere.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(411, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 32);
            this.label4.TabIndex = 13;
            this.label4.Text = "Création d\'un étudiant";
            // 
            // Creation_Etudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1095, 632);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.niveau);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.filiere);
            this.Controls.Add(this.vailder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.date);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Creation_Etudiant";
            this.Text = "Creation_Etudiant";
            this.Load += new System.EventHandler(this.Creation_Etudiant_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox prenom;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button vailder;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.ComboBox niveau;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox filiere;
        private System.Windows.Forms.Label label4;
    }
}