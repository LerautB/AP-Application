
namespace AP_estudia
{
    partial class edt
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
            this.creaEdt = new System.Windows.Forms.Button();
            this.panelEdt = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.creaEdt);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 820);
            this.panel1.TabIndex = 0;
            // 
            // creaEdt
            // 
            this.creaEdt.BackColor = System.Drawing.Color.White;
            this.creaEdt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creaEdt.Location = new System.Drawing.Point(3, 37);
            this.creaEdt.Name = "creaEdt";
            this.creaEdt.Size = new System.Drawing.Size(146, 56);
            this.creaEdt.TabIndex = 2;
            this.creaEdt.Text = "Création emploi du temps";
            this.creaEdt.UseVisualStyleBackColor = false;
            this.creaEdt.Click += new System.EventHandler(this.creaEdt_Click);
            // 
            // panelEdt
            // 
            this.panelEdt.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panelEdt.Location = new System.Drawing.Point(161, 12);
            this.panelEdt.Name = "panelEdt";
            this.panelEdt.Size = new System.Drawing.Size(1107, 638);
            this.panelEdt.TabIndex = 1;
            // 
            // edt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1300, 820);
            this.Controls.Add(this.panelEdt);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "edt";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button creaEdt;
        private System.Windows.Forms.Panel panelEdt;
    }
}