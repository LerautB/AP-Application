using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using AP_estudia.Modeles;
using AP_estudia.Services;

namespace AP_estudia.Modeles
{
    using BCrypt.Net;
    public class Enseignants
    {
        MySqlConnection conn = new MySqlConnection("database=estudia; server=localhost; user id = root; pwd=");
        public List<Enseignants> liste_enseignants = new List<Enseignants>();
        private List<Enseignants> listeEnseignant = new List<Enseignants>();

        public int idUtilisateur { get; set; }
        public int idEnseignant { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string matiere { get; set; }
        public string mail { get; set; }
        public string dateNaiss { get; set; }
        public int id { get; set; }
        public string name { get; set; }
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
        public bool updateEnseignant(int idUtilisateur, string nom,string prenom,ComboBoxItem matiere,string email)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command.Parameters.AddWithValue("@idUtilisateur", idUtilisateur);
            command.Parameters.AddWithValue("@nom", nom);
            command.Parameters.AddWithValue("@prenom", prenom);
            command.Parameters.AddWithValue("@matiere", matiere.Text);
            command.Parameters.AddWithValue("@idMatiere", matiere.Value);
            command.Parameters.AddWithValue("@email", email);

            command.CommandText = "UPDATE enseignants SET Nom=@nom, Prenom=@prenom, matiere = @matiere, idMatiere = @idMatiere WHERE idUtilisateur = @idUtilisateur;" +
                "Update utilisateur SET  nom=@nom, prenom=@prenom, email = @email WHERE idUtilisateur = @idUtilisateur";
            if (command.ExecuteNonQuery() > 0)
            {
                conn.Close();
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool supprEnseignant(int idUtilisateur)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command.Parameters.AddWithValue("@idUtilisateur", idUtilisateur);

            command.CommandText = "DELETE FROM enseignants  WHERE idUtilisateur = @idUtilisateur;DELETE FROM utilisateur  WHERE idUtilisateur = @idUtilisateur;";
            if (command.ExecuteNonQuery() > 0)
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
        public MySqlDataAdapter allEnseignants()
        {
            conn.Open();
            MySqlCommand commande = conn.CreateCommand();

            commande.CommandText = "SELECT idUtilisateur,idEnseignant, utilisateur.Nom, utilisateur.Prenom,  matieres.matiere, utilisateur.email FROM enseignants INNER JOIN utilisateur USING(idUtilisateur) LEFT JOIN matieres USING(idMatiere);";
            MySqlDataReader reader = commande.ExecuteReader();
            while (reader.Read())
            {
                string matiere = "";
                string mailA = "";
                if (!reader.IsDBNull(reader.GetOrdinal("email"))) { 
                    mailA = reader.GetString(5); 
                }
                if (!reader.IsDBNull(reader.GetOrdinal("matiere")))
                {
                    matiere = reader.GetString(4);
                }
                 
                liste_enseignants.Add(new Enseignants() { idUtilisateur = Convert.ToInt32(reader.GetString(0)), idEnseignant = Convert.ToInt32(reader.GetString(1)), nom = reader.GetString(2), prenom = reader.GetString(3), matiere = matiere, mail = mailA,});
            }

            MySqlDataAdapter adpt = new MySqlDataAdapter("SELECT idUtilisateur,idEnseignant, utilisateur.Nom, utilisateur.Prenom,  matieres.matiere, utilisateur.email FROM enseignants INNSER JOIN utilisateur USING(idUtilisateur) LEFT JOIN matieres USING(idMatiere)", conn);
            conn.Close();
            return adpt;
        }
        public List<Enseignants> listEnseignant()
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT idEnseignant, Nom, Prenom, idUtilisateur, idMatiere FROM enseignants";
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                listeEnseignant.Add(new Enseignants() { name = reader.GetString(1) + " " + reader.GetString(2), id = reader.GetInt32(3) });
            }
            reader.Close();
            conn.Close();
            return listeEnseignant;
        }
    }
}
