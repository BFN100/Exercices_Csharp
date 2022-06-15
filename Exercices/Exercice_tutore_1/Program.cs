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
3 */

namespace Exercice_tutore_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double calcul1 = 0;
            double calcul2 = 0;
            double calcul3 = 0;
            double calcul4 = 0;

            calcul1 = -1 + 4 * 6;
            calcul2 = (35 + 5) % 7;
            calcul3 = 14 + -4 * 6 / 11;
            calcul4 = 2 + 15 / 6 * 1 - 7 % 2;

            Console.WriteLine(calcul1);
            Console.WriteLine(calcul2);
            Console.WriteLine(calcul3);
            Console.WriteLine(calcul4);

            Console.ReadKey();
        }
    }
}
