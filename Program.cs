using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace topic_6_while_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice = "";

            while (choice != "q")
            {
                Console.Clear(); // Optional
                Console.WriteLine("Welcome to my generic menu.  Please select an option:");
                Console.WriteLine();
                Console.WriteLine("1 - Menu Option 1");
                Console.WriteLine("2 - Menu Option 2");
                Console.WriteLine("...");
                Console.WriteLine("x - Menu Option x");
                Console.WriteLine("Q - Quit");
                Console.WriteLine();
                choice = Console.ReadLine().ToLower().Trim();
                Console.WriteLine();

                if (choice == "1")
                {
                    //Do option 1
                    Console.WriteLine("You chose option 1");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == "2")
                {
                    // Do option 2
                    Console.WriteLine("You chose option 2");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                // Add an else if for each valid choice...
                else
                {
                    Console.WriteLine("Invalid choice, press ENTER to continue.");
                    Console.ReadLine();


                }



            }
        }

        static void MinMax()
        {
            int maxnum = 0, minnum = 0;
            int guess = 0;

            bool done = false;
            while (!done)
            {
                Console.WriteLine("you are going to give me 2 numbers and ones going to become the minimum and the other will become the maximum after you give me the two numbers you have to say a number that is between the two numbers you just gave me ");
                Console.WriteLine("please give me any number to make the minimum for the numbers you have to guess between ");
                minnum = Int32.Parse(Console.ReadLine());
                Console.WriteLine("please enter the second number that will become your maximum");
                maxnum = Int32.Parse(Console.ReadLine());
                guess = Int32.Parse(Console.ReadLine());
                if (minnum < maxnum)
                {
                    done = true;
                }
                else
                {
                    Console.WriteLine("invalid answer");
                }
            }
            done = false;
            while (!done)
            {

                if (guess > minnum && guess < maxnum)
                {
                    Console.WriteLine("good job not too impressive but still nice one ");
                }
                else
                {
                    Console.WriteLine("cmon you gave me the numbers ");
                }
            }
        }
        static void percent()
        {
            bool done = false;
            Console.WriteLine("part #2");

            int total;

            int Num1 = 0, Num2 = 0, Num3 = 0;
            Console.WriteLine("enter your first of 3 score's");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("what is your second number ");
            Num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("what is your third number ");
            Num3 = Convert.ToInt32(Console.ReadLine());


            total = Num1 * Num2 * Num3 / 3;

            while (!done)
            {
                if (total >= 70)
                {
                    done = true;
                    Console.ReadLine();

                }
                else
                {
                    Console.WriteLine(" your score isnt greater then 70% ");
                }





                Console.WriteLine("part three ");
                int i,oddsum,num = 0;

                Console.WriteLine("give me a number and i will add every odd number to it up until the number you gave me ");
                oddsum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("your odd numbers are ");
                for (i = 1; i <=oddsum; i++)
                {
                    Console.Write("0", 2 * 1 - 1);

                    num += 2 * i - 1;
                }
                Console.Write("the ammount based on your number is " , oddsum,num);
                Console.ReadLine();


                Console.WriteLine("part 4 ");
                int num1, num2;
                Console.WriteLine("you are going to give me two numbers and i am going to give you 25 random numbers in between");
                Console.WriteLine("Give me the first number to make the max for the game ");
                num1 = Convert.ToInt32(Console.ReadLine());

            }
        }
    }
}
