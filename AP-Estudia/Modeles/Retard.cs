using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using AP_estudia.Modeles;

namespace AP_estudia.Modeles
{
    class Retard
    {
        MySqlConnection conn = new MySqlConnection("database=estudia; server=localhost; user id = root; pwd=");
        private List<Retard> liste_retards = new List<Retard>();

        public int idCours { get; set; }
        public int idRetard { get; set; }
        public int idUtilisateur { get; set; }
        public string nom { get; set; }
        public string date { get; set; }
        public string matiere { get; set; }
        public string justification { get; set; }
        public string verifJustification { get; set; }
        public MySqlDataAdapter allRetards(int id)
        {
            conn.Open();
            MySqlCommand commande = conn.CreateCommand();
            MySqlDataAdapter adpt;

            commande.CommandText = "SELECT idRetard,enseignants.nom,edt.matiere,edt.date,justification,verifJustification FROM retards  LEFT JOIN edt USING(idCours) LEFT JOIN enseignants ON edt.idUtilisateur = enseignants.idEnseignant WHERE retards.idUtilisateur = @idUser;";
            commande.Parameters.AddWithValue("@idUser", id);


            MySqlDataReader reader = commande.ExecuteReader();
            while (reader.Read())
            {
                //string mailA = (reader.GetValue(5) is string) ? reader.GetString(5) : "";
                //int filiereA = (reader.GetValue(3) is string) ? Convert.ToInt32(reader.GetString(3)) : 0;
                //string filiereB = (reader.GetValue(4) is string) ? reader.GetString(4) : "";
                liste_retards.Add(new Retard() { });
            }

            adpt = new MySqlDataAdapter(commande.CommandText, conn);
            adpt.SelectCommand.Parameters.AddWithValue("@idUser", id);

            conn.Close();
            return adpt;
        }
        public MySqlDataAdapter getRetard(int idRetard)
        {
            conn.Open();
            MySqlCommand commande = conn.CreateCommand();
            MySqlDataAdapter adpt;

            commande.Parameters.AddWithValue("@idRetard", idRetard);

            commande.CommandText = "SELECT idRetard,enseignants.nom,edt.matiere,edt.date,justification,verifJustification FROM retards  LEFT JOIN edt USING(idCours) LEFT JOIN enseignants ON edt.idUtilisateur = enseignants.idEnseignant WHERE retards.idRetard = @idRetard;";


            MySqlDataReader reader = commande.ExecuteReader();
            while (reader.Read())
            {
                this.idRetard = Convert.ToInt32(reader.GetString(0));
                this.nom = reader.GetString(1);
                this.matiere = reader.GetString(2);
                this.date = reader.GetString(3);
                this.justification = reader.GetString(4);
                this.verifJustification = reader.GetString(5);
            }

            adpt = new MySqlDataAdapter(commande.CommandText, conn);
            adpt.SelectCommand.Parameters.AddWithValue("@idAbsence", idRetard);

            conn.Close();
            return adpt;
        }
        public bool updateRetard(int idRetard, string justification, string verif)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@idRetard", idRetard);
            command.Parameters.AddWithValue("@justification", justification);
            command.Parameters.AddWithValue("@verif", verif);

            command.CommandText = "UPDATE retards SET justification=@justification, verifJustification=@verif WHERE idRetard = @idRetard";
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
        public bool supprRetard(int idRetard)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command.Parameters.AddWithValue("@idRetard", idRetard);

            command.CommandText = "DELETE FROM retards WHERE idRetard=@idRetard;";
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
    }
}