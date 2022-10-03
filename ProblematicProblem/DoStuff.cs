using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading;
namespace ProblematicProblem
{


    internal class DoStuff
    {
        static int age;
        static string name;
        static string cousinsBestfriendsGrandmasBingoclubpresidentsGrandsonsDogsChewToy;
        Random rng;
        static List<string> activities = new List<string>() { "Movies", "Paintball", "Bowling", "Lazer Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting" };
        
        public void ActGen()
        {

            Console.WriteLine("Would you like to generate a random activity? yes/no: ");
            string input = Console.ReadLine().ToLower();
            if (input == "yes")
            {
                GetInfo();
            }
            else if (input == "no")
            {
                EndProgram();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid input... Please try again!");
                Thread.Sleep(2000);
                Console.Clear();
                ActGen();
            }

            Console.Clear();

            Console.WriteLine("Wanna see all of the activities yes/no:");
            ShowActivities();


        }
        public void GetInfo()
        {

            Console.Clear();
            Console.WriteLine("Connecting to system...");
            Thread.Sleep(1000);


            Console.Write(". ");
            Thread.Sleep(500);
            Console.Write(". ");
            Thread.Sleep(500);
            Console.Write(". ");
            Thread.Sleep(500);
            Console.WriteLine(". ");
            Thread.Sleep(2000);
            Console.WriteLine();
            Console.Clear();

            Console.WriteLine("I want some information... All your information... ENDLESS INFORMATION... JUST GIVE IT ALL TO ME!!! ");
            Console.WriteLine();
            Thread.Sleep(2000);
            Console.WriteLine("How old are you: ");
            bool parse = int.TryParse(Console.ReadLine(), out int age);
            if (!parse)
            {
                Console.WriteLine("WOW...JUST..WOW...I CANT BELIEVE THAT YOU DIDINT GIVE ME YOUR INFORMATION! TRY AGAIN NOWWWWWWW!");
                Thread.Sleep(4000);
                GetInfo();
            }

            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("good...Good..GOOD! AWESOMEEE...MORE POWER..ER..I MEAN INFORMATION!! Now... WHATS YOUR FIRST NAME!");
            Console.WriteLine();

            name = Console.ReadLine();

            Thread.Sleep(1000);
            Console.Clear();

            Console.WriteLine("ALRIGHTTTTTTT!!!");
            Console.WriteLine();
            Console.WriteLine("Now...Last question! What is your cousin's best friend's grandma's bingo club president's grandson's dog's cousin's name?");

            cousinsBestfriendsGrandmasBingoclubpresidentsGrandsonsDogsChewToy = Console.ReadLine();

            Console.WriteLine("Thanks!");
            Thread.Sleep(2000);


        }
        public void ShowActivities()
        {
                

            string input = Console.ReadLine().ToLower();


            if (input == "yes")
            {
                for (int i = 0; i < activities.Count; i++)
                {
                    if (i == 0)
                    {
                        for (int k = 0; k < activities[i].Length; k++)
                        {
                            Thread.Sleep(75);
                            Console.Write(activities[i][k]);
                        }
                    }
                    else
                    {
                        Thread.Sleep(250);
                        Console.Write(", ");
                        for (int j = 0; j < activities[i].Length; j++)
                        {
                            Thread.Sleep(75);
                            Console.Write(activities[i][j]);
                        }
                    }
                }
                Thread.Sleep(5000);
            }
            else if (input == "no")
            {
                Console.WriteLine("Alright!");
                Thread.Sleep(1000);
            }
            else 
            {
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("Bruh please just enter in yes or no!");
                ShowActivities();
            }

            GenerateActivity();
        }
        public void GenerateActivity()
        {


            Console.Clear();
            Console.WriteLine("Wanna add something? | yes to add something... | no to generate a random activity! |");
            string input = Console.ReadLine();
            Thread.Sleep(1000);

            if (input == "yes")
            {
                Console.WriteLine("Here... What do you wanna add! ");
                string inputYes = Console.ReadLine();
                activities.Add(inputYes);
                Thread.Sleep(1000);
                GenerateActivity();

            }
            else if (input == "no")
            {
                Console.WriteLine("Alright!");
                Thread.Sleep(1000);
            }
            else
            {
                Console.WriteLine("Well try again...");
                Thread.Sleep(1000);
                GenerateActivity();
            }

            Thread.Sleep(1000);
            Console.Clear();


            Thread.Sleep(2000);
            Console.WriteLine("Here's all of the activities: ");
            Console.WriteLine();

            for (int i = 0; i < activities.Count; i++)
            {
                if (i == 0)
                {
                    for (int k = 0; k < activities[i].Length; k++)
                    {
                        Thread.Sleep(75);
                        Console.Write(activities[i][k]);
                    }
                }
                else
                {
                    Thread.Sleep(250);
                    Console.Write(", ");
                    for (int j = 0; j < activities[i].Length; j++)
                    {
                        Thread.Sleep(75);
                        Console.Write(activities[i][j]);
                    }
                }
            }

            Thread.Sleep(5000);
            Console.Clear();

            Console.WriteLine("Lets generate you an activity!");

            Thread.Sleep(1000);

            Console.WriteLine("3...");
            Thread.Sleep(1000);
            Console.WriteLine("2...");
            Thread.Sleep(1000);
            Console.WriteLine("1...");
            Thread.Sleep(1000);

            Console.Clear();


            Random rng = new Random();
            int arrayRand;
            int otherArrayRand = rng.Next(activities.Count);

            while (otherArrayRand == 7 && age < 21)
            {
                otherArrayRand = rng.Next(activities.Count);
            }

            arrayRand = otherArrayRand;


            Console.WriteLine($"HERE IT IS, {name}! {activities[arrayRand]}");

            Thread.Sleep(2000);
            ActGen();
        }
        public void EndProgram()
        {
            Console.WriteLine("BYE BYE I guess you are being mean and you dont want to participate in this program :(");
            Thread.Sleep(2000);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Environment.Exit(0);

        }
    }
}
