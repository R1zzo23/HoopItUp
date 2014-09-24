using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HoopItUp
{
    class MyPlayer
    {
        static public int Level = 1;

        static public int Feet;
        static public int Inches;
        static public int Height;
        static public int Weight;
        static public string FirstName;
        static public string LastName;
        static public string FullName;

        static public int shooting;
        static public int handle;
        static public int drive;
        static public int rebound;
        static public int defense;
        static public int steal;

        public static void CreateName()
        {
            Console.WriteLine("What is the name the fans of RHS will know you by?");
            Console.Write("Enter your first name: ");
            FirstName = Console.ReadLine();

            while (FirstName.Length < 1)
            {
                Console.Write("Please enter a valid name: ");
                FirstName = Console.ReadLine();
            }

            Console.Write("Enter your last name: ");
            LastName = Console.ReadLine();

            while (LastName.Length < 1)
            {
                Console.Write("Please enter a valid name: ");
                LastName = Console.ReadLine();
            }

            FullName = (FirstName + " " + LastName);

            Console.WriteLine("Your name is {0}.", FullName);
            Console.Write("Is this correct? Y/N: ");
            string CorrectName = Console.ReadLine();

            while (true)
            {
                if (CorrectName == "Y" || CorrectName == "y")
                {
                    Console.Clear();
                    CreateHeight();
                }
                else if (CorrectName == "N" || CorrectName == "n")
                {
                    CreateName();
                }
                else
                {
                    Console.Write("Enter either Y or N: ");
                    CorrectName = Console.ReadLine();
                }
            }
        
        }

        public static void CreateHeight()
        {
            string FeetTall;
            string InchesTall;

            Console.WriteLine("I can't get a good read on your height so help me out.");
            Console.Write("Enter height in feet: ");
            FeetTall = Console.ReadLine();

            while (FeetTall.Length < 1)
            {
                Console.Write("Please enter a valid number: ");
                FeetTall = Console.ReadLine();
            }

            Feet = int.Parse(FeetTall);
            while (Feet < 4 || Feet > 7)
            {
                Console.WriteLine("Nobody that tall is playing ball down here.");
                Console.Write("Enter a height, in feet, between 4 and 7: ");
                FeetTall = Console.ReadLine();
                Feet = int.Parse(FeetTall);
            }

            Console.Write("Enter height in inches: ");
            InchesTall = Console.ReadLine();

            while (InchesTall.Length < 1)
            {
                Console.Write("Please enter a valid number: ");
                InchesTall = Console.ReadLine();
            }

            Inches = int.Parse(InchesTall);
            while (Inches < 0 || Inches > 12)
            {
                Console.WriteLine("Something tells me you won't have the grades to play for this team.");
                Console.WriteLine("Let's try this again, shall we?");
                Console.Write("Enter a number between 0 and 12: ");
                InchesTall = Console.ReadLine();
                Inches = int.Parse(InchesTall);
            }

            Height = (Feet * 12) + Inches;

            Console.WriteLine("Your height is {0}'{1}\".", Feet, Inches);
            Console.Write("Is this correct? Y/N: ");
            string CorrectHeight = Console.ReadLine();

            while (true)
            {
                if (CorrectHeight == "Y" || CorrectHeight == "y")
                {
                    Console.Clear();
                    CreateWeight();
                }
                else if (CorrectHeight == "N" || CorrectHeight == "n")
                {
                    CreateHeight();
                }
                else
                {
                    Console.Write("Enter either Y or N: ");
                    CorrectHeight = Console.ReadLine();
                }
            }
            
        }

        public static void CreateWeight()
        {
            Console.WriteLine("I know how tall you are, but now I need to know what you weigh.");
            Console.Write("Enter your weight (in pounds): ");
            string MyWeight = Console.ReadLine();
            while (MyWeight.Length < 1)
            {
                Console.Write("Please enter a valid number: ");
                MyWeight = Console.ReadLine();
            }

            Weight = int.Parse(MyWeight);

            while (Weight < 100 || Weight > 250)
            {
                Console.WriteLine("You can't play at that weight. Try again.");
                Console.Write("Enter a number between 100 & 250: ");
                MyWeight = Console.ReadLine();
                Weight = int.Parse(MyWeight);
            }

            Console.WriteLine("Your weight is {0}.", Weight);
            Console.Write("Is this correct? Y/N: ");
            string CorrectWeight = Console.ReadLine();

            while (true)
            {
                if (CorrectWeight == "Y" || CorrectWeight == "y")
                {
                    Console.Clear();
                    GiveAttributes();
                }
                else if (CorrectWeight == "N" || CorrectWeight == "n")
                {
                    CreateWeight();
                }
                else
                {
                    Console.Write("Enter either Y or N: ");
                    CorrectWeight = Console.ReadLine();
                }
            }
        }

        public static void GiveAttributes()
        {
            Console.WriteLine("HELP - It's time to select your attributes on the court. You");
            Console.WriteLine("start with 200 attribute points to spread out across six ");
            Console.WriteLine("different skills. The skills are shooting, handles, driving, ");
            Console.WriteLine("rebounding, defense and steals.");
            Console.ReadLine();
            Console.WriteLine("You get a chance to customize these abilities to your liking.");
            Console.WriteLine("There are minimums and maximums to start. The lowest any one ");
            Console.WriteLine("skill can be is 10 and the highest is 50. Let's get started!");
            Console.ReadLine();
            Console.Clear();
            CreateShooting();
        }

        public static void CreateShooting()
        {
            Console.Write("Enter your shooting ability: ");
            string createShooting = Console.ReadLine();

            while (createShooting.Length < 1)
            {
                Console.Write("Please enter a valid number: ");
                createShooting = Console.ReadLine();
            }

            shooting = int.Parse(createShooting);

            while (true)
            {
                if (shooting >= 10 && shooting <= 50)
                {
                    Console.WriteLine("Shooting: {0}", shooting);
                    Console.WriteLine("Points Remaining: " + (200 - shooting));
                    Console.ReadLine();
                    CreateDrive();
                }
                else
                {
                    Console.Write("Please enter a number between 10 and 50: ");
                    createShooting = Console.ReadLine();
                    shooting = int.Parse(createShooting);
                }
            }
        }

        public static void CreateDrive()
        {
            Console.Write("Enter your driving ability: ");
            string createDrive = Console.ReadLine();

            while (createDrive.Length < 1)
            {
                Console.Write("Please enter a valid number: ");
                createDrive = Console.ReadLine();
            }

            drive = int.Parse(createDrive);

            while (true)
            {
                if (drive >= 10 && drive <= 50)
                {
                    Console.WriteLine("Shooting: {0}", shooting);
                    Console.WriteLine("Driving: {0}", drive);
                    Console.WriteLine("Points Remaining: " + (200 - (shooting + drive)));
                    Console.ReadLine();
                    CreateHandle();
                }
                else
                {
                    Console.Write("Please enter a number between 10 and 50: ");
                    createDrive = Console.ReadLine();
                    drive = int.Parse(createDrive);
                }
            }
        }

        public static void CreateHandle()
        {
            Console.Write("Enter your handle ability: ");
            string createHandle = Console.ReadLine();

            while (createHandle.Length < 1)
            {
                Console.Write("Please enter a valid number: ");
                createHandle = Console.ReadLine();
            }

            handle = int.Parse(createHandle);

            while (true)
            {
                if (shooting >= 10 && shooting <= 50)
                {
                    Console.WriteLine("Shooting: {0}", shooting);
                    Console.WriteLine("Driving: {0}", drive);
                    Console.WriteLine("Handle: {0}", handle);
                    Console.WriteLine("Points Remaining: " + (200 - (shooting + drive + handle)));
                    Console.ReadLine();
                    CreateRebound();
                }
                else
                {
                    Console.Write("Please enter a number between 10 and 50: ");
                    createHandle = Console.ReadLine();
                    handle = int.Parse(createHandle);
                }
            }
        }

        public static void CreateRebound()
        {
            Console.Write("Enter your rebound ability: ");
            string createRebound = Console.ReadLine();

            while (createRebound.Length < 1)
            {
                Console.Write("Please enter a valid number: ");
                createRebound = Console.ReadLine();
            }

            rebound = int.Parse(createRebound);

            while (true)
            {
                if (rebound >= 10 && rebound <= 50)
                {
                    Console.WriteLine("Shooting: {0}", shooting);
                    Console.WriteLine("Driving: {0}", drive);
                    Console.WriteLine("Handle: {0}", handle);
                    Console.WriteLine("Rebound: {0}", rebound);
                    Console.WriteLine("Points Remaining: " + (200 - (shooting + drive + handle + rebound)));
                    Console.ReadLine();
                    CreateDefense();
                }
                else if ((shooting + handle + drive + rebound) > 180)
                {
                    Console.WriteLine("You have used too many points. Please start again.");
                    Console.ReadLine();
                    CreateShooting();
                }
                else
                {
                    Console.Write("Please enter a number between 10 and 50: ");
                    createRebound = Console.ReadLine();
                    rebound = int.Parse(createRebound);
                }
            }
        }

        public static void CreateDefense()
        {
            Console.Write("Enter your defensive ability: ");
            string createDefense = Console.ReadLine();

            while (createDefense.Length < 1)
            {
                Console.Write("Please enter a valid number: ");
                createDefense = Console.ReadLine();
            }

            defense = int.Parse(createDefense);

            while (true)
            {
                if (defense >= 10 && defense <= 50)
                {
                    Console.WriteLine("Shooting: {0}", shooting);
                    Console.WriteLine("Driving: {0}", drive);
                    Console.WriteLine("Handle: {0}", handle);
                    Console.WriteLine("Rebound: {0}", rebound);
                    Console.WriteLine("Defense: {0}", defense);
                    Console.WriteLine("Points Remaining: " + (200 - (shooting + drive + handle + rebound + defense)));
                    Console.ReadLine();
                    CreateSteal();
                }
                else if ((shooting + handle + drive + rebound + defense) > 190)
                {
                    Console.WriteLine("You have used too many points. Please start again.");
                    Console.ReadLine();
                    CreateShooting();
                }
                else
                {
                    Console.Write("Please enter a number between 10 and 50: ");
                    createDefense = Console.ReadLine();
                    defense = int.Parse(createDefense);
                }
            }
        }

        public static void CreateSteal()
        {
            Console.Write("Enter your stealing ability: ");
            string createSteal = Console.ReadLine();

            while (createSteal.Length < 1)
            {
                Console.Write("Please enter a valid number: ");
                createSteal = Console.ReadLine();
            }

            steal = int.Parse(createSteal);

            while (true)
            {
                if (steal >= 10 && steal <= 50 )
                {
                    if (steal <= (200 - (shooting + drive + handle + rebound + defense)))
                    {
                        Console.WriteLine("Shooting: {0}", shooting);
                        Console.WriteLine("Driving: {0}", drive);
                        Console.WriteLine("Handle: {0}", handle);
                        Console.WriteLine("Rebound: {0}", rebound);
                        Console.WriteLine("Defense: {0}", defense);
                        Console.WriteLine("Steal: {0}", steal);
                        Console.WriteLine("Points Remaining: " + (200 - (shooting + drive + handle + rebound + defense + steal)));
                        Console.ReadLine();

                        if (200 > (shooting + drive + handle + rebound + defense + steal))
                        {
                            AddExtraPoints();
                        }
                        else
                        {
                            DisplayMyOriginalStats();
                        }
                    }
                    else
                    {
                        Console.WriteLine("You have exceeded the maximum points allowed.");
                        Console.ReadLine();
                        Console.Write("Enter a number between 10 and " + (200 - (shooting + drive + handle + rebound + defense)) + ": ");
                        createSteal = Console.ReadLine();
                        steal = int.Parse(createSteal);
                    }
                }
                else
                {
                    Console.Write("Please enter a number between 10 and 70: ");
                    createSteal = Console.ReadLine();
                    steal = int.Parse(createSteal);
                }
            }
        }

        public static void AddExtraPoints()
        {
            Console.WriteLine("you have " + (200 - (shooting + drive + handle + rebound + defense + steal)) + " points left.");
            Console.ReadLine();
            Console.WriteLine("They will be evenly distributed to all of your attributes.");
            Console.ReadLine();
            int PointDifference = ((200 - (shooting + drive + handle + rebound + defense + steal)) / 6);
            shooting = shooting + PointDifference;
            drive = drive + PointDifference;
            handle = handle + PointDifference;
            rebound = rebound + PointDifference;
            defense = defense + PointDifference;
            steal = steal + PointDifference;
            DisplayMyOriginalStats();
        }

        public static void DisplayMyOriginalStats()
        {
            Console.Clear();
            Console.WriteLine("Here are your starting attributes:");
            Console.WriteLine("Name: {0}", FullName);
            Console.WriteLine("Height: {0}'{1}\"", Feet, Inches);
            Console.WriteLine("Weight: {0}", Weight);
            Console.WriteLine("Level: {0}", Level);
            Console.WriteLine("Shooting: {0}", shooting);
            Console.WriteLine("Driving: {0}", drive);
            Console.WriteLine("Handles: {0}", handle);
            Console.WriteLine("Rebound: {0}", rebound);
            Console.WriteLine("Defense: {0}", defense);
            Console.WriteLine("Steal: {0}", steal);
            Console.ReadLine();
        }
    }
}
