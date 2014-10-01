using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HoopItUp
{
    class Game
    {
        static public int MyScore = 0;
        static public int OpponentScore = 0;

        static public int MyShotDifference = (MyPlayer.Height + MyPlayer.shooting) - (Opponent.height + Opponent.defense);
        static public int MyDriveDifference = (MyPlayer.drive + MyPlayer.handle) - (Opponent.defense + Opponent.steal);
        static public int MyDribbleMoveDifference = (MyPlayer.handle + ((MyPlayer.Weight - Opponent.weight) / 2)) - (Opponent.steal);
        static public int MyReboundDifference = (MyPlayer.Height + MyPlayer.rebound) - (Opponent.height + (Opponent.rebound / 2));
        static public int MyPutbackDifference = ((MyPlayer.Height - Opponent.height) * 2) + ((MyPlayer.Weight - Opponent.weight) / 10);

        static public int OpponentShotDifference = (Opponent.height + Opponent.shooting) - (MyPlayer.Height + MyPlayer.defense);
        static public int OpponentDriveDifference = (Opponent.drive + Opponent.handle) - (MyPlayer.defense + MyPlayer.steal);
        static public int OpponentDribbleMoveDifference = (Opponent.handle + ((Opponent.weight - MyPlayer.Weight) / 2)) - (MyPlayer.steal);
        static public int OpponentReboundDifference = (Opponent.height + Opponent.rebound) - (MyPlayer.Height + (MyPlayer.rebound / 2));
        static public int OpponentPutbackDifference = ((Opponent.height - MyPlayer.Height) * 2) + ((Opponent.weight - MyPlayer.Weight) / 10);

        static public void StartGame()
        {
            while (MyPlayer.CareerGames == 0)
            {
                string Intro;

                Console.Write("Do you need an intro on how to play? (Y/N)");
                Intro = Console.ReadLine();

                while (true)
                {
                    if (Intro == "Y" || Intro == "y")
                    {
                        Console.WriteLine("Here's a quick rundown of the game.");
                        Console.ReadLine();
                        Console.WriteLine("You can either shoot, drive or attempt a dribble move.");
                        Console.WriteLine("If you shoot, success is based on your shooting ability and height");
                        Console.WriteLine("as well as your oponent's defense and height. Pick your spots!");
                        Console.ReadLine();
                        Console.WriteLine("When you drive, you better have handles to go with it.");
                        Console.WriteLine("Be careful if your opponent has good defense and steal ability.");
                        Console.ReadLine();
                        Console.WriteLine("If you attempt a dribble move and succeed, it gives you a ");
                        Console.WriteLine("much better chance at sinking a jumper or finishing at the rim.");
                        Console.WriteLine("This is based off your handles versus his steals. If the move is ");
                        Console.WriteLine("unsuccessfull then it will lead to a turnover. High risk, high reward!");
                        Console.ReadLine();
                        Console.WriteLine("The game is up to 7, straight up.");
                        Console.ReadLine();
                        Console.Clear();
                        WhoStarts();
                    }
                    else if (Intro == "N" || Intro == "n")
                    {
                        Console.WriteLine("Alright then, time to ball up!");
                        Console.ReadLine();
                        Console.Clear();
                        WhoStarts();
                    }
                    else
                    {
                        Console.Write("Enter either Y/y or N/n: ");
                        Intro = Console.ReadLine();
                    }
                }
            }

            Console.Clear();
            WhoStarts();
        }

        static public void WhoStarts()
        {

            Random whoShoots = new Random();
            int ShootForBall = whoShoots.Next(1, 3);

            if (ShootForBall == 1)
            {
                Console.WriteLine("You get to shoot for ball.");
                Console.WriteLine("Press enter to shoot.");
                Console.ReadLine();

                Random rnd = new Random();
                int iShootForBall = rnd.Next(1, 101);

                if (iShootForBall <= (MyPlayer.shooting + 10))
                {
                    Console.WriteLine("You step up to the line and knock it down. Your ball to start.");
                    Console.ReadLine();
                    Console.Clear();
                    MyBall();
                }
                else
                {
                    Console.WriteLine("The shot is up and...no goood. It's going to be {0}'s ball to start.", Opponent.LastName);
                    Console.ReadLine();
                    Console.Clear();
                    OpponentBall();
                }
            }
            else
            {
                Console.WriteLine("{0} will shoot for it.", Opponent.FirstName);
                Console.ReadLine();

                Random rnd = new Random();
                int oShootForBall = rnd.Next(1, 101);

                if (oShootForBall <= (Opponent.shooting + 10))
                {
                    Console.WriteLine("{0} takes it and makes it. His ball to start.", Opponent.FullName);
                    Console.ReadLine();
                    Console.Clear();
                    OpponentBall();
                }
                else
                {
                    Console.WriteLine("{0} misses the do-or-die. Ball goes to {1}.", Opponent.LastName, MyPlayer.LastName);
                    Console.ReadLine();
                    Console.Clear();
                    MyBall();
                }
            }
        }

        static public void MyBall()
        {
            string MyDecision;
            int MyChoice;

            Console.WriteLine("Your ball, what will you do?");
            Console.WriteLine("1. Shoot \n2. Drive \n3. Dribble Move");
            MyDecision = Console.ReadLine();

            while (MyDecision.Length < 1)
            {
                Console.Write("Please enter a valid number: ");
                MyDecision = Console.ReadLine();
            }

            MyChoice = int.Parse(MyDecision);

            while (true)
            {
                if (MyChoice == 1)
                {
                    int MyShotSuccess;

                    Console.WriteLine("Rises up over {0}...", Opponent.LastName);
                    Console.ReadLine();
                    Random rnd = new Random();
                    MyShotSuccess = rnd.Next(1, 101);

                    if (MyShotSuccess <= (38 + MyShotDifference))
                    {
                        MyPlayer.ShotMakesCareer++;
                        MyPlayer.ShotMakesGame++;
                        MyPlayer.ShotAttemptsGame++;
                        MyPlayer.ShotAttemptsCareer++;
                        Commentary.iMadeShot();
                        Console.ReadLine();
                        MyScore++;
                        Console.WriteLine("Score: {0} - {1}, {2} - {3}", MyPlayer.FullName, MyScore, Opponent.FullName, OpponentScore);
                        Console.WriteLine();
                        Console.ReadLine();

                        if (MyScore == 7)
                        {
                            iWin();
                        }
                        else
                        {
                            OpponentBall();
                        }
                    }
                    else
                    {
                        MyPlayer.ShotAttemptsGame++;
                        MyPlayer.ShotAttemptsCareer++;
                        Commentary.iMissedShot();
                        Console.ReadLine();
                        ReboundMyMiss();
                    }
                }
                else if (MyChoice == 2)
                {
                    int MyDriveSuccess;

                    Console.WriteLine("{0} takes it to the rack...", MyPlayer.LastName);
                    Console.ReadLine();
                    Random rnd = new Random();
                    MyDriveSuccess = rnd.Next(1, 101);

                    if (MyDriveSuccess <= (43 + MyDriveDifference))
                    {
                        MyPlayer.DriveAttemptsCareer++;
                        MyPlayer.DriveAttemptsGame++;
                        MyPlayer.DriveMakesCareer++;
                        MyPlayer.DriveMakesGame++;
                        Commentary.iMadeDrive();
                        Console.ReadLine();
                        MyScore++;
                        Console.WriteLine("Score: {0} - {1}, {2} - {3}", MyPlayer.FullName, MyScore, Opponent.FullName, OpponentScore);
                        Console.WriteLine();
                        Console.ReadLine(); 
                        if (MyScore == 7)
                        {
                            iWin();
                        }
                        else
                        {
                            OpponentBall();
                        }
                    }
                    else
                    {
                        MyPlayer.DriveAttemptsCareer++;
                        MyPlayer.DriveAttemptsGame++;
                        Commentary.iMissedDrive();
                        Console.ReadLine();
                        ReboundMyMiss();
                    }
                }
                else if (MyChoice == 3)
                {
                    int MyDribbleMoveSuccess;

                    Console.WriteLine("{0} looks to create some space with a dribble move...", MyPlayer.FirstName);
                    Console.ReadLine();
                    Random rnd = new Random();
                    MyDribbleMoveSuccess = rnd.Next(1, 101);

                    if (MyDribbleMoveSuccess <= (15 + MyDriveDifference))
                    {
                        Console.WriteLine("{0} breaks {1} with a sweet move to clear some space...", MyPlayer.LastName, Opponent.LastName);
                        Console.WriteLine("He's got options now...");
                        Console.ReadLine();
                        Console.WriteLine("1. Shoot \n2. Drive");
                        MyDecision = Console.ReadLine();

                        while (MyDecision.Length < 1)
                        {
                            Console.Write("Please enter either 1 or 2: ");
                            MyDecision = Console.ReadLine();
                        }

                        MyChoice = int.Parse(MyDecision);

                        while (true)
                        {
                            if (MyChoice == 1)
                            {
                                int MyShotSuccess;

                                Console.WriteLine("{0} rises up for an open jumper...", MyPlayer.FirstName);
                                Console.ReadLine();

                                Random rndShot = new Random();
                                MyShotSuccess = rndShot.Next(1, 101);

                                if (MyShotSuccess <= (48 + MyShotDifference))
                                {
                                    MyPlayer.ShotAttemptsCareer++;
                                    MyPlayer.ShotAttemptsGame++;
                                    MyPlayer.ShotMakesCareer++;
                                    MyPlayer.ShotMakesGame++;
                                    Commentary.iMadeShot();
                                    Console.ReadLine();
                                    MyScore++;
                                    Console.WriteLine("Score: {0} - {1}, {2} - {3}", MyPlayer.FullName, MyScore, Opponent.FullName, OpponentScore);
                                    Console.WriteLine();
                                    Console.ReadLine(); 
                                    if (MyScore == 7)
                                    {
                                        iWin();
                                    }
                                    else
                                    {
                                        OpponentBall();
                                    }
                                }
                                else
                                {
                                    MyPlayer.ShotAttemptsGame++;
                                    MyPlayer.ShotAttemptsCareer++;
                                    Commentary.iMissedShot();
                                    Console.ReadLine();
                                    ReboundMyMiss();
                                }
                            }
                            else if (MyChoice == 2)
                            {
                                int MyDriveSuccess;

                                Console.WriteLine("{0} takes it to the rack with a step on {1}...", MyPlayer.LastName, Opponent.LastName);
                                Console.ReadLine();
                                Random rndDrive = new Random();
                                MyDriveSuccess = rndDrive.Next(1, 101);

                                if (MyDriveSuccess <= (60 + MyDriveDifference))
                                {
                                    MyPlayer.DriveAttemptsCareer++;
                                    MyPlayer.DriveAttemptsGame++;
                                    MyPlayer.DriveMakesCareer++;
                                    MyPlayer.DriveMakesGame++;
                                    Commentary.iMadeDrive();
                                    Console.ReadLine();
                                    MyScore++;
                                    Console.WriteLine("Score: {0} - {1}, {2} - {3}", MyPlayer.FullName, MyScore, Opponent.FullName, OpponentScore);
                                    Console.WriteLine();
                                    Console.ReadLine(); 
                                    if (MyScore == 7)
                                    {
                                        iWin();
                                    }
                                    else
                                    {
                                        OpponentBall();
                                    }
                                }
                                else
                                {
                                    MyPlayer.DriveAttemptsCareer++;
                                    MyPlayer.DriveAttemptsGame++;
                                    Commentary.iMissedDrive();
                                    Console.ReadLine();
                                    ReboundMyMiss();
                                }
                            }
                            else
                            {
                                Console.Write("Enter either 1 or 2: ");
                                MyDecision = Console.ReadLine();
                                MyChoice = int.Parse(MyDecision);
                            }
                        }
                    }
                    else if (MyDribbleMoveSuccess >= (15 + MyDribbleMoveDifference) && MyDribbleMoveSuccess <= 80)
                    {
                        Console.WriteLine("That's some good defense by {0}. Now {1} is going to have to force...", Opponent.FirstName, MyPlayer.LastName);
                        Console.WriteLine("1. a shot \n2. a drive");
                        MyDecision = Console.ReadLine();

                        while (MyDecision.Length < 1)
                        {
                            Console.Write("Enter either 1 or 2: ");
                            MyDecision = Console.ReadLine();
                        }

                        MyChoice = int.Parse(MyDecision);

                        while (true)
                        {
                            if (MyChoice == 1)
                            {
                                int MyShotSuccess;

                                Console.WriteLine("{0} rises up for an jumper with {1} on him...", MyPlayer.FirstName, Opponent.LastName);
                                Console.ReadLine();

                                Random rndShot = new Random();
                                MyShotSuccess = rndShot.Next(1, 101);

                                if (MyShotSuccess <= (28 + MyShotDifference))
                                {
                                    MyPlayer.ShotAttemptsCareer++;
                                    MyPlayer.ShotAttemptsGame++;
                                    MyPlayer.ShotMakesCareer++;
                                    MyPlayer.ShotMakesGame++;
                                    Console.WriteLine("...and knocks down the contested jumper! That's a point for {0}!", MyPlayer.LastName);
                                    Console.ReadLine();
                                    MyScore++;
                                    Console.WriteLine("Score: {0} - {1}, {2} - {3}", MyPlayer.FullName, MyScore, Opponent.FullName, OpponentScore);
                                    Console.WriteLine();
                                    Console.ReadLine(); 
                                    if (MyScore == 7)
                                    {
                                        iWin();
                                    }
                                    else
                                    {
                                        OpponentBall();
                                    }
                                }
                                else
                                {
                                    MyPlayer.ShotAttemptsGame++;
                                    MyPlayer.ShotAttemptsCareer++;
                                    Commentary.iMissedShot();
                                    Console.ReadLine();
                                    ReboundMyMiss();
                                }
                            }
                            else if (MyChoice == 2)
                            {
                                int MyDriveSuccess;

                                Console.WriteLine("{0} takes it to the rack with {1} all over him...", MyPlayer.LastName, Opponent.LastName);
                                Console.ReadLine();
                                Random rndDrive = new Random();
                                MyDriveSuccess = rndDrive.Next(1, 101);

                                if (MyDriveSuccess <= (35 + MyDriveDifference))
                                {
                                    MyPlayer.DriveAttemptsCareer++;
                                    MyPlayer.DriveAttemptsGame++;
                                    MyPlayer.DriveMakesCareer++;
                                    MyPlayer.DriveMakesGame++;
                                    Commentary.iMadeDrive();
                                    Console.ReadLine();
                                    MyScore++;
                                    Console.WriteLine("Score: {0} - {1}, {2} - {3}", MyPlayer.FullName, MyScore, Opponent.FullName, OpponentScore);
                                    Console.WriteLine();
                                    Console.ReadLine(); 
                                    if (MyScore == 7)
                                    {
                                        iWin();
                                    }
                                    else
                                    {
                                        OpponentBall();
                                    }
                                }
                                else
                                {
                                    MyPlayer.DriveAttemptsCareer++;
                                    MyPlayer.DriveAttemptsGame++;
                                    Commentary.iMissedDrive();
                                    Console.ReadLine();
                                    ReboundMyMiss();
                                }
                            }
                            else
                            {
                                Console.Write("Enter either 1 or 2: ");
                                MyDecision = Console.ReadLine();
                                MyChoice = int.Parse(MyDecision);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("{0} loses the handle and turns it over! Steal for {1}!", MyPlayer.FirstName, Opponent.LastName);
                        MyPlayer.TurnoversCareer++;
                        MyPlayer.TurnoversGame++;
                        OpponentBall();
                    }
                }
                else
                {
                    Console.Write("Enter a valid number: ");
                    MyDecision = Console.ReadLine();
                    MyChoice = int.Parse(MyDecision);
                }
            }
        }

        static public void OpponentBall()
        {
            int OpponentTendency;
            int OpponentChoice;

            OpponentTendency = Opponent.shooting + Opponent.drive + (Opponent.handle / 2);

            Random rnd = new Random();
            OpponentChoice = rnd.Next(1, (OpponentTendency + 1));

            if (OpponentChoice <= Opponent.shooting)
            {
                Console.WriteLine("{0} attempts a jumper...", Opponent.FirstName);
                Console.ReadLine();
                Random rndOpponentShot = new Random();
                int OpponentShotSuccess = rndOpponentShot.Next(1, 101);

                if (OpponentShotSuccess <= (38 + OpponentShotDifference))
                {
                    Commentary.OpponentMadeShot();
                    Console.ReadLine();
                    OpponentScore++;
                    Console.WriteLine("Score: {0} - {1}, {2} - {3}", MyPlayer.FullName, MyScore, Opponent.FullName, OpponentScore);
                    Console.WriteLine();
                    Console.ReadLine(); 
                    if (OpponentScore == 7)
                    {
                        iLose();
                    }
                    else
                    {
                        MyBall();
                    }
                }
                else
                {
                    Commentary.OpponentMissedShot();
                    Console.ReadLine();
                    ReboundOpponentMiss();
                }
            }
            else if (OpponentChoice > Opponent.shooting && OpponentChoice <= (Opponent.shooting + Opponent.drive))
            {
                int OpponentDriveSuccess;

                Console.WriteLine("{0} tries to take it to the rack...", Opponent.FirstName);
                Console.ReadLine();

                Random rndOpponentDrive = new Random();
                OpponentDriveSuccess = rndOpponentDrive.Next(1, 101);

                if (OpponentDriveSuccess <= (43 + OpponentDriveDifference))
                {
                    Commentary.OpponentMadeDrive();
                    Console.ReadLine();
                    OpponentScore++;
                    Console.WriteLine("Score: {0} - {1}, {2} - {3}", MyPlayer.FullName, MyScore, Opponent.FullName, OpponentScore);
                    Console.WriteLine();
                    Console.ReadLine(); 
                    if (OpponentScore == 7)
                    {
                        iLose();
                    }
                    else
                    {
                        MyBall();
                    }
                }
                else
                {
                    Commentary.OpponentMissedDrive();
                    Console.ReadLine();
                    ReboundOpponentMiss();
                }
            }
            else
            {
                Console.WriteLine("{0} flashes some handles looking to break down the defender...", Opponent.FirstName);
                Console.ReadLine();

                int OpponentDribbleMoveSuccess;

                Random rndOpponentDribbleMove = new Random();
                OpponentDribbleMoveSuccess = rndOpponentDribbleMove.Next(1, 101);

                if (OpponentDribbleMoveSuccess <= (15 + OpponentDribbleMoveDifference))
                {
                    Console.WriteLine("{0} breaks {1} with a sweet move to clear some space...", Opponent.LastName, MyPlayer.LastName);
                    Console.WriteLine("He's got options now...");
                    Console.ReadLine();

                    Random rndMoveChoice = new Random();
                    int OpponentMoveChoice = rndMoveChoice.Next(1, (Opponent.shooting + Opponent.drive + 1));

                    if (OpponentMoveChoice <= Opponent.shooting)
                    {
                        Console.WriteLine("{0} takes an open jump shot...", Opponent.LastName);
                        Console.ReadLine();
                        Random rndOpponentShot = new Random();
                        int OpponentShotSuccess = rndOpponentShot.Next(1, 101);

                        if (OpponentShotSuccess <= (48 + OpponentShotDifference))
                        {
                            Commentary.OpponentMadeShot();
                            Console.ReadLine();
                            OpponentScore++;
                            Console.WriteLine("Score: {0} - {1}, {2} - {3}", MyPlayer.FullName, MyScore, Opponent.FullName, OpponentScore);
                            Console.WriteLine();
                            Console.ReadLine(); 
                            if (OpponentScore == 7)
                            {
                                iLose();
                            }
                            else
                            {
                                MyBall();
                            }
                        }
                        else
                        {
                            Commentary.OpponentMissedShot();
                            Console.ReadLine();
                            ReboundOpponentMiss();
                        }
                    }
                    else
                    {
                        int OpponentDriveSuccess;

                        Console.WriteLine("{0} looks to have an open lane to the rim...", Opponent.LastName);
                        Console.ReadLine();

                        Random rndOpponentDrive = new Random();
                        OpponentDriveSuccess = rndOpponentDrive.Next(1, 101);

                        if (OpponentDriveSuccess <= (60 + OpponentDriveDifference))
                        {
                            Commentary.OpponentMadeDrive();
                            Console.ReadLine();
                            OpponentScore++;
                            Console.WriteLine("Score: {0} - {1}, {2} - {3}", MyPlayer.FullName, MyScore, Opponent.FullName, OpponentScore);
                            Console.WriteLine();
                            Console.ReadLine(); 
                            if (OpponentScore == 7)
                            {
                                iLose();
                            }
                            else
                            {
                                MyBall();
                            }
                        }
                        else
                        {
                            Commentary.OpponentMissedDrive();
                            Console.ReadLine();
                            ReboundOpponentMiss();
                        }
                    }
                }
                else if (OpponentDribbleMoveSuccess >= (15 + OpponentDriveDifference) && OpponentDribbleMoveSuccess <= 80)
                {
                    Console.WriteLine("That's some good defense by {0}. Now {1} is going to have to force...", MyPlayer.LastName, Opponent.LastName);
                    Console.ReadLine();

                    Random rndForced = new Random();
                    int OpponentForced = rndForced.Next(1, (Opponent.shooting + Opponent.drive + 1));

                    if (OpponentForced <= Opponent.shooting)
                    {
                        int ForcedShotSuccess;

                        Console.WriteLine("...a jumper with {0} in his face...", MyPlayer.LastName);
                        Console.ReadLine();
                        Random rndShot = new Random();
                        ForcedShotSuccess = rndShot.Next(1, 101);

                        if (ForcedShotSuccess <= (28 + OpponentShotDifference))
                        {
                            Console.WriteLine("Knocks it down! That's a point for {0}!", Opponent.FirstName);
                            OpponentScore++;
                            Console.WriteLine("Score: {0} - {1}, {2} - {3}", MyPlayer.FullName, MyScore, Opponent.FullName, OpponentScore);
                            Console.WriteLine();
                            Console.ReadLine(); 
                            if (OpponentScore == 7)
                            {
                                iLose();
                            }
                            else
                            {
                                MyBall();
                            }
                        }
                        else
                        {
                            Commentary.OpponentMissedShot();
                            Console.ReadLine();
                            ReboundOpponentMiss();
                        }
                    }
                    else
                    {
                        int ForcedDriveSuccess;

                        Console.WriteLine("...a drive with {0} draped all over him...", MyPlayer.FirstName);
                        Console.ReadLine();
                        Random rndDrive = new Random();
                        ForcedDriveSuccess = rndDrive.Next(1, 101);

                        if (ForcedDriveSuccess <= (35 + OpponentDriveDifference))
                        {
                            Console.WriteLine("Ohhh a tough finish by {0}!", Opponent.LastName);
                            OpponentScore++;
                            Console.WriteLine("Score: {0} - {1}, {2} - {3}", MyPlayer.FullName, MyScore, Opponent.FullName, OpponentScore);
                            Console.WriteLine();
                            Console.ReadLine(); if (OpponentScore == 7)
                            {
                                iLose();
                            }
                            else
                            {
                                MyBall();
                            }
                        }
                        else
                        {
                            Commentary.OpponentMissedDrive();
                            Console.ReadLine();
                            ReboundOpponentMiss();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("{0} loses the handles and turns it over! Steal for {1}!", Opponent.LastName, MyPlayer.LastName);
                    MyPlayer.StealsCareer++;
                    MyPlayer.StealsGame++;
                    MyBall();
                }
            }
        }

        static public void ReboundMyMiss()
        {
            int OpponentRebound;

            Random rnd = new Random();
            OpponentRebound = rnd.Next(1, 101);

            if (OpponentRebound <= (80 + OpponentReboundDifference))
            {
                Console.WriteLine("{0} reaches up and grabs the rebound.", Opponent.FirstName);
                Console.ReadLine();
                OpponentBall();
            }
            else
            {
                MyPlayer.OffensiveReboundsGame++;
                MyPlayer.OffensiveReboundsCareer++;
                
                Console.WriteLine("That's an offensive rebound for {0}! What will he do?", MyPlayer.LastName);
                Console.WriteLine("1. Attempt putback \n2. Dribble out");
                string iPutback = Console.ReadLine();

                while (iPutback.Length < 1)
                {
                    Console.Write("Enter either a 1 or a 2: ");
                    iPutback = Console.ReadLine();
                }

                int PutbackChoice = int.Parse(iPutback);

                if (PutbackChoice == 1)
                {
                    Console.WriteLine("{0} goes back up with it...", MyPlayer.FirstName);
                    Random rand = new Random();
                    int PutbackSuccess = rand.Next(1, 101);

                    if (PutbackSuccess <= (50 + MyPutbackDifference))
                    {
                        MyPlayer.PutbackAttemptsGame++;
                        MyPlayer.PutbackAttemptsCareer++;
                        MyPlayer.PutbackMakesCareer++;
                        MyPlayer.PutbackMakesGame++;

                        Console.WriteLine("...and finishes over {0}!", Opponent.LastName);
                        MyScore++;
                        Console.WriteLine("Score: {0} - {1}, {2} - {3}", MyPlayer.FullName, MyScore, Opponent.FullName, OpponentScore);
                        Console.WriteLine();
                        Console.ReadLine(); 
                        if (MyScore == 7)
                        {
                            iWin();
                        }
                        else
                        {
                            OpponentBall();
                        }
                    }
                    else
                    {
                        MyPlayer.PutbackAttemptsGame++;
                        MyPlayer.PutbackAttemptsCareer++;

                        Console.WriteLine("...can't finish the putback!");
                        Console.ReadLine();
                        ReboundMyMiss();
                    }
                }
                else if (PutbackChoice == 2)
                {
                    Console.WriteLine("{0} dribbles out to the top of the key to reset.", MyPlayer.FirstName);
                    MyBall();
                }
                else
                {
                    Console.Write("Enter either a 1 or 2: ");
                    iPutback = Console.ReadLine();
                    PutbackChoice = int.Parse(iPutback);
                }
            }
        }

        static public void ReboundOpponentMiss()
        {
            int MyRebound;

            Random rnd = new Random();
            MyRebound = rnd.Next(1, 101);

            if (MyRebound <= (80 + MyReboundDifference))
            {
                Console.WriteLine("{0} reaches up and grabs the rebound.", MyPlayer.FirstName);
                Console.ReadLine();
                MyPlayer.DefensiveReboundsCareer++;
                MyPlayer.DefensiveReboundsGame++;
                MyBall();
            }
            else
            {
                Console.WriteLine("That's an offensive rebound for {0}! What will he do?", Opponent.LastName);

                Random rndOpponentPutback = new Random();
                int PutbackChoice = rndOpponentPutback.Next(1, 101);

                if (PutbackChoice <= (50 + OpponentPutbackDifference))
                {
                    Console.WriteLine("{0} goes back up with it...", Opponent.FirstName);
                    Random rand = new Random();
                    int PutbackSuccess = rand.Next(1, 101);

                    if (PutbackSuccess <= (50 + OpponentPutbackDifference))
                    {
                        Console.WriteLine("...and finishes over {0}!", MyPlayer.FirstName);
                        OpponentScore++;
                        Console.WriteLine("Score: {0} - {1}, {2} - {3}", MyPlayer.FullName, MyScore, Opponent.FullName, OpponentScore);
                        Console.WriteLine();
                        Console.ReadLine(); 
                        if (OpponentScore == 7)
                        {
                            iLose();
                        }
                        else
                        {
                            MyBall();
                        }
                    }
                    else
                    {
                        Console.WriteLine("...can't finish the putback!");
                        Console.ReadLine();
                        ReboundOpponentMiss();
                    }
                }
                else
                {
                    Console.WriteLine("{0} dribbles out to the top of the key to reset.", Opponent.LastName);
                    OpponentBall();
                }
            }
        }

        static public void iWin()
        {
            MyScore = 0;
            OpponentScore = 0;
            if (MyPlayer.CareerWins == 0)
            {
                MyPlayer.CareerWins++;
                MyPlayer.CareerGames++;
                Console.WriteLine("Congrats! You won your first ever game!");
                Console.ReadLine();
                MyPlayer.DisplayGameStats();
            }
            else
            {
                MyPlayer.CareerWins++;
                MyPlayer.CareerGames++;
                Console.WriteLine("Another win under your belt! Winning never gets old!");
                Console.ReadLine();
                MyPlayer.DisplayGameStats();
            }
        }

        static public void iLose()
        {
            MyScore = 0;
            OpponentScore = 0;
            if (MyPlayer.CareerLosses == 0)
            {
                MyPlayer.CareerLosses++;
                MyPlayer.CareerGames++;
                Console.WriteLine("It's just the first loss of your career. Don't let it define you!");
                Console.ReadLine();
                MyPlayer.DisplayGameStats();
            }
            else
            {
                MyPlayer.CareerLosses++;
                MyPlayer.CareerGames++;
                Console.WriteLine("Tough loss, kid. Don't let it get you down. Keep working hard!");
                Console.ReadLine();
                MyPlayer.DisplayGameStats();
            }
        }
    }
}
