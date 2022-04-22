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
    public partial class AbsenceForm : Form
    {
        int idAbsence;
        Absence Absence = new Absence();
        public AbsenceForm(int id)
        {
            idAbsence = id;
            InitializeComponent();
            Absence.getAbsence(idAbsence);
            prof.Text = Absence.nom;
            matiere.Text = Absence.matiere;
            date.Text = Absence.date;
            textBox1.Text = Absence.justification;
            if(Absence.verifJustification == "oui")
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
            }
        }


        private void supprimer_Click(object sender, EventArgs e)
        {
            if (Absence.supprAbsence(idAbsence))
            {
                MessageBox.Show("Absence supprimer avec succès");
                this.Close();
            }
            else
            {
                MessageBox.Show("Erreur lors de la suppression");
            }
        }

        private void modifier_Click(object sender, EventArgs e)
        {
            string result = "non";
            if (checkBox1.Checked == true)
            {
                result = "oui";
            }
            else
            {
                result = "non";
            }
            if (Absence.updateAbsence(idAbsence, textBox1.Text, result))
            {
                MessageBox.Show("Mise a jour avec succès");
                this.Close();
            }
            else
            {
                MessageBox.Show("Erreur lors de la mise a jour");
            }
        }
    }
}
