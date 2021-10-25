using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPP_2
{
    class Arme
    {
        private string NomArme;
        private float DegatMini;
        private float DegatMaxi;
        public Arme(string nomArme, float degatMini, float degatMaxi, Type type) // Constructeur des la classe Arme
        {
            NomArme = nomArme;
            DegatMini = degatMini;
            DegatMaxi = degatMaxi;
        }
        private readonly Type typeArme; //readonly : pas besoin d'être modifiable

        internal Type TypeArme => typeArme; // Getter car en readonly

        //Getters et Setters
        public string GetNomArme() => NomArme;
        public float GetDegatMini() => DegatMini;
        public float GetDegatMaxi() => DegatMaxi;
        public string SetNomArme(string NomA) => NomArme = NomA;
        public float SetDegatMini(float DMin) => DegatMini = DMin;
        public float SetDegatMaxi(float DMax) => DegatMaxi = DMax;
    }
    enum Type // Liste des Types d'armes
    {
        Direct,
        Explosif,
        Guide
    }
}
