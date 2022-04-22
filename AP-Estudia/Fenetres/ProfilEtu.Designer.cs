
namespace AP_estudia
{
    partial class ProfilEtu
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
            this.select_classe = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.eleveCBB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panelProfil = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // select_classe
            // 
            this.select_classe.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_classe.FormattingEnabled = true;
            this.select_classe.Location = new System.Drawing.Point(91, 141);
            this.select_classe.Name = "select_classe";
            this.select_classe.Size = new System.Drawing.Size(239, 31);
            this.select_classe.TabIndex = 0;
            this.select_classe.SelectionChangeCommitted += new System.EventHandler(this.select_classe_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label1.Location = new System.Drawing.Point(86, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Classe :";
            // 
            // eleveCBB
            // 
            this.eleveCBB.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eleveCBB.FormattingEnabled = true;
            this.eleveCBB.Location = new System.Drawing.Point(91, 263);
            this.eleveCBB.Name = "eleveCBB";
            this.eleveCBB.Size = new System.Drawing.Size(239, 31);
            this.eleveCBB.TabIndex = 2;
            this.eleveCBB.Visible = false;
            this.eleveCBB.SelectionChangeCommitted += new System.EventHandler(this.eleveCBB_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label2.Location = new System.Drawing.Point(95, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Eleve :";
            this.label2.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(91, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(365, 109);
            this.button1.TabIndex = 4;
            this.button1.Text = "Consulter le Profil ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelProfil
            // 
            this.panelProfil.BackColor = System.Drawing.Color.LightGray;
            this.panelProfil.Location = new System.Drawing.Point(497, 12);
            this.panelProfil.Name = "panelProfil";
            this.panelProfil.Size = new System.Drawing.Size(775, 622);
            this.panelProfil.TabIndex = 5;
            // 
            // ProfilEtu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1284, 678);
            this.Controls.Add(this.panelProfil);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.eleveCBB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.select_classe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProfilEtu";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.ProfilEtu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox select_classe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox eleveCBB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelProfil;
    }
}