
namespace AP_estudia.Fenetres
{
    partial class NoteForm
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
            this.prof = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.noteMax = new System.Windows.Forms.NumericUpDown();
            this.noteInput = new System.Windows.Forms.NumericUpDown();
            this.commentaire = new System.Windows.Forms.TextBox();
            this.designation = new System.Windows.Forms.TextBox();
            this.matiere = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.noteMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteInput)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Professeur :";
            // 
            // prof
            // 
            this.prof.AutoSize = true;
            this.prof.Location = new System.Drawing.Point(86, 31);
            this.prof.Name = "prof";
            this.prof.Size = new System.Drawing.Size(0, 13);
            this.prof.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Matière :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Note :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Note Max :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Commentaire :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Libelé :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(86, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "/";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(86, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "/";
            // 
            // noteMax
            // 
            this.noteMax.Location = new System.Drawing.Point(107, 188);
            this.noteMax.Name = "noteMax";
            this.noteMax.Size = new System.Drawing.Size(74, 20);
            this.noteMax.TabIndex = 10;
            // 
            // noteInput
            // 
            this.noteInput.Location = new System.Drawing.Point(26, 188);
            this.noteInput.Name = "noteInput";
            this.noteInput.Size = new System.Drawing.Size(54, 20);
            this.noteInput.TabIndex = 11;
            // 
            // commentaire
            // 
            this.commentaire.Location = new System.Drawing.Point(26, 264);
            this.commentaire.Name = "commentaire";
            this.commentaire.Size = new System.Drawing.Size(327, 20);
            this.commentaire.TabIndex = 12;
            // 
            // designation
            // 
            this.designation.Location = new System.Drawing.Point(26, 135);
            this.designation.Name = "designation";
            this.designation.Size = new System.Drawing.Size(327, 20);
            this.designation.TabIndex = 13;
            // 
            // matiere
            // 
            this.matiere.AutoSize = true;
            this.matiere.Location = new System.Drawing.Point(77, 76);
            this.matiere.Name = "matiere";
            this.matiere.Size = new System.Drawing.Size(0, 13);
            this.matiere.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Supprimer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(296, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Modifier";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // NoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(447, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.matiere);
            this.Controls.Add(this.designation);
            this.Controls.Add(this.commentaire);
            this.Controls.Add(this.noteInput);
            this.Controls.Add(this.noteMax);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.prof);
            this.Controls.Add(this.label1);
            this.Name = "NoteForm";
            this.Text = "NoteForm";
            ((System.ComponentModel.ISupportInitialize)(this.noteMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label prof;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown noteMax;
        private System.Windows.Forms.NumericUpDown noteInput;
        private System.Windows.Forms.TextBox commentaire;
        private System.Windows.Forms.TextBox designation;
        private System.Windows.Forms.Label matiere;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}