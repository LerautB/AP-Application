using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using AP_estudia.Modeles;
namespace AP_estudia.Modeles
{
    class Absence
    {
        MySqlConnection conn = new MySqlConnection("database=estudia; server=localhost; user id = root; pwd=");
        private List<Absence> liste_absences = new List<Absence>();

        public int idCours { get; set; }
        public int idAbsence { get; set; }
        public string nom { get; set; }
        public string date { get; set; }
        public string matiere { get; set; }
        public int idUtilisateur { get; set; }
        public string justification { get; set; }
        public string verifJustification { get; set; }

        public MySqlDataAdapter allAbsences(int id)
        {
            conn.Open();
            MySqlCommand commande = conn.CreateCommand();
            MySqlDataAdapter adpt;

            commande.CommandText = "SELECT idAbsence,enseignants.nom,edt.matiere,edt.date,justification,verifJustification FROM absence  LEFT JOIN edt USING(idCours) LEFT JOIN enseignants ON edt.idUtilisateur = enseignants.idEnseignant WHERE absence.idUtilisateur = @idUser;";
            commande.Parameters.AddWithValue("@idUser", id);


            MySqlDataReader reader = commande.ExecuteReader();
            while (reader.Read())
            {
                //string mailA = (reader.GetValue(5) is string) ? reader.GetString(5) : "";
                //int filiereA = (reader.GetValue(3) is string) ? Convert.ToInt32(reader.GetString(3)) : 0;
                //string filiereB = (reader.GetValue(4) is string) ? reader.GetString(4) : "";
                liste_absences.Add(new Absence() { });
            }

            adpt = new MySqlDataAdapter(commande.CommandText, conn);
            adpt.SelectCommand.Parameters.AddWithValue("@idUser", id);

            conn.Close();
            return adpt;
        }
        public MySqlDataAdapter getAbsence(int idAbsence)
        {
            conn.Open();
            MySqlCommand commande = conn.CreateCommand();
            MySqlDataAdapter adpt;

            commande.Parameters.AddWithValue("@idAbsence", idAbsence);

            commande.CommandText = "SELECT idAbsence,enseignants.nom,edt.matiere,edt.date,justification,verifJustification FROM absence  LEFT JOIN edt USING(idCours) LEFT JOIN enseignants ON edt.idUtilisateur = enseignants.idEnseignant WHERE absence.idAbsence = @idAbsence;";


            MySqlDataReader reader = commande.ExecuteReader();
            while (reader.Read())
            {
                this.idAbsence = Convert.ToInt32(reader.GetString(0));
                this.nom = reader.GetString(1);
                this.matiere = reader.GetString(2);
                this.date = reader.GetString(3);
                this.justification = reader.GetString(4);
                this.verifJustification = reader.GetString(5);
            }

            adpt = new MySqlDataAdapter(commande.CommandText, conn);
            adpt.SelectCommand.Parameters.AddWithValue("@idAbsence", idAbsence);

            conn.Close();
            return adpt;
        }
        public bool supprAbsence(int idAbsence)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command.Parameters.AddWithValue("@idAbsence", idAbsence);

            command.CommandText = "DELETE FROM absence WHERE idAbsence=@idAbsence;";
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
        public bool updateAbsence(int idAbsence, string motif, string verif)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@idAbsence", idAbsence);
            command.Parameters.AddWithValue("@motif", motif);

            command.Parameters.AddWithValue("@verif", verif);

            command.CommandText = "UPDATE absence SET justification=@motif, verifJustification = @verif WHERE idAbsence = @idAbsence";
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



