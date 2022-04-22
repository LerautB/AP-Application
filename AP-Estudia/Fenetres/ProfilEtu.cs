using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using AP_estudia.Modeles;
using AP_estudia.Services;
using AP_estudia.Fenetres;

namespace AP_estudia
{
    public partial class ProfilEtu : Form
    {
        int idUtilisateur;
        List<Eleve> liste_eleves = new List<Eleve>();
        public ProfilEtu(Panel panel)
        {
            InitializeComponent();
            
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ProfilEtu_Load(object sender, EventArgs e)
        {
            var Classe = new Classe();
            Classe.allClasse();

            foreach (Classe x in Classe.liste_classes)
            {
                ComboBoxItem ClasseEtu = new ComboBoxItem();
                ClasseEtu.Text = x.nameClasse + " " + x.numClasse;
                ClasseEtu.Value = x.idClasse;
                this.select_classe.Items.Add(ClasseEtu);
                
            }
        }

        private void select_classe_SelectionChangeCommitted(object sender, EventArgs e)
        {

            Eleve Eleve = new Eleve();
            Eleve.allEtudiants((select_classe.SelectedItem as ComboBoxItem).Value);


            this.eleveCBB.Items.Clear();
            foreach (Eleve x in Eleve.liste_etu)
            {
                ComboBoxItem student = new ComboBoxItem();
                student.Text = x.nom + " " + x.prenom;
                student.Value = x.id;
                this.eleveCBB.Items.Add(student);

            }
            eleveCBB.Visible = true;
            label2.Visible = true;
        }

        private void eleveCBB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.panelProfil.Controls.Clear();
            Profil myForm = new Profil((eleveCBB.SelectedItem as ComboBoxItem).Value);
            myForm.AutoScroll = true;
            myForm.TopLevel = false;
            this.panelProfil.Controls.Add(myForm);
            myForm.Show();
        }

       
    }
}
