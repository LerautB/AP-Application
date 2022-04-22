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

    public partial class Gestion_Salle : Form
    {
        int idSalle;
     
       
        public Gestion_Salle()
        {
            InitializeComponent();
            displayData();
        }
        
        /*INSERTION DE LA CLASSE*/
        private void button1_Click(object sender, EventArgs e)
        {
            var creation = new Salle();
            if(!String.IsNullOrEmpty(numSalle.Text))
            if(creation.ajouter_salle(numSalle.Text) == true)
            {
                MessageBox.Show("creation Success");
            }
            else
            {
                MessageBox.Show("creation Failed");
            }
            clear();
            displayData();
        }
        
        
        /*AFFICHAGE DES DONNEES*/
        public void displayData()
        {
            var Salle = new Salle();
            MySqlDataAdapter listeSalles = Salle.get_liste_salle();
           

             DataTable dt = new DataTable();
            listeSalles.Fill(dt);
            dataGridView.DataSource = dt;
    
        }

        /*CLEAR DES INPUTS*/
         public void clear()
        {
            numSalle.Text = "";
            idSalle = 0;
        }

        /*ENVOIE DU DATAGRIVIEW DANS LES INPUTS*/
        private void dataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!String.IsNullOrEmpty(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString()))
            {
                idSalle = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                numSalle.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }
        
        /*MODIFICATION DE LA CLASSE*/
        private void Modif_Click(object sender, EventArgs e)
        {
            var objetSalle = new Salle();


            if (numSalle.Text != string.Empty)
            {
                //string idUtilisateur, string nom,string prenom,string matiere,string email,string dateNaiss
                if (objetSalle.updateSalle(idSalle, numSalle.Text) == true)
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
                MessageBox.Show("Le num de la Salle est vide");

            }
            clear();
            displayData();
        }
        
        /*SUPPRESSION DE LA CLASSE*/
        private void Supression_Click(object sender, EventArgs e)
        {
            var objetSalle = new Salle();
            if(idSalle != 0)
            {
                if (objetSalle.supprSalle(idSalle) == true)
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
    }
}