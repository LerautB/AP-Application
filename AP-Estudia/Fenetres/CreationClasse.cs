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

namespace AP_Estudia
{
    public partial class CreationClasse : Form
    {
        MySqlConnection conn = new MySqlConnection("database=estudia; server=localhost; user id = root; pwd=");

        public CreationClasse()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var objetClasse = new Classe();
            if(numClasseCrea.Text != string.Empty)
            {
                if(nomClasseCrea.Text != string.Empty)
                {
                    if(nomClasseCrea.Text.Length < 50)
                    {
                        if (objetClasse.creationClasse(numClasseCrea.Text, nomClasseCrea.Text) == true)
                        {
                            MessageBox.Show("Insertion réussi");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Insertion raté");

                        }
                    }
                    else
                    {
                        MessageBox.Show("Nom trop long");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Nom Vide");
                }
            }
            else
            {
                MessageBox.Show("Num Vide");

            }
            
        }
    }
}
