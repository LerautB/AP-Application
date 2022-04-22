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

namespace AP_estudia.Fenetres
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

            foreach (Filiere x in Filiere.ListeFiliere)
            {
                ComboBoxItem filiere = new ComboBoxItem();
                filiere.Text = x.name;
                filiere.Value = x.idFiliere;
                this.filiere.Items.Add(filiere);
            }
        }

        private void valider_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.niveau.Text, this.filiere.Text);
            Utilisateur utilisateur = new Utilisateur();
            if(!String.IsNullOrEmpty(this.nom.Text) && !String.IsNullOrEmpty(this.prenom.Text) && !String.IsNullOrEmpty(this.niveau.Text) && !String.IsNullOrEmpty(this.filiere.Text))
            {
                if ( utilisateur.Inscription(this.nom.Text, this.prenom.Text, this.mail.Text, this.date.Value.Date.ToString("yyyy-MM-dd"), "Etudiant",0,"", (this.niveau.SelectedItem as ComboBoxItem).Value.ToString()) == true)
                {
                    label5.ForeColor = Color.GreenYellow;
                    label5.Text = "Inscription d'un Administrateur : succès";
                    label5.Text = this.nom.Text + " | " + this.prenom.Text + " | " + this.mail.Text + " | " + this.date.Value.Date.ToString("yyyy-MM-dd") + " | Etudiant | " + this.filiere.Text + " | " + this.niveau.Text;
                }
                else
                {
                    label5.ForeColor = Color.Red;
                    label5.Text = "Inscription d'un Administrateur : erreur";
                }
            }
            else
            {
                MessageBox.Show("Erreur de saisis dans le formulaire");
            }

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
                var Niveau = new Etude();
                Niveau.allPremiere();
                Niveau.allTerminal();
                this.niveau.Items.Clear();
                foreach(Etude classe in Niveau.liste_classes)
                {
                    ComboBoxItem niveau = new ComboBoxItem();
                    niveau.Text = classe.classe + " " + classe.numclass;
                    niveau.Value = classe.idEtude;
                    this.niveau.Items.Add(niveau);
                }
                this.niveau.Show();
            }
        }
    }
    }

