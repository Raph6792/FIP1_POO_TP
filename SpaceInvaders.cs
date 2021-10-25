using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPP_2
{
    class SpaceInvaders
    {
        private static Joueur j1, j2, j3; // Appel de la classe Joueurs
        public SpaceInvaders()
        {
            Init_Joueur();
        }

        public static void Init_Joueur() // Initialisation des Joueurs 
        {
            j1 = new Joueur(n: "GOETZ", p: "Raph", pseu: "RaphG");
            j2 = new Joueur(n: "SIMON", p: "Maxime", pseu: "Max");
            j3 = new Joueur(n: "SCHMIDT", p: "Guillaume", pseu: "GuiGui");
        }

        public static void Main() // Affichage et appel des différentes classe/méthodes
        {
            Init_Joueur();
            SpaceInvaders SpaceInvaders = new SpaceInvaders();
            Console.WriteLine("Joueur 1 :" + j1 + ", Joueur 2 :" + j2 + " et le Joueur 3 :" + j3 + " ");
        }
    }
}
