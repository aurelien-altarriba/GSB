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

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        // ******************************************************* //

        private void Interface_Load(object sender, EventArgs e)
        {
            BDD = new BDD();
            actualiserListePersonnel();
            actualiserListeMatériel();
        }

        private void actualiserListeMatériel()
        {
            // Compteur du matériel
            int Matériel = 0;
            int MatérielAffecté = 0;

            listeMatériel.Items.Clear();
            listeMatériel2.Items.Clear();

            string requete = "SELECT * FROM materiel;";
            MySqlCommand cmd = BDD.executerRequete(requete);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                listeMatériel.Items.Add(rdr.GetInt32(0) + " : " + rdr.GetString(1) + " - Date d'achat ou de location : " + rdr.GetValue(2) + " - Garantie jusqu'au : " + rdr.GetValue(3) + " - Fournisseur : " + rdr.GetString(4) + " - Affecté à : " + rdr.GetValue(5));
                listeMatériel2.Items.Add(rdr.GetInt32(0) + " : " + rdr.GetString(1) + " - Date d'achat ou de location : " + rdr.GetValue(2) + " - Garantie jusqu'au : " + rdr.GetValue(3) + " - Fournisseur : " + rdr.GetString(4) + " - Affecté à : " + rdr.GetValue(5));

                Matériel++;

                // Si l'affection à un personnel est NULL
                if (!rdr.IsDBNull(5))
                {
                    MatérielAffecté++;
                }
            }

            rdr.Close();

            nbMatériel.Text = Matériel.ToString();
            nbMatérielAffecté.Text = MatérielAffecté.ToString();
        }

        private void actualiserListePersonnel()
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
            listePersonnelMatériel.Items.Clear();

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
                listePersonnelMatériel.Items.Add(rdr.GetInt32(0) + " - " + rdr.GetString(1) + " " + rdr.GetString(2) + " - " + rdr.GetString(5) + " : Embauché depuis le " + rdr.GetDateTime(3) + " en tant que " + rdr.GetString(6) + " dans la région " + rdr.GetString(4));
                
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
                listePersonnelMatériel.Items.Add(rdr.GetInt32(0) + " - " + rdr.GetString(1) + " " + rdr.GetString(2) + " - " + rdr.GetString(5) + " : Embauché depuis le " + rdr.GetDateTime(3) + " en tant que " + rdr.GetString(6) + " dans la région " + rdr.GetString(4));

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
                listePersonnelMatériel.Items.Add(rdr.GetInt32(0) + " - " + rdr.GetString(1) + " " + rdr.GetString(2) + " - " + rdr.GetString(5) + " : Embauché depuis le " + rdr.GetDateTime(3) + " en tant que " + rdr.GetString(6) + " dans la région " + rdr.GetString(4) + ". Son objectif est '" + rdr.GetString(8) + "' avec un budget de " + rdr.GetInt32(11) + "€. Prime : " + rdr.GetString(9) + "€ - Avantages : " + rdr.GetString(10));

                VisiteurMédical++;
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
                listePersonnelMatériel.Items.Add(rdr.GetInt32(0) + " - " + rdr.GetString(1) + " " + rdr.GetString(2) + " - " + rdr.GetString(5) + " : Embauché depuis le " + rdr.GetDateTime(3) + " en tant que " + rdr.GetString(6) + " dans la région " + rdr.GetString(4) + ". Son objectif est '" + rdr.GetString(8) + "' avec un budget de " + rdr.GetInt32(11) + "€. Prime : " + rdr.GetString(9) + "€ - Avantages : " + rdr.GetString(10));

                DéléguéRégional++;
            }

            rdr.Close();

            // TECHNICIEN
            requete = "SELECT * FROM personnel P JOIN technicien T ON P.id_personnel = T.id_personnel " +
                "WHERE P.role = 'Technicien';";
            cmd = BDD.executerRequete(requete);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                listePersonnel.Items.Add(rdr.GetInt32(0) + " - " + rdr.GetString(1) + " " + rdr.GetString(2) + " - " + rdr.GetString(5) + " : Embauché depuis le " + rdr.GetDateTime(3) + " en tant que " + rdr.GetString(6) + " dans la région " + rdr.GetString(4) + ". Niveau de compétence : " + rdr.GetInt32(8) + " - Compétences : " + rdr.GetString(10) + " - Formation : " + rdr.GetString(9));
                listePersonnelMatériel.Items.Add(rdr.GetInt32(0) + " - " + rdr.GetString(1) + " " + rdr.GetString(2) + " - " + rdr.GetString(5) + " : Embauché depuis le " + rdr.GetDateTime(3) + " en tant que " + rdr.GetString(6) + " dans la région " + rdr.GetString(4) + ". Niveau de compétence : " + rdr.GetInt32(8) + " - Compétences : " + rdr.GetString(10) + " - Formation : " + rdr.GetString(9));

                Technicien++;
            }

            rdr.Close();

            // TECHNICIEN SUPERIEUR
            requete = "SELECT * FROM personnel P JOIN technicien T ON P.id_personnel = T.id_personnel " +
                "WHERE P.role = 'Technicien supérieur';";
            cmd = BDD.executerRequete(requete);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                listePersonnel.Items.Add(rdr.GetInt32(0) + " - " + rdr.GetString(1) + " " + rdr.GetString(2) + " - " + rdr.GetString(5) + " : Embauché depuis le " + rdr.GetDateTime(3) + " en tant que " + rdr.GetString(6) + " dans la région " + rdr.GetString(4) + ". Niveau de compétence : " + rdr.GetInt32(8) + " - Compétences : " + rdr.GetString(10) + " - Formation : " + rdr.GetString(9));
                listePersonnelMatériel.Items.Add(rdr.GetInt32(0) + " - " + rdr.GetString(1) + " " + rdr.GetString(2) + " - " + rdr.GetString(5) + " : Embauché depuis le " + rdr.GetDateTime(3) + " en tant que " + rdr.GetString(6) + " dans la région " + rdr.GetString(4) + ". Niveau de compétence : " + rdr.GetInt32(8) + " - Compétences : " + rdr.GetString(10) + " - Formation : " + rdr.GetString(9));

                TechnicienSupérieur++;
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

            actualiserListePersonnel();
        }

        private void btModifierPersonnel_Click(object sender, EventArgs e)
        {
            bool trouvé = false;
            string role = "";

            // On récupère le rôle du personnel recherché
            string requete = "SELECT role FROM personnel P WHERE P.id_personnel = " + Convert.ToInt32(tbIDPersonnelModifier.Text);
            MySqlCommand cmd = BDD.executerRequete(requete);
            cmd = BDD.executerRequete(requete);
            rdr = cmd.ExecuteReader();

            while (rdr.Read()) { role = rdr.GetString(0); }

            rdr.Close();

            // Si le personnel est un visiteur ou délégué
            if (role == "Visiteur médical" || role == "Délégué régional")
            {
                requete = "UPDATE personnel SET nom = '" + tbNomPersonnel.Text + "', prenom = '" + tbPrénomPersonnel.Text + "', date_embauche = '" + tbDateEmbauchePersonnel.Text + "', region_carriere = '" + tbRégionPersonnel.Text + "', mail = '" + tbMailPersonnel.Text + "@swiss-galaxy.com'" +
                    " WHERE personnel.id_personnel = " + Convert.ToInt32(tbIDPersonnelModifier.Text) + ";";
                cmd = BDD.executerRequete(requete);
                cmd.ExecuteNonQuery();

                requete = "UPDATE visiteur SET objectif = '" + tbObjectifVisiteur.Text + "', prime = " + Convert.ToInt32(tbPrimeVisiteur.Text) + ", avantages = '" + tbAvantagesVisiteur.Text + "', budget = " + Convert.ToInt32(tbBudgetVisiteur.Text) +
                    " WHERE visiteur.id_personnel = " + Convert.ToInt32(tbIDPersonnelModifier.Text) + ";";
                cmd = BDD.executerRequete(requete);
                cmd.ExecuteNonQuery();

                trouvé = true;
            }

            else if (role == "Technicien" || role == "Technicien supérieur")
            {
                requete = "UPDATE personnel SET nom = '" + tbNomPersonnel.Text + "', prenom = '" + tbPrénomPersonnel.Text + "', date_embauche = '" + tbDateEmbauchePersonnel.Text + "', region_carriere = '" + tbRégionPersonnel.Text + "', mail = '" + tbMailPersonnel.Text + "@swiss-galaxy.com'" +
                    " WHERE personnel.id_personnel = " + Convert.ToInt32(tbIDPersonnelModifier.Text) + ";";
                cmd = BDD.executerRequete(requete);
                cmd.ExecuteNonQuery();

                requete = "UPDATE technicien SET niveau_intervention = " + Convert.ToInt32(tbNiveauInterventionTechnicien.Text) + ", formation = '" + tbFormationTechnicien.Text + "', competences = '" + tbCompetencesTechnicien.Text +
                    "' WHERE technicien.id_personnel = " + Convert.ToInt32(tbIDPersonnelModifier.Text) + ";";
                cmd = BDD.executerRequete(requete);
                cmd.ExecuteNonQuery();

                trouvé = true;
            }

            else
            {
                requete = "UPDATE personnel SET nom = '" + tbNomPersonnel.Text + "', prenom = '" + tbPrénomPersonnel.Text + "', date_embauche = '" + tbDateEmbauchePersonnel.Text + "', region_carriere = '" + tbRégionPersonnel.Text + "', mail = '" + tbMailPersonnel.Text + "@swiss-galaxy.com'" +
                    " WHERE personnel.id_personnel = " + Convert.ToInt32(tbIDPersonnelModifier.Text) + ";";
                cmd = BDD.executerRequete(requete);
                cmd.ExecuteNonQuery();

                trouvé = true;
            }

            if (trouvé)
            {
                actualiserListePersonnel();
                MessageBox.Show("Le personnel n°" + tbIDPersonnelModifier.Text + " a bien été modifié");
            }
            else
            {
                MessageBox.Show("Impossible de trouver le personnel n°" + tbIDPersonnelModifier.Text);
            }
        }

        private void btSupprimerPersonnel_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = BDD.executerRequete("DELETE FROM personnel WHERE id_personnel = " + Convert.ToInt32(tbIDPersonnelSupprimer.Text));
            int resultat = cmd.ExecuteNonQuery();

            if (resultat == 1)
            {
                actualiserListePersonnel();
                MessageBox.Show("Le personnel n°" + tbIDPersonnelSupprimer.Text + " a bien été supprimé");
            }
            else
            {
                MessageBox.Show("Le personnel n°" + tbIDPersonnelSupprimer.Text + " n'existe pas ou a déjà été supprimé");
            }
        }

        private void btAjouterMatériel_Click(object sender, EventArgs e)
        {
            string requete = "INSERT INTO materiel (nom, date_possession, garantie, fournisseur)" +
                    " VALUES ('" +tbNomMatériel.Text + "', '" + tbDatePossessionMatériel.Text + "', '" + tbDateGarantieMatériel.Text + "', '" + tbFournisseurMatériel.Text + "');";
            MySqlCommand cmd = BDD.executerRequete(requete);
            cmd.ExecuteNonQuery();

            actualiserListeMatériel();
        }

        private void btModifierMatériel_Click(object sender, EventArgs e)
        {
            string requete = "UPDATE materiel SET nom = '" + tbNomMatériel.Text + "', date_possession = '" + tbDatePossessionMatériel.Text + "', garantie = '" + tbDateGarantieMatériel.Text + "', fournisseur = '" + tbFournisseurMatériel.Text +
                    "' WHERE materiel.id_materiel = " + Convert.ToInt32(tbIdMatérielModifier.Text) + ";";
            MySqlCommand cmd = BDD.executerRequete(requete);
            int resultat = cmd.ExecuteNonQuery();

            if (resultat == 1)
            {
                actualiserListeMatériel();
                MessageBox.Show("Le matériel n°" + tbIDPersonnelSupprimer.Text + " a bien été modifié");
            }
            else
            {
                MessageBox.Show("Le matériel n°" + tbIDPersonnelSupprimer.Text + " n'existe pas ou a déjà été modifié");
            }
        }

        private void btSupprimerMatériel_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = BDD.executerRequete("DELETE FROM materiel WHERE id_materiel = " + Convert.ToInt32(tbIdMatérielSupprimer.Text));
            int resultat = cmd.ExecuteNonQuery();

            if (resultat == 1)
            {
                actualiserListeMatériel();
                MessageBox.Show("Le matériel n°" + tbIdMatérielSupprimer.Text + " a bien été supprimé");
            }
            else
            {
                MessageBox.Show("Le matériel n°" + tbIdMatérielSupprimer.Text + " n'existe pas ou a déjà été supprimé");
            }
        }

        private void btAffecterMatériel_Click(object sender, EventArgs e)
        {
            string requete = "UPDATE materiel SET id_personnel = " + Convert.ToInt32(tbIdPersonnelMatérielAffecter.Text) +
                    " WHERE materiel.id_materiel = " + Convert.ToInt32(tbIdMatérielAffecter.Text) + ";";
            MySqlCommand cmd = BDD.executerRequete(requete);
            int resultat = cmd.ExecuteNonQuery();

            if (resultat == 1)
            {
                actualiserListeMatériel();
                MessageBox.Show("Le matériel n°" + tbIdMatérielAffecter.Text + " a bien été affecté au personnel n°" + tbIdPersonnelMatérielAffecter.Text);
            }
            else
            {
                MessageBox.Show("Le matériel n°" + tbIdMatérielAffecter.Text + " ou le personnel n°" + tbIdPersonnelMatérielAffecter.Text + " n'existe pas ou a déjà été supprimé");
            }
        }
    }
}
