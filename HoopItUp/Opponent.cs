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
        static public string FullName = (FirstName + " " + LastName);

        static public int feet;
        static public int inches;
        static public int height = ((feet * 12) + inches);
        
        static public int weight;

        static public int shooting;
        static public int drive;
        static public int handle;
        static public int rebound;
        static public int defense;
        static public int steal;

        static public void CreateFirstOpponent()
        {

        }
    }
}
