using PlanovacTridy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Planovac
{
    public partial class formPznm : Form
    {
        Udalost udalost;
        int index;
        public formPznm(Udalost ud)
        {
            InitializeComponent();
            lbNazev.Text = ud.Nazev;
            tbPonamka.Text = ud.Poznamka;
            index = Array.FindIndex(Form1.zaznamZ.udalosti, udalost => udalost == ud);
            udalost = ud;
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbPonamka.Text))
            {
                string poznamka = tbPonamka.Text;
                udalost.Poznamka = poznamka;
                Form1.zaznamZ.udalosti[index] = udalost;
                
                Close();
            }
        }

            private void FormPoznamka_Load(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
