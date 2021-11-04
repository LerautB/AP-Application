using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using AP_Estudia.Modeles;

namespace AP_Estudia.Modeles
{
    public class Part : IEquatable<Part>
    {
        public string PartName { get; set; }

        public int PartId { get; set; }

        public override string ToString()
        {
            return "ID: " + PartId + "   Name: " + PartName;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Part objAsPart = obj as Part;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }
        public override int GetHashCode()
        {
            return PartId;
        }
        public bool Equals(Part other)
        {
            if (other == null) return false;
            return (this.PartId.Equals(other.PartId));
        }
        // Should also override == and != operators.
    }
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
