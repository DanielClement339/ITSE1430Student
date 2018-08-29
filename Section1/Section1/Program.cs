using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section1
{
    class Program
    {
        static void Main( string[] args )
        {
            //DisplayMenu();
            PlayWithStrings();
        }

        private static void PlayWithStrings()
        {
            //string hoursString = "10";
            //int hours = Int32.Parse(hoursString);
            //int hours;
            //bool result = Int32.TryParse(hoursString,out hours);
            //bool result = Int32.TryParse(hoursString, out int hours);

            //hoursString = hours.ToString();

            //Console.ReadLine().ToString();

            //string message = "Hello\tWorld";
            //string filePath = "C:\\Temp\\Test";

            //verbatim strings
            //string filePath2 = @"C:\Temp\Test";

            //concat
            //string fName = "John";
            //string lName = "Doe";
            //string name = fName + " " + lName;

        }

        private static void DisplayMenu()
        {
            Console.WriteLine("A)dd Movie");
            Console.WriteLine("E)dit Movie");
            Console.WriteLine("D)elete Movie");
            Console.WriteLine("V)iew Movies");
            Console.WriteLine("Q)uit");

            string input  = Console.ReadLine();
            switch (input[0])
            {
                case 'A': AddMovie(); break;
                case 'E': EditMovie(); break;
                case 'D': DeleteMovie(); break;
                case 'V': ViewMovie(); break;
                case 'Q': ; break;

                default: Console.WriteLine("Please enter a valid Value."); break;
            };
        }

        private static void ViewMovie()
        {
            throw new NotImplementedException();
        }

        private static void DeleteMovie()
        {
            throw new NotImplementedException();
        }

        private static void EditMovie()
        {
            throw new NotImplementedException();
        }

        private static void AddMovie()
        {
            throw new NotImplementedException();
        }
    }
}
