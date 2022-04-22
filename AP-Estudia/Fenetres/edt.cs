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

namespace AP_estudia
{
    public partial class edt : Form
    {
        public edt()
        {
            InitializeComponent();
        }

        private void panelEdt_Paint(object sender, PaintEventArgs e)
        {

        }

        private void creaEdt_Click(object sender, EventArgs e)
        {
            this.panelEdt.Controls.Clear();
            visuEdt myForm = new visuEdt();
            myForm.AutoScroll = true;
            myForm.TopLevel = false;
            this.panelEdt.Controls.Add(myForm);
            myForm.Show();
        }
    }
}
