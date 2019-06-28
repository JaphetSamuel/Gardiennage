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
    public partial class FormAjout : Form
    {
        public FormAjout()
        {
            InitializeComponent();
            numUpDuree.Enabled = ckbDuree.Checked;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ckbDuree_CheckedChanged(object sender, EventArgs e)
        {
            numUpDuree.Enabled = ckbDuree.Checked;
        }

        public Gardien NouveauGardien(string nom,
            string prenom,
            int age,
            string situationM,
            string domicile, string competence,
            DateTime debutcontrat, DateTime Fincontrat)
        {
            string mat = "i" + nom[0] + nom[1] + age;
            competence = competence == string.Empty ? "-" : competence;
            
                Gardien g = new Gardien
                {
                    Nom = nom,
                    Prenom = prenom,
                    Age = age,
                    SituationMatrimoniale = situationM,
                    Domicile = domicile,
                    Description = competence.Split(';').ToString(),
                    DebutDambauche = debutcontrat,
                    FinDambauche = Fincontrat.ToString(),
                    Matricule = mat
                };
            return g;

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            bool valide = tbNom.Text != string.Empty &&
                tbPrenom.Text != string.Empty &&
                tbAge.Value >= 12 &&
                tbDomicile.Text != string.Empty;
            string desc = string.Empty;
            foreach (string ckb in chkListBox1.SelectedItems)
            {
                desc = ckb + ';';
            }

            if (valide)
            {
                GardiennageContainer gad = new GardiennageContainer();

                gad.GardienSet.Add(NouveauGardien(tbNom.Text, tbPrenom.Text, (int)tbAge.Value, cmboMatrimonial.SelectedText, tbDomicile.Text, desc, dtpdebut.Value, dtpfin.Value));
                gad.SaveChanges();
                MessageBox.Show("emregistrer avec succes");
                this.Close();
            }
        }
    }
}
