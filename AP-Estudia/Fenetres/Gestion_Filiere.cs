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

    public partial class Gestion_Filiere : Form
    {
        int idFiliere;

       
        public Gestion_Filiere()
        {
            InitializeComponent();
            displayData();
        }
        
        /*INSERTION DE LA CLASSE*/
        private void button1_Click(object sender, EventArgs e)
        {
            var creation = new Filiere();
            if(creation.ajouter_filiere(nomFiliere.Text) == true)
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
            var Filiere = new Filiere();
            MySqlDataAdapter liste_filiere = Filiere.get_liste_filiere();
           

             DataTable dt = new DataTable();
            liste_filiere.Fill(dt);
            dataGridView.DataSource = dt;
    
        }

        /*CLEAR DES INPUTS*/
         public void clear()
        {

            nomFiliere.Text = "";
            
        }

        /*ENVOIE DU DATAGRIVIEW DANS LES INPUTS*/
        private void dataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!String.IsNullOrEmpty(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString()))
            {
                idFiliere = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                nomFiliere.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }
        
        /*MODIFICATION DE LA CLASSE*/
        private void Modif_Click(object sender, EventArgs e)
        {
            var objetFiliere = new Filiere();
            
            if(nomFiliere.Text != string.Empty)
            {
                    //string idUtilisateur, string nom,string prenom,string matiere,string email,string dateNaiss
                    if (objetFiliere.updateFiliere(idFiliere, nomFiliere.Text) == true)
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
            var objetFiliere = new Filiere();
            if(idFiliere != 0)
            {
                if (objetFiliere.supprFiliere(idFiliere) == true)
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
            var objetFiliere = new Filiere();
            if (!String.IsNullOrEmpty(nomFiliere.Text))
            {
                //string idUtilisateur, string nom,string prenom,string matiere,string email,string dateNaiss
                if (objetFiliere.ajouter_filiere(nomFiliere.Text) == true)
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