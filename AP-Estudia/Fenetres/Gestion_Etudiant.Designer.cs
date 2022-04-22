
namespace AP_estudia
{
    partial class Gestion_Etudiant
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.nomEtu = new System.Windows.Forms.TextBox();
            this.prenomEtu = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Supression = new System.Windows.Forms.Button();
            this.Modif = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.emailEtu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.suppr_filter = new System.Windows.Forms.Label();
            this.ClasseEtu = new System.Windows.Forms.ComboBox();
            this.filiereEtu = new System.Windows.Forms.ComboBox();
            this.etudeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etudeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom : ";
            // 
            // nomEtu
            // 
            this.nomEtu.Location = new System.Drawing.Point(107, 112);
            this.nomEtu.Margin = new System.Windows.Forms.Padding(4);
            this.nomEtu.Name = "nomEtu";
            this.nomEtu.Size = new System.Drawing.Size(163, 25);
            this.nomEtu.TabIndex = 2;
            // 
            // prenomEtu
            // 
            this.prenomEtu.Location = new System.Drawing.Point(107, 167);
            this.prenomEtu.Margin = new System.Windows.Forms.Padding(4);
            this.prenomEtu.Name = "prenomEtu";
            this.prenomEtu.Size = new System.Drawing.Size(163, 25);
            this.prenomEtu.TabIndex = 3;
            // 
            // dataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeight = 50;
            this.dataGridView.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.GridColor = System.Drawing.Color.White;
            this.dataGridView.Location = new System.Drawing.Point(348, 112);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(734, 468);
            this.dataGridView.TabIndex = 7;
            this.dataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseDoubleClick);
            // 
            // Supression
            // 
            this.Supression.Location = new System.Drawing.Point(196, 492);
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
            this.Modif.Location = new System.Drawing.Point(37, 492);
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
            this.label1.Location = new System.Drawing.Point(13, 170);
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
            this.label3.Location = new System.Drawing.Point(343, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 30);
            this.label3.TabIndex = 10;
            this.label3.Text = "Gestion des Etudiants";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 379);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Filière :";
            // 
            // emailEtu
            // 
            this.emailEtu.Location = new System.Drawing.Point(107, 220);
            this.emailEtu.Margin = new System.Windows.Forms.Padding(4);
            this.emailEtu.Name = "emailEtu";
            this.emailEtu.Size = new System.Drawing.Size(163, 25);
            this.emailEtu.TabIndex = 13;
            this.emailEtu.TextChanged += new System.EventHandler(this.emailEtu_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 223);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Adresse Mail :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 318);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Classe :";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(86, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(164, 25);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 22);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Classe :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // suppr_filter
            // 
            this.suppr_filter.AutoSize = true;
            this.suppr_filter.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.suppr_filter.ForeColor = System.Drawing.Color.Gray;
            this.suppr_filter.Location = new System.Drawing.Point(256, 23);
            this.suppr_filter.Name = "suppr_filter";
            this.suppr_filter.Size = new System.Drawing.Size(20, 21);
            this.suppr_filter.TabIndex = 20;
            this.suppr_filter.Text = "X";
            this.suppr_filter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.suppr_filter.Click += new System.EventHandler(this.suppr_filter_Click);
            // 
            // ClasseEtu
            // 
            this.ClasseEtu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClasseEtu.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClasseEtu.FormattingEnabled = true;
            this.ClasseEtu.Location = new System.Drawing.Point(86, 311);
            this.ClasseEtu.Name = "ClasseEtu";
            this.ClasseEtu.Size = new System.Drawing.Size(184, 31);
            this.ClasseEtu.TabIndex = 21;
            // 
            // filiereEtu
            // 
            this.filiereEtu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filiereEtu.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filiereEtu.FormattingEnabled = true;
            this.filiereEtu.Location = new System.Drawing.Point(86, 372);
            this.filiereEtu.Name = "filiereEtu";
            this.filiereEtu.Size = new System.Drawing.Size(184, 31);
            this.filiereEtu.TabIndex = 22;
            // 
            // etudeBindingSource
            // 
            this.etudeBindingSource.DataSource = typeof(AP_estudia.Modeles.Etude);
            // 
            // Gestion_Etudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1095, 632);
            this.Controls.Add(this.filiereEtu);
            this.Controls.Add(this.ClasseEtu);
            this.Controls.Add(this.suppr_filter);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.emailEtu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Modif);
            this.Controls.Add(this.Supression);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prenomEtu);
            this.Controls.Add(this.nomEtu);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Gestion_Etudiant";
            this.Text = "Gestion_Etu";
            this.Load += new System.EventHandler(this.Gestion_Classes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etudeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nomEtu;
        private System.Windows.Forms.TextBox prenomEtu;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button Supression;
        private System.Windows.Forms.Button Modif;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox emailEtu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label suppr_filter;
        private System.Windows.Forms.BindingSource etudeBindingSource;
        private System.Windows.Forms.ComboBox ClasseEtu;
        private System.Windows.Forms.ComboBox filiereEtu;
    }
}