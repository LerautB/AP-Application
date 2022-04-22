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
using AP_estudia.Modeles;

namespace AP_estudia
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
            if(!String.IsNullOrEmpty(id_input.Text) && !String.IsNullOrEmpty(mdp_input.Text))
            { 
                var User = new Utilisateur();
                ;
                if(User.Connection(id_input.Text, mdp_input.Text) == true)
                {
                    this.Hide();
                    var estudia = new estudia();
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
}
