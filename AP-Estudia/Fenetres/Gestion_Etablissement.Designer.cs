
namespace AP_estudia
{
    partial class Gestion_Etablissement
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
            this.inscription_etu = new System.Windows.Forms.Button();
            this.gestion_etu = new System.Windows.Forms.Button();
            this.gestion_filieres = new System.Windows.Forms.Button();
            this.gestion_salles = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelGestionEta = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inscription_etu
            // 
            this.inscription_etu.Location = new System.Drawing.Point(3, 3);
            this.inscription_etu.Name = "inscription_etu";
            this.inscription_etu.Size = new System.Drawing.Size(147, 52);
            this.inscription_etu.TabIndex = 0;
            this.inscription_etu.Text = "Inscription Etudiant";
            this.inscription_etu.UseVisualStyleBackColor = true;
            this.inscription_etu.Click += new System.EventHandler(this.button1_Click);
            // 
            // gestion_etu
            // 
            this.gestion_etu.Location = new System.Drawing.Point(3, 61);
            this.gestion_etu.Name = "gestion_etu";
            this.gestion_etu.Size = new System.Drawing.Size(147, 52);
            this.gestion_etu.TabIndex = 1;
            this.gestion_etu.Text = "Gestion Etudiants";
            this.gestion_etu.UseVisualStyleBackColor = true;
            this.gestion_etu.Click += new System.EventHandler(this.button2_Click);
            // 
            // gestion_filieres
            // 
            this.gestion_filieres.Location = new System.Drawing.Point(3, 119);
            this.gestion_filieres.Name = "gestion_filieres";
            this.gestion_filieres.Size = new System.Drawing.Size(147, 52);
            this.gestion_filieres.TabIndex = 2;
            this.gestion_filieres.Text = "Gestion des Filieres";
            this.gestion_filieres.UseVisualStyleBackColor = true;
            this.gestion_filieres.Click += new System.EventHandler(this.button3_Click);
            // 
            // gestion_salles
            // 
            this.gestion_salles.Location = new System.Drawing.Point(3, 177);
            this.gestion_salles.Name = "gestion_salles";
            this.gestion_salles.Size = new System.Drawing.Size(147, 52);
            this.gestion_salles.TabIndex = 3;
            this.gestion_salles.Text = "Gestion des salles";
            this.gestion_salles.UseVisualStyleBackColor = true;
            this.gestion_salles.Click += new System.EventHandler(this.button4_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.flowLayoutPanel1.Controls.Add(this.inscription_etu);
            this.flowLayoutPanel1.Controls.Add(this.gestion_etu);
            this.flowLayoutPanel1.Controls.Add(this.gestion_filieres);
            this.flowLayoutPanel1.Controls.Add(this.gestion_salles);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, -1);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(154, 665);
            this.flowLayoutPanel1.TabIndex = 4;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // panelGestionEta
            // 
            this.panelGestionEta.BackColor = System.Drawing.Color.LightGray;
            this.panelGestionEta.Location = new System.Drawing.Point(169, 12);
            this.panelGestionEta.Name = "panelGestionEta";
            this.panelGestionEta.Size = new System.Drawing.Size(1095, 632);
            this.panelGestionEta.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 52);
            this.button1.TabIndex = 4;
            this.button1.Text = "Gestion des matières";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Gestion_Etablissement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1284, 660);
            this.Controls.Add(this.panelGestionEta);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Gestion_Etablissement";
            this.Text = "Gestion_Etablissement";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button inscription_etu;
        private System.Windows.Forms.Button gestion_etu;
        private System.Windows.Forms.Button gestion_filieres;
        private System.Windows.Forms.Button gestion_salles;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelGestionEta;
        private System.Windows.Forms.Button button1;
    }
}