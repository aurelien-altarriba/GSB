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

namespace GSB
{
    public partial class Interface : System.Windows.Forms.Form
    {
        BDD BDD;
        MySqlDataReader rdr;

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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void tbDateEmbauchePersonnel_ValueChanged(object sender, EventArgs e)
        {

        }

        // ******************************************************* //

        private void Interface_Load(object sender, EventArgs e)
        {
            BDD = new BDD();
            actualiserListePersonnelOngletPersonnel();
        }

        private void actualiserListePersonnelOngletPersonnel()
        {
            // Compteur du personnel pour chaque rôle
            int VisiteurMédical = 0;
            int DéléguéRégional = 0;
            int ResponsableRégion = 0;
            int Technicien = 0;
            int TechnicienSupérieur = 0;
            int Autre = 0;

            // On efface la liste du personnel
            listePersonnel.Items.Clear();

            // AUTRE
            // On créer et exécute la requête
            string requete = "SELECT * FROM personnel WHERE role = 'Autre'";
            MySqlCommand cmd = BDD.executerRequete(requete);
            rdr = cmd.ExecuteReader();

            // Pour chaque personnel correspondant à la requête qui a été trouvé en BDD
            while (rdr.Read())
            {
                // On ajoute cette chaîne dans la liste du personnel 
                listePersonnel.Items.Add(rdr.GetInt32(0) + " - " + rdr.GetString(1) + " " + rdr.GetString(2) + " - " + rdr.GetString(5) + " : Embauché depuis le " + rdr.GetDateTime(3) + " en tant que " + rdr.GetString(6) + " dans la région " + rdr.GetString(4));
                
                // On incrémente de 1 le nombre de personnel de ce rôle
                Autre++;
            }

            // On ferme le reader
            rdr.Close();

            // RESPONSABLE REGION
            requete = "SELECT * FROM personnel P JOIN responsable_region RR ON P.id_personnel = RR.id_personnel " +
                "WHERE P.role = 'Responsable région';";
            cmd = BDD.executerRequete(requete);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                listePersonnel.Items.Add(rdr.GetInt32(0) + " - " + rdr.GetString(1) + " " + rdr.GetString(2) + " - " + rdr.GetString(5) + " : Embauché depuis le " + rdr.GetDateTime(3) + " en tant que " + rdr.GetString(6) + " dans la région " + rdr.GetString(4));
                ResponsableRégion++;
            }

            rdr.Close();

            // VISITEUR MEDICAL
            requete = "SELECT * FROM personnel P JOIN visiteur V ON P.id_personnel = V.id_personnel " +
                "WHERE P.role = 'Visiteur médical';";
            cmd = BDD.executerRequete(requete);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                listePersonnel.Items.Add(rdr.GetInt32(0) + " - " + rdr.GetString(1) + " " + rdr.GetString(2) + " - " + rdr.GetString(5) + " : Embauché depuis le " + rdr.GetDateTime(3) + " en tant que " + rdr.GetString(6) + " dans la région " + rdr.GetString(4) + ". Son objectif est '" + rdr.GetString(8) + "' avec un budget de " + rdr.GetInt32(11) + "€. Prime : " + rdr.GetString(9) + "€ - Avantages : " + rdr.GetString(10));
                ResponsableRégion++;
            }

            rdr.Close();

