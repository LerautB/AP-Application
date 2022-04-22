
namespace AP_estudia.Fenetres
{
    partial class Profil
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nomEtu = new System.Windows.Forms.Label();
            this.prenomEtu = new System.Windows.Forms.Label();
            this.filiereEtu = new System.Windows.Forms.Label();
            this.classeEtu = new System.Windows.Forms.Label();
            this.notes = new System.Windows.Forms.Button();
            this.absences = new System.Windows.Forms.Button();
            this.retards = new System.Windows.Forms.Button();
            this.punitions = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(187, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prénom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Filière :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Classe :";
            // 
            // nomEtu
            // 
            this.nomEtu.AutoSize = true;
            this.nomEtu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomEtu.Location = new System.Drawing.Point(86, 83);
            this.nomEtu.Name = "nomEtu";
            this.nomEtu.Size = new System.Drawing.Size(52, 21);
            this.nomEtu.TabIndex = 4;
            this.nomEtu.Text = "label5";
            // 
            // prenomEtu
            // 
            this.prenomEtu.AutoSize = true;
            this.prenomEtu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenomEtu.Location = new System.Drawing.Point(260, 85);
            this.prenomEtu.Name = "prenomEtu";
            this.prenomEtu.Size = new System.Drawing.Size(52, 21);
            this.prenomEtu.TabIndex = 5;
            this.prenomEtu.Text = "label6";
            // 
            // filiereEtu
            // 
            this.filiereEtu.AutoSize = true;
            this.filiereEtu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filiereEtu.Location = new System.Drawing.Point(94, 139);
            this.filiereEtu.Name = "filiereEtu";
            this.filiereEtu.Size = new System.Drawing.Size(52, 21);
            this.filiereEtu.TabIndex = 6;
            this.filiereEtu.Text = "label7";
            // 
            // classeEtu
            // 
            this.classeEtu.AutoSize = true;
            this.classeEtu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classeEtu.Location = new System.Drawing.Point(97, 190);
            this.classeEtu.Name = "classeEtu";
            this.classeEtu.Size = new System.Drawing.Size(52, 21);
            this.classeEtu.TabIndex = 7;
            this.classeEtu.Text = "label8";
            // 
            // notes
            // 
            this.notes.Location = new System.Drawing.Point(51, 262);
            this.notes.Name = "notes";
            this.notes.Size = new System.Drawing.Size(149, 33);
            this.notes.TabIndex = 8;
            this.notes.Text = "Notes";
            this.notes.UseVisualStyleBackColor = true;
            this.notes.Click += new System.EventHandler(this.notes_Click);
            // 
            // absences
            // 
            this.absences.Location = new System.Drawing.Point(237, 262);
            this.absences.Name = "absences";
            this.absences.Size = new System.Drawing.Size(149, 33);
            this.absences.TabIndex = 9;
            this.absences.Text = "Absence";
            this.absences.UseVisualStyleBackColor = true;
            this.absences.Click += new System.EventHandler(this.absences_Click);
            // 
            // retards
            // 
            this.retards.Location = new System.Drawing.Point(420, 262);
            this.retards.Name = "retards";
            this.retards.Size = new System.Drawing.Size(149, 33);
            this.retards.TabIndex = 10;
            this.retards.Text = "Retard";
            this.retards.UseVisualStyleBackColor = true;
            this.retards.Click += new System.EventHandler(this.retards_Click);
            // 
            // punitions
            // 
            this.punitions.Location = new System.Drawing.Point(597, 262);
            this.punitions.Name = "punitions";
            this.punitions.Size = new System.Drawing.Size(149, 33);
            this.punitions.TabIndex = 11;
            this.punitions.Text = "Sanction disciplinaire";
            this.punitions.UseVisualStyleBackColor = true;
            this.punitions.Click += new System.EventHandler(this.punitions_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 315);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(751, 289);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // Profil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(775, 632);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.punitions);
            this.Controls.Add(this.retards);
            this.Controls.Add(this.absences);
            this.Controls.Add(this.notes);
            this.Controls.Add(this.classeEtu);
            this.Controls.Add(this.filiereEtu);
            this.Controls.Add(this.prenomEtu);
            this.Controls.Add(this.nomEtu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Profil";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label nomEtu;
        private System.Windows.Forms.Label prenomEtu;
        private System.Windows.Forms.Label filiereEtu;
        private System.Windows.Forms.Label classeEtu;
        private System.Windows.Forms.Button notes;
        private System.Windows.Forms.Button absences;
        private System.Windows.Forms.Button retards;
        private System.Windows.Forms.Button punitions;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}