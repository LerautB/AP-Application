using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using AP_Estudia.Modeles;

namespace AP_Estudia.Modeles
{
    using BCrypt.Net;
    public class Enseignants
    {
        MySqlConnection conn = new MySqlConnection("database=estudia; server=localhost; user id = root; pwd=");

        public bool ajouter_enseignant(string nom,string prenom,int idMat,string matiere)
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
            command2.Parameters.AddWithValue("@idMat", idMat);
            command2.Parameters.AddWithValue("@matiere", matiere);


            command2.CommandText = "INSERT INTO Enseignants (Nom,Prenom,idUtilisateur,idMatiere,matiere) VALUES(@Nom,@Prenom,@idUtilisateur,@idMat,@matiere)";
            if (command2.ExecuteNonQuery() > 0)
            {
                conn.Close();
                return true;
            } else 
            {
                conn.Close();
                return false;
            }
        }
    }
}
