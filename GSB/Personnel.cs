using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB
{
    class Personnel
    {
        int id_personnel;
        string nom;
        string prenom;
        string matricule;
        string date_embauche;
        string region_carriere;
        string mail;

        static int num_id_personnel = 0;

        public Personnel(string unNom, string unPrenom, string uneDate_embauche, string uneRegion_carriere, string unMail)
        {
            num_id_personnel = num_id_personnel + 1;
            id_personnel = num_id_personnel;
            nom = unNom;
            prenom = unPrenom;
            matricule = "A GENERER";
            date_embauche = uneDate_embauche;
            region_carriere = region_carriere + " - " + uneRegion_carriere;
            mail = unMail + "@swiss-galaxy.com";
        }

        public string infos()
        {
            return id_personnel + " : " + nom + " " + prenom + " (" + matricule + ") - " + mail + " : Embauché le " + date_embauche + " à: " + region_carriere;
        }

        public int Id_personnel
        {
            get
            {
                return id_personnel;
            }

            set
            {
                id_personnel = value;
            }
        }

        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }

        public string Prenom
        {
            get
            {
                return prenom;
            }

            set
            {
                prenom = value;
            }
        }

        public string Matricule
        {
            get
            {
                return matricule;
            }

            set
            {
                matricule = value;
            }
        }

        public string Date_embauche
        {
            get
            {
                return date_embauche;
            }

            set
            {
                date_embauche = value;
            }
        }

        public string Region_carriere
        {
            get
            {
                return region_carriere;
            }

            set
            {
                region_carriere = value;
            }
        }

        public string Mail
        {
            get
            {
                return mail;
            }

            set
            {
                mail = value;
            }
        }
    }
}
