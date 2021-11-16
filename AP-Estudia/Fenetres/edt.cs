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
//using AP_Estudia.Fenetres;

namespace AP_Estudia
{
    public partial class edt : Form
    {
        public edt()
        {
            InitializeComponent();
        }

        private void visuEdt_Click(object sender, EventArgs e)
        {
            this.panelEdt.Controls.Clear();
            selecteClasse myForm = new selecteClasse(this);
            myForm.AutoScroll = true;
            myForm.TopLevel = false;
            this.panelEdt.Controls.Add(myForm);
            myForm.Show();
        }

        private void panelEdt_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
