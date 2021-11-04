using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AP_Estudia.Services;
using AP_Estudia.Modeles;
using MySql.Data.MySqlClient;

namespace AP_Estudia.Fenetres
{
    public partial class CreationPersonnel : Form
    {
        public CreationPersonnel()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            var User = new Utilisateur();

           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Select = this.comboBox1.Text;
            if(Select == "Enseignant")
            {
                
                var Matieres = new Matieres();
                var reader = Matieres.get_liste_matiere();
                
                foreach (Part aPart in Matieres.Test)
                {
                    this.comboBox2.Items.AddRange(new object[] { aPart.PartName });
                }
                
                
                this.comboBox2.Show();
            }
            if(Select == "Administration")
            {
                this.comboBox2.Items.Clear();
                this.comboBox2.Hide();
            }
        }
    }
}
