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


namespace AP_Estudia.Modeles
{
    using BCrypt.Net;
    public class Utilisateur
    {
        MySqlConnection conn = new MySqlConnection("database=estudia; server=localhost; user id = root; pwd=");
        public bool Connection(string identifiant, string mot_de_passe )
        {
            var WindowLogin = new login();
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

            if (BCrypt.Verify(mot_de_passe, User_mdp))
            {
                //MessageBox.Show("Connexion réussi...");
                //Estudia f = new Estudia();
                //f.Show();

                return true;
            }
            else
            {
                
                return false;
            }


        } 
        public bool Inscription(string nom,string prenom, string dateNaiss, string status, string matiere = "", string idEtude = "")
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command.Parameters.AddWithValue("@Nom", nom);
            command.Parameters.AddWithValue("@Prenom", prenom);
            command.Parameters.AddWithValue("@identifiant", identifiant);
            command.Parameters.AddWithValue("@mdpHash", mdpHash);
            command.Parameters.AddWithValue("@mdpTemp", mdpTemp);
            command.Parameters.AddWithValue("@status", status);
            command.Parameters.AddWithValue("@dateNaiss", dateNaiss);


            command.CommandText = ("INSERT INTO utilisateurs (identifiant,nom, prenom,dateNaiss, mdp, mdpTemp,status) values (@identifiant,@nom,@prenom,@dateNaiss,@mdpHash,@mdpTemp,@status)");

            if (command.ExecuteNonQuery() > 0) 
            {
                if(status == "Enseignant")
                {
                    var User = new Enseignants();
                    User.ajouter_enseignant(nom,prenom,matiere);
                }
                else if(status == "Etudiant")
                {
                    var User = new Eleve();
                    User.ajouter_etudiant(nom, prenom, idEtude);
                }
                else if(status == "Administration")
                {
                    return true;
                }
            } 
            else 
            {
                return false;
            }
        }
    }
}
