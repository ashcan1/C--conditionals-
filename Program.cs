using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading;

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
            /*
             int i;
             Console.Write("Enter your first number :\t");
             int num = int.Parse(Console.ReadLine());
             
             Console.Write("Enter your second number :\t");
             int secNum = int.Parse(Console.ReadLine());
       
             int sum = num + secNum;
             Console.WriteLine(sum);
       //////////////////////////////////////////////////////////////////////////
       
       */
            // 3- Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait.

            /* Console.Write("Enter width of image :\t");
             int width = int.Parse(Console.ReadLine());
               
             Console.Write("Enter your height of image:\t");
             int height = int.Parse(Console.ReadLine());
         
             if (width >= 70 && height <= 70 )
             {
                 Console.WriteLine("the image is landscape");
                 
             }
             else
             {
                 Console.WriteLine("it is portrait");
             }
              */

            // Console.Write("Enter your speed limit :\t");
            // int speedLimit = int.Parse(Console.ReadLine());

            //Console.Write("Enter your car speed :\t");
            // int carSpeed = int.Parse(Console.ReadLine());



            /*  if (speedLimit <= 50)
  
              {
                  Console.WriteLine("ok");
  
  
              }
              else {
                  const int KmPerDemertipoint = 5;
                  var demeritPoint = (speedLimit - carSpeed) / KmPerDemertipoint;
                  if (demeritPoint > 12)
                      Console.WriteLine("License Suspended");
                  else
                      Console.WriteLine("Demerit points: " + demeritPoint);
            
  
  */
///////////////////////////////////////////////////////////
            /// LOOPS/////////////////

            //   1- Write a program to count how many numbers between 1 and 100 are divisible
            // by 3 with no remainder. Display the count on the console.

            /*  var count = 0;
              for (var i = 1; i <= 100; i++)
              {
                  if (i % 3 == 0)
                      count++;
              }
  
              Console.WriteLine("There are {0} numbers divisible by 3 between 1 and 100.", count);
              */



            //////////////////////////////////////////////////////////////////////////////////////
//  Write a program and continuously ask the user to enter a
// number or "ok" to exit. Calculate the sum of all the previously
// entered numbers and display it on the console.



            /* var sum = 0;
             while (true)
             {
                 Console.Write("Enter a number (or 'ok' to exit): ");
                 var input = Console.ReadLine();

                 if (input.ToLower() == "ok")
                     break;

                 sum += Convert.ToInt32(input);
             
             Console.WriteLine("Sum of all numbers is: " + sum);
         }

 }
     */

            /////////////////////////////////////////////////////////////////////
            /*4- Write a program that picks a random number between 1 and 10.
                Give the user 4 chances to guess the number. If the user guesses the number,
                 display “You won"; otherwise, display “You lost". (To make sure the program is behaving correctly,
                you can display the secret number on the console first.)
                */
/*  var number = new Random().Next(1, 10);
Console.WriteLine("Secret is ... ");

for (int i = 0; i < 4; i++)
{

    Console.WriteLine("gusse the numebr");
    var guss = Convert.ToInt32(Console.ReadLine());

    if (number == guss)
    {
        Console.WriteLine("you won");
    return;

    }

}
Console.WriteLine("you lost ");
*/

// Write a program and ask the user to enter a series of numbers separated by comma.
// Find the maximum of the numbers and display it on the console.
// For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.

            /* Console.WriteLine("enter series of numbers:");
             var input = Console.ReadLine();
 
             {
                 
             }
 
 */
            ////////////Write a program and continuously ask the user to enter different names
            /// , until the user presses Enter (without supplying a name). Depending on the number of names provided,
            /// display a message based on the above pattern.
            ///






// 1. make a list object and store it in var
//2. using while loop 
//3. write message for names /exit
//4. store the input in var 
//5 . break the app 
// 6. add input to array 



            var names = new List<string>();

            while (true)
            {
                Console.Write("Type a name (or hit ENTER to quit): ");

                var input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))
                    break;
                names.Add(input);
            }


            if (names.Count > 2)
                Console.WriteLine("{0}, {1} and {2} others like your post", names[0], names[1], names.Count - 2);
            else if (names.Count == 2)
                Console.WriteLine("{0} and {1} like your post", names[0], names[1]);
            else if (names.Count == 1)
                Console.WriteLine("{0} likes your post.", names[0]);
            else
                Console.WriteLine();
        }
      //  2- Write a program and ask the user to enter their name.
      // Use an array to reverse the name and then store the result in a new string.
      // Display the reversed name on the console.
    }


    }


    

































