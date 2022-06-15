using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a C# Sharp program to swap two numbers.
Test Data:
Input the First Number : 5
Input the Second Number : 6
Expected Output:
After Swapping :
First Number : 6
Second Number : 5 */

namespace Exercice_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Ecrivez un nombre entier, s'il vous plait: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            // o 32 ali é o tamanho na memoria
            Console.WriteLine("Ecrivez un nombre entier, s'il vous plait: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Les nombres sont: " + n1 + " et " + n2);            

            int x = n1;
            n1 = n2;
            n2 = x;

            Console.WriteLine("Les nombres au contraire sont: " + n1 + " et " + n2);


            Console.ReadKey();
        }
    }
}
