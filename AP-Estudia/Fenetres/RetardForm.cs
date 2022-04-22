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
    public partial class RetardForm : Form
    {
        int idRetard;
        Retard Retard = new Retard();
        public RetardForm(int id)
        {
            idRetard = id;
            InitializeComponent();
            Retard.getRetard(idRetard);
            prof.Text = Retard.nom;
            matiere.Text = Retard.matiere;
            date.Text = Retard.date;
            textBox1.Text = Retard.justification;
            if(Retard.verifJustification == "oui")
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
            if (Retard.supprRetard(idRetard))
            {
                MessageBox.Show("Retard supprimer avec succès");
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
            if (Retard.updateRetard(idRetard, textBox1.Text, result)){
                MessageBox.Show("Mise a jour avec succès");
                this.Close();
            }
            else
            {
                MessageBox.Show("Erreur lors de la mise a jours");
            }
        }
    }
}
