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

    class Salle
    {
        
        public List<Salle> ListeSalle = new List<Salle>();
        public List<Salle> listeSalle = new List<Salle>();

        MySqlConnection conn = new MySqlConnection("database=estudia; server=localhost; user id = root; pwd=");
        public int idSalle { get; set; }
        public string numero { get; set; }
        public int PartId { get; set; }
        public string PartName { get; set; }
        public bool ajouter_salle(string num)
        {
            conn.Open();
            MySqlCommand command2 = conn.CreateCommand();
            command2.Parameters.AddWithValue("@Num", num);

            command2.CommandText = "INSERT INTO salle (numero) VALUES(@Num)";
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
        public bool updateSalle(int idSalle, string num)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@idSalle", idSalle);
            command.Parameters.AddWithValue("@num", num);


            command.CommandText = "UPDATE salle SET numero=@num WHERE IDSalle = @idSalle;";
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
        public bool supprSalle(int idSalle)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command.Parameters.AddWithValue("@idSalle", idSalle);

            command.CommandText = "DELETE FROM salle  WHERE IDSalle = @idSalle";
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

        public MySqlDataAdapter get_liste_salle()
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command.CommandText = "SELECT * FROM salle";
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ListeSalle.Add(new Salle() { numero = reader.GetString(1), idSalle = Convert.ToInt32(reader.GetString(0)) });
            }
            MySqlDataAdapter adpt = new MySqlDataAdapter(command.CommandText, conn);

            conn.Close();

            return adpt;
        }
        public List<Salle> listSalle()
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT idSalle, numero FROM salle";
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                listeSalle.Add(new Salle() { PartName = reader.GetString(1), PartId = reader.GetInt32(0) });
            }
            reader.Close();
            conn.Close();
            return listeSalle;
        }
    }
}
