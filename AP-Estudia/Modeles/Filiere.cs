using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using AP_estudia.Services;
using AP_estudia.Modeles;
using System.Collections.Generic;
using System;

namespace AP_estudia.Modeles
{

    class Filiere
    {

        public List<Filiere> ListeFiliere = new List<Filiere>();
        MySqlConnection conn = new MySqlConnection("database=estudia; server=localhost; user id = root; pwd=");
        public int idFiliere { get; set; }
        public string name { get; set; }
        public bool ajouter_filiere(string nom)
        {
            conn.Open();
            MySqlCommand command2 = conn.CreateCommand();
            command2.Parameters.AddWithValue("@Nom", nom);

            command2.CommandText = "INSERT INTO filiere (nom) VALUES(@Nom)";
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
        public bool updateFiliere(int idFiliere, string nom)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@idFiliere", idFiliere);
            command.Parameters.AddWithValue("@nom", nom);


            command.CommandText = "UPDATE filiere SET nom=@nom WHERE IDfiliere = @idFiliere;";
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
        public bool supprFiliere(int idFiliere)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command.Parameters.AddWithValue("@idFiliere", idFiliere);

            command.CommandText = "DELETE FROM filiere  WHERE IDfiliere = @idFiliere";
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

        public MySqlDataAdapter get_liste_filiere()
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command.CommandText = "SELECT * FROM filiere";
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ListeFiliere.Add(new Filiere() { name = reader.GetString(1), idFiliere = Convert.ToInt32(reader.GetString(0)) });
            }
            MySqlDataAdapter adpt = new MySqlDataAdapter(command.CommandText, conn);

            conn.Close();

            return adpt;
        }
    }
}
