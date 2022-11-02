using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
            {
                diceGame();
            }
        }

        static void MinMax()
        {
            int maxnum = 0, minnum = 0;
            int guess = 0;

            bool done = false;
            while (!done)
            {
                Console.WriteLine("Part 1");
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
                int i, oddsum, num = 0;

                Console.WriteLine("give me a number and i will add every odd number to it up until the number you gave me ");
                oddsum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("your odd numbers are ");
                for (i = 1; i <= oddsum; i++)
                {
                    Console.Write("0", 2 * 1 - 1);

                    num += 2 * i - 1;
                }
                Console.Write("the ammount based on your number is ", oddsum, num);
                Console.ReadLine();
            }
        }
        static void ranNum()
        {
            Console.WriteLine("part 4 ");
            int num1, num2;
            Console.WriteLine("you are going to give me two numbers and i am going to give you 25 random numbers in between");
            Console.WriteLine("Give me the first number to make the max for the game ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Give me the second number to make your minimum ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Random generator = new Random();
            for (int i = 0; i < 25; i++)
            {
                generator.Next(num2, num1);
            }

        }
        static void diceGame()
        {

            Console.WriteLine("Part 5 ");
            double bet = 0, roll, roll2;
            double currency = 100;
            string guess;
            Random generator = new Random();
            bool done = false;


            
            while (currency > 0)
            {

                Console.WriteLine($"Place a bet of no more then {currency}$ ");
                bet = Int32.Parse(Console.ReadLine());
                Console.WriteLine("option # 1 is if both dice are the same then your bet doubles ");
                Console.WriteLine("option # 2 is if its not a double and if you guess that you win half your bet ");
                Console.WriteLine("option # 3 is if both the dice rolled add up to a even number you win your bet back ");
                Console.WriteLine("option # 4 is if both the dice rolled add up to a uneven number you win and get your bet back ");
                roll = generator.Next(1, 7);
                roll2 = generator.Next(1, 7);
                guess = Console.ReadLine();
                currency -= bet;
                double totalroll = roll + roll2;

                if (bet > currency)
                {
                    Console.WriteLine("no the bet must be less then 100 ");
                    bet = 0;
                }
                if (guess == "1")
                {
                    if (roll == roll2)
                    {
                        bet *= 2;
                        Console.WriteLine(" Good guess you won double your bet the dice were " + totalroll);
                        currency += bet;
                        Console.WriteLine(currency);
                    }
                    else
                    {
                        currency -= bet;
                        Console.WriteLine("unfourtunate the dice were " + totalroll);
                        Console.WriteLine(currency);
                    }
                }
                if (guess == "2")
                {
                    if (roll != roll2)
                    {
                        bet /= 2;
                        Console.WriteLine(" Good guess but you only get half the bet back " + totalroll);
                        currency += bet;
                        Console.WriteLine(currency);
                    }
                    else
                    {
                        currency -= bet;
                        Console.WriteLine("good try but the cards were the same the dice rolled cause the dice added to  " + totalroll);

                    }
                }
                if (guess == "3")
                {
                    if (totalroll == 2 || totalroll == 4 || totalroll == 6 || totalroll == 8 || totalroll == 10 || totalroll == 12)
                    {
                        Console.WriteLine(" Nice guess you get your bet becasue the dice rolled " + totalroll);
                        currency += bet;
                        Console.WriteLine(totalroll);
                        Console.WriteLine(currency);
                    }
                    else
                    {
                        currency -= bet;
                        Console.WriteLine(" Tuff luck u lose your bet the dice rolled " + totalroll);
                    }
                }
                if (guess == "4")
                {
                    if (totalroll == 1 || totalroll == 3 || totalroll == 5 || totalroll == 7 || totalroll == 9 || totalroll == 11)
                    {
                        currency += bet;
                        Console.WriteLine("Congrats you won your bet the dice rolled " + totalroll);
                        Console.WriteLine(currency);
                    }
                    else
                    {
                        currency -= bet;
                        Console.WriteLine("nicee try better luck next time the dice rolled " + totalroll);
                        Console.WriteLine(currency);
                    }

                }
            }

        }
        }
    }

