using System;
using System.Diagnostics.Eventing.Reader;

namespace Conditionals
{
    internal class Program
    {
        public static void Main(string[] args)
        {
      
            Console.Write("Enter your number :\t");
            int num = int.Parse(Console.ReadLine());
            if (num <= 10)
            {
                Console.WriteLine("valid number");
             
            }
            else
            { 
                Console.WriteLine("eneter number between 1 - 10 ");
            }
            

         
            //  int num = int.Parse(Console.ReadLine());



        }
    }
}