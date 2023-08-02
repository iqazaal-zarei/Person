using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person_Excample
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
          
            try
            {

                Console.WriteLine("How many persons do you have ?? ");
                int Number = Convert.ToInt32(Console.ReadLine());
                string[] Names = new string[Number];
                for(int i = 0; i<Number; i++)
                {
                    Console.WriteLine("Please enter number " + (i+1));
                    Names[i] = Console.ReadLine();
                
                }
       foreach(string name in Names)
                {
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Hi    "+ name);
                    Console.ResetColor();
                }
            }
            catch
            {
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("enter just number ");
                Console.ResetColor();
                
            }
      
            Console.ReadLine();
        }
    }
}
