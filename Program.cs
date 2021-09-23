using System;
using System.Diagnostics.Eventing.Reader;

namespace Conditionals
{
    internal class Program
    {
        public static void Main(string[] args)
        {
      /*1- Write a program and ask the user to enter a number. The number should be between 1 to 10. If the user enters a valid number, display "Valid" on the console. Otherwise, display "Invalid".
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
            
            */
      
      ////////////////////////////////////////////////////////////////
      //2- Write a program which takes two numbers from the console and displays the maximum of the two.
     
      int i;
      Console.Write("Enter your first number :\t");
      int num = int.Parse(Console.ReadLine());
      
      Console.Write("Enter your second number :\t");
      int secNum = int.Parse(Console.ReadLine());

      int sum = num + secNum;
      Console.WriteLine(sum);
//////////////////////////////////////////////////////////////////////////









        }
    }
}