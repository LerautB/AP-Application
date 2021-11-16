﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using AP_Estudia.Modeles;
using AP_Estudia.Services;

namespace AP_Estudia.Modeles
{
    
    class Matieres
    {
        
        private List<Part> ListeMatiere = new List<Part>();
        MySqlConnection conn = new MySqlConnection("database=estudia; server=localhost; user id = root; pwd=");
        public bool get_liste_matiere()
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command.CommandText = "SELECT * FROM Matieres";
            MySqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                ListeMatiere.Add(new Part() { PartName = reader.GetString(1), PartId = Convert.ToInt32(reader.GetString(0)) });
            }
            conn.Close();

            return true;
        }
        public List<Part> Test
        {
            get
            {
                return ListeMatiere;
            }
            protected set
            {
                ListeMatiere = value;
            }
        }
    }
}
