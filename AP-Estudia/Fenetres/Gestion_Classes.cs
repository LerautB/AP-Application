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
            //conn.open();
            //string nbclasse = numclasse.text;
            //string nameclasse = nomclasse.text;
            //mysqlcommand command = conn.createcommand();
            //command.parameters.addwithvalue("@nbclasse", nbclasse);
            //command.parameters.addwithvalue("@nomclasse", nameclasse);
            //command.commandtext = "insert into etudes (classe, nom) values (@nbclasse, @nomclasse)";
            //if(command.executenonquery()>0)
            //{
            //    messagebox.show("insertion");
            //}
            //else
            //{
            //    messagebox.show("fail");
            //}
            //conn.close();
            //displaydata();
        }
        
        /*A SUPPRIMER*/
        private void Gestion_Classes_Load(object sender, EventArgs e)
        {

        }
        /*SELECT DES CLASSES*/
        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();

            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT classe, nom FROM etudes";
            MySqlDataReader reader = command.ExecuteReader();
            conn.Close();
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

        /*A SUPPRIMER*/
         private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
         {
             idClasse = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
             numClasse.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
             nomClasse.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
         }
        /*A SUPPRIMER*/
         private void dataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
         {
             idClasse = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
             numClasse.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
             nomClasse.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
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
     
            conn.Open();
            string numeroClasse = numClasse.Text;
            string nomDeClasse = nomClasse.Text;
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@nbClasse", numeroClasse);
            command.Parameters.AddWithValue("@nomClasse", nomDeClasse);
            command.Parameters.AddWithValue("@idClasse", idClasse);

           command.CommandText = "UPDATE etudes SET classe=@nbClasse, nom=@nomClasse WHERE idEtude = @idClasse";
           if(command.ExecuteNonQuery() > 0)
           {
               MessageBox.Show("Update");
           }
           else
           {
                MessageBox.Show("raté");
           }
           MessageBox.Show("Modifiée");
           conn.Close();
           clear();
           displayData();
        }
        
        /*SUPPRESSION DE LA CLASSE*/
        private void Supression_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@idclasse", idClasse);
            command.CommandText = "DELETE FROM etudes WHERE idEtude = @idclasse";
            if(command.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Supprimé");
            }
            else
            {
                MessageBox.Show("Raté");
            }
            conn.Close();
            clear();

            displayData();
        }
    }
}
