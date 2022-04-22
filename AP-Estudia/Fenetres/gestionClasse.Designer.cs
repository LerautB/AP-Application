namespace AP_estudia.Fenetres
{
    partial class gestionClasse
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ajoutEleve = new System.Windows.Forms.Button();
            this.gestClass = new System.Windows.Forms.Button();
            this.panelGestion = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.ajoutEleve);
            this.panel1.Controls.Add(this.gestClass);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 821);
            this.panel1.TabIndex = 12;
            // 
            // ajoutEleve
            // 
            this.ajoutEleve.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ajoutEleve.BackColor = System.Drawing.Color.White;
            this.ajoutEleve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ajoutEleve.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajoutEleve.Location = new System.Drawing.Point(0, 89);
            this.ajoutEleve.Name = "ajoutEleve";
            this.ajoutEleve.Size = new System.Drawing.Size(152, 57);
            this.ajoutEleve.TabIndex = 3;
            this.ajoutEleve.Text = "Ajout élève";
            this.ajoutEleve.UseVisualStyleBackColor = false;
            this.ajoutEleve.Click += new System.EventHandler(this.ajoutEleve_Click);
            // 
            // gestClass
            // 
            this.gestClass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gestClass.BackColor = System.Drawing.Color.White;
            this.gestClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gestClass.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestClass.Location = new System.Drawing.Point(0, 37);
            this.gestClass.Name = "gestClass";
            this.gestClass.Size = new System.Drawing.Size(152, 57);
            this.gestClass.TabIndex = 2;
            this.gestClass.Text = "Gestion des classes";
            this.gestClass.UseVisualStyleBackColor = false;
            this.gestClass.Click += new System.EventHandler(this.gestClass_Click);
            // 
            // panelGestion
            // 
            this.panelGestion.BackColor = System.Drawing.Color.LightGray;
            this.panelGestion.Location = new System.Drawing.Point(158, 12);
            this.panelGestion.Name = "panelGestion";
            this.panelGestion.Size = new System.Drawing.Size(1115, 639);
            this.panelGestion.TabIndex = 13;
            // 
            // gestionClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 820);
            this.Controls.Add(this.panelGestion);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "gestionClasse";
            this.Text = "gestionClasse";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ajoutEleve;
        private System.Windows.Forms.Button gestClass;
        private System.Windows.Forms.Panel panelGestion;
    }
}