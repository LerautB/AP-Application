
namespace AP_estudia
{
    partial class Gestion_personnel
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
            this.inscription_personnel = new System.Windows.Forms.Button();
            this.liste_administration = new System.Windows.Forms.Button();
            this.liste_enseignants = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelGestionPersonnel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inscription_personnel
            // 
            this.inscription_personnel.Location = new System.Drawing.Point(4, 10);
            this.inscription_personnel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inscription_personnel.Name = "inscription_personnel";
            this.inscription_personnel.Size = new System.Drawing.Size(146, 56);
            this.inscription_personnel.TabIndex = 0;
            this.inscription_personnel.Text = "Ajoutez personnel";
            this.inscription_personnel.UseVisualStyleBackColor = true;
            this.inscription_personnel.Click += new System.EventHandler(this.button1_Click);
            // 
            // liste_administration
            // 
            this.liste_administration.Location = new System.Drawing.Point(4, 128);
            this.liste_administration.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.liste_administration.Name = "liste_administration";
            this.liste_administration.Size = new System.Drawing.Size(146, 56);
            this.liste_administration.TabIndex = 1;
            this.liste_administration.Text = "Liste du personnel Administratif";
            this.liste_administration.UseVisualStyleBackColor = true;
            this.liste_administration.Click += new System.EventHandler(this.listePersonnel_Click);
            // 
            // liste_enseignants
            // 
            this.liste_enseignants.Location = new System.Drawing.Point(4, 69);
            this.liste_enseignants.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.liste_enseignants.Name = "liste_enseignants";
            this.liste_enseignants.Size = new System.Drawing.Size(146, 56);
            this.liste_enseignants.TabIndex = 2;
            this.liste_enseignants.Text = "Liste des Enseignants";
            this.liste_enseignants.UseVisualStyleBackColor = true;
            this.liste_enseignants.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.inscription_personnel);
            this.panel1.Controls.Add(this.liste_administration);
            this.panel1.Controls.Add(this.liste_enseignants);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 677);
            this.panel1.TabIndex = 3;
            // 
            // panelGestionPersonnel
            // 
            this.panelGestionPersonnel.BackColor = System.Drawing.Color.LightGray;
            this.panelGestionPersonnel.Location = new System.Drawing.Point(158, 9);
            this.panelGestionPersonnel.Name = "panelGestionPersonnel";
            this.panelGestionPersonnel.Size = new System.Drawing.Size(1120, 637);
            this.panelGestionPersonnel.TabIndex = 4;
            // 
            // Gestion_personnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1290, 675);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelGestionPersonnel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Gestion_personnel";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button inscription_personnel;
        private System.Windows.Forms.Button liste_administration;
        private System.Windows.Forms.Button liste_enseignants;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelGestionPersonnel;
    }
}