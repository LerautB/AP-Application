using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AP_estudia.Modeles;
using AP_estudia.Services;
using AP_estudia.Fenetres;

namespace AP_estudia
{
    public partial class Gestion_Etablissement : Form
    {
        public Gestion_Etablissement()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.panelGestionEta.Controls.Clear();
            Creation_Etudiant myForm = new Creation_Etudiant();
            myForm.AutoScroll = true;
            myForm.TopLevel = false;
            this.panelGestionEta.Controls.Add(myForm);
            myForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.panelGestionEta.Controls.Clear();
            Gestion_Etudiant myForm = new Gestion_Etudiant();
            myForm.AutoScroll = true;
            myForm.TopLevel = false;
            this.panelGestionEta.Controls.Add(myForm);
            myForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.panelGestionEta.Controls.Clear();
            Gestion_Filiere myForm = new Gestion_Filiere();
            myForm.AutoScroll = true;
            myForm.TopLevel = false;
            this.panelGestionEta.Controls.Add(myForm);
            myForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.panelGestionEta.Controls.Clear();
            Gestion_Salle myForm = new Gestion_Salle();
            myForm.AutoScroll = true;
            myForm.TopLevel = false;
            this.panelGestionEta.Controls.Add(myForm);
            myForm.Show();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.panelGestionEta.Controls.Clear();
            Gestion_Matiere myForm = new Gestion_Matiere();
            myForm.AutoScroll = true;
            myForm.TopLevel = false;
            this.panelGestionEta.Controls.Add(myForm);
            myForm.Show();
        }
    }
}
