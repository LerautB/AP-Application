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
    class EDT
    {
        List<string> infoEDT = new List<string>();
        MySqlConnection conn = new MySqlConnection("database=estudia; server=localhost; user id = root; pwd=");

        //RECUP DONNEE DE L'EMPLOI DU TEMPS -> visuEDT
        public List<string> listCoursEDT(string idClasse)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command.Parameters.AddWithValue("@idClasse", idClasse);
            DateTime date = DateTime.Today;
            command.Parameters.AddWithValue("@date", date);
            command.CommandText = "SELECT idUtilisateur, enseignants.Nom, enseignants.Prenom, matiere, idSalle, date, horaireDebut, horaireFin, idClasse FROM edt INNER JOIN enseignants ON enseignants.idUtilisateur = edt.idUtilisateur INNER JOIN matieres ON matieres.idMatiere = edt.idMatiere WHERE idClasse = @idClasse AND WHERE date = @date";
            MySqlDataReader reader = command.ExecuteReader();
            int x = 0;
            while (reader.Read())
            {
                infoEDT.Add(reader.GetString(x));
                x++;
            }
            return infoEDT;
        }
        public bool CreationEdt(int idUser, int idSalle, int idClasse, string matiere, DateTime date, string horaireDebut, string horaireFin)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command.Parameters.AddWithValue("@idUtilisateur", idUser);
            command.Parameters.AddWithValue("@idSalle", idSalle);
            command.Parameters.AddWithValue("@idClasse", idClasse);
            command.Parameters.AddWithValue("@matiere", matiere);
            command.Parameters.AddWithValue("@date", date);
            command.Parameters.AddWithValue("@horaireDebut", horaireDebut);
            command.Parameters.AddWithValue("@horaireFin", horaireFin);

            command.CommandText = "INSERT INTO edt (idUtilisateur, idSalle, idClasse, matiere, date, horaireDebut, horaireFin) VALUES (@idUtilisateur, @idSalle, @idClasse,@matiere, @date, @horaireDebut, @horaireFin)";

            if (command.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("insertion effectué");
                conn.Close();
                return true;
            }
            else
            {
                MessageBox.Show("raté");
                conn.Close();
                return false;
            }

        }
    }
}