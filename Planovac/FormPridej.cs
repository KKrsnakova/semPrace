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
            if (!String.IsNullOrEmpty(tbNazev.Text) && !String.IsNullOrEmpty(tbMisto.Text) )
            {
                if(String.IsNullOrEmpty(tbPznm.Text))
                {

                    string nazev = tbNazev.Text;
                    string misto = tbMisto.Text;
                    DateTime datum = dtPicker.Value;
                    Priorita pr = (Priorita)cbPriorita.SelectedItem;
                    string pznm = tbPznm.Text;
                    pznm += "prázdná poznámka";

                    Udalost u = new Udalost(nazev, datum, misto, pr, pznm);
                    Form1.zaznamZ.Pridej(u);
                }     else
                {

                    string nazev = tbNazev.Text;
                    string misto = tbMisto.Text;
                    DateTime datum = dtPicker.Value;
                    Priorita pr = (Priorita)cbPriorita.SelectedItem;
                    string pznm = tbPznm.Text;

                    Udalost u = new Udalost(nazev, datum, misto, pr, pznm);
                    Form1.zaznamZ.Pridej(u);
                }


               
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

        private void label5_Click_1(object sender, EventArgs e)
        {

        }
    }
}
