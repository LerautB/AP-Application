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
    class Punition
    {
        MySqlConnection conn = new MySqlConnection("database=estudia; server=localhost; user id = root; pwd=");
        private List<Punition> liste_punitions = new List<Punition>();
        public int idPunition { get; set; }
        public string nom { get; set; }
        public string date { get; set; }
        public string motif { get; set; }
        public string punition { get; set; }
        public MySqlDataAdapter allPunitions(int id)
        {
            conn.Open();
            MySqlCommand commande = conn.CreateCommand();
            MySqlDataAdapter adpt;

            commande.CommandText = "SELECT idPunition, enseignants.nom,ladate as 'date',motif,punition FROM punition  LEFT JOIN enseignants ON punition.idUtilisateur=enseignants.idEnseignant WHERE punition.idEleve = @idUser";
            commande.Parameters.AddWithValue("@idUser", id);


            MySqlDataReader reader = commande.ExecuteReader();
            while (reader.Read())
            {
                //string mailA = (reader.GetValue(5) is string) ? reader.GetString(5) : "";
                //int filiereA = (reader.GetValue(3) is string) ? Convert.ToInt32(reader.GetString(3)) : 0;
                //string filiereB = (reader.GetValue(4) is string) ? reader.GetString(4) : "";
                liste_punitions.Add(new Punition() { });
            }

            adpt = new MySqlDataAdapter(commande.CommandText, conn);
            adpt.SelectCommand.Parameters.AddWithValue("@idUser", id);

            conn.Close();
            return adpt;
        }
        public MySqlDataAdapter getPunition(int id)
        {
            conn.Open();
            MySqlCommand commande = conn.CreateCommand();
            MySqlDataAdapter adpt;

            commande.Parameters.AddWithValue("@idPunition", id);

            commande.CommandText = "SELECT idPunition, enseignants.nom,ladate as 'date',motif,punition FROM punition  LEFT JOIN enseignants ON punition.idUtilisateur=enseignants.idEnseignant WHERE punition.idPunition = @idPunition";


            MySqlDataReader reader = commande.ExecuteReader();
            while (reader.Read())
            {
                this.idPunition = Convert.ToInt32(reader.GetString(0));
                this.nom = reader.GetString(1);
                this.date = reader.GetString(2);
                this.motif = reader.GetString(3);
                this.punition = reader.GetString(4);
            }

            adpt = new MySqlDataAdapter(commande.CommandText, conn);
            adpt.SelectCommand.Parameters.AddWithValue("@idAbsence", id);

            conn.Close();
            return adpt;
        }
        public bool supprPunition(int idPunition)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command.Parameters.AddWithValue("@idPunition", idPunition);

            command.CommandText = "DELETE FROM punition WHERE idPunition=@idPunition;";
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
        public bool updatePunition(int idPunition, string date, string motif, string punition)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@idPunition", idPunition);
            command.Parameters.AddWithValue("@date", date);
            command.Parameters.AddWithValue("@motif", motif);

            command.Parameters.AddWithValue("@punition", punition);

            command.CommandText = "UPDATE punition SET ladate=@date, motif=@motif, punition = @punition WHERE idPunition = @idPunition";
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
