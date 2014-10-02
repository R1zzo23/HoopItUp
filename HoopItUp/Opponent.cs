using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HoopItUp
{
    class Opponent
    {
        static public string FirstName;
        static public string LastName;
        static public string FullName = FirstName + " " + LastName;

        static public int feet;
        static public int inches;
        static public int weight;
        static public int height;
        static public int shooting;
        static public int drive;
        static public int handle;
        static public int rebound;
        static public int defense;
        static public int steal;

        static public void CreateFirstOpponent()
        {
            FirstName = "Jake";
            LastName = "Gambini";
            FullName = "Jake Gambini";
            feet = 5;
            inches = 9;
            height = ((feet * 12) + inches);
            weight = 195;
            shooting = 22;
            drive = 33;
            handle = 23;
            rebound = 30;
            defense = 38;
            steal = 17;

            Console.WriteLine("Here is your first challenge:");
            Console.WriteLine("Name...........{0}", FullName);
            Console.WriteLine("Height.........{0}'{1}\"", feet, inches);
            Console.WriteLine("Weight.........{0}", weight);
            Console.WriteLine("Shooting.......{0}", shooting);
            Console.WriteLine("Drive..........{0}", drive);
            Console.WriteLine("Handle.........{0}", handle);
            Console.WriteLine("Rebound........{0}", rebound);
            Console.WriteLine("Defense........{0}", defense);
            Console.WriteLine("Steal..........{0}", steal);
            Console.ReadLine();
            Console.Clear();

            Game.StartGame();
        }
    }
}
