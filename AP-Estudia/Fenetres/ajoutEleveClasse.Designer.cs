namespace AP_estudia.Fenetres
{
    partial class AjouterEleve
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.listeEleve = new System.Windows.Forms.ComboBox();
            this.Eleve = new System.Windows.Forms.Label();
            this.Classee = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(1, 365);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(1113, 273);
            this.dataGridView.TabIndex = 0;
            // 
            // listeEleve
            // 
            this.listeEleve.FormattingEnabled = true;
            this.listeEleve.Location = new System.Drawing.Point(231, 162);
            this.listeEleve.Name = "listeEleve";
            this.listeEleve.Size = new System.Drawing.Size(121, 21);
            this.listeEleve.TabIndex = 1;
            this.Load += new System.EventHandler(this.listeEleve_Load);

            // 
            // Eleve
            // 
            this.Eleve.AutoSize = true;
            this.Eleve.Location = new System.Drawing.Point(115, 165);
            this.Eleve.Name = "Eleve";
            this.Eleve.Size = new System.Drawing.Size(100, 13);
            this.Eleve.TabIndex = 2;
            this.Eleve.Text = "Choissisez un élève";

            // 
            // Classee
            // 
            this.Classee.FormattingEnabled = true;
            this.Classee.Location = new System.Drawing.Point(231, 210);
            this.Classee.Name = "Classee";
            this.Classee.Size = new System.Drawing.Size(121, 21);
            this.Classee.TabIndex = 3;
            this.Load += new System.EventHandler(this.Classee_Load);

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choissisez une classe";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(118, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 45);
            this.button1.TabIndex = 5;
            this.button1.Text = "Valider l\'élève";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(384, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(380, 39);
            this.label2.TabIndex = 6;
            this.label2.Text = "Disposition des classes";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(838, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(234, 45);
            this.button2.TabIndex = 7;
            this.button2.Text = "Valider la classe";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AjouterEleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1115, 639);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Classee);
            this.Controls.Add(this.Eleve);
            this.Controls.Add(this.listeEleve);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AjouterEleve";
            this.Text = "Ajouter un Eleve";
            this.Load += new System.EventHandler(this.AjouterEleve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ComboBox listeEleve;
        private System.Windows.Forms.Label Eleve;
        private System.Windows.Forms.ComboBox Classee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}