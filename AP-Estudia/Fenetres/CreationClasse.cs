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

namespace AP_Estudia
{
    public partial class CreationClasse : Form
    {
        MySqlConnection conn = new MySqlConnection("database=estudia; server=localhost; user id = root; pwd=");

        public CreationClasse()
        {
            InitializeComponent();
        }

        private void CreationClasse_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            string nbclasse = numClasseCrea.Text;
            string nameclasse = nomClasseCrea.Text;
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@nbclasse", nbclasse);
            command.Parameters.AddWithValue("@nomclasse", nameclasse);
            command.CommandText = "insert into etudes (classe, nom) values (@nbclasse, @nomclasse)";
            if (command.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("insertion");
            }
            else
            {
                MessageBox.Show("fail");
            }
            conn.Close();
            this.Close();
            //Displaydata();
        }
    }
}
