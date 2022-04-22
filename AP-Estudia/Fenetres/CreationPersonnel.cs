using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AP_estudia.Services;
using AP_estudia.Modeles;
using MySql.Data.MySqlClient;

namespace AP_estudia.Fenetres
{
    public partial class CreationPersonnel : Form
    {
        public CreationPersonnel()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            var User = new Utilisateur();
            if(!String.IsNullOrEmpty(this.nom.Text) && !String.IsNullOrEmpty(this.prenom.Text) && !String.IsNullOrEmpty(this.poste.Text))
            { 
                if(this.poste.Text == "Administration")
                {
                    if(User.Inscription(this.nom.Text, this.prenom.Text, this.mail.Text , this.date.Value.Date.ToString("yyyy-MM-dd"),this.poste.Text) == true)
                    {
                        label5.ForeColor = Color.GreenYellow;
                        label5.Text = "Inscription d'un Administrateur : succès";
                        label5.Text = this.nom.Text + " | " + this.prenom.Text + " | " + this.mail.Text + " | "+ this.date.Value.Date.ToString("yyyy-MM-dd") + " | "+ this.poste.Text +" | "+ this.matiere.Text ;
                    }
                    else
                    {
                        label5.ForeColor = Color.Red;
                        label5.Text = "Inscription d'un Administrateur : erreur";
                    }
                }
                else if(this.poste.Text == "Professeur")
                {
                    if(User.Inscription(this.nom.Text, this.prenom.Text, this.mail.Text, this.date.Value.Date.ToString("yyyy-MM-dd"), this.poste.Text,this.matiere.SelectedIndex, this.matiere.Text) == true)
                    {
                        label5.ForeColor = Color.GreenYellow;
                        label5.Text = "Inscription d'un Professeur : succès";
                    }
                    else
                    {
                        label5.ForeColor = Color.Red;
                        label5.Text = "Inscription d'un Professeur : erreur";
                    }
                }
                else
                {
                    label5.ForeColor = Color.Red;
                    label5.Text = "Veuillez selectionner un poste avant de continuer.";
                }
            }
            else
            {
                MessageBox.Show("Erreur de saisies dans le formulaire");
            }
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Select = this.poste.Text;
            if(Select == "Professeur")
            {
                
                var Matieres = new Matieres();
                Matieres.get_liste_matiere();
                
                foreach (Matieres x in Matieres.ListeMatiere)
                {
                    ComboBoxItem matiere = new ComboBoxItem();
                    matiere.Text = x.name;
                    matiere.Value = x.id;
               
                    this.matiere.Items.Add(matiere);

                }

                this.label6.Show();
                this.matiere.Show();
            }
            if(Select == "Administration")
            {
                this.matiere.Items.Clear();
                this.matiere.Hide();
                this.label6.Hide();
            }
        }

        private void matiere_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CreationPersonnel_Load(object sender, EventArgs e)
        {

        }
    }
}
