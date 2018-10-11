using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab4
{
    class Program
    {
        static void Main(string[] args)
        {
            int userEnteredInt;
            string answer;

            do

            {
                Console.Clear();
                Console.WriteLine("Table of Powers!!!");
                Console.Write("Please enter a number: ");
                userEnteredInt = int.Parse(Console.ReadLine());

                Console.WriteLine("The numbers you chose!");
                for (int i = 0; i < userEnteredInt; ++i)
                {

                    Console.WriteLine(i + 1);

                }
                Console.WriteLine("press any key...");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Your numbers squared!");
                for (int i = 0; i < userEnteredInt; ++i)
                {

                    Console.WriteLine((i + 1) * (i + 1));
                }
                Console.WriteLine("press any key...");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Your Numbers Cubed!");
                for (int i = 0; i < userEnteredInt; ++i)
                {

                    Console.WriteLine((i + 1) * (i + 1) * (i + 1));
                }
                Console.WriteLine("press any key...");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Do you want to pick a different number? (y/n)");
                answer = Console.ReadLine();

            } while ( answer.ToLower() == "y");
            

        }
    }
}
