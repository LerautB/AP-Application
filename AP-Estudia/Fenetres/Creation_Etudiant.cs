using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AP_Estudia.Modeles;
using AP_Estudia.Services;
using AP_Estudia.Fenetres;

namespace AP_Estudia.Fenetres
{
    public partial class Creation_Etudiant : Form
    {
        public Creation_Etudiant()
        {
            InitializeComponent();
        }

        private void Creation_Etudiant_Load(object sender, EventArgs e)
        {
            var Filiere = new Filiere();
            var reader = Filiere.get_liste_filiere();

            foreach (Part aPart in Filiere.Test)
            {
                this.filiere.Items.AddRange(new object[] { aPart.PartName });
            }
        }

        private void vailder_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Select = this.filiere.Text;
            if (Select == "Générale")
            {
                this.niveau.Items.Clear();
                this.niveau.Hide();
            }
            else
            {
                var Niveau = new Classe();
                this.niveau.Show();
            }
        }
    }
    }

