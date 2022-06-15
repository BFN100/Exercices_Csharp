using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  Write a C# Sharp program that takes a number as input and print its 
multiplication table. 
Test Data:
Enter the number: 5
Expected Output:
5 * 0 = 0
5 * 1 = 5
5 * 2 = 10
5 * 3 = 15
....
5 * 10 = 50 */

namespace Exercice4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Tapez un nombre entier: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            int resultat = 0;

            if (n1 != 0)
            {
                for (int i = 0; i <= 10; i++)
                {
                    resultat = n1 * i;
                    Console.WriteLine("Les multiples sont: " + resultat);
                }
            }
            else
            {
                Console.WriteLine("Ecrivez un nombre entier...");
            }
            Console.ReadKey();
        }
    }
}
