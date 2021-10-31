using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;
using MySql.Data.MySqlClient;

namespace AP_Estudia
{
    using BCrypt.Net;
    
    
    public partial class login : Form
    {
        MySqlConnection conn = new MySqlConnection("database=estudia; server=localhost; user id = root; pwd=");
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mot_de_passe = mdp_input.Text;
            string identifiant = id_input.Text;
            string User_mdp = "";
            string User_nom;
            string User_statut;
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            
            command.Parameters.AddWithValue("@id", identifiant);
            

            command.CommandText = "SELECT nom,mdp,statut FROM utilisateur WHERE identifiant = @id";
            
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                User_nom = reader.GetString(0);
                User_mdp = reader.GetString(1);
                User_statut = reader.GetString(2);
                
            }
            // Fermeture de la connexion
            conn.Close();

            if(BCrypt.Verify(mot_de_passe, User_mdp))
            {
                MessageBox.Show("Connexion réussi...");
            }
            else
            {
                MessageBox.Show("Connexion échouée...");
            }
        }
    }
}
