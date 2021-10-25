using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPP_2
{
    class Joueur
    {
        private string nom;
                string prenom;
        public  string pseudo;
        public Joueur(string n, string p, string pseu) // Constructeur de la classe Joueur
        {
            nom = n;
            prenom = p;
            pseudo = pseu;
            FormatNP();
        }

        private void FormatNP() // Fonction qui permet de mettre une majuscule à la première lettre du nom et prénom 
        {
            nom = nom.ToLower() + char.ToUpper(nom[0]);
            prenom = prenom.ToLower() + char.ToUpper(prenom[0]);
        }
        public override string ToString() => pseudo + "( " + nom + "  " + prenom + " )"; // Ordre d'affichage des Joueur 


        public override bool Equals(object obj) //Comparaison des pseudos des joueurs 
        {
            Joueur def = (Joueur)obj;
            return def.pseudo == this.pseudo;
        }

        private List<Vaisseau> listeDesVaisseau = new List<Vaisseau>(); // Utilisation de la classe Vaisseau pour choisir le vaisseau souhaité

        //Getters et Setters
        public List<Vaisseau> GetlisteDesVaisseau() => listeDesVaisseau;
        public List<Vaisseau> SetlisteDesVaisseau(List<Vaisseau> _listeDesVaisseau) => listeDesVaisseau = _listeDesVaisseau;

    }
}
