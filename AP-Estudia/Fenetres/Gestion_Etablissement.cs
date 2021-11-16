using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AP_Estudia.Modeles;
using AP_Estudia.Services;
using AP_Estudia.Fenetres;

namespace AP_Estudia
{
    public partial class Gestion_Etablissement : Form
    {
        public Gestion_Etablissement()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                this.Hide();
                var creation = new Creation_Etudiant();
                creation.Show();
            
        }
    }
}
