
namespace AP_Estudia
{
    partial class Estudia
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.emploiDuTempsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesClassesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDuPersonnelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionEtablissementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // emploiDuTempsToolStripMenuItem
            // 
            this.emploiDuTempsToolStripMenuItem.AutoSize = false;
            this.emploiDuTempsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.emploiDuTempsToolStripMenuItem.Name = "emploiDuTempsToolStripMenuItem";
            this.emploiDuTempsToolStripMenuItem.Size = new System.Drawing.Size(250, 91);
            this.emploiDuTempsToolStripMenuItem.Text = "Emploi du temps";
            this.emploiDuTempsToolStripMenuItem.Click += new System.EventHandler(this.emploiDuTempsToolStripMenuItem_Click);
            // 
            // gestionDesClassesToolStripMenuItem
            // 
            this.gestionDesClassesToolStripMenuItem.AutoSize = false;
            this.gestionDesClassesToolStripMenuItem.Name = "gestionDesClassesToolStripMenuItem";
            this.gestionDesClassesToolStripMenuItem.Size = new System.Drawing.Size(250, 91);
            this.gestionDesClassesToolStripMenuItem.Text = "Gestion des classes";
            this.gestionDesClassesToolStripMenuItem.Click += new System.EventHandler(this.gestionDesClassesToolStripMenuItem_Click_1);
            // 
            // gestionDuPersonnelToolStripMenuItem
            // 
            this.gestionDuPersonnelToolStripMenuItem.AutoSize = false;
            this.gestionDuPersonnelToolStripMenuItem.Name = "gestionDuPersonnelToolStripMenuItem";
            this.gestionDuPersonnelToolStripMenuItem.Size = new System.Drawing.Size(250, 91);
            this.gestionDuPersonnelToolStripMenuItem.Text = "Gestion du personnel";
            this.gestionDuPersonnelToolStripMenuItem.Click += new System.EventHandler(this.gestionDuPersonnelToolStripMenuItem_Click);
            // 
            // gestionEtablissementToolStripMenuItem
            // 
            this.gestionEtablissementToolStripMenuItem.AutoSize = false;
            this.gestionEtablissementToolStripMenuItem.Name = "gestionEtablissementToolStripMenuItem";
            this.gestionEtablissementToolStripMenuItem.Size = new System.Drawing.Size(250, 91);
            this.gestionEtablissementToolStripMenuItem.Text = "Gestion Etablissement";
            this.gestionEtablissementToolStripMenuItem.Click += new System.EventHandler(this.gestionEtablissementToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.AutoSize = false;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(250, 91);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emploiDuTempsToolStripMenuItem,
            this.gestionDesClassesToolStripMenuItem,
            this.gestionDuPersonnelToolStripMenuItem,
            this.gestionEtablissementToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1280, 95);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 626);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // Estudia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1280, 721);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(934, 760);
            this.Name = "Estudia";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem emploiDuTempsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesClassesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDuPersonnelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionEtablissementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
    }
}

