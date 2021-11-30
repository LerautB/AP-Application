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
using AP_Estudia.Services;

namespace AP_Estudia
{
    public partial class selecteClasse : Form
    {
        public selecteClasse()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            var edt = new visuEDT();
            edt.Show();
        }

        private void listeClasses(object sender, EventArgs e)
        {
            var classes = new Classe();
            classes.allClasse();
            
            foreach(Part aPart in classes.Test)
            {
                ComboBoxItem classe = new ComboBoxItem();
                classe.Text = aPart.PartName + " " + aPart.PartNumClasse;
                classe.Value = aPart.PartId;
                this.listeClasse.Items.Add(classe);
            }
        }
    }
}
