using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPP_2
{
    class Vaisseau
    {
        private float PointDeVie;
                float Bouclier;
                bool Detruit;

        public Vaisseau() //Valeurs des variables par défaut
        {
            PointDeVie = 2000; //Valeur Max
            Bouclier = 500; //Valeur Max
            Detruit = false;
        }

        //Getters et Setters
        public float GetPointDeVie() => PointDeVie;
        public float GetBouclier() => Bouclier;
        public bool GetDetruit() => Detruit;
        public float SetPointDeVie(float PDV) => PointDeVie = PDV;
        public float SetBouclier(float Boubou) => Bouclier = Boubou;
        public bool SetDetruit(bool D) => Detruit = D;

        // Permet de stocker des armes 
        private List<Armurerie> StockArmes = new List<Armurerie>();
        public List<Armurerie> GetStockArmes() => StockArmes;
        public List<Armurerie> SetStockArmes(List<Armurerie> _StockArmes) => StockArmes = _StockArmes;

        public void AjoutArme()// Fonction pour ajouter des armes
        {
             
        }

        public void RetireArme()// Fonction pour retirer des armes
        {

        }
    }
}
