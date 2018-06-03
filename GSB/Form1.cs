using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSB
{
    public partial class Interface : System.Windows.Forms.Form
    {
        Personnel unPersonnel;
        List<Personnel> lesPersonnels;
        Visiteur unVisiteur;
        List<Visiteur> lesVisiteurs;
        Technicien unTechnicien;
        List<Technicien> lesTechniciens;


        public Interface()
        {
            InitializeComponent();
        }

        private void clôreUnTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxAjouterPersonnel_Enter(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void personnel_Click(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label61_Click(object sender, EventArgs e)
        {

        }

        private void label66_Click(object sender, EventArgs e)
        {

        }

        private void textBox39_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox40_TextChanged(object sender, EventArgs e)
        {

        }

        private void label76_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void visite_Click(object sender, EventArgs e)
        {

        }

        // ******************************************************* //

        private void Interface_Load(object sender, EventArgs e)
        {
            lesPersonnels = new List<Personnel>();
            lesVisiteurs = new List<Visiteur>();
            lesTechniciens = new List<Technicien>();
        }

        public void actualiserListePersonnelOngletPersonnel()
        {
            listePersonnel.Items.Clear();

            foreach (Personnel Per in lesPersonnels)
            {
                listePersonnel.Items.Add(Per.infos());
            }

            foreach (Visiteur Vis in lesVisiteurs)
            {
                listePersonnel.Items.Add(Vis.infos());
            }

            foreach (Technicien Tec in lesTechniciens)
            {
                listePersonnel.Items.Add(Tec.infos());
            }
        }

        private void btAjouterPersonnel_Click(object sender, EventArgs e)
        {
            if (rbVisiteur.Checked || rbDéléguéRégional.Checked)
            {
                unVisiteur = new Visiteur(tbObjectifVisiteur.Text, Convert.ToInt32(tbPrimeVisiteur.Text), tbAvantagesVisiteur.Text, Convert.ToInt32(tbBudgetVisiteur.Text), tbNomPersonnel.Text, tbPrénomPersonnel.Text, tbDateEmbauchePersonnel.Text, tbRégionPersonnel.Text, tbMailPersonnel.Text);
                lesVisiteurs.Add(unVisiteur);
            }

            else if (rbTechnicien.Checked || rbTechnicienSupérieur.Checked)
            {
                unTechnicien = new Technicien(Convert.ToInt32(tbNiveauInterventionTechnicien.Text), tbFormationTechnicien.Text, tbCompetencesTechnicien.Text, tbNomPersonnel.Text, tbPrénomPersonnel.Text, tbDateEmbauchePersonnel.Text, tbRégionPersonnel.Text, tbMailPersonnel.Text);
                lesTechniciens.Add(unTechnicien);
            }

            else
            {
                unPersonnel = new Personnel(tbNomPersonnel.Text, tbPrénomPersonnel.Text, tbDateEmbauchePersonnel.Text, tbRégionPersonnel.Text, tbMailPersonnel.Text);
                lesPersonnels.Add(unPersonnel);
            }

            actualiserListePersonnelOngletPersonnel();
        }

        private void btModifierPersonnel_Click(object sender, EventArgs e)
        {
            bool trouvé = false;

            foreach (Personnel Per in lesPersonnels)
            {
                // Si l'ID correspond à celui trouvé dans la liste lesPersonnels
                if (Per.Id_personnel == Convert.ToInt16(tbIDPersonnelModifier.Text))
                {
                    Per.Nom = tbNomPersonnel.Text;
                    Per.Prenom = tbPrénomPersonnel.Text;
                    Per.Date_embauche = tbDateEmbauchePersonnel.Text;
                    Per.Region_carriere = Per.Region_carriere + " - " + tbRégionPersonnel.Text;
                    Per.Mail = tbMailPersonnel.Text + "@swiss-galaxy.com";

                    trouvé = true;
                }
            }

            if (trouvé == false)
            {
                foreach (Visiteur Vis in lesVisiteurs)
                {
                    if (Vis.Id_personnel == Convert.ToInt16(tbIDPersonnelModifier.Text))
                    {
                        Vis.Nom = tbNomPersonnel.Text;
                        Vis.Prenom = tbPrénomPersonnel.Text;
                        Vis.Date_embauche = tbDateEmbauchePersonnel.Text;
                        Vis.Region_carriere = Vis.Region_carriere + " - " + tbRégionPersonnel.Text;
                        Vis.Mail = tbMailPersonnel.Text + "@swiss-galaxy.com";
                        Vis.Objectif = tbObjectifVisiteur.Text;
                        Vis.Prime = Convert.ToInt32(tbPrimeVisiteur.Text);
                        Vis.Avantages = tbAvantagesVisiteur.Text;
                        Vis.Budget = Convert.ToInt32(tbBudgetVisiteur.Text);

                        trouvé = true;
                    }
                }
            }

            if (trouvé == false)
            {
                foreach (Technicien Tec in lesTechniciens)
                {
                    if (Tec.Id_personnel == Convert.ToInt16(tbIDPersonnelModifier.Text))
                    {
                        Tec.Nom = tbNomPersonnel.Text;
                        Tec.Prenom = tbPrénomPersonnel.Text;
                        Tec.Date_embauche = tbDateEmbauchePersonnel.Text;
                        Tec.Region_carriere = Tec.Region_carriere + " - " + tbRégionPersonnel.Text;
                        Tec.Mail = tbMailPersonnel.Text + "@swiss-galaxy.com";
                        Tec.Niveau_intervention = Convert.ToInt32(tbNiveauInterventionTechnicien.Text);
                        Tec.Formation = tbFormationTechnicien.Text;
                        Tec.Competences = tbCompetencesTechnicien.Text;

                        trouvé = true;
                    }
                }
            }

            if (trouvé == false)
            {
                MessageBox.Show("Aucun personnel avec l'ID " + tbIDPersonnelModifier.Text + " n'a été trouvé");
            }
            else
            {
                actualiserListePersonnelOngletPersonnel();

                MessageBox.Show("Personnel " + tbIDPersonnelModifier + " modifié avec succés");
            }
        }

        private void btSupprimerPersonnel_Click(object sender, EventArgs e)
        {
            bool trouvé = false;
            Personnel PersonnelSupprimer = null;
            Visiteur VisiteurSupprimer = null;
            Technicien TechnicienSupprimer = null;

            foreach (Personnel Per in lesPersonnels)
            {
                // Si l'ID correspond à celui trouvé dans la liste lesPersonnels
                if (Per.Id_personnel == Convert.ToInt16(tbIDPersonnelSupprimer.Text))
                {
                    PersonnelSupprimer = Per;

                    trouvé = true;
                }
            }

            if (trouvé)
            {
                lesPersonnels.Remove(PersonnelSupprimer);
            }
            else
            {
                foreach (Visiteur Vis in lesVisiteurs)
                {
                    if (Vis.Id_personnel == Convert.ToInt16(tbIDPersonnelSupprimer.Text))
                    {
                        VisiteurSupprimer = Vis;

                        trouvé = true;
                    }
                }

                if (trouvé)
                {
                    lesVisiteurs.Remove(VisiteurSupprimer);
                }
                else
                {
                    foreach (Technicien Tec in lesTechniciens)
                    {
                        if (Tec.Id_personnel == Convert.ToInt16(tbIDPersonnelSupprimer.Text))
                        {
                            TechnicienSupprimer = Tec;

                            trouvé = true;
                        }
                    }

                    if (trouvé)
                    {
                        lesTechniciens.Remove(TechnicienSupprimer);
                    }
                }
            }

            if (trouvé == false)
            {
                MessageBox.Show("Aucun personnel avec l'ID " + tbIDPersonnelSupprimer.Text + " n'a été trouvé");
            }
            else
            {
                actualiserListePersonnelOngletPersonnel();

                MessageBox.Show("Personnel " + tbIDPersonnelSupprimer + " supprimé avec succés");
            }
        }
    }
}
