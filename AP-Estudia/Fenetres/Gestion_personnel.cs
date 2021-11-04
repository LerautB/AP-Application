using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AP_Estudia.Fenetres;
using AP_Estudia.Modeles;
using AP_Estudia.Services;

namespace AP_Estudia
{
    public partial class Gestion_personnel : Form
    {
        public Gestion_personnel()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var creation = new CreationPersonnel();
            creation.Show();
        }
    }
}
