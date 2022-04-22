
namespace AP_estudia
{
    partial class Gestion_Enseignants
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.nomEnseignant = new System.Windows.Forms.TextBox();
            this.prenomEnseignant = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Supression = new System.Windows.Forms.Button();
            this.Modif = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.matiereEnseignant = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.emailEnseignants = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom : ";
            // 
            // nomEnseignant
            // 
            this.nomEnseignant.Location = new System.Drawing.Point(82, 91);
            this.nomEnseignant.Margin = new System.Windows.Forms.Padding(4);
            this.nomEnseignant.Name = "nomEnseignant";
            this.nomEnseignant.Size = new System.Drawing.Size(132, 25);
            this.nomEnseignant.TabIndex = 2;
            // 
            // prenomEnseignant
            // 
            this.prenomEnseignant.Location = new System.Drawing.Point(320, 91);
            this.prenomEnseignant.Margin = new System.Windows.Forms.Padding(4);
            this.prenomEnseignant.Name = "prenomEnseignant";
            this.prenomEnseignant.Size = new System.Drawing.Size(132, 25);
            this.prenomEnseignant.TabIndex = 3;
            // 
            // dataGridView
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.ColumnHeadersHeight = 50;
            this.dataGridView.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.GridColor = System.Drawing.Color.White;
            this.dataGridView.Location = new System.Drawing.Point(46, 223);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(988, 354);
            this.dataGridView.TabIndex = 7;
            this.dataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseDoubleClick);
            // 
            // Supression
            // 
            this.Supression.Location = new System.Drawing.Point(329, 164);
            this.Supression.Margin = new System.Windows.Forms.Padding(4);
            this.Supression.Name = "Supression";
            this.Supression.Size = new System.Drawing.Size(100, 30);
            this.Supression.TabIndex = 8;
            this.Supression.Text = "Supression";
            this.Supression.UseVisualStyleBackColor = true;
            this.Supression.Click += new System.EventHandler(this.Supression_Click);
            // 
            // Modif
            // 
            this.Modif.Location = new System.Drawing.Point(532, 164);
            this.Modif.Margin = new System.Windows.Forms.Padding(4);
            this.Modif.Name = "Modif";
            this.Modif.Size = new System.Drawing.Size(100, 30);
            this.Modif.TabIndex = 9;
            this.Modif.Text = "Modification";
            this.Modif.UseVisualStyleBackColor = true;
            this.Modif.Click += new System.EventHandler(this.Modif_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Prenom : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(324, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 30);
            this.label3.TabIndex = 10;
            this.label3.Text = "Gestion des Enseignants";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // matiereEnseignant
            // 
            this.matiereEnseignant.FormattingEnabled = true;
            this.matiereEnseignant.Location = new System.Drawing.Point(580, 91);
            this.matiereEnseignant.Name = "matiereEnseignant";
            this.matiereEnseignant.Size = new System.Drawing.Size(132, 25);
            this.matiereEnseignant.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(500, 99);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Matiere :";
            // 
            // emailEnseignants
            // 
            this.emailEnseignants.Location = new System.Drawing.Point(860, 94);
            this.emailEnseignants.Margin = new System.Windows.Forms.Padding(4);
            this.emailEnseignants.Name = "emailEnseignants";
            this.emailEnseignants.Size = new System.Drawing.Size(132, 25);
            this.emailEnseignants.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(756, 99);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Adresse Mail : ";
            // 
            // Gestion_Enseignants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1276, 667);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.emailEnseignants);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.matiereEnseignant);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Modif);
            this.Controls.Add(this.Supression);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prenomEnseignant);
            this.Controls.Add(this.nomEnseignant);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Gestion_Enseignants";
            this.Text = "Gestion_Classes";
            this.Load += new System.EventHandler(this.Gestion_Classes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nomEnseignant;
        private System.Windows.Forms.TextBox prenomEnseignant;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button Supression;
        private System.Windows.Forms.Button Modif;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox matiereEnseignant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox emailEnseignants;
        private System.Windows.Forms.Label label5;
    }
}