
namespace AP_Estudia
{
    partial class Gestion_Classes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.numClasse = new System.Windows.Forms.TextBox();
            this.nomClasse = new System.Windows.Forms.TextBox();
            this.Insert = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Supression = new System.Windows.Forms.Button();
            this.Modif = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 200);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numéro de la classe : ";
            // 
            // numClasse
            // 
            this.numClasse.Location = new System.Drawing.Point(404, 197);
            this.numClasse.Margin = new System.Windows.Forms.Padding(4);
            this.numClasse.Name = "numClasse";
            this.numClasse.Size = new System.Drawing.Size(132, 25);
            this.numClasse.TabIndex = 2;
            // 
            // nomClasse
            // 
            this.nomClasse.Location = new System.Drawing.Point(880, 197);
            this.nomClasse.Margin = new System.Windows.Forms.Padding(4);
            this.nomClasse.Name = "nomClasse";
            this.nomClasse.Size = new System.Drawing.Size(132, 25);
            this.nomClasse.TabIndex = 3;
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(500, 89);
            this.Insert.Margin = new System.Windows.Forms.Padding(4);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(310, 30);
            this.Insert.TabIndex = 5;
            this.Insert.Text = "Créer une classe";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.button1_Click);
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
            this.dataGridView.Location = new System.Drawing.Point(259, 344);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(753, 293);
            this.dataGridView.TabIndex = 7;
            this.dataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseDoubleClick);
            // 
            // Supression
            // 
            this.Supression.Location = new System.Drawing.Point(912, 264);
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
            this.Modif.Location = new System.Drawing.Point(259, 264);
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
            this.label1.Location = new System.Drawing.Point(755, 200);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nom de la classe :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(555, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 30);
            this.label3.TabIndex = 10;
            this.label3.Text = "Gestion des classes";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Gestion_Classes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1276, 667);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Modif);
            this.Controls.Add(this.Supression);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nomClasse);
            this.Controls.Add(this.numClasse);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Gestion_Classes";
            this.Text = "Gestion_Classes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numClasse;
        private System.Windows.Forms.TextBox nomClasse;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button Supression;
        private System.Windows.Forms.Button Modif;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}