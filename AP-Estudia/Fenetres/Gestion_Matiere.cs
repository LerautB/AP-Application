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

    public partial class Gestion_Matiere : Form
    {
        int idMatiere;

       
        public Gestion_Matiere()
        {
            InitializeComponent();
            displayData();
        }
        
        /*INSERTION DE LA CLASSE*/
        private void button1_Click(object sender, EventArgs e)
        {
            var creation = new Matieres();
            if(creation.ajouterMatiere(matiere.Text) == true)
            {
                MessageBox.Show("creation Success");
            }
            else
            {
                MessageBox.Show("creation Failed");
            }
        }
        
        /*AFFICHAGE DES DONNEES*/
        public void displayData()
        {
            var Matiere = new Matieres();
            MySqlDataAdapter liste_matiere = Matiere.get_liste_matiere();
           

             DataTable dt = new DataTable();
            liste_matiere.Fill(dt);
            dataGridView.DataSource = dt;
    
        }

        /*CLEAR DES INPUTS*/
         public void clear()
        {

            matiere.Text = "";
            
        }

        /*ENVOIE DU DATAGRIVIEW DANS LES INPUTS*/
        private void dataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!String.IsNullOrEmpty(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString()))
            {
                idMatiere = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                matiere.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }
        
        /*MODIFICATION DE LA CLASSE*/
        private void Modif_Click(object sender, EventArgs e)
        {
            var objetMatiere = new Matieres();
            
            if(matiere.Text != string.Empty)
            {
                    //string idUtilisateur, string nom,string prenom,string matiere,string email,string dateNaiss
                    if (objetMatiere.updateMatiere(idMatiere, matiere.Text) == true)
                    {
                        MessageBox.Show("Modif Réussi");
                    }
                    else
                    {
                        MessageBox.Show("Erreur de modification");
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
            var objetFiliere = new Matieres();
            if(idMatiere != 0)
            {
                if (objetFiliere.supprMatiere(idMatiere) == true)
                {
                    MessageBox.Show("Suppression Réussi");
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            var objetMatiere = new Matieres();
            if (!String.IsNullOrEmpty(matiere.Text))
            {
                //string idUtilisateur, string nom,string prenom,string matiere,string email,string dateNaiss
                if (objetMatiere.ajouterMatiere(matiere.Text) == true)
                {
                    MessageBox.Show("Création de la filière Réussi");
                }
                else
                {
                    MessageBox.Show("Erreur lors de la création de la filière");
                }
            }
            clear();
            displayData();
        }
    }
}