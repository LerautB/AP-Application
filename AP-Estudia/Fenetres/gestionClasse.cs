using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP_estudia.Fenetres
{
    public partial class gestionClasse : Form
    {
        public gestionClasse()
        {
            InitializeComponent();
        }

        private void gestClass_Click(object sender, EventArgs e)
        {
            this.panelGestion.Controls.Clear();
            Gestion_Classes myForm = new Gestion_Classes();
            myForm.AutoScroll = true;
            myForm.TopLevel = false;
            this.panelGestion.Controls.Add(myForm);
            myForm.Show();
        }

        private void ajoutEleve_Click(object sender, EventArgs e)
        {
            this.panelGestion.Controls.Clear();
            AjouterEleve myForm = new AjouterEleve();
            myForm.AutoScroll = true;
            myForm.TopLevel = false;
            this.panelGestion.Controls.Add(myForm);
            myForm.Show();
        }
    }
}
