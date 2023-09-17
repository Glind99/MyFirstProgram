using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram //Gustav Lind .Net23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nr = 4; //

            if (nr < 10) // if number is lower than 10 write
            {
                Console.WriteLine("Oj, Lågt tal!"); // Telling the user its a low number 
            }
            else
            {
                Console.WriteLine("Högt tal!");
            }

            Console.WriteLine("Vad heter du?");
            string name = Console.ReadLine(); //Give the username a value
            Console.WriteLine("Hej " + name + "!"); // Telling the user Hey and calling its value
            
            int sum = 0;
            while (sum < nr) //While sum is lower than the number we earlier gave a value, count till reached the number
            {
                Console.WriteLine(sum);
                sum++;
                
            }
            Console.WriteLine("Du har nu nått numret. Hej då!"); // Say good bye to the user.
            Console.ReadKey(); //Make sure the program doesn't quit before the user can read it.

        }
    }
}
