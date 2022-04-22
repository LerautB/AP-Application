using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using AP_estudia.Modeles;

namespace AP_estudia.Modeles
{
    class Etude
    {
        MySqlConnection conn = new MySqlConnection("database=estudia; server=localhost; user id = root; pwd=");
        public List<Etude> liste_classes = new List<Etude>();
        public int idEtude{ get; set; }
        public int numclass { get; set; }
        public string classe { get; set; }

        public MySqlDataAdapter allSeconde() 
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command.CommandText = "SELECT * FROM etudes where nom = 'Seconde'";
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                liste_classes.Add(new Etude() { classe = reader.GetString(2), numclass = Convert.ToInt32(reader.GetString(1)), idEtude = Convert.ToInt32(reader.GetString(0)) });
            }
            MySqlDataAdapter adpt = new MySqlDataAdapter(command.CommandText, conn);

            conn.Close();

            return adpt;
        }
        public MySqlDataAdapter allPremiere()
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command.CommandText = "SELECT * FROM etudes where nom = 'Première'";
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                liste_classes.Add(new Etude() { classe = reader.GetString(2), numclass = Convert.ToInt32(reader.GetString(1)), idEtude = Convert.ToInt32(reader.GetString(0)) });
            }
            MySqlDataAdapter adpt = new MySqlDataAdapter(command.CommandText, conn);

            conn.Close();

            return adpt;
        }
        public MySqlDataAdapter allTerminal()
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command.CommandText = "SELECT * FROM etudes where nom = 'Terminale'";
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                liste_classes.Add(new Etude() { classe = reader.GetString(2), numclass = Convert.ToInt32(reader.GetString(1)), idEtude = Convert.ToInt32(reader.GetString(0)) });
            }
            MySqlDataAdapter adpt = new MySqlDataAdapter(command.CommandText, conn);

            conn.Close();

            return adpt;
        }
    }
}
