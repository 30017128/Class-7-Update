//Stephen Burgess
//Class program example


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    class Program
    {
        static void Main(string[] args)
        {



            /*/
            Console.WriteLine("enter your four digit pin");
            int pin = int.Parse(Console.ReadLine());

            if (pin >= 1000 && pin<= 9999)
            {
                Console.WriteLine("Enter your pin again");
                int pin2 = int.Parse(Console.ReadLine());

                if (pin == pin2)

                {
                    Console.WriteLine("Your pin has been set");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Error!Your PIN numbers did not match.Your PIN was not set");
                }

               
            }
            else
            {
                Console.WriteLine("This PIN number is not within the right parameters");
            }
            Console.ReadLine();

            /*/


            /*/
             
            
             

             
          
            Console.WriteLine("Select your first letter");
            string let1 = Console.ReadLine();

            Console.WriteLine("Select your second letter");
            string let2 = Console.ReadLine();

            Console.WriteLine("Select your third letter");
            string let3 = Console.ReadLine();
            //check first and last letters are the same

            

            if (let1 == let3)
            {
                if (let2 == "a" || let2 == "e" || let2 == "i" || let2 == "o" || let2 =="u")
                {
                    Console.WriteLine("This is a palindrome");

                }

                else
                {
                    Console.WriteLine("This is not a word");
                }


            }

        
            else
            {
                Console.WriteLine("This is not a palindrome");
            }

            Console.ReadLine();

            /*/



            /*/



            Console.WriteLine("Enter your first number");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter your operator +  -  /  * ");
            string input = (Console.ReadLine());
            double result = 0;




            switch (input)

            {
                case "+":
                    result = num1 + num2;
                    break;

                case "-":
                    result = num1 - num2;
                    break;

                case "/":
                    result = num1 / num2;
                    break;

                case "*":
                    result = num1 * num2;
                    break;


                default:
                    Console.WriteLine("Goodbye");
                    break;







            }

            Console.WriteLine("\n{0} {1} {2} = {3}", num1, input, num2, result);
            Console.ReadLine();

            /*/

            /*/

            //Loop Example

            Console.WriteLine("Loop Example");

            int limit = 10; //the variable for the int limit for the loop

            for(int counter = 1; counter <= limit; counter++)
            {
                Console.WriteLine("Loop" + counter);


            }

            Console.ReadLine();

            /*/

            //While Loop Example

            /*/

            Console.WriteLine("While Loop Example\n");

            Console.WriteLine("Would you like to enter the loop (Y / N)");
            string input = Console.ReadLine().ToLower();//ToLower allows string to accept uppercase and turn it to lower case


            while (input == "y")
            {
                Console.WriteLine("You are now inside the loop");
                Console.Write("Would you like to stay inside the loop (Y / N):  ");
                input = Console.ReadLine().ToLower();




            }
            Console.WriteLine("\nYou have now passed the WHILE loop. ");
            
            Console.ReadLine();

            /*/

            /*/

            Console.WriteLine("Do While Example");

            string input = "n";

            do
            {
                Console.WriteLine("You are now inside the loop");
                Console.Write("Would you like to stay inside the loop (Y / N)");
                input = Console.ReadLine().ToLower();
            }

            while (input != "n");

            Console.WriteLine("\nYou have now passed the DO WHILE loop.");
            Console.ReadLine();


              /*/


            /*/



            //for Loop table example.


            Console.WriteLine("For Loop Table Example\n");

          
            

            for (int counter = 3; counter <= 7; counter++)
            {
                Console.WriteLine($" {counter}\t\t{counter * 10}\t\t{counter * 100}\t\t{counter * 1000}");


            }
            


            Console.ReadLine();

            /*/


            //While Loop Table
            //While loops don't have a counter so you need to make a counter.


            /*/
            

            Console.WriteLine("While Loop Table Example");



            int finish = 7;
            int counter = 1;
            while (counter <= finish)
            {

                Console.WriteLine($" {counter}\t\t{counter * 2}\t\t{counter * 3}\t\t{counter * 4}");
                counter++;

            }
            Console.WriteLine("End of the while loop");
            Console.ReadLine();


            



            
            Console.WriteLine("Do While Loop");
            counter = 3;
            do
            {

                Console.WriteLine($" {counter}\t\t{counter * 10}\t\t{counter * 100}\t\t{counter * 1000}");
                counter++;


            }
            while (counter <= finish);
            
            Console.ReadLine();

            /*/


            // 7 times table time

            Console.WriteLine("For Loop");

            for (int counter = 1; counter <= 12; counter++)
            {

                Console.WriteLine($" {counter} x 7 = {counter * 7}");


            }

            Console.WriteLine("While Loop Times Table");
            int finish = 12;
            int counter2 = 1;
            while (counter2 <= finish)
            {

                Console.WriteLine($" {counter2} x 7 = {counter2 * 7}");
                counter2++;
            }
            Console.ReadLine();
         

















        }














        }

    }

