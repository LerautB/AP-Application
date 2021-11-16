using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using AP_Estudia.Modeles;
using System.Windows.Forms;
using AP_Estudia.Services;
using System.Collections.Generic;

namespace AP_Estudia.Modeles
{
    class Classe
    {
        MySqlConnection conn = new MySqlConnection("database=estudia; server=localhost; user id = root; pwd=");
        private List<Part> liste_classes = new List<Part>();
        //MySqlDataAdapter adpt;
        //DataTable dt;
        

        //public bool displayData()
        //{
        //    string requete = "SELECT * FROM etudes";
        //    conn.Open();
        //    adpt = new MySqlDataAdapter(requete, conn);
        //    dt = new DataTable();
        //    conn.Close();
        //    return requete;
        //}
        public bool updateClasse(string numClasse, string nomClasse, int idClasse)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@nbClasse", numClasse);
            command.Parameters.AddWithValue("@nomClasse", nomClasse);
            command.Parameters.AddWithValue("@idClasse", idClasse);

            command.CommandText = "UPDATE etudes SET classe=@nbClasse, nom=@nomClasse WHERE idEtude = @idClasse";
            if(command.ExecuteNonQuery() > 0)
            {
                conn.Close();
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public bool supprClasse(int idClasse)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            
            command.Parameters.AddWithValue("@idClasse", idClasse);

            command.CommandText = "DELETE FROM etudes WHERE idEtude = @idclasse";
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
        public bool creationClasse(string nbClasse, string nameClasse)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@nbclasse", nbClasse);
            command.Parameters.AddWithValue("@nomclasse", nameClasse);
            command.CommandText = "insert into etudes (classe, nom) values (@nbclasse, @nomclasse)";
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

        public MySqlDataAdapter allClasse()
        {
            //MySqlCommand commande = conn.CreateCommand();

            //commande.CommandText = "SELECT * FROM classes;";
            //MySqlDataReader reader = commande.ExecuteReader();
            //while (reader.Read())
            //{
            //    liste_classes.Add(new Part() { PartName = reader.GetString(1), PartId = Convert.ToInt32(reader.GetString(0)) });
            //}
            conn.Open();
            MySqlDataAdapter adpt = new MySqlDataAdapter("SELECT * FROM etudes", conn);
            conn.Close();
            return adpt;
        }
        public List<Part> Test
        {
            get
            {
                return liste_classes;
            }
            protected set
            {
                liste_classes = value;
            }
        }
    }
}
