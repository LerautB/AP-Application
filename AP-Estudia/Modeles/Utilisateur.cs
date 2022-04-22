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
using AP_estudia.Modeles;
using AP_estudia.Services;


namespace AP_estudia.Modeles
{
    using BCrypt.Net;
    public class Utilisateur
        
    {
        private List<Utilisateur> liste_Utilisateurs = new List<Utilisateur>();
        MySqlConnection conn = new MySqlConnection("database=estudia; server=localhost; user id = root; pwd=");
        public string prenom { get; set; }
        public string nom { get; set; }
        public int idUtilisateur { get; set; }
        public string email { get; set; }
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
                if(User_statut != "Administration")
                {
                    return false;
                }

            }
            // Fermeture de la connexion
            conn.Close();

            if (BCrypt.Verify(mot_de_passe, User_mdp))
            {
                //MessageBox.Show("Connexion réussi...");
                //estudia f = new estudia();
                //f.Show();

                return true;
            }
            else
            {
                
                return false;
            }


        } 
        public bool Inscription(string nom,string prenom,string email ,string dateNaiss, string status,int idMat = 0,string matiere = "", string idEtude = "")
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            string identifiant = Services.Services.randomID(nom, prenom);
            string mdpTemp = Services.Services.randomPassword();
            string mdpHash = BCrypt.HashPassword(mdpTemp);
            
            command.Parameters.AddWithValue("@nom", nom);
            command.Parameters.AddWithValue("@prenom", prenom);
            command.Parameters.AddWithValue("@identifiant", identifiant);
            
            command.Parameters.AddWithValue("@mdpHash", mdpHash);
            command.Parameters.AddWithValue("@mdpTemp", mdpTemp);
            command.Parameters.AddWithValue("@status", status);
            command.Parameters.AddWithValue("@dateNaiss", dateNaiss);
            
            if(email.Length > 0)
            {
                command.Parameters.AddWithValue("@mail", email);
                command.CommandText = ("INSERT INTO utilisateur (identifiant,nom, prenom,email,dateNaiss, mdp, mdpTemp,statut) VALUES (@identifiant,@nom,@prenom,@mail,@dateNaiss,@mdpHash,@mdpTemp,@status)");
            }
            else
            {
                command.CommandText = ("INSERT INTO utilisateur (identifiant,nom, prenom,dateNaiss, mdp, mdpTemp,statut) VALUES (@identifiant,@nom,@prenom,@dateNaiss,@mdpHash,@mdpTemp,@status)");

            }

            
            if (command.ExecuteNonQuery() > 0) 
            {
                if (status == "Professeur")
                {
                    var User = new Enseignants();
                    if (User.ajouter_enseignant(nom, prenom,idMat,matiere) == true)
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
                else if (status == "Etudiant")
                {
                    var User = new Eleve();
                    if (User.ajouter_etudiant(nom, prenom, idEtude) == true)
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
                else if (status == "Administration")
                {
                    conn.Close();
                    return true;
                }
            } 
            else 
            {
                conn.Close();
                return false;
            }
            conn.Close();
            return false;
        }
        public bool updateAdministration(int idUser, string prenom,string nom, string email)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@prenom", prenom);
            command.Parameters.AddWithValue("@nom", nom);
            command.Parameters.AddWithValue("@idUser", idUser);
            command.Parameters.AddWithValue("@email", email);
            

            command.CommandText = "UPDATE utilisateur SET prenom=@prenom, nom=@nom, idUtilisateur=@idUser, email=@email WHERE idUtilisateur = @idUser";
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
        public bool supprUser(int idUtilisateur)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command.Parameters.AddWithValue("@idUtilisateur", idUtilisateur);

            command.CommandText = "DELETE FROM utilisateur WHERE idUtilisateur = @idUtilisateur";
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
        public MySqlDataAdapter listeAdministration()
        {
            conn.Open();
            MySqlCommand commande = conn.CreateCommand();

            commande.CommandText = "SELECT idUtilisateur,prenom,nom,email FROM utilisateur WHERE statut='Administration'";
            MySqlDataReader reader = commande.ExecuteReader();
            while (reader.Read())
            {
                string mail = (reader.GetValue(3) is string) ? reader.GetString(3) : "";
                liste_Utilisateurs.Add(new Utilisateur() { prenom = reader.GetString(1), nom = reader.GetString(2), idUtilisateur = Convert.ToInt32(reader.GetString(0)), email = mail });
            }

            MySqlDataAdapter adpt = new MySqlDataAdapter("SELECT idUtilisateur,prenom,nom,email FROM utilisateur WHERE statut='Administration'", conn);
            conn.Close();
            return adpt;
        }
    }
}


