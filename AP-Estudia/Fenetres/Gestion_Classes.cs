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

        public Gestion_Classes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            string nbClasse = numClasse.Text;
            string nameClasse = nomClasse.Text;
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@nbClasse", nbClasse);
            command.Parameters.AddWithValue("@nomClasse", nameClasse);
            command.CommandText = "INSERT INTO etudes (classe, nom) VALUES (@nbClasse, @nomClasse)";
            if(command.ExecuteNonQuery()>0)
            {
                MessageBox.Show("Insertion");
            }
            else
            {
                MessageBox.Show("Fail");
            }
            conn.Close();
        }

        private void Gestion_Classes_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT classe, nom FROM etudes";
            MySqlDataReader reader = command.ExecuteReader();
            List<string> classes = new List<string>();
            for (int i = 0; i < classes.Count; i++)
            {
                string numClasse = reader.GetString(0);
                string nomClasse = reader.GetString(1);
                classes.Insert(i, nomClasse);
                Console.WriteLine(classes.ElementAt(i).ToString());
            }
            
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
