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
using AP_estudia.Services;
using AP_estudia.Modeles;



namespace AP_estudia
{

    public partial class Gestion_Enseignants : Form
    {
        int idEnseignant;
        int idUtilisateur;
       
        public Gestion_Enseignants()
        {
            InitializeComponent();
            displayData();
        }
        
        /*INSERTION DE LA CLASSE*/
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var creation = new CreationClasse();
            creation.Show();
        }
        
        /*AFFICHAGE DES DONNEES*/
        public void displayData()
        {
            var Enseignants = new Enseignants();
            MySqlDataAdapter listeEnseignants = Enseignants.allEnseignants();
           

             DataTable dt = new DataTable();
            listeEnseignants.Fill(dt);
            dataGridView.DataSource = dt;
    
        }

        /*CLEAR DES INPUTS*/
         public void clear()
        {
            
            matiereEnseignant.SelectedIndex = -1;
            emailEnseignants.Text = "";
            nomEnseignant.Text = "";
            prenomEnseignant.Text = "";
        }

        /*ENVOIE DU DATAGRIVIEW DANS LES INPUTS*/
        private void dataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(!String.IsNullOrEmpty(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString()))
            {
                idEnseignant = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString());
                idUtilisateur = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                //numClasse = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString());
                matiereEnseignant.SelectedValue = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                int index = -1;
                int i = 0;
                foreach (ComboBoxItem x in this.matiereEnseignant.Items)
                {
                    if (dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString() == x.Text)
                    {
                        index = i;
                    }
                    i++;
                }
                if (index != -1)
                {
                    matiereEnseignant.SelectedIndex = index;
                }
                else
                {
                    matiereEnseignant.SelectedIndex = index;
                }

                emailEnseignants.Text = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                nomEnseignant.Text = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                prenomEnseignant.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }
        
        /*MODIFICATION DE LA CLASSE*/
        private void Modif_Click(object sender, EventArgs e)
        {
            var objetEnseignant = new Enseignants();
            
            if(nomEnseignant.Text != string.Empty)
            {
                if(prenomEnseignant.Text != string.Empty)
                {
                    //string idUtilisateur, string nom,string prenom,string matiere,string email,string dateNaiss
                    if (objetEnseignant.updateEnseignant(idUtilisateur, nomEnseignant.Text, prenomEnseignant.Text, (matiereEnseignant.SelectedItem as ComboBoxItem), emailEnseignants.Text) == true)
                    {
                        MessageBox.Show("Modif Réussi");
                        idEnseignant = 0;
                        idUtilisateur = 0;
                    }
                    else
                    {
                        MessageBox.Show("Erreur de modification");
                    }
                }
                else
                {
                    MessageBox.Show("Le nom de la classe est vide");

                }
            }
            else
            {
                MessageBox.Show("Le numéro de la classe est vide");
            }
            clear();
            displayData();
        }
        
        /*SUPPRESSION DE LA CLASSE*/
        private void Supression_Click(object sender, EventArgs e)
        {
            var objetEnseignants = new Enseignants();
            if(idUtilisateur != 0)
            {
                if (objetEnseignants.supprEnseignant(idUtilisateur) == true)
                {
                    MessageBox.Show("Suppression Réussi");
                    //idEnseignant = 0;
                }
                else
                {
                    MessageBox.Show("Erreur de suppression");
                }
            }
            else
            {
                MessageBox.Show("id Vide");

            }
            clear();

            displayData();
        }

        private void Gestion_Classes_Load(object sender, EventArgs e)
        {
            var Matieres = new Matieres();
            Matieres.get_liste_matiere();

            foreach (Matieres x in Matieres.ListeMatiere)
            {
                ComboBoxItem matiereEnseignant = new ComboBoxItem();
                matiereEnseignant.Text = x.name;
                matiereEnseignant.Value = x.id;
                this.matiereEnseignant.Items.Add(matiereEnseignant);

            }
        }
    }
}