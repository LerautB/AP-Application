using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using AP_estudia.Modeles;

namespace AP_estudia.Modeles
{
    class Note
    {
        MySqlConnection conn = new MySqlConnection("database=estudia; server=localhost; user id = root; pwd=");
        private List<Note> liste_notes = new List<Note>();

        public int idNote { get; set; }
        public int idProf { get; set; }
        public string nom { get; set; }
        public string matiere { get; set; }
        public int idUtilisateur { get; set; }
        public int idExamen { get; set; }
        public int note { get; set; }
        public string designation { get; set; }
        public int noteMax { get; set; }
        public string commentaire { get; set; }

        public bool updateNote(int idNote, float note, int notemax, string designation,string commentaire)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@idNote", idNote);
            command.Parameters.AddWithValue("@note", note);
            command.Parameters.AddWithValue("@designation", designation);
            
            command.Parameters.AddWithValue("@noteMax", notemax);
            command.Parameters.AddWithValue("@commentaire", commentaire);

            command.CommandText = "UPDATE notes SET Note=@note, NoteMax=@noteMax, designation=@designation, commentaire = @commentaire WHERE idNote = @idNote";
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
        public MySqlDataAdapter getNote(int id)
        {
            conn.Open();
            MySqlCommand commande = conn.CreateCommand();
            MySqlDataAdapter adpt;

            commande.Parameters.AddWithValue("@idNote", id);

            commande.CommandText = "SELECT idNote,enseignants.nom, matieres.matiere,designation, Note, NoteMax, Commentaire FROM notes  LEFT JOIN enseignants ON idProf = idEnseignant LEFT JOIN matieres ON notes.idMatiere=matieres.idMatiere WHERE notes.idNote = @idNote;";


            MySqlDataReader reader = commande.ExecuteReader();
            while (reader.Read())
            {
                this.idNote = Convert.ToInt32(reader.GetString(0));
                this.nom = reader.GetString(1);
                this.matiere = reader.GetString(2);
                this.designation = reader.GetString(3);
                this.note = Convert.ToInt32(reader.GetString(4));
                this.noteMax = Convert.ToInt32(reader.GetString(5));
                this.commentaire = reader.GetString(6);
            }

            adpt = new MySqlDataAdapter(commande.CommandText, conn);
            adpt.SelectCommand.Parameters.AddWithValue("@idNote", id);

            conn.Close();
            return adpt;
        }
        public bool supprNote(int idNote)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command.Parameters.AddWithValue("@idNote", idNote);

            command.CommandText = "DELETE FROM notes WHERE idNote=@idNote;";
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
        public MySqlDataAdapter allNotes(int idUser)
        {
            conn.Open();
            MySqlCommand commande = conn.CreateCommand();
            MySqlDataAdapter adpt;

            commande.CommandText = "SELECT idNote,enseignants.nom, matieres.matiere,designation, Note, NoteMax, Commentaire FROM notes  LEFT JOIN enseignants ON idProf = idEnseignant LEFT JOIN matieres ON notes.idMatiere=matieres.idMatiere WHERE notes.idUtilisateur = @idUser;";
            commande.Parameters.AddWithValue("@idUser", idUser);

      
            MySqlDataReader reader = commande.ExecuteReader();
            while (reader.Read())
            {
                liste_notes.Add(new Note() {  });
            }

            adpt = new MySqlDataAdapter(commande.CommandText, conn);
            adpt.SelectCommand.Parameters.AddWithValue("@idUser", idUser);
           
            conn.Close();
            return adpt;
        }
    }

}

