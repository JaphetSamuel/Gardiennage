using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gardiennage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        GardiennageContainer dbGarde = new GardiennageContainer();
        
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dbGarde.GardienSet.Select(p => new { Nom = p.Nom, Prenom = p.Prenom, p.Matricule }).ToList();
        }

        private void btnFiltrer_Click(object sender, EventArgs e)
        {
            if(tbFiltreNom.Text != string.Empty)
            {
                /*
               var filtre = dbGarde.GardienSet.Where(p => p.Nom == tbFiltreNom.Text).ToList();
                dataGridView1.DataSource = filtre;
                MessageBox.Show(filtre.GetType().ToString());
                */
                dataGridView1.DataSource = MFiltrage.Fnom(tbFiltreNom.Text).ToList();
                MessageBox.Show(dbGarde.GardienSet.GetType().ToString());
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAjout formAjout = new FormAjout();
            formAjout.ShowDialog();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dbGarde.GardienSet.Select(p => new { Nom = p.Nom, Prenom = p.Prenom, p.Matricule }).ToList();
        }
    }
}
