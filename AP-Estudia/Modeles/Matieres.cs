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
    
    class Matieres
    {
        
        public List<Matieres> ListeMatiere = new List<Matieres>();
        MySqlConnection conn = new MySqlConnection("database=estudia; server=localhost; user id = root; pwd=");
        public string name { get; set; }
        public int id { get; set; }

        public MySqlDataAdapter get_liste_matiere()
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command.CommandText = "SELECT * FROM Matieres";
            MySqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                ListeMatiere.Add(new Matieres() { name = reader.GetString(1), id = Convert.ToInt32(reader.GetString(0)) });
            }
            MySqlDataAdapter adpt = new MySqlDataAdapter(command.CommandText, conn);

            conn.Close();

            return adpt;
            
        }
        public bool ajouterMatiere(string nom)
        {
            conn.Open();
            MySqlCommand command2 = conn.CreateCommand();
            command2.Parameters.AddWithValue("@Nom", nom);

            command2.CommandText = "INSERT INTO matieres (matiere) VALUES(@Nom)";
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
        public bool updateMatiere(int idMatiere, string nom)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@idMatiere", idMatiere);
            command.Parameters.AddWithValue("@nom", nom);


            command.CommandText = "UPDATE matieres SET matiere=@nom WHERE idMatiere = @idMatiere;";
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
        public bool supprMatiere(int idMatiere)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command.Parameters.AddWithValue("@idMatiere", idMatiere);

            command.CommandText = "DELETE FROM matieres  WHERE idMatiere = @idMatiere";
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
