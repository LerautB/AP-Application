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
    public partial class PunitionForm : Form
    {
        int idPunition;
        Punition Punition = new Punition();
        public PunitionForm(int id)
        {
            idPunition = id;
            InitializeComponent();
            Punition.getPunition(idPunition);
            prof.Text = Punition.nom;
            dateTimePicker1.Text = Punition.date;
            motif.Text = Punition.motif;
            punitionTextbox.Text = Punition.punition;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Punition.supprPunition(idPunition))
            {
                MessageBox.Show("Punition supprimer avec succès");
                this.Close();
            }
            else
            {
                MessageBox.Show("Erreur lors de la suppression");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Punition.updatePunition(idPunition,dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"), motif.Text,punitionTextbox.Text))
            {
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
