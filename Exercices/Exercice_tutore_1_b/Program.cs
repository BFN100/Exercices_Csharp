using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a C# Sharp program to print the result of the specified operations.
Test data:
• -1 + 4 * 6
• ( 35+ 5 ) % 7
• 14 + -4 * 6 / 11
• 2 + 15 / 6 * 1 - 7 % 2
Expected Output:
23
5
12
3 

 Now make the user enter the two numbers and choose the desired operation */

namespace Exercice_tutore_1_b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ecrivez un nombre entier: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ecrivez un nombre entier: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choisissez quelle operation vous besoin de faire entre (+ - / *): ");
            char operateur = Convert.ToChar(Console.ReadLine());

            int resultat = 0;

            if (n1 > 0 && n2 > 0)
            {
                switch (operateur) 
                { 
                    case '+':
                    resultat = n1 + n2;
                        break;
                    case '-':
                    resultat = n1 - n2;
                        break;
                    case '*':
                    resultat = n1 * n2;
                        break;
                    case '/':
                        resultat = n1 / n2;
                        break;
                    default:
                        resultat = n1 + n2;
                        break;
                }
            }
            else
            {
                Console.WriteLine("Ecrivez un nombre entier... ");
            }
            Console.WriteLine("les numéros choisis sont: " + n1 + " et " + n2);
            Console.WriteLine("Vous avez choisi l'opérateur : " + operateur);
            Console.WriteLine("Ça c'est le resultat : " + resultat);
            Console.ReadKey();
        }
    }
}
