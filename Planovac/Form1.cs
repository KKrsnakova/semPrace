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
    public partial class Form1 : Form
    {
        public static Zaznamy zaznamZ = new Zaznamy();
        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Pridej(object sender, EventArgs e)
        {
            FormPridej formPridej = new FormPridej();
            formPridej.ShowDialog();
            lvUdalosti.Items.Clear();
            foreach (Udalost item in zaznamZ.udalosti)
            {

                string[] rou = { "" + item.Datum, "" + item.Misto, "" + item.Priorita };
                lvUdalosti.Items.Add(item.Nazev).SubItems.AddRange(rou);
            }

           

        }

        private void Uprav(object sender, EventArgs e)
        {

        }

        private void Smaz(object sender, EventArgs e)
        {
            if (lvUdalosti.SelectedItems.Count > 0)
            {
                int ar = lvUdalosti.Items.IndexOf(lvUdalosti.SelectedItems[0]);
                zaznamZ.Smaz(ar);   
                int before = lvUdalosti.Items.Count;
                lvUdalosti.Items.Clear();
                lbPoznamka.Items.Clear();
                foreach (Udalost item in zaznamZ.udalosti)
                {

                    string[] rou = { "" + item.Datum, "" + item.Misto,  "" + item.Priorita };
                    lvUdalosti.Items.Add(item.Nazev).SubItems.AddRange(rou);
                }
                
            }
            else
            {
                string message = "Chyba";
                string title = "Chybně zadáno";
                MessageBox.Show(message, title);
            }

        }

        private void ZobrazPznm(object sender, EventArgs e)
        {
        }

        private void ZobrazPznm(object sender, MouseEventArgs e)
        {
        }

        private void Klik(object sender, MouseEventArgs e)
        {
            lbPoznamka.Items.Clear();
            lbPoznamka.Items.Add(zaznamZ[lvUdalosti.SelectedItems[0].Index].Poznamka);
        }

        private void btnPoznamka_Click(object sender, EventArgs e)
        {
            if (lvUdalosti.SelectedItems.Count > 0)
            {
                lbPoznamka.Items.Clear();
                formPznm fPoznamka = new formPznm(zaznamZ[lvUdalosti.SelectedItems[0].Index]);
                fPoznamka.ShowDialog();
                
            } else
            {
                string message = "Chyba";
                string title = "Chybně zadáno";
                MessageBox.Show(message, title);

            }
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbDatum.Text = DateTime.Now.ToLongDateString();
            lbCas.Text = DateTime.Now.ToLongTimeString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
