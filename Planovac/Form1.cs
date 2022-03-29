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

                string[] rou = { "" + item.Misto, "" + item.Datum, "" + item.Priorita };
                lvUdalosti.Items.Add(item.Nazev).SubItems.AddRange(rou);
            }

        }

        private void Uprav(object sender, EventArgs e)
        {

        }

        private void Smaz(object sender, EventArgs e)
        {

        }
    }
}