            // DELEGUE REGIONAL
            requete = "SELECT * FROM personnel P JOIN visiteur V ON P.id_personnel = V.id_personnel " +
                "WHERE P.role = 'Délégué régional';";
            cmd = BDD.executerRequete(requete);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                listePersonnel.Items.Add(rdr.GetInt32(0) + " - " + rdr.GetString(1) + " " + rdr.GetString(2) + " - " + rdr.GetString(5) + " : Embauché depuis le " + rdr.GetDateTime(3) + " en tant que " + rdr.GetString(6) + " dans la région " + rdr.GetString(4) + ". Son objectif est '" + rdr.GetString(8) + "' avec un budget de " + rdr.GetInt32(11) + "€. Prime : " + rdr.GetString(9) + "€ - Avantages : " + rdr.GetString(10));
                ResponsableRégion++;
            }

            rdr.Close();



            nbVisiteurMédical.Text = VisiteurMédical.ToString();
            nbDéléguéRégional.Text = DéléguéRégional.ToString();
            nbResponsableRégion.Text = ResponsableRégion.ToString();
            nbTechnicien.Text = Technicien.ToString();
            nbTechnicienSupérieur.Text = TechnicienSupérieur.ToString();
            nbAutre.Text = Autre.ToString();
        }

        private void btAjouterPersonnel_Click(object sender, EventArgs e)
        {
            if (rbVisiteur.Checked)
            {
                string requete = "INSERT INTO personnel (nom, prenom, date_embauche, region_carriere, mail, role)" +
                    " VALUES ('" + tbNomPersonnel.Text + "', '" + tbPrénomPersonnel.Text + "', '" + tbDateEmbauchePersonnel.Text + "', '" + tbRégionPersonnel.Text + "', '" + tbMailPersonnel.Text + "@swiss-galaxy.com', 'Visiteur médical');";
                MySqlCommand cmd = BDD.executerRequete(requete);
                cmd.ExecuteNonQuery();

                requete = "INSERT INTO visiteur (objectif, prime, avantages, budget, id_personnel)" +
                    " VALUES ('" + tbObjectifVisiteur.Text + "', " + Convert.ToInt32(tbPrimeVisiteur.Text) + ", '" + tbAvantagesVisiteur.Text + "', " + Convert.ToInt32(tbBudgetVisiteur.Text) + ", LAST_INSERT_ID());";
                cmd = BDD.executerRequete(requete);
                cmd.ExecuteNonQuery();
            }

            else if (rbDéléguéRégional.Checked)
            {
                string requete = "INSERT INTO personnel (nom, prenom, date_embauche, region_carriere, mail, role)" +
                    " VALUES ('" + tbNomPersonnel.Text + "', '" + tbPrénomPersonnel.Text + "', '" + tbDateEmbauchePersonnel.Text + "', '" + tbRégionPersonnel.Text + "', '" + tbMailPersonnel.Text + "@swiss-galaxy.com', 'Délégué régional');";
                MySqlCommand cmd = BDD.executerRequete(requete);
                cmd.ExecuteNonQuery();

                requete = "INSERT INTO visiteur (objectif, prime, avantages, budget, id_personnel)" +
                    " VALUES ('" + tbObjectifVisiteur.Text + "', " + Convert.ToInt32(tbPrimeVisiteur.Text) + ", '" + tbAvantagesVisiteur.Text + "', " + Convert.ToInt32(tbBudgetVisiteur.Text) + ", LAST_INSERT_ID());";
                cmd = BDD.executerRequete(requete);
                cmd.ExecuteNonQuery();

                requete = "INSERT INTO delegue (id_visiteur)" +
                    " VALUES (LAST_INSERT_ID());";
                cmd = BDD.executerRequete(requete);
                cmd.ExecuteNonQuery();
            }

            else if (rbTechnicien.Checked)
            {
                string requete = "INSERT INTO personnel (nom, prenom, date_embauche, region_carriere, mail, role)" +
                    " VALUES ('" + tbNomPersonnel.Text + "', '" + tbPrénomPersonnel.Text + "', '" + tbDateEmbauchePersonnel.Text + "', '" + tbRégionPersonnel.Text + "', '" + tbMailPersonnel.Text + "@swiss-galaxy.com', 'Technicien');";
                MySqlCommand cmd = BDD.executerRequete(requete);
                cmd.ExecuteNonQuery();

                requete = "INSERT INTO technicien (niveau_intervention, formation, competences, id_personnel)" +
                    " VALUES (" + Convert.ToInt32(tbNiveauInterventionTechnicien.Text) + ", '" + tbFormationTechnicien.Text + "', '" + tbCompetencesTechnicien.Text + "', LAST_INSERT_ID());";
                cmd = BDD.executerRequete(requete);
                cmd.ExecuteNonQuery();
            }

            else if (rbTechnicienSupérieur.Checked)
            {
                string requete = "INSERT INTO personnel (nom, prenom, date_embauche, region_carriere, mail, role)" +
                    " VALUES ('" + tbNomPersonnel.Text + "', '" + tbPrénomPersonnel.Text + "', '" + tbDateEmbauchePersonnel.Text + "', '" + tbRégionPersonnel.Text + "', '" + tbMailPersonnel.Text + "@swiss-galaxy.com', 'Technicien supérieur');";
                MySqlCommand cmd = BDD.executerRequete(requete);
                cmd.ExecuteNonQuery();

                requete = "INSERT INTO technicien (niveau_intervention, formation, competences, id_personnel)" +
                    " VALUES (" + Convert.ToInt32(tbNiveauInterventionTechnicien.Text) + ", '" + tbFormationTechnicien.Text + "', '" + tbCompetencesTechnicien.Text + "', LAST_INSERT_ID());";
                cmd = BDD.executerRequete(requete);
                cmd.ExecuteNonQuery();
            }

            else if (rbResponsableRégion.Checked)
            {
                string requete = "INSERT INTO personnel (nom, prenom, date_embauche, region_carriere, mail, role)" +
                    " VALUES ('" + tbNomPersonnel.Text + "', '" + tbPrénomPersonnel.Text + "', '" + tbDateEmbauchePersonnel.Text + "', '" + tbRégionPersonnel.Text + "', '" + tbMailPersonnel.Text + "@swiss-galaxy.com', 'Responsable région');";
                MySqlCommand cmd = BDD.executerRequete(requete);
                cmd.ExecuteNonQuery();

                requete = "INSERT INTO responsable_region (id_personnel)" +
                    " VALUES (LAST_INSERT_ID());";
                cmd = BDD.executerRequete(requete);
                cmd.ExecuteNonQuery();
            }

            else
            {
                string requete = "INSERT INTO personnel (nom, prenom, date_embauche, region_carriere, mail, role)" +
                    " VALUES ('" + tbNomPersonnel.Text + "', '" + tbPrénomPersonnel.Text + "', '" + tbDateEmbauchePersonnel.Text + "', '" + tbRégionPersonnel.Text + "', '" + tbMailPersonnel.Text + "@swiss-galaxy.com', 'Autre');";
                MySqlCommand cmd = BDD.executerRequete(requete);
                cmd.ExecuteNonQuery();
            }

            actualiserListePersonnelOngletPersonnel();
        }

        private void btModifierPersonnel_Click(object sender, EventArgs e)
        {
            /*bool trouvé = false;

            foreach (Personnel Per in lesPersonnels)
            {
                // Si l'ID correspond à celui trouvé dans la liste lesPersonnels
                if (Per.Id_personnel == Convert.ToInt16(tbIDPersonnelModifier.Text))
                {
                    Per.Nom = tbNomPersonnel.Text;
                    Per.Prenom = tbPrénomPersonnel.Text;
                    Per.Date_embauche = tbDateEmbauchePersonnel.Text;
                    if (Per.Region_carriere != tbRégionPersonnel.Text)
                    {
                        Per.Region_carriere = Per.Region_carriere + " - " + tbRégionPersonnel.Text;
                    }
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
                        if (Vis.Region_carriere != tbRégionPersonnel.Text)
                        {
                            Vis.Region_carriere = Vis.Region_carriere + " - " + tbRégionPersonnel.Text;
                        }
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
                        if (Tec.Region_carriere != tbRégionPersonnel.Text)
                        {
                            Tec.Region_carriere =Tec.Region_carriere + " - " + tbRégionPersonnel.Text;
                        }
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
                majStatsPersonnel();

                MessageBox.Show("Personnel " + tbIDPersonnelModifier.Text + " modifié avec succés");
            }*/
        }

        private void btSupprimerPersonnel_Click(object sender, EventArgs e)
        {
            /*bool trouvé = false;
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

                MessageBox.Show("Personnel " + tbIDPersonnelSupprimer.Text + " supprimé avec succés");
            }*/
        }
    }
}
