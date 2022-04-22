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
using AP_estudia.Services;



namespace AP_estudia.Fenetres
{
    public partial class visuEdt : Form
    {
        DataTable dt = new DataTable();
        DataRow dr;
        Enseignants objetEnseignant = new Enseignants();


        public visuEdt()
        {
            InitializeComponent();
            dt.Columns.Add("Professeur");
            dt.Columns.Add("Salle");
            dt.Columns.Add("Classe");
            dt.Columns.Add("Matiere");
            dt.Columns.Add("Date");
            dt.Columns.Add("Heure de debut");
            dt.Columns.Add("Heure de fin");
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

        public void SelectListEnseignant()
        {
            var listeEnseignant = objetEnseignant.allEnseignants();

            foreach (Enseignants x in objetEnseignant.liste_enseignants)
            {
                ComboBoxItem ClasseEtu = new ComboBoxItem();
                ClasseEtu.Text = x.nom + " " + x.prenom;
                ClasseEtu.Value = x.idUtilisateur;
                this.Professeur.Items.Add(ClasseEtu);
            }
        }

        public void SelectListSalle()
        {
            var objetSalle = new Salle();
            var listeSalle = objetSalle.listSalle();
            Dictionary<string, string> comboSource = new Dictionary<string, string>();

            foreach (var x in listeSalle)
            {
                comboSource.Add(x.PartId.ToString(), x.PartName);
            }
            Sallee.DataSource = new BindingSource(comboSource, null);
            Sallee.DisplayMember = "Value";
            Sallee.ValueMember = "Key";
        }
        private void Classee_Load(object sender, EventArgs e)
        {
            SelectListClasse();
        }

        private void Professeur_Load(object sender, EventArgs e)
        {
            SelectListEnseignant();
        }

        private void Salle_Load(object sender, EventArgs e)
        {
            SelectListSalle();
        }

        private void ValideCours_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Professeur.SelectedValue.ToString());
            ComboBoxItem selectedItem = Professeur.SelectedItem as ComboBoxItem;

            dr = dt.NewRow();
            dr["Professeur"] = selectedItem.Value;
            dr["Salle"] = Sallee.SelectedValue;
            dr["Classe"] = Classee.SelectedValue;
            dr["Matiere"] = matiereProf.Text;
            dr["Date"] = Date.Text;
            dr["Heure de Debut"] = HoraireDebut.Text;
            dr["Heure de fin"] = HoraireFin.Text;

            dt.Rows.Add(dr);
            dataGridView.DataSource = dt;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int verif = 0;
            var objetEdt = new EDT();
          
            foreach (DataGridViewRow dr in dataGridView.Rows)
            {

                bool insert;

                int idProf = Convert.ToInt32(dr.Cells["Professeur"].Value);
                int idSalle = Convert.ToInt32(dr.Cells["Salle"].Value);
                int idClasse = Convert.ToInt32(dr.Cells["Classe"].Value);
                string matiere = Convert.ToString(dr.Cells["Matiere"].Value);
                DateTime date = Convert.ToDateTime(dr.Cells["Date"].Value);
                string heureDebut = Convert.ToString(dr.Cells["Heure de Debut"].Value);
                string heureFin = Convert.ToString(dr.Cells["Heure de fin"].Value);
                if (dr.IsNewRow) continue;
                {
                     insert = objetEdt.CreationEdt(idProf, idSalle, idClasse, matiere, date, heureDebut, heureFin);
                }
                
                
                if(insert == true)
                {
                    verif++;
                }
            }
            /*if(verif == dataGridView.Rows.Count)
            {
                verifInsertion.Text = "insertion réussi";
            }
            else
            {
                verifInsertion.Text = "insertion raté";
            }*/
            
        }

        private void Professeur_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            ComboBoxItem selectedItem = Professeur.SelectedItem as ComboBoxItem;
            
            foreach (Enseignants x in objetEnseignant.liste_enseignants)
            {
                if(selectedItem.Value == x.idUtilisateur)
                {
                    
                    this.matiereProf.Text = x.matiere.ToString();
                }
            }

        }
    }
}
