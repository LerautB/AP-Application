using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using AP_estudia.Modeles;
using System.Windows.Forms;
using AP_estudia.Services;

namespace AP_estudia.Modeles
{
    class Classe
    {
        MySqlConnection conn = new MySqlConnection("database=estudia; server=localhost; user id = root; pwd=");
        public List<Classe> liste_classes = new List<Classe>();
        public List<Classe> listeClasse = new List<Classe>();

        public string nameClasse { get; set; }
        public string numClasse { get; set; }
        public int idClasse { get; set; }
        public int PartId { get; set; }
        public string PartName { get; set; }

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
            conn.Open();
            MySqlCommand commande = conn.CreateCommand();

            commande.CommandText = "SELECT * FROM etudes;";
            MySqlDataReader reader = commande.ExecuteReader();
            while (reader.Read())
            {
                liste_classes.Add(new Classe() { nameClasse = reader.GetString(2), numClasse = reader.GetString(1), idClasse = Convert.ToInt32(reader.GetString(0)) });
            }

            MySqlDataAdapter adpt = new MySqlDataAdapter("SELECT * FROM etudes", conn);
            conn.Close();
            return adpt;
        }
        public List<Classe> listClasse(/*int idEtude*/)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            //command.Parameters.AddWithValue("@idEtude", idEtude);
            command.CommandText = "SELECT idEtude, nom, classe FROM etudes";
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                listeClasse.Add(new Classe() { PartName = reader.GetString(1) + " " + reader.GetString(2), PartId = reader.GetInt32(0) });
            }
            reader.Close();
            conn.Close();
            return listeClasse;
        }

    }
}
