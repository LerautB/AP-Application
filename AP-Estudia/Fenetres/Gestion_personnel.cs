using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AP_estudia.Fenetres;
using AP_estudia.Modeles;
using AP_estudia.Services;

namespace AP_estudia
{
    public partial class Gestion_personnel : Form
    {
        public Gestion_personnel()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.panelGestionPersonnel.Controls.Clear();
            CreationPersonnel myForm = new CreationPersonnel();
            myForm.AutoScroll = true;
            myForm.TopLevel = false;
            this.panelGestionPersonnel.Controls.Add(myForm);
            myForm.Show();
        }

        private void listePersonnel_Click(object sender, EventArgs e)
        {
            this.panelGestionPersonnel.Controls.Clear();
            Gestion_Administration myForm = new Gestion_Administration();
            myForm.AutoScroll = true;
            myForm.TopLevel = false;
            this.panelGestionPersonnel.Controls.Add(myForm);
            myForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.panelGestionPersonnel.Controls.Clear();
            Gestion_Enseignants listeEnseignants = new Gestion_Enseignants();
            listeEnseignants.AutoScroll = true;
            listeEnseignants.TopLevel = false;
            this.panelGestionPersonnel.Controls.Add(listeEnseignants);
            listeEnseignants.Show();
        }


    }
}
