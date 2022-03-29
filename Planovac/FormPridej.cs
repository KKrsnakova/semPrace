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
    public partial class FormPridej : Form
    {
        Udalost ud;

        public FormPridej()
        {
            InitializeComponent();
            cbPriorita.DataSource = Enum.GetValues(typeof(Priorita));


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormPridej_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Pridat(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbNazev.Text) && !String.IsNullOrEmpty(tbMisto.Text) && !String.IsNullOrEmpty(tbDatum.Text))
            {
                string nazev = tbNazev.Text;
                string misto = tbMisto.Text;
                string datum = tbDatum.Text;
                Priorita pr = (Priorita)cbPriorita.SelectedItem;


                Udalost u = new Udalost(nazev, misto, datum, pr);

                Form1.zaznamZ.Pridej(u);
                Close();

                //ChampionsLeagueForm.playerR.players[index] = p;
                //Form1.ud
            } 
            else
            {
                string message = "Chyba";
                string title = "Chybně zadáno";
                MessageBox.Show(message, title);
            }
        }

        private void Zrus(object sender, EventArgs e)
        {
            Close();
        }
    }
}
