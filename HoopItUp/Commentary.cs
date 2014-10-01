using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HoopItUp
{
    class Commentary
    {

        public static void iMadeShot()
        {
            Random rnd = new Random();
            int iMadeShotCommentary = rnd.Next(1, 6);

            if (iMadeShotCommentary == 1)
            {
                Console.WriteLine("...and {0} knocks down a turn-around jumper!", MyPlayer.LastName);
            }
            else if (iMadeShotCommentary == 2)
            {
                Console.WriteLine("BANG! {0} buries the 15-footer!", MyPlayer.FirstName);
            }
            else if (iMadeShotCommentary == 3)
            {
                Console.WriteLine("...a couple bounces on the rim and it falls! Shooter's roll for {0}!", MyPlayer.LastName);
            }
            else if (iMadeShotCommentary == 4)
            {
                Console.WriteLine("...nothing but net! {0} has got to be feeling it after that shot!", MyPlayer.FirstName);
            }
            else
            {
                Console.WriteLine("...{0} banks it in off the glass!", MyPlayer.LastName);
            }
        }

        public static void iMissedShot()
        {
            Random rnd = new Random();
            int iMissedShotCommentary = rnd.Next(1, 6);

            if (iMissedShotCommentary == 1)
            {
                Console.WriteLine("...that's a brick from {0}.", MyPlayer.FirstName);
            }
            else if (iMissedShotCommentary == 2)
            {
                Console.WriteLine("...that didn't have a chance of going in. What was {0} thinking?", MyPlayer.LastName);
            }
            else if (iMissedShotCommentary == 3)
            {
                Console.WriteLine("...the rim was unkind to {0}. That one looked good.", MyPlayer.LastName);
            }
            else if (iMissedShotCommentary == 4)
            {
                Console.WriteLine("...that's going to be an airball! {0} looks shocked!", MyPlayer.LastName);
            }
            else
            {
                Console.WriteLine("...bank isn't open today for {0}!", MyPlayer.FirstName);
            }
        }

        public static void iMadeDrive()
        {
            Random rnd = new Random();
            int iMadeDriveCommentary = rnd.Next(1, 6);

            if (iMadeDriveCommentary == 1)
            {
                Console.WriteLine("...and bodies {0} at the rim for a bucket!", Opponent.FirstName);
            }
            else if (iMadeDriveCommentary == 2)
            {
                Console.WriteLine("...nothing {0} could do to stop that strong drive.", Opponent.LastName);
            }
            else if (iMadeDriveCommentary == 3)
            {
                Console.WriteLine("...what a beautiful reverse layup using the rim as a defender!");
            }
            else if (iMadeDriveCommentary == 4)
            {
                Console.WriteLine("...and the floater is good! {0} just missed the block on that one.", Opponent.LastName);
            }
            else
            {
                Console.WriteLine("...scoops it under {0}'s arm and scores!", Opponent.LastName);
            }
        }

        static public void iMissedDrive()
        {
            Random rnd = new Random();
            int iMissedDriveCommentary = rnd.Next(1, 6);

            if (iMissedDriveCommentary == 1)
            {
                Console.WriteLine("...and throws up an ugly layup attempt that's no good.");
            }
            else if (iMissedDriveCommentary == 2)
            {
                Console.WriteLine("...soft touch but can't get it to fall.");
            }
            else if (iMissedDriveCommentary == 3)
            {
                Console.WriteLine("...too hard off the glass and ricochets out.");
            }
            else if (iMissedDriveCommentary == 4)
            {
                Console.WriteLine("...tries to bully {0} but can't finish through contact.", Opponent.FirstName);
            }
            else
            {
                Console.WriteLine("...hits the underside of the rim! That's embarrassing!");
            }
        }

        public static void OpponentMadeShot()
        {
            Random rnd = new Random();
            int OpponenetMadeShotCommentary = rnd.Next(1, 6);

            if (OpponenetMadeShotCommentary == 1)
            {
                Console.WriteLine("...and he knocks it down over {0}!", MyPlayer.FirstName);
            }
            else if (OpponenetMadeShotCommentary == 2)
            {
                Console.WriteLine("...it takes a couple bounces on the rim and falls in!");
            }
            else if (OpponenetMadeShotCommentary == 3)
            {
                Console.WriteLine("Nothing but net!");
            }
            else if (OpponenetMadeShotCommentary == 4)
            {
                Console.WriteLine("Banks it in off the glass!");
            }
            else
            {
                Console.WriteLine("Oh that's a pure stroke right there!");
            }
        }

        public static void OpponentMissedShot()
        {
            Random rnd = new Random();
            int OpponentMissedShotCommentary = rnd.Next(1, 6);

            if (OpponentMissedShotCommentary == 1)
            {
                Console.WriteLine("...ouch that's a brick!");
            }
            else if (OpponentMissedShotCommentary == 2)
            {
                Console.WriteLine("...unkind bounce off the double rim and it's no good!");
            }
            else if (OpponentMissedShotCommentary == 3)
            {
                Console.WriteLine("...missed it! {0} looking confident on defense after that one!", MyPlayer.LastName);
            }
            else if (OpponentMissedShotCommentary == 4)
            {
                Console.WriteLine("...that didn't have a chance at going in! Looked like he just chucked it up.");
            }
            else
            {
                Console.WriteLine("...good shot but bad result. He got unlucky on that one.");
            }
        }

        public static void OpponentMadeDrive()
        {
            Random rnd = new Random();
            int OpponentMadeDriveCommentary = rnd.Next(1, 6);

            if (OpponentMadeDriveCommentary == 1)
            {
                Console.WriteLine("Oh what a beautiful finish!");
            }
            else if (OpponentMadeDriveCommentary == 2)
            {
                Console.WriteLine("...muscles through {0} and finishes with contact!", MyPlayer.LastName);
            }
            else if (OpponentMadeDriveCommentary == 3)
            {
                Console.WriteLine("...hits {0} with a Euro-step and finishes with his strong hand!", MyPlayer.FirstName);
            }
            else if (OpponentMadeDriveCommentary == 4)
            {
                Console.WriteLine("...the floater is good!");
            }
            else
            {
                Console.WriteLine("...has to go to the weak hand and finishes with ease!");
            }
        }

        public static void OpponentMissedDrive()
        {
            Random rnd = new Random();
            int OpponentMissedDriveCommentary = rnd.Next(1, 6);

            if (OpponentMissedDriveCommentary == 1)
            {
                Console.WriteLine("...too strong off the glass and comes off the front of the rim!");
            }
            else if (OpponentMissedDriveCommentary == 2)
            {
                Console.WriteLine("...tries to draw contact on {0} and can't finish!", MyPlayer.LastName);
            }
            else if (OpponentMissedDriveCommentary == 3)
            {
                Console.WriteLine("...goes for the reverse and can't kiss it off the glass!");
            }
            else if (OpponentMissedDriveCommentary == 4)
            {
                Console.WriteLine("...floater is up and no good!");
            }
            else
            {
                Console.WriteLine("...he's out of control and the shot goes beggging!");
            }
        }
    }
}
