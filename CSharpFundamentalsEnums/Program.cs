using System;

namespace CSharpFundamentalsEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            Carte[] jeu = new Carte[52];

            int couleur = 0;
            int valeur = 2;

            for (int index = 0; index < jeu.Length; index++, valeur++)
            {
                if(valeur == 15)
                {
                    valeur = 2;
                    couleur++;
                }
                
                jeu[index].Couleur = (Couleurs)couleur;
                jeu[index].Valeur = (Valeurs)valeur;
            }

            foreach (Carte carte in jeu)
            {
                Console.WriteLine($"{carte.Valeur} de {carte.Couleur}");
            }
        }
    }
}
