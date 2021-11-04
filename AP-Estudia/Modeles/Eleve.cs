using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using AP_Estudia.Modeles;

namespace AP_Estudia.Modeles
{
    public class Eleve
    {
        MySqlConnection conn = new MySqlConnection("database=estudia; server=localhost; user id = root; pwd=");
        public bool ajouter_etudiant(string nom, string prenom, string idEtude)
        {
            string idUtilisateur = "";
            conn.Open();

            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@Nom", nom);
            command.Parameters.AddWithValue("@Prenom", prenom);

            command.CommandText = "SELECT idUtilisateur FROM utilisateur WHERE nom = @Nom AND prenom = @Prenom";
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                idUtilisateur = reader.GetString(0);
            }
            conn.Close();
            conn.Open();
            MySqlCommand command2 = conn.CreateCommand();
            command2.Parameters.AddWithValue("@Nom", nom);
            command2.Parameters.AddWithValue("@Prenom", prenom);
            command2.Parameters.AddWithValue("@idUtilisateur", idUtilisateur);
            command2.Parameters.AddWithValue("@idEtude", idEtude);


            command2.CommandText = "INSERT INTO Eleve (Nom,Prenom,idUtilisateur,idEtude) VALUES(@Nom,@Prenom,@idUtilisateur,@idEtude)";
            if (command2.ExecuteNonQuery() > 0)
            {
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }
        }
    }
  }

