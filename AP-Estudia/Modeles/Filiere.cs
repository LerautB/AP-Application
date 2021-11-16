using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using AP_Estudia.Services;
using AP_Estudia.Modeles;
using System.Collections.Generic;
using System;

namespace AP_Estudia.Modeles
{

    class Filiere
    {

        private List<Part> ListeFiliere = new List<Part>();
        MySqlConnection conn = new MySqlConnection("database=estudia; server=localhost; user id = root; pwd=");
        public bool get_liste_filiere()
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command.CommandText = "SELECT * FROM filiere";
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ListeFiliere.Add(new Part() { PartName = reader.GetString(1), PartId = Convert.ToInt32(reader.GetString(0)) });
            }
            conn.Close();

            return true;
        }
        public List<Part> Test
        {
            get
            {
                return ListeFiliere;
            }
            protected set
            {
                ListeFiliere = value;
            }
        }
    }
}
