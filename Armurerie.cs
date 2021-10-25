using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPP_2
{
    class Armurerie
    {
        private List<Arme> listeDesArmes = new List<Arme>(); // Utilisation de la liste de types d'armes pour la liste d'armes

        //Getters et Setters
        public List<Arme> GetlisteDesArmes() => listeDesArmes;
        public List<Arme> SetlisteDesArmes(List<Arme> _listeDesArmes) => listeDesArmes = _listeDesArmes;

        public Armurerie() => InitRemplir();
        private void InitRemplir() //Liste d'armes 
        {
            Arme AK = new Arme("AK_47", 89, 189, (Type)1);
            Arme Canon = new Arme("Canon", 379, 750, (Type)2);
            Arme Roquette = new Arme("Roquette", 289, 789, (Type)3);
            //Ajout des armes dans la liste
            listeDesArmes.Add(AK);
            listeDesArmes.Add(Canon);
            listeDesArmes.Add(Roquette);
        }
    }
}
