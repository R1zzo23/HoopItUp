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

        static public float ShotAttemptsGame = 0;
        static public float ShotMakesGame = 0;
        static public float DriveAttemptsGame = 0;
        static public float DriveMakesGame = 0;
        static public float PutbackAttemptsGame = 0;
        static public float PutbackMakesGame = 0;
        static public float TurnoversGame = 0;
        static public float StealsGame = 0;
        static public float DefensiveReboundsGame = 0;
        static public float OffensiveReboundsGame = 0;

        static public int ShotAttemptsCareer = 0;
        static public int ShotMakesCareer = 0;
        static public int DriveAttemptsCareer = 0;
        static public int DriveMakesCareer = 0;
        static public int PutbackAttemptsCareer = 0;
        static public int PutbackMakesCareer = 0;
        static public int TurnoversCareer = 0;
        static public int StealsCareer = 0;
        static public int DefensiveReboundsCareer = 0;
        static public int OffensiveReboundsCareer = 0;
        static public int TotalReboundsCareer = DefensiveReboundsCareer + OffensiveReboundsCareer;
        static public int TotalAttemptsCareer = ShotAttemptsCareer + DriveAttemptsCareer + PutbackAttemptsCareer;
        static public int TotalMakesCareer = ShotMakesCareer + DriveMakesCareer + PutbackMakesCareer;

        /*static public int ShortPercentageCareer = ShotMakesCareer / ShotAttemptsCareer;
        static public int DrivePercentageCareer = DriveMakesCareer / DriveAttemptsCareer;
        static public int PutbackPercentageCareer = PutbackMakesCareer / PutbackAttemptsCareer;
        static public int TotalAttemptsPercentageCareer = TotalMakesCareer / TotalAttemptsCareer;*/

        static public int CareerWins = 0;
        static public int CareerLosses = 0;
        static public int CareerGames = CareerWins + CareerLosses;

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

            Console.WriteLine();
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

            Console.WriteLine();
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

            Console.WriteLine();
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
            Console.WriteLine("start with 150 attribute points to spread out across six ");
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
                    Console.Clear();
                    Console.WriteLine("Shooting: {0}", shooting);
                    Console.WriteLine("Points Remaining: " + (150 - shooting));
                    Console.WriteLine();
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
                if ((shooting + drive) > 130)
                {
                    Console.WriteLine("You have used too many points. You won't be able");
                    Console.WriteLine("to reach the attribute minimum for all abilities.");
                    Console.WriteLine("Please start again.");
                    Console.ReadLine();
                    Console.Clear();
                    CreateShooting();
                }
                else if (drive >= 10 && drive <= 50)
                {
                    Console.Clear();
                    Console.WriteLine("Shooting: {0}", shooting);
                    Console.WriteLine("Driving: {0}", drive);
                    Console.WriteLine("Points Remaining: " + (150 - (shooting + drive)));
                    Console.WriteLine();
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
                if ((shooting + handle + drive) > 120)
                {
                    Console.WriteLine("You have used too many points. You won't be able");
                    Console.WriteLine("to reach the attribute minimum for all abilities.");
                    Console.WriteLine("Please start again.");
                    Console.ReadLine();
                    Console.Clear();
                    CreateShooting();
                }
                else if (handle >= 10 && handle <= 50)
                {
                    Console.Clear();
                    Console.WriteLine("Shooting: {0}", shooting);
                    Console.WriteLine("Driving: {0}", drive);
                    Console.WriteLine("Handle: {0}", handle);
                    Console.WriteLine("Points Remaining: " + (150 - (shooting + drive + handle)));
                    Console.WriteLine();
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
                if ((shooting + handle + drive + rebound) > 130)
                {
                    Console.WriteLine("You have used too many points. You won't be able");
                    Console.WriteLine("to reach the attribute minimum for all abilities.");
                    Console.WriteLine("Please start again.");
                    Console.ReadLine();
                    Console.Clear();
                    CreateShooting();
                }
                else if (rebound >= 10 && rebound <= 50)
                {
                    Console.Clear();
                    Console.WriteLine("Shooting: {0}", shooting);
                    Console.WriteLine("Driving: {0}", drive);
                    Console.WriteLine("Handle: {0}", handle);
                    Console.WriteLine("Rebound: {0}", rebound);
                    Console.WriteLine("Points Remaining: " + (150 - (shooting + drive + handle + rebound)));
                    Console.WriteLine();
                    CreateDefense();
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
                if ((shooting + handle + drive + rebound + defense) > 140)
                {
                    Console.WriteLine("You have used too many points. You won't be able");
                    Console.WriteLine("to reach the attribute minimum for all abilities.");
                    Console.WriteLine("Please start again.");
                    Console.ReadLine();
                    Console.Clear();
                    CreateShooting();
                }
                else if (defense >= 10 && defense <= 50)
                {
                    Console.Clear();
                    Console.WriteLine("Shooting: {0}", shooting);
                    Console.WriteLine("Driving: {0}", drive);
                    Console.WriteLine("Handle: {0}", handle);
                    Console.WriteLine("Rebound: {0}", rebound);
                    Console.WriteLine("Defense: {0}", defense);
                    Console.WriteLine("Points Remaining: " + (150 - (shooting + drive + handle + rebound + defense)));
                    Console.WriteLine();
                    CreateSteal();
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
                    if (steal <= (150 - (shooting + drive + handle + rebound + defense)))
                    {
                        Console.Clear();
                        Console.WriteLine("Shooting: {0}", shooting);
                        Console.WriteLine("Driving: {0}", drive);
                        Console.WriteLine("Handle: {0}", handle);
                        Console.WriteLine("Rebound: {0}", rebound);
                        Console.WriteLine("Defense: {0}", defense);
                        Console.WriteLine("Steal: {0}", steal);
                        Console.WriteLine("Points Remaining: " + (150 - (shooting + drive + handle + rebound + defense + steal)));
                        Console.WriteLine();

                        if (150 > (shooting + drive + handle + rebound + defense + steal))
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
                        Console.Write("Enter a number between 10 and " + (150 - (shooting + drive + handle + rebound + defense)) + ": ");
                        createSteal = Console.ReadLine();
                        steal = int.Parse(createSteal);
                    }
                }
                else
                {
                    Console.Write("Please enter a number between 10 and 50: ");
                    createSteal = Console.ReadLine();
                    steal = int.Parse(createSteal);
                }
            }
        }

        public static void AddExtraPoints()
        {
            int RemainingPoints = (150 - (shooting + drive + handle + rebound + defense + steal));

            Console.WriteLine("You have " + (150 - (shooting + drive + handle + rebound + defense + steal)) + " points left.");
            Console.WriteLine("Where do you want to add some extra points?");
            Console.WriteLine("1. Shooting (" + shooting + ")");
            Console.WriteLine("2. Drive (" + drive + ")");
            Console.WriteLine("3. Handle (" + handle + ")");
            Console.WriteLine("4. Rebound (" + rebound + ")");
            Console.WriteLine("5. Defense (" + defense + ")");
            Console.WriteLine("6. Steal (" + steal + ")");
            Console.Write("Enter the number to the corresponding skill you want to add points to: ");
            string ChooseExtra = Console.ReadLine();
            
            while (ChooseExtra.Length < 1)
            {
                Console.Write("Enter the number to the corresponding skill you want to add points to: ");
                ChooseExtra = Console.ReadLine();
            }

            int ExtraPoints = int.Parse(ChooseExtra);

            while (ExtraPoints < 1 || ExtraPoints > 5)
            {
                Console.Write("Enter a number between 1 & 5: ");
                ChooseExtra = Console.ReadLine();
                ExtraPoints = int.Parse(ChooseExtra);
            }

            if (ExtraPoints == 1)
            {
                Console.WriteLine("How many points do you want to add to shooting?");
                Console.Write("Enter a number between 0 and " + Math.Min(RemainingPoints, (50-shooting)) + ": ");
                string ExtraShooting = Console.ReadLine();
                int AddShooting = int.Parse(ExtraShooting);

                while (AddShooting < 0 || AddShooting > Math.Min(RemainingPoints, (50 - shooting)))
                {
                    Console.Write("Enter a number between 0 and " + Math.Min(RemainingPoints, (50 - shooting)) + ": ");
                    ExtraShooting = Console.ReadLine();
                    AddShooting = int.Parse(ExtraShooting);
                }

                shooting = shooting + AddShooting;
                RemainingPoints = (150 - (shooting + drive + handle + rebound + defense + steal));
                if (RemainingPoints == 0)
                {
                    DisplayMyOriginalStats();
                }
                else
                {
                    AddExtraPoints();
                }
            }
            else if (ExtraPoints == 2)
            {
                Console.WriteLine("How many points do you want to add to drive?");
                Console.Write("Enter a number between 0 and " + Math.Min(RemainingPoints, (50 - drive)) + ": ");
                string ExtraDrive = Console.ReadLine();
                int AddDrive = int.Parse(ExtraDrive);

                while (AddDrive < 0 || AddDrive > Math.Min(RemainingPoints, (50 - drive)))
                {
                    Console.Write("Enter a number between 0 and " + Math.Min(RemainingPoints, (50 - drive)) + ": ");
                    ExtraDrive = Console.ReadLine();
                    AddDrive = int.Parse(ExtraDrive);
                }

                drive = drive + AddDrive;
                RemainingPoints = (150 - (shooting + drive + handle + rebound + defense + steal));

                if (RemainingPoints == 0)
                {
                    DisplayMyOriginalStats();
                }
                else
                {
                    AddExtraPoints();
                }
            }
            else if (ExtraPoints == 3)
            {
                Console.WriteLine("How many points do you want to add to handle?");
                Console.Write("Enter a number between 0 and " + Math.Min(RemainingPoints, (50 - handle)) + ": ");
                string ExtraHandle = Console.ReadLine();
                int AddHandle = int.Parse(ExtraHandle);

                while (AddHandle < 0 || AddHandle > Math.Min(RemainingPoints, (50 - handle)))
                {
                    Console.Write("Enter a number between 0 and " + Math.Min(RemainingPoints, (50 - handle)) + ": ");
                    ExtraHandle = Console.ReadLine();
                    AddHandle = int.Parse(ExtraHandle);
                }

                handle = handle + AddHandle;
                RemainingPoints = (150 - (shooting + drive + handle + rebound + defense + steal));

                if (RemainingPoints == 0)
                {
                    DisplayMyOriginalStats();
                }
                else
                {
                    AddExtraPoints();
                }
            }
            else if (ExtraPoints == 4)
            {
                Console.WriteLine("How many points do you want to add  to rebound?");
                Console.Write("Enter a number between 0 and " + Math.Min(RemainingPoints, (50 - rebound)) + ": ");
                string ExtraRebound = Console.ReadLine();
                int AddRebound = int.Parse(ExtraRebound);

                while (AddRebound < 0 || AddRebound > Math.Min(RemainingPoints, (50 - rebound)))
                {
                    Console.Write("Enter a number between 0 and " + Math.Min(RemainingPoints, (50 - rebound)) + ": ");
                    ExtraRebound = Console.ReadLine();
                    AddRebound = int.Parse(ExtraRebound);
                }

                rebound = rebound + AddRebound;
                RemainingPoints = (150 - (shooting + drive + handle + rebound + defense + steal));

                if (RemainingPoints == 0)
                {
                    DisplayMyOriginalStats();
                }
                else
                {
                    AddExtraPoints();
                }
            }
            else if (ExtraPoints == 5)
            {
                Console.WriteLine("How many points do you want to add to defense?");
                Console.Write("Enter a number between 0 and " + Math.Min(RemainingPoints, (50 - defense)) + ": ");
                string ExtraDefense = Console.ReadLine();
                int AddDefense = int.Parse(ExtraDefense);

                while (AddDefense < 0 || AddDefense > Math.Min(RemainingPoints, (50-defense)))
                {
                    Console.Write("Enter a number between 0 and " + Math.Min(RemainingPoints, (50 - defense)) + ": ");
                    ExtraDefense = Console.ReadLine();
                    AddDefense = int.Parse(ExtraDefense);
                }

                defense = defense + AddDefense;
                RemainingPoints = (150 - (shooting + drive + handle + rebound + defense + steal));

                if (RemainingPoints == 0)
                {
                    DisplayMyOriginalStats();
                }
                else
                {
                    AddExtraPoints();
                }
            }
            else
            {
                Console.WriteLine("How many points do you want to add to steal?");
                Console.Write("Enter a number between 0 and " + Math.Min(RemainingPoints, (50 - steal)) + ": ");
                string ExtraSteal = Console.ReadLine();
                int AddSteal = int.Parse(ExtraSteal);

                while (AddSteal < 0 || AddSteal > Math.Min(RemainingPoints, (50 - steal)))
                {
                    Console.Write("Enter a number between 0 and " + Math.Min(RemainingPoints, (50 - steal)) + ": ");
                    ExtraSteal = Console.ReadLine();
                    AddSteal = int.Parse(ExtraSteal);
                }

                steal = steal + AddSteal;
                RemainingPoints = (200 - (shooting + drive + handle + rebound + defense + steal));

                if (RemainingPoints == 0)
                {
                    DisplayMyOriginalStats();
                }
                else
                {
                    AddExtraPoints();
                }
            }
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

            Opponent.CreateFirstOpponent();
        }

        public static void DisplayGameStats()
        {
            float ShotPercentageGame;
            float DrivePercentageGame;
            float PutbackPercentageGame;
            float TotalAttemptsPercentageGame;
            float TotalReboundsGame = OffensiveReboundsGame + DefensiveReboundsGame;
            float TotalAttemptsGame = ShotAttemptsGame + DriveAttemptsGame + PutbackAttemptsGame;
            float TotalMakesGame = ShotMakesGame + DriveMakesGame + PutbackMakesGame;

            if (ShotAttemptsGame == 0)
            {
                ShotPercentageGame = 0;
            }
            else
            {
                ShotPercentageGame = (ShotMakesGame / ShotAttemptsGame);
            }

            if (DriveAttemptsGame == 0)
            {
                DrivePercentageGame = 0;
            }
            else
            {
                DrivePercentageGame = (DriveMakesGame / DriveAttemptsGame);
            }

            if (PutbackAttemptsGame == 0)
            {
                PutbackPercentageGame = 0;
            }
            else
            {
                PutbackPercentageGame = (PutbackMakesGame / PutbackAttemptsGame);
            }
            
            TotalAttemptsPercentageGame = (TotalMakesGame / TotalAttemptsGame);
            

            Console.WriteLine("Let's take a look at your stats from this past game.");
            Console.ReadLine();
            Console.WriteLine("Jumpshots Made: {0}", ShotMakesGame);
            Console.WriteLine("Jumpshots Attempted: {0}", ShotAttemptsGame);
            Console.WriteLine("Jumpshot Percentage: {0}%", (ShotPercentageGame * 100));
            Console.WriteLine();
            Console.WriteLine("Drives Finished: {0}", DriveMakesGame);
            Console.WriteLine("Drives Attempted: {0}", DriveAttemptsGame);
            Console.WriteLine("Drive Percentage: {0}%", (DrivePercentageGame * 100));
            Console.WriteLine();
            Console.WriteLine("Putback Makes: {0}", PutbackMakesGame);
            Console.WriteLine("Putback Attempts: {0}", PutbackAttemptsGame);
            Console.WriteLine("Putback Percentage: {0}%", (PutbackPercentageGame * 100));
            Console.WriteLine();
            Console.WriteLine("Total Shot Makes: {0}", TotalMakesGame);
            Console.WriteLine("Total Shot Attempts: {0}", TotalAttemptsGame);
            Console.WriteLine("Total Shot Percentage: {0}%", (TotalAttemptsPercentageGame * 100));
            Console.WriteLine();
            Console.WriteLine("Offensive Rebounds: {0}", OffensiveReboundsGame);
            Console.WriteLine("Defensive Rebounds: {0}", DefensiveReboundsGame);
            Console.WriteLine("Total Rebounds: {0}", TotalReboundsGame);
            Console.WriteLine();
            Console.WriteLine("Steals: {0}", StealsGame);
            Console.WriteLine("Turnovers: {0}", TurnoversGame);
            Console.ReadLine();
        }
    }
}
