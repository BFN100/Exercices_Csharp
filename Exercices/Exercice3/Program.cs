using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a C# Sharp program to print on screen the output of adding, 
subtracting, multiplying and dividing of two numbers which will be entered by 
the user.
Test Data:
Input the first number: 25
Input the second number: 4
Expected Output:
25 + 4 = 29
25 - 4 = 21
25 x 4 = 100
25 / 4 = 6
25 mod 4 = 1 */

namespace Exercice3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Tapez un nombre entier: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tapez un deuxieme nombre entier: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            if (n1 > 0 && n2 > 0)
            {
                double resultat = n1 + n2;
                Console.WriteLine(resultat);
                resultat = n1 - n2;
                Console.WriteLine(resultat);
                resultat = n1 * n2;
                Console.WriteLine(resultat);
                resultat = n1 / n2;
                Console.WriteLine(resultat);
                resultat = n1 % n2;
                Console.WriteLine(resultat);
            }
            else
            {
                Console.WriteLine("Tapez les nombres entiers...");
            }

            Console.ReadKey();
        }
    }
}
