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

        private void incident_Click(object sender, EventArgs e)
        {

        }
  
        private void label44_Click(object sender, EventArgs e)
        {

        }

        private void tbIdVisteurACAjout_TextChanged(object sender, EventArgs e)
        {

        }

        // ******************************************************* //

        private void Interface_Load(object sender, EventArgs e)
        {
            BDD = new BDD();

            actualiserListePersonnel();
            actualiserListeMatériel();
            actualiserListeProduit();
            actualiserListePraticien();
            actualiserListeIncident();
            actualiserListeVisite();
            actualiserListeActivitéComplémentaire();
        }

        private void actualiserListeTechnicien()
        {
            listeTechnicien.Items.Clear();

            string requete = "SELECT * FROM personnel P JOIN technicien T ON P.id_personnel = T.id_personnel " +
                "WHERE P.role = 'Technicien' OR P.role = 'Technicien supérieur';";
            MySqlCommand cmd = BDD.executerRequete(requete);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                listeTechnicien.Items.Add(rdr.GetInt32(0) + " - " + rdr.GetString(1) + " " + rdr.GetString(2) + " - " + rdr.GetString(5) + " : Embauché depuis le " + rdr.GetDateTime(3) + " en tant que " + rdr.GetString(6) + " dans la région " + rdr.GetString(4) + ". Niveau de compétence : " + rdr.GetInt32(8) + " - Compétences : " + rdr.GetString(10) + " - Formation : " + rdr.GetString(9));
            }

            rdr.Close();
        }

        private void actualiserListeResponsableRegion()
        {
            listeResponsableRégion.Items.Clear();

            string requete = "SELECT * FROM personnel P JOIN responsable_region RR ON P.id_personnel = RR.id_personnel " +
                "WHERE P.role = 'Responsable région';";
            MySqlCommand cmd = BDD.executerRequete(requete);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                listeResponsableRégion.Items.Add(rdr.GetInt32(0) + " - " + rdr.GetString(1) + " " + rdr.GetString(2) + " - " + rdr.GetString(5) + " : Embauché depuis le " + rdr.GetDateTime(3) + " en tant que " + rdr.GetString(6) + " dans la région " + rdr.GetString(4));
            }

            rdr.Close();
        }

        private void actualiserListeVisiteursMédicaux()
        {
            listeVisiteursMédicaux.Items.Clear();
            listeVisiteurs2.Items.Clear();

            string requete = "SELECT * FROM personnel P JOIN visiteur V ON P.id_personnel = V.id_personnel " +
                "WHERE P.role = 'Visiteur médical' OR P.role = 'Délégué régional';";
            MySqlCommand cmd = BDD.executerRequete(requete);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                listeVisiteursMédicaux.Items.Add(rdr.GetInt32(0) + " - " + rdr.GetString(1) + " " + rdr.GetString(2) + " - " + rdr.GetString(5) + " : Embauché depuis le " + rdr.GetDateTime(3) + " en tant que " + rdr.GetString(6) + " dans la région " + rdr.GetString(4) + ". Son objectif est '" + rdr.GetString(8) + "' avec un budget de " + rdr.GetInt32(11) + "€. Prime : " + rdr.GetString(9) + "€ - Avantages : " + rdr.GetString(10));
                listeVisiteurs2.Items.Add(rdr.GetInt32(0) + " - " + rdr.GetString(1) + " " + rdr.GetString(2) + " - " + rdr.GetString(5) + " : Embauché depuis le " + rdr.GetDateTime(3) + " en tant que " + rdr.GetString(6) + " dans la région " + rdr.GetString(4) + ". Son objectif est '" + rdr.GetString(8) + "' avec un budget de " + rdr.GetInt32(11) + "€. Prime : " + rdr.GetString(9) + "€ - Avantages : " + rdr.GetString(10));

            }

            rdr.Close();
        }

        private void actualiserListeProduit()
        {
            int Produits = 0;

            listeProduits.Items.Clear();
            listeProduits2.Items.Clear();

            string requete = "SELECT * FROM produit;";

            MySqlCommand cmd = BDD.executerRequete(requete);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                listeProduits.Items.Add(rdr.GetInt32(0) + " - " + rdr.GetString(1) + " - Effet: " + rdr.GetString(2) + " - Contre-Indication : " + rdr.GetString(3) + " - Composition: " + rdr.GetString(4) + " - Posologie: " + rdr.GetString(5) + " - Famille : " + rdr.GetString(6) + " - Coût: " + rdr.GetDouble(7) + "€");
                listeProduits2.Items.Add(rdr.GetInt32(0) + " - " + rdr.GetString(1) + " - Effet: " + rdr.GetString(2) + " - Contre-Indication : " + rdr.GetString(3) + " - Composition: " + rdr.GetString(4) + " - Posologie: " + rdr.GetString(5) + " - Famille : " + rdr.GetString(6) + " - Coût: " + rdr.GetDouble(7) + "€");

                Produits++;
            }

            rdr.Close();

            nbProduit.Text = Produits.ToString();
        }

        private void actualiserListeVisite()
        {
            int Visites = 0;

            listeVisites.Items.Clear();

            string requete = "SELECT * FROM activite A JOIN visite V ON A.id_activite = V.id_activite;";

            MySqlCommand cmd = BDD.executerRequete(requete);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                listeVisites.Items.Add(rdr.GetInt32(3) + " - AC par le visiteur n°" + rdr.GetUInt32(2) + " le " + rdr.GetValue(4) + " : " + rdr.GetString(5) + " pour un côut de " + rdr.GetInt32(8) + "€ - Médicament offert en échantillon => " + rdr.GetValue(7) + " x le n°" + rdr.GetValue(6));

                Visites++;
            }

            rdr.Close();

            nbVisites.Text = Visites.ToString();
        }

        private void actualiserListePraticien()
        {
            int Praticiens = 0;

            listePraticiens.Items.Clear();
            listePraticiens2.Items.Clear();
            listePraticiens3.Items.Clear();

            string requete = "SELECT * FROM praticien;";

            MySqlCommand cmd = BDD.executerRequete(requete);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                listePraticiens.Items.Add(rdr.GetInt32(0) + " - " + rdr.GetString(1) + " - Libelle: " + rdr.GetString(2));
                listePraticiens2.Items.Add(rdr.GetInt32(0) + " - " + rdr.GetString(1) + " - Libelle: " + rdr.GetString(2));
                listePraticiens3.Items.Add(rdr.GetInt32(0) + " - " + rdr.GetString(1) + " - Libelle: " + rdr.GetString(2));

                Praticiens++;
            }

            rdr.Close();

            nbPraticiens.Text = Praticiens.ToString();
        }

        private void actualiserListeIncident()
        {
            int IncidentsEnCours = 0;
            int IncidentsCloturés = 0;

            listeIncidentEnCours.Items.Clear();
            listeIncidentCloturé.Items.Clear();

            string requete = "SELECT * FROM ticket_incident;";
            MySqlCommand cmd = BDD.executerRequete(requete);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                if (rdr.GetString(3) == "Clôturé")
                {
                    listeIncidentCloturé.Items.Add(rdr.GetInt32(0) + " : Urgence => " + rdr.GetInt32(1) + "/9 sur le matériel n°" + rdr.GetInt32(9) + " - Etat : " + rdr.GetString(3) + " - Objet : " + rdr.GetString(2) + " - Déposé le : " + rdr.GetValue(4) + ". Début prise en charge : " + rdr.GetValue(5) + " - Fin prise en charge : " + rdr.GetValue(6) + " - Travail réalisé : " + rdr.GetValue(7) + " - Type de prise en charge : " + rdr.GetValue(8) + " par le technicien n°" + rdr.GetValue(10));
                    IncidentsCloturés++;
                }
                else
                {
                    listeIncidentEnCours.Items.Add(rdr.GetInt32(0) + " : Urgence => " + rdr.GetInt32(1) + "/9 sur le matériel n°" + rdr.GetInt32(9) + " - Etat : " + rdr.GetString(3) + " - Objet : " + rdr.GetString(2) + " - Déposé le : " + rdr.GetValue(4) + ". Début prise en charge : " + rdr.GetValue(5) + " - Fin prise en charge : " + rdr.GetValue(6) + " - Travail réalisé : " + rdr.GetValue(7) + " - Type de prise en charge : " + rdr.GetValue(8) + " par le technicien n°" + rdr.GetValue(10));
                    IncidentsEnCours++;
                }
            }

            rdr.Close();

            nbTicketEnCours.Text = IncidentsEnCours.ToString();
            nbTicketCloturé.Text = IncidentsCloturés.ToString();  
        }

        private void actualiserListeActivitéComplémentaire()
        {
            int ACAccordée = 0;
            int ACRefusée = 0;

            listeDemandeAC.Items.Clear();

            string requete = "SELECT * FROM activite A JOIN activite_complementaire AC ON A.id_activite = AC.id_activite";
            MySqlCommand cmd = BDD.executerRequete(requete);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                if (rdr.IsDBNull(8))
                {
                    listeDemandeAC.Items.Add(rdr.GetInt32(3) + " - Demande d'AC du visiteur n°" + rdr.GetInt32(2) + " : " + rdr.GetString(6) + " en salle n°" + rdr.GetInt32(4) + " pour un budget de " + rdr.GetInt32(5) + "€ avec pour participants : " + rdr.GetString(7));
                }

                else if (rdr.GetBoolean(8) == true)
                {
                    ACAccordée++;
                }
                else
                {
                    ACRefusée++;
                }
            }

            rdr.Close();

            nbACAccordé.Text = ACAccordée.ToString();
            nbACRefusé.Text = ACRefusée.ToString();
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

            actualiserListeVisiteursMédicaux();
            actualiserListeTechnicien();
            actualiserListeResponsableRegion();

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

        private void button14_Click(object sender, EventArgs e)
        {
            string requete = "INSERT INTO produit (nom, effet_therapeutique, contre_indication, composition, posologie, famille, cout)" +
                " VALUES ('" + tbNomProduit.Text + "', '" + tbEffetTheraProduit.Text + "', '" + tbContreIndicationProduit.Text + "', '" + tbCompositionProduit.Text + "' , '" + tbPosologieProduit.Text + "', '" + tbFamilleProduit.Text + "', " + Convert.ToDouble(tbCoutProduit.Text) + ");";

            MySqlCommand cmd = BDD.executerRequete(requete);
            cmd.ExecuteNonQuery();

            actualiserListeProduit();
        }

        private void btModifierProduit_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = BDD.executerRequete("UPDATE produit SET nom = '" + tbNomProduit.Text + "', effet_therapeutique = '" + tbEffetTheraProduit.Text + "', contre_indication = '" + tbContreIndicationProduit.Text + "', composition = '" + tbCompositionProduit.Text + "', posologie = '" + tbPosologieProduit.Text + "', famille = '" + tbFamilleProduit.Text + "', cout = " + Convert.ToDouble(tbCoutProduit.Text) +
                " WHERE id_produit = " + Convert.ToInt32(tbIdProduitModifier.Text) + ";");
            int resultat = cmd.ExecuteNonQuery();

            if (resultat == 1)
            {
                actualiserListeProduit();
                MessageBox.Show("Le produit n°" + tbIdProduitModifier.Text + " a bien été modifié");
            }
            else
            {
                MessageBox.Show("Impossible de trouver le produit n°" + tbIdProduitModifier.Text);
            }
        }

        private void btSupprimerProduit_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = BDD.executerRequete("DELETE FROM produit WHERE id_produit = " + Convert.ToInt32(tbIdProduitSupprimer.Text));
            int resultat = cmd.ExecuteNonQuery();

            if (resultat == 1)
            {
                actualiserListeProduit();
                MessageBox.Show("Le produit n°" + tbIdProduitSupprimer.Text + " a bien été supprimé");
            }
            else
            {
                MessageBox.Show("Le produit n°" + tbIdProduitSupprimer.Text + " n'existe pas ou a déjà été supprimé");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string requete = "INSERT INTO praticien (nom, libelle) " + "VALUES ('" + tbNomPraticien.Text + "', '" + tbLibellePraticien.Text + "');";

            MySqlCommand cmd = BDD.executerRequete(requete);
            cmd.ExecuteNonQuery();

            actualiserListePraticien();
        }

        private void btPraticienModifier_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = BDD.executerRequete("UPDATE praticien SET nom = '" + tbNomPraticien.Text + "', libelle = '" + tbLibellePraticien.Text +
                    "' WHERE id_praticien = " + Convert.ToInt32(tbIdPraticienModifier.Text) + ";");
            int resultat = cmd.ExecuteNonQuery();

            if (resultat == 1)
            {
                actualiserListePraticien();
                MessageBox.Show("Le praticien n°" + tbIdPraticienModifier.Text + " a bien été modifié");
            }
            else
            {
                MessageBox.Show("Impossible de trouver le praticien n°" + tbIdPraticienModifier.Text);
            }
        }

        private void btPraticienSupprimer_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = BDD.executerRequete("DELETE FROM praticien WHERE id_praticien = " + Convert.ToInt32(tbIdPraticienSupprimer.Text));
            int resultat = cmd.ExecuteNonQuery();

            if (resultat == 1)
            {
                actualiserListePraticien();
                MessageBox.Show("Le praticien n°" + tbIdPraticienSupprimer.Text + " a bien été supprimé");
            }
            else
            {
                MessageBox.Show("Le praticien n°" + tbIdPraticienSupprimer.Text + " n'existe pas ou a déjà été supprimé");
            }
        }

        private void btAjouterIncident_Click(object sender, EventArgs e)
        {
            string requete = "INSERT INTO ticket_incident (niveau_urgence, objet, etat, date, id_materiel)" +
               " VALUES (" + Convert.ToInt32(tbNiveauUrgenceIncident.Text) + ", '" + tbObjetIncident.Text + "', 'Enregistrée', '" + tbDateIncident.Text + "', " + Convert.ToInt32(tbIdMatérielAjouterIncident.Text) + ");";

            MySqlCommand cmd = BDD.executerRequete(requete);
            cmd.ExecuteNonQuery();

            actualiserListeIncident();
        }

        private void btIncidentTraitement_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = BDD.executerRequete("UPDATE ticket_incident SET etat = 'En cours de traitement'"+
                " WHERE id_ticket_incident = " + Convert.ToInt32(tbIdTicketIncidentModifier.Text) + ";");
            int resultat = cmd.ExecuteNonQuery();

            if (resultat == 1)
            {
                actualiserListeIncident();
                MessageBox.Show("L'état du ticket d'incident n°" + tbIdTicketIncidentModifier.Text + " a bien été modifié");
            }
            else
            {
                MessageBox.Show("Impossible de trouver le ticket d'incident n°" + tbIdTicketIncidentModifier.Text);
            }
        }

        private void btIncidentRésolu_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = BDD.executerRequete("UPDATE ticket_incident SET etat = 'Résolu'" +
                " WHERE id_ticket_incident = " + Convert.ToInt32(tbIdTicketIncidentModifier.Text) + ";");
            int resultat = cmd.ExecuteNonQuery();

            if (resultat == 1)
            {
                actualiserListeIncident();
                MessageBox.Show("L'état du ticket d'incident n°" + tbIdTicketIncidentModifier.Text + " a bien été modifié");
            }
            else
            {
                MessageBox.Show("Impossible de trouver le ticket d'incident n°" + tbIdTicketIncidentModifier.Text);
            }
        }

        private void btIncidentCloturé_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = BDD.executerRequete("UPDATE ticket_incident SET etat = 'Clôturé'" +
                " WHERE id_ticket_incident = " + Convert.ToInt32(tbIdTicketIncidentModifier.Text) + ";");
            int resultat = cmd.ExecuteNonQuery();

            if (resultat == 1)
            {
                actualiserListeIncident();
                MessageBox.Show("L'état du ticket d'incident n°" + tbIdTicketIncidentModifier.Text + " a bien été modifié");
            }
            else
            {
                MessageBox.Show("Impossible de trouver le ticket d'incident n°" + tbIdTicketIncidentModifier.Text);
            }
        }

        private void btPriseEnChargeTéléphoneIncident_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = BDD.executerRequete("UPDATE ticket_incident SET type_prise_en_charge = 'Technicien au téléphone'" +
                " WHERE id_ticket_incident = " + Convert.ToInt32(tbIdTicketIncidentModifier.Text) + ";");
            int resultat = cmd.ExecuteNonQuery();

            if (resultat == 1)
            {
                actualiserListeIncident();
                MessageBox.Show("Le type de prise en charge du ticket d'incident n°" + tbIdTicketIncidentModifier.Text + " a bien été modifié");
            }
            else
            {
                MessageBox.Show("Impossible de trouver le ticket d'incident n°" + tbIdTicketIncidentModifier.Text);
            }
        }

        private void btPriseEnChargeTélémaintenanceIncident_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = BDD.executerRequete("UPDATE ticket_incident SET type_prise_en_charge = 'Technicien en télémaintenance'" +
                " WHERE id_ticket_incident = " + Convert.ToInt32(tbIdTicketIncidentModifier.Text) + ";");
            int resultat = cmd.ExecuteNonQuery();

            if (resultat == 1)
            {
                actualiserListeIncident();
                MessageBox.Show("Le type de prise en charge du ticket d'incident n°" + tbIdTicketIncidentModifier.Text + " a bien été modifié");
            }
            else
            {
                MessageBox.Show("Impossible de trouver le ticket d'incident n°" + tbIdTicketIncidentModifier.Text);
            }
        }

        private void btPriseEnChargeDéplacementIncident_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = BDD.executerRequete("UPDATE ticket_incident SET type_prise_en_charge = 'Déplacement sur site'" +
                " WHERE id_ticket_incident = " + Convert.ToInt32(tbIdTicketIncidentModifier.Text) + ";");
            int resultat = cmd.ExecuteNonQuery();

            if (resultat == 1)
            {
                actualiserListeIncident();
                MessageBox.Show("Le type de prise en charge du ticket d'incident n°" + tbIdTicketIncidentModifier.Text + " a bien été modifié");
            }
            else
            {
                MessageBox.Show("Impossible de trouver le ticket d'incident n°" + tbIdTicketIncidentModifier.Text);
            }
        }

        private void btTechnicienAffecterIncident_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = BDD.executerRequete("UPDATE ticket_incident SET date_debut_travail = '" + tbDateDébutPriseEnCharge.Text + "', date_fin_travail = '" + tbDateFinPriseEnCharge.Text + "', travail_realise = '" + tbTravailRéaliséIncident.Text + "', id_technicien = " + Convert.ToInt32(tbIdTechnicienAffectationIncident.Text) +
                " WHERE id_ticket_incident = " + Convert.ToInt32(tbIdIncidentAffectationTechnicien.Text) + ";");
            int resultat = cmd.ExecuteNonQuery();

            if (resultat == 1)
            {
                actualiserListeIncident();
                MessageBox.Show("Le technicien a bien été affecté sur le ticket d'incident n°" + tbIdTechnicienAffectationIncident.Text);
            }
            else
            {
                MessageBox.Show("Impossible de trouver le ticket d'incident n°" + tbIdTechnicienAffectationIncident.Text + " ou le technicien n°" + tbIdTechnicienAffectationIncident.Text);
            }
        }

        private void btAjouterVisite_Click(object sender, EventArgs e)
        {
            string requete = "INSERT INTO activite (bilan, id_visiteur)" +
              " VALUES ('" + tbBilanVisite.Text + "', " + Convert.ToInt32(tbIdVisiteurAjoutVisite.Text) + ");";
            MySqlCommand cmd = BDD.executerRequete(requete);
            cmd.ExecuteNonQuery();

            requete = "INSERT INTO visite (date, motif, nb_echantillons_offerts, cout, id_activite)" +
              " VALUES ('" + tbDateVisite.Text + "', '" + tbMotifVisite.Text + "', " + tbNbEchantillonVisite.Text + ", " + tbCoutVisite.Text + ", LAST_INSERT_ID());";
            cmd = BDD.executerRequete(requete);
            cmd.ExecuteNonQuery();

            if (tbIdProduitAjoutVisite.Text != "")
            {
                cmd = BDD.executerRequete("UPDATE visite SET medicament = " + tbIdProduitAjoutVisite.Text +
                " WHERE id_visite = LAST_INSERT_ID();");
                cmd.ExecuteNonQuery();
            }

            actualiserListeVisite();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string requete = "INSERT INTO activite (id_visiteur) VALUES (" + Convert.ToInt32(tbIdVisteurACAjout.Text) + ");";
            MySqlCommand cmd = BDD.executerRequete(requete);
            cmd.ExecuteNonQuery();

            requete = "INSERT INTO activite_complementaire (num_salle, budget_max, commentaire, id_activite, praticiens)" +
                " VALUES (" + Convert.ToInt32(tbNoSalleAC.Text) + ", " + Convert.ToInt32(tbBudgetMaxAC.Text) + ", '" + tbCommentaireAC.Text + "', LAST_INSERT_ID(),  '" + tbPraticiensAC.Text + "');";
            cmd = BDD.executerRequete(requete);
            cmd.ExecuteNonQuery();

            actualiserListeActivitéComplémentaire();
        }

        private void btDonnerAccordAC_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = BDD.executerRequete("UPDATE activite_complementaire SET accorde = true" +
                " WHERE id_activite_complementaire = " + Convert.ToInt32(tbIdDemandeAC.Text) + ";");
            int resultat = cmd.ExecuteNonQuery();

            if (resultat == 1)
            {
                actualiserListeActivitéComplémentaire();
                MessageBox.Show("La demande d'AC n°" + tbIdDemandeAC.Text + " a bien été accordée");
            }
            else
            {
                MessageBox.Show("Impossible de trouver la demande d'AC n°" + tbIdDemandeAC.Text);
            }
        }

        private void btDonnerRefusAC_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = BDD.executerRequete("UPDATE activite_complementaire SET accorde = false" +
                " WHERE id_activite_complementaire = " + Convert.ToInt32(tbIdDemandeAC.Text) + ";");
            int resultat = cmd.ExecuteNonQuery();

            if (resultat == 1)
            {
                actualiserListeActivitéComplémentaire();
                MessageBox.Show("La demande d'AC n°" + tbIdDemandeAC.Text + " a bien été refusée");
            }
            else
            {
                MessageBox.Show("Impossible de trouver la demande d'AC n°" + tbIdDemandeAC.Text);
            }
        }

        private void btStatsDemandeAC_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = BDD.executerRequete("SELECT statsDemandeAC(" + Convert.ToInt32(tbIdVisiteurStats.Text) + ");");
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                MessageBox.Show(rdr.GetValue(0).ToString());
            }
        }
    }
}
