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
using AP_estudia.Modeles;
using AP_estudia.Services;
using AP_estudia.Fenetres;

namespace AP_estudia.Fenetres
{
    public partial class Profil : Form
    {
        int idEtudiant;
        int idTarget;
        Eleve Eleve = new Eleve();
        string datagrid_mode = "";
        public Profil(int idUser)
        {
            InitializeComponent();
            idEtudiant = idUser;
            InitEleve();
        }

        private void InitEleve()
        {
            
            Eleve.studentProfil(idEtudiant);
            nomEtu.Text = Eleve.nom;
            prenomEtu.Text = Eleve.prenom;
            classeEtu.Text = Eleve.classe;
            filiereEtu.Text = Eleve.filiere;
        }

        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void notes_Click(object sender, EventArgs e)
        {
            displayNotesData();
            datagrid_mode = "note";
        }
        private void absences_Click(object sender, EventArgs e)
        {
            displayAbsenceData();
            datagrid_mode = "absence";
        }
        private void retards_Click(object sender, EventArgs e)
        {
            displayRetardData();
            datagrid_mode = "retard";
        }
        private void punitions_Click(object sender, EventArgs e)
        {
            displayPunitionsData();
            datagrid_mode = "punition";
        }
        public void displayNotesData()
        {
            MySqlDataAdapter liste;
            Note Note = new Note();
            liste = Note.allNotes(Eleve.id);
            DataTable dt = new DataTable();
            liste.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        public void displayPunitionsData()
        {
            MySqlDataAdapter liste;
            Punition Punition = new Punition();
            liste = Punition.allPunitions(Eleve.id);
            DataTable dt = new DataTable();
            liste.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public void displayRetardData()
        {
            MySqlDataAdapter liste;
            Retard Retard = new Retard();
            liste = Retard.allRetards(Eleve.id);
            DataTable dt = new DataTable();
            liste.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        public void displayAbsenceData()
        {
            MySqlDataAdapter liste;
            Absence Absence = new Absence();
            liste = Absence.allAbsences(Eleve.id);
            DataTable dt = new DataTable();
            liste.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!String.IsNullOrEmpty(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()))
            {
                idTarget = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                Console.WriteLine(idTarget);
                Console.WriteLine(datagrid_mode);

                if (datagrid_mode == "note")
                {
                    var myForm = new NoteForm(idTarget);
                    myForm.Show();
                }
                else if (datagrid_mode == "absence")
                {
                    var myForm = new AbsenceForm(idTarget);

                    myForm.Show();

                }
                else if (datagrid_mode == "retard")
                {
                    var myForm = new RetardForm(idTarget);
                    myForm.AutoScroll = true;

                    myForm.Show();
                }
                else if (datagrid_mode == "punition")
                {
                    var myForm = new PunitionForm(idTarget);
                    myForm.Show();
                }
            }
        }
    }
}
