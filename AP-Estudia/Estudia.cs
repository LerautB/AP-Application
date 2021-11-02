using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP_Estudia
{
    public partial class Estudia : Form
    {
        public Estudia()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void gestionDesClassesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void emploiDuTempsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.panel1.Controls.Clear();
            edt myForm = new edt();
            myForm.AutoScroll = true;
            myForm.TopLevel = false;
            this.panel1.Controls.Add(myForm);
            myForm.Show();
            
        }

        private void gestionDesClassesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            Gestion_Classes myForm = new Gestion_Classes();
            myForm.AutoScroll = true;
            myForm.TopLevel = false;
            this.panel1.Controls.Add(myForm);
            myForm.Show();
        }

        private void gestionDuPersonnelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            Gestion_personnel myForm = new Gestion_personnel();
            myForm.AutoScroll = true;
            myForm.TopLevel = false;
            this.panel1.Controls.Add(myForm);
            myForm.Show();
        }

        private void gestionEtablissementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            Gestion_Etablissement myForm = new Gestion_Etablissement();
            myForm.AutoScroll = true;
            myForm.TopLevel = false;
            this.panel1.Controls.Add(myForm);
            myForm.Show();
        }

        private void settingsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            Settings myForm = new Settings();
            myForm.AutoScroll = true;
            myForm.TopLevel = false;
            this.panel1.Controls.Add(myForm);
            myForm.Show();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
