using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HoopItUp
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("====================================================");
            Console.WriteLine("|                    Hoop It Up                    |");
            Console.WriteLine("|           Written & Designed by R1zzo23          |");
            Console.WriteLine("====================================================");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                Press Enter to Start                ");
            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Welcome to the courst of Revere where all the legends play!");
            Console.WriteLine("If you want to make a name for yourself to play at Revere");
            Console.WriteLine("High School for Coach Rizzo, this is the place to do it!");
            Console.ReadLine();

            MyPlayer.CreateName();
                        
        }
    }
}
