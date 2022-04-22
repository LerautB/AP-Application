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



namespace AP_estudia
{

    public partial class Gestion_Administration : Form
    {
        int idAdministration;
       
        public Gestion_Administration()
        {
            InitializeComponent();
            displayData();
        }
        
        /*AFFICHAGE DES DONNEES*/
        public void displayData()
        {
            var Utilisateur = new Utilisateur();
            MySqlDataAdapter listeUser = Utilisateur.listeAdministration();
           

            DataTable dt = new DataTable();
            listeUser.Fill(dt);
            dataGridView.DataSource = dt;
    
        }

        /*CLEAR DES INPUTS*/
         public void clear()
        {
            nomAdministration.Text = "";
            prenomAdministration.Text = "";
            emailAdministration.Text = "";
            idAdministration = 0;
        }

        /*ENVOIE DU DATAGRIVIEW DANS LES INPUTS*/
        private void dataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!String.IsNullOrEmpty(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString()))
            {
                idAdministration = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                //numClasse = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString());

                nomAdministration.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                prenomAdministration.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                emailAdministration.Text = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }
        
        /*MODIFICATION DE LA CLASSE*/
        private void Modif_Click(object sender, EventArgs e)
        {
            var objetAdministration = new Utilisateur();
            
            if(nomAdministration.Text != string.Empty)
            {
                if(prenomAdministration.Text != string.Empty)
                {
                    if (objetAdministration.updateAdministration(idAdministration,prenomAdministration.Text, nomAdministration.Text,emailAdministration.Text) == true)
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
            var objetAdministration = new Utilisateur();
            if(idAdministration != 0)
            {
                if (objetAdministration.supprUser(idAdministration) == true)
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

        private void Gestion_Classes_Load(object sender, EventArgs e)
        {

        }

    }
}