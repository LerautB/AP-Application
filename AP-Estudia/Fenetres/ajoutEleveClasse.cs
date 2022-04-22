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
using AP_estudia.Modeles;
using AP_estudia.Fenetres;

namespace AP_estudia.Fenetres
{
    public partial class AjouterEleve : Form
    {
        DataTable dt = new DataTable();
        DataRow dr;
        public AjouterEleve()
        {
            InitializeComponent();

            dt.Columns.Add("idUtilisateur");
            dt.Columns.Add("Nom");
            dt.Columns.Add("Classe");
        }

        private void AjouterEleve_Load(object sender, EventArgs e)
        {

        }
        public void SelectListClasse()
        {
            var objetClasse = new Classe();
            var listeClasse = objetClasse.listClasse();
            Dictionary<string, string> comboSource = new Dictionary<string, string>();

            foreach (var x in listeClasse)
            {
                comboSource.Add(x.PartId.ToString(), x.PartName);
            }
            Classee.DataSource = new BindingSource(comboSource, null);
            Classee.DisplayMember = "Value";
            Classee.ValueMember = "Key";
        }
        public void ListeEleve()
        {
            Eleve Eleve = new Eleve();

            Dictionary<string, string> comboSource = new Dictionary<string, string>();

            foreach (Eleve x in Eleve.listeEleveSansClasse())
            {

                comboSource.Add(x.id.ToString(), x.nom + " " + x.prenom);

            }

            listeEleve.DataSource = new BindingSource(comboSource, null);
            listeEleve.DisplayMember = "Value";
            listeEleve.ValueMember = "Key";
        }
        private void listeEleve_Load(object sender, EventArgs e)
        {
            ListeEleve();
        }
        private void Classee_Load(object sender, EventArgs e)
        {
            SelectListClasse();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dr = dt.NewRow();
            dr["idUtilisateur"] = listeEleve.SelectedValue;
            dr["Nom"] = listeEleve.Text;
            dr["Classe"] = Classee.SelectedValue;
            

            dt.Rows.Add(dr);
            dataGridView.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int verif = 0;
            var objetEleve = new Eleve();

            foreach (DataGridViewRow dr in dataGridView.Rows)
            {

                bool insert;

                int idUtilisateur = Convert.ToInt32(dr.Cells["idUtilisateur"].Value);
                int idClasse = Convert.ToInt32(dr.Cells["Classe"].Value);

                if (dr.IsNewRow) continue;
                {
                    insert = objetEleve.updateClasseEleve(idUtilisateur, idClasse);
                }

                if (insert == true)
                {
                    verif++;
                }
            }
            
            this.dataGridView.DataSource=null;
        }
    }
}
