using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using AP_estudia.Modeles;

namespace AP_estudia.Modeles
{
    public class Eleve
    {
        MySqlConnection conn = new MySqlConnection("database=estudia; server=localhost; user id = root; pwd=");
        public List<Eleve> liste_etu = new List<Eleve>();
        public List<Eleve> listeEleve = new List<Eleve>();

        public int id { get; set; } 

        public string nom { get; set; }
        public string prenom { get; set; }
        public int idFiliere { get; set; }
        public string filiere { get; set; }
        public string email { get; set; }
        public int idEtude { get; set; }
        public string classe { get; set; }

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
        public bool updateEtudiants(int idUtilisateur, string nom, string prenom, int filiere, int classe ,string email)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@idUtilisateur", idUtilisateur);
            command.Parameters.AddWithValue("@nom", nom);
            command.Parameters.AddWithValue("@prenom", prenom);
            command.Parameters.AddWithValue("@filiere", filiere);
            command.Parameters.AddWithValue("@classe", classe);
            command.Parameters.AddWithValue("@email", email);

            command.CommandText = "UPDATE eleve SET nom=@nom, prenom=@prenom, IDfiliere = @filiere, idEtude = @classe WHERE idUtilisateur = @idUtilisateur;" +
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
        public bool supprEtudiant(int idUtilisateur)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command.Parameters.AddWithValue("@idUtilisateur", idUtilisateur);

            command.CommandText = "DELETE FROM eleve  WHERE idUtilisateur = @idUtilisateur; DELETE FROM utilisateur  WHERE idUtilisateur = @idUtilisateur;";
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
        public MySqlDataAdapter allEtudiants(int? idClasse = null)
        {
            conn.Open();
            MySqlCommand commande = conn.CreateCommand();
            MySqlDataAdapter adpt;
            if (idClasse == null)
            {
                commande.CommandText = "SELECT idUtilisateur, utilisateur.nom, utilisateur.prenom, filiere.IDfiliere,filiere.nom as 'Filiere',utilisateur.email,idEtude, etudes.nom as 'classe', etudes.classe as 'n' FROM eleve INNER JOIN utilisateur USING(idUtilisateur) LEFT JOIN filiere USING(IDfiliere) LEFT JOIN etudes USING(idEtude);";

            }
            else
            {
                commande.Parameters.AddWithValue("@idClasse", idClasse);

                commande.CommandText = "SELECT idUtilisateur, utilisateur.nom, utilisateur.prenom, filiere.IDfiliere,filiere.nom as 'Filiere',utilisateur.email,idEtude, etudes.nom as 'classe', etudes.classe as 'n' FROM eleve INNER JOIN utilisateur USING(idUtilisateur) LEFT JOIN filiere USING(IDfiliere) LEFT JOIN etudes USING(idEtude) WHERE idEtude= @idClasse;";

            }
            MySqlDataReader reader = commande.ExecuteReader();
            while (reader.Read())
            {
                string mailA = (reader.GetValue(5) is string) ? reader.GetString(5) : "";
                int filiereA = (reader.GetValue(3) is string) ? Convert.ToInt32(reader.GetString(3)) : 0;
                string filiereB = (reader.GetValue(4) is string) ? reader.GetString(4): "";
                int idEtude = (reader.GetValue(6) is string) ? Convert.ToInt32(reader.GetString(6)) : 0;
                string classe = (reader.GetValue(6) is string) ? reader.GetString(6) + ' ' + reader.GetString(7): "";
                liste_etu.Add(new Eleve() { id = Convert.ToInt32(reader.GetString(0)), nom = reader.GetString(1), prenom = reader.GetString(2), idFiliere = filiereA, filiere = filiereB, email = mailA, idEtude = idEtude, classe = classe });
            }

            if (idClasse == null)
            {
                adpt = new MySqlDataAdapter(commande.CommandText, conn);
                
            }
            else
            {

                adpt = new MySqlDataAdapter(commande.CommandText, conn);
                adpt.SelectCommand.Parameters.AddWithValue("@idClasse", idClasse);
            }
            conn.Close();
            return adpt;
        }
        public MySqlDataAdapter allEtudiantsProfil(int? idClasse = null)
        {
            conn.Open();
            MySqlCommand commande = conn.CreateCommand();
            MySqlDataAdapter adpt;
            if (idClasse == null)
            {
                commande.CommandText = "SELECT idUtilisateur, utilisateur.nom, utilisateur.prenom FROM utilisateur";

            }
            else
            {
                commande.Parameters.AddWithValue("@idClasse", idClasse);

                commande.CommandText = "SELECT idUtilisateur, utilisateur.nom, utilisateur.prenom FROM utilisateur WHERE idEtude= @idClasse;";

            }
            MySqlDataReader reader = commande.ExecuteReader();
            while (reader.Read())
            {
                liste_etu.Add(new Eleve() { id = Convert.ToInt32(reader.GetString(0)), nom = reader.GetString(1), prenom = reader.GetString(2)});
            }

            if (idClasse == null)
            {
                adpt = new MySqlDataAdapter(commande.CommandText, conn);

            }
            else
            {

                adpt = new MySqlDataAdapter(commande.CommandText, conn);
                adpt.SelectCommand.Parameters.AddWithValue("@idClasse", idClasse);
            }
            conn.Close();
            return adpt;
        }
        public MySqlDataAdapter studentProfil(int idUser)
        {
            conn.Open();
            MySqlCommand commande = conn.CreateCommand();
            MySqlDataAdapter adpt;

                commande.Parameters.AddWithValue("@idUser", idUser);

                commande.CommandText = "SELECT idUtilisateur, eleve.nom, eleve.prenom,filiere.nom as 'Filiere',etudes.nom as 'Classe',etudes.classe as 'numéro' FROM eleve LEFT JOIN etudes USING(idEtude) LEFT JOIN filiere USING(IDfiliere) WHERE idUtilisateur=@idUser";

            
            MySqlDataReader reader = commande.ExecuteReader();
            while (reader.Read())
            {
                this.id = Convert.ToInt32(reader.GetString(0));
                this.nom = reader.GetString(1);
                this.prenom = reader.GetString(2);
                if (!reader.IsDBNull(reader.GetOrdinal("Filiere")))
                {
                    this.filiere = reader.GetString(3);
                }
                else
                {
                    this.filiere = "";
                }
                this.classe = reader.GetString(4) + " " + reader.GetString(5);
            }

                adpt = new MySqlDataAdapter(commande.CommandText, conn);
                adpt.SelectCommand.Parameters.AddWithValue("@idUser", idUser);
            
            conn.Close();
            return adpt;
        }

        public List<Eleve> listeEleveSansClasse()
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT idUtilisateur, nom, prenom FROM eleve WHERE idEtude IS NULL";
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                liste_etu.Add(new Eleve() { nom = reader.GetString(1) + " " + reader.GetString(2), id = reader.GetInt32(0) });
            }
            
            reader.Close();
            conn.Close();
            return liste_etu;
        }
        public bool updateClasseEleve(int idUtilisateur, int classe)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@idUtilisateur", idUtilisateur);
            command.Parameters.AddWithValue("@classe", classe);


            command.CommandText = "UPDATE eleve SET idEtude = @classe WHERE idUtilisateur = @idUtilisateur";
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

    }
  }

