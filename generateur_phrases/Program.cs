using System;
using System.Collections.Generic;
using System.Linq;

namespace generateur_phrases
{
    class Program
    {
        static string ObtenirElementAleatoire(string[] t)
        {
            Random r = new Random();
            int i = r.Next(t.Length);
            return t[i];
        }
        static void Main(string[] args)
        {
            var sujets = new string[]
            {
              "Le lapin de Pâques",
              "Une chouette",
              "Une fée",
              "Un crocodile",
              "Un éléphant",
              "Un lutin",
              "Le père Noël",
              "Une grenouille",
              "La petite souris",
              "Une licorne",
              "Un phoque"
            };

            var verbes = new string[]
            {
                "nettoie",
                "caresse",
                "discute avec",
                "observe",
                "détruit",
                "mange",
                "joue avec",
                "embrasse",
                "câline",
                "s'accroche à",
                "mord",
                "pique",
                "lèche"
            };

            var complements = new string[]
            {
                "le soleil",
                "la lune",
                "un arbre",
                "un livre",
                "une bulle de savon",
                "une boule à neige",
                "une voiture",
                "une fusée",
                "Vénus",
                "une chaussure",
                "une goutte d'eau",
                "une pomme de pain",
                "un vif d'or",
                "une baguette magique",
                "un médaillon",
                "une couronne",
                "une épée",
                "une casserole"
            };

           

            const int NB_PHRASES = 150;

            var listePhrases = new List<string>();
            int doublons = 0;
            
            
            while (listePhrases.Count < NB_PHRASES)
            {
               
                    var sujet = ObtenirElementAleatoire(sujets);
                    var verbe = ObtenirElementAleatoire(verbes);
                    var complement = ObtenirElementAleatoire(complements);
                    var phrase = sujet + " " + verbe + " " + complement + ".";

                    phrase = phrase.Replace("à le", "au");

                if (listePhrases.Contains(phrase))
                {
                    doublons++;
                }
                else
                    listePhrases.Add(phrase);
            }
           
            foreach (var phrase in listePhrases)
            {
                Console.WriteLine(phrase);
            }

            Console.WriteLine("Nombre de phrases : " + listePhrases.Count);
            Console.WriteLine("Doublons évités : " + doublons);
        }
    }
}
