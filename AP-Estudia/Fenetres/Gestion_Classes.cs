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
using AP_Estudia.Modeles;



namespace AP_Estudia
{

    public partial class Gestion_Classes : Form
    {
        MySqlConnection conn = new MySqlConnection("database=estudia; server=localhost; user id = root; pwd=");
        MySqlDataAdapter adpt;
        DataTable dt;
        int idClasse;
       
        public Gestion_Classes()
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
            conn.Open();
            adpt = new MySqlDataAdapter("SELECT * FROM etudes", conn);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView.DataSource = dt;
            conn.Close();
        }

        /*CLEAR DES INPUTS*/
         public void clear()
        {
            numClasse.Text = "";
            nomClasse.Text = "";
        }

        /*ENVOIE DU DATAGRIVIEW DANS LES INPUTS*/
        private void dataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            idClasse = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            //numClasse = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString());

            numClasse.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            nomClasse.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
        
        /*MODIFICATION DE LA CLASSE*/
        private void Modif_Click(object sender, EventArgs e)
        {
            var objetClasse = new Classe();
            
            if(numClasse.Text != string.Empty)
            {
                if(nomClasse.Text != string.Empty)
                {
                    if (objetClasse.updateClasse(numClasse.Text, nomClasse.Text, idClasse) == true)
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
            var objetClasse = new Classe();
            if(idClasse != 0)
            {
                if (objetClasse.supprClasse(idClasse) == true)
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