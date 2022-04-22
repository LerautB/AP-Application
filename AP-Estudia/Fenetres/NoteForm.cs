using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AP_estudia.Fenetres;
using AP_estudia.Modeles;
using MySql.Data.MySqlClient;

namespace AP_estudia.Fenetres
{
    public partial class NoteForm : Form
    {
        int idNote;
        Note Note = new Note();
        public NoteForm(int id)
        {
            idNote = id;
            InitializeComponent();
            Note.getNote(idNote);
            matiere.Text = Note.matiere;
            prof.Text = Note.nom;
            noteInput.Value = Note.note;
            noteMax.Value = Note.noteMax;
            designation.Text = Note.designation;
            commentaire.Text = Note.commentaire;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Note.supprNote(idNote))
            {
                MessageBox.Show("mise a jour avec succès");
            }
            else
            {
                MessageBox.Show("erreur de mise a jour");
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(Note.updateNote(idNote, (float)noteInput.Value, (int)noteMax.Value, designation.Text, commentaire.Text)){
                MessageBox.Show("mise a jour avec succès");
            }
            else
            {
                MessageBox.Show("erreur de mise a jour");
            }
            this.Close();
        }
    }
}
