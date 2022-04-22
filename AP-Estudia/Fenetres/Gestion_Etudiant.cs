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

    public partial class Gestion_Etudiant : Form
    {
        
        int idUtilisateur;
        ComboBoxItem SelectedClass = new ComboBoxItem();
        public Gestion_Etudiant()
        {
            InitializeComponent();
            displayData();
        }
        

        
        /*AFFICHAGE DES DONNEES*/
        public void displayData(int? idetude=null)
        {
            var Etudiant = new Eleve();
            MySqlDataAdapter listeEtudiant;
            if (idetude == null)
            {
                
                listeEtudiant = Etudiant.allEtudiants();
            }
            else
            {
                listeEtudiant = Etudiant.allEtudiants(idetude);

            }



            DataTable dt = new DataTable();
            listeEtudiant.Fill(dt);
            dataGridView.DataSource = dt;
    
        }

        /*CLEAR DES INPUTS*/
         public void clear()
        {
            
            filiereEtu.SelectedItem = "";
            emailEtu.Text = "";
            nomEtu.Text = "";
            prenomEtu.Text = "";
        }

        /*ENVOIE DU DATAGRIVIEW DANS LES INPUTS*/
        private void dataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!String.IsNullOrEmpty(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString()))
            {
                Console.WriteLine(dataGridView.Rows[e.RowIndex].Cells[3]);
                idUtilisateur = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                //numClasse = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString());

                string Text = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();

                this.filiereEtu.SelectedIndex = -1;
                int index = -1;
                int i = 0;
                foreach (ComboBoxItem x in this.filiereEtu.Items)
                {
                    if(Text == x.Text)
                    {
                        index = i;
                    }
                    i++;
                }
                if(index != -1)
                {
                    filiereEtu.SelectedIndex = index;
                }
                string Text2 = dataGridView.Rows[e.RowIndex].Cells[7].Value.ToString() + " " + dataGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
                index = -1;
                i = 0;
                foreach (ComboBoxItem x in this.ClasseEtu.Items)
                {
                    if (Text2 == x.Text)
                    {
                        index = i;
                    }
                    i++;
                }
                if (index != -1)
                {
                    ClasseEtu.SelectedIndex = index;
                }
                

                emailEtu.Text = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                nomEtu.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                prenomEtu.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }
        
        /*MODIFICATION DE LA CLASSE*/
        private void Modif_Click(object sender, EventArgs e)
        {
            var objetEtudiant = new Eleve();

            if (nomEtu.Text != string.Empty)
            {
                if(prenomEtu.Text != string.Empty)
                {
                    //string idUtilisateur, string nom,string prenom,string matiere,string email,string dateNaiss
                    if (objetEtudiant.updateEtudiants(idUtilisateur, nomEtu.Text, prenomEtu.Text, (this.filiereEtu.SelectedItem as ComboBoxItem).Value, (this.ClasseEtu.SelectedItem as ComboBoxItem).Value,emailEtu.Text) == true)
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
            if (this.SelectedClass.Value != 0)
            {
                displayData(this.SelectedClass.Value);
            }
            else
            {
                displayData();
            }
        }
        
        /*SUPPRESSION DE LA CLASSE*/
        private void Supression_Click(object sender, EventArgs e)
        {
            var objetEtudiant = new Eleve();
            if(idUtilisateur != 0)
            {
                if (objetEtudiant.supprEtudiant(idUtilisateur) == true)
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
            if(this.SelectedClass.Value != 0)
            {
                displayData(this.SelectedClass.Value);
            }
            else
            {
               displayData();
            }
            
        }

        private void Gestion_Classes_Load(object sender, EventArgs e)
        {
            var Filiere = new Filiere();
            Filiere.get_liste_filiere();

            foreach (Filiere x in Filiere.ListeFiliere)
            {
                ComboBoxItem filiereEtu = new ComboBoxItem();
                filiereEtu.Text = x.name;
                filiereEtu.Value = x.idFiliere;
                this.filiereEtu.Items.Add(filiereEtu);

            }

            var Classe = new Classe();
            Classe.allClasse();

            foreach( Classe x in Classe.liste_classes)
            {
                ComboBoxItem ClasseEtu = new ComboBoxItem();
                ClasseEtu.Text = x.nameClasse + " " + x.numClasse;
                ClasseEtu.Value = x.idClasse;
                this.ClasseEtu.Items.Add(ClasseEtu);
                this.comboBox1.Items.Add(ClasseEtu);
            }
        }

        private void emailEtu_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClasseEtu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            this.SelectedClass = comboBox1.SelectedItem as ComboBoxItem;
            clear();
            displayData(this.SelectedClass.Value) ;
            suppr_filter.ForeColor = Color.Red;


        }

        private void suppr_filter_Click(object sender, EventArgs e)
        {
            this.comboBox1.SelectedIndex = -1;
            this.SelectedClass = this.comboBox1.SelectedItem as ComboBoxItem;
            clear();
            displayData();
            suppr_filter.ForeColor = Color.Gray;
        }
    }
}