
namespace AP_Estudia
{
    partial class login
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
            this.button1 = new System.Windows.Forms.Button();
            this.id_input = new System.Windows.Forms.TextBox();
            this.mdp_input = new System.Windows.Forms.TextBox();
            this.identifiant = new System.Windows.Forms.Label();
            this.mdp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(271, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // id_input
            // 
            this.id_input.Location = new System.Drawing.Point(65, 120);
            this.id_input.Name = "id_input";
            this.id_input.Size = new System.Drawing.Size(271, 20);
            this.id_input.TabIndex = 1;
            // 
            // mdp_input
            // 
            this.mdp_input.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mdp_input.Location = new System.Drawing.Point(65, 205);
            this.mdp_input.Name = "mdp_input";
            this.mdp_input.PasswordChar = '•';
            this.mdp_input.Size = new System.Drawing.Size(271, 20);
            this.mdp_input.TabIndex = 2;
            // 
            // identifiant
            // 
            this.identifiant.AutoSize = true;
            this.identifiant.Location = new System.Drawing.Point(62, 93);
            this.identifiant.Name = "identifiant";
            this.identifiant.Size = new System.Drawing.Size(53, 13);
            this.identifiant.TabIndex = 3;
            this.identifiant.Text = "Identifiant";
            // 
            // mdp
            // 
            this.mdp.AutoSize = true;
            this.mdp.Location = new System.Drawing.Point(68, 186);
            this.mdp.Name = "mdp";
            this.mdp.Size = new System.Drawing.Size(70, 13);
            this.mdp.TabIndex = 4;
            this.mdp.Text = "mot de passe";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(430, 598);
            this.Controls.Add(this.mdp);
            this.Controls.Add(this.identifiant);
            this.Controls.Add(this.mdp_input);
            this.Controls.Add(this.id_input);
            this.Controls.Add(this.button1);
            this.Name = "login";
            this.Text = "login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox id_input;
        private System.Windows.Forms.TextBox mdp_input;
        private System.Windows.Forms.Label identifiant;
        private System.Windows.Forms.Label mdp;
    }
}