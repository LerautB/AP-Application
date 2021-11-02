using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;
using MySql.Data.MySqlClient;
using AP_Estudia.Modeles;

namespace AP_Estudia
{
    using BCrypt.Net;
    
    
    public partial class login : Form
    {
        
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var User = new Utilisateur();
            ;
            if(User.Connection(id_input.Text, mdp_input.Text) == true)
            {
                this.Hide();
                var estudia = new Estudia();
                estudia.Closed += (s, args) => this.Close();
                estudia.Show();
            }
            else
            {
                MessageBox.Show("Connexion échouée...");
            }
        }

       
    }
}
