using System;
using System.Linq;
using System.Threading;

namespace TP0
{
    class Program
    {
        static void Main(string[] args)
        {
            string nom, prenom;
            float taille, poids;
            int age;
           // bool reset;

            //do
            //{

               // reset = true;

                Console.WriteLine("Bienvenue sur mon programme, jeune inconnu O_o");

                Console.WriteLine("Donne moi ton nom, aller hop : ");
                nom = Console.ReadLine();
                if (nom.Any(char.IsDigit))
                {
                    Console.WriteLine("Ton nom contient un nombre, refusé !");
                    return;
                }
                else
                {
                    Console.WriteLine("OK, et ton petit prénom c'est quoi : ");
                }
                prenom = Console.ReadLine();
                if (prenom.Any(char.IsDigit))
                {
                    Console.WriteLine("Ton prénom contient un nombre, refusé !");
                    return;
                }
                else
                {
                    Console.WriteLine("Bonjour à toi " + etiquette(prenom, nom) + "!");
                }
                Console.WriteLine("Quel est ta taille (en cm) ?");
                taille = float.Parse(Console.ReadLine());
                if (taille <= 0)
                {
                    Console.WriteLine("Tu ne peux pas faire 0 cm, refusé !");
                    return;
                }
                else
                {
                    Console.WriteLine("Quel est ton poids (en kg) ?");
                }
                poids = float.Parse(Console.ReadLine());
                if (poids <= 0)
                {
                    Console.WriteLine("Tu ne peux pas faire 0 kg, refusé !");
                    return;
                }
                else
                {
                    Console.WriteLine("Quel est ton age ?");
                }
                age = int.Parse(Console.ReadLine());
                if (age <= 0)
                {
                    Console.WriteLine("Tu veux me faire croire que t'es pas né... Refusé !!! ");
                    return;
                }
                else
                {
                    Console.WriteLine("Bonjour " + etiquette(prenom, nom) + ", tu as " + age + "ans, tu pèses " + poids + "Kg et tu mesures " + taille + "cm.");
                }

                if (age < 18)
                {
                    Console.WriteLine("Tu veux un Panaché petit imberbe ?");
                }
                else
                {
                    Console.WriteLine("Viens boire un ptit coup à la maison " + prenom + " !");
                }
            
            // float s = CalculIMC(taille, poids);
            // NombreCheveux();


            //} while (!reset);

            Console.WriteLine("A+ bye bye !");
            Thread.Sleep(3000);
            return;

        }

        //Fonctions : 
        static string etiquette(string prenom, string nom) 
        {
            return prenom.ToLower() + " " + nom.ToUpper();
        }

        static float CalculIMC (float taille, float poids) 
        {
            taille /= 100;
            float result = (poids / (taille * taille));
            return result;
          
        }

        static void TabIMC(float IMC)
        {
            const string anorexie = "Attention à l’anorexie !";
            const string maigre = "Vous êtes un peu maigrichon !";
            const string normale = "Vous êtes de corpulence normale!";
            const string surpoids = "Vous êtes en surpoids !";
            const string omodere = "Obésité modérée !";
            const string osevere = "Obésité sévère !";
            const string omorbide = "Obésité morbide !";

            if(IMC >= 40)
            {
                Console.WriteLine(omorbide);
            }
            else if(IMC >= 35)
            {
                Console.WriteLine(osevere);
            }
            else if(IMC >= 30)
            {
                Console.WriteLine(omodere);
            }
            else if(IMC >= 25)
            {
                Console.WriteLine(surpoids);
            }
            else if(IMC >= 18.5)
            {
                Console.WriteLine(normale);
            }
            else if(IMC >= 16.5)
            {
                Console.WriteLine(maigre);
            }
            else
            {
                Console.WriteLine(anorexie);
            }
        }
        static void NombreCheveux() 
        {
            int nombreCH = 0;

            while(nombreCH < 100000 || nombreCH > 150000)
            {
                Console.WriteLine("Combiens de cheveux penses-tu avoir ?");
                try
                {
                    nombreCH = int.Parse(Console.ReadLine());
                }
                catch(Exception e)
                {
                    Console.WriteLine("Erreur de saisie, veuillez réessayer !");
                }
                if(nombreCH < 100000 || nombreCH > 150000)
                {
                    Console.WriteLine("Non, pas bon. Encore ?");
                }
                else
                {
                    Console.WriteLine("Bien joué ! ça fait beaucoup :) ");
                }
            }

        }


    }
}
