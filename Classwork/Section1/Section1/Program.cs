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
            bool notQuit;
            do
            {
                notQuit = DisplayMenu();
            }
            while (notQuit);
            //PlayWithStrings();
        }

        private static void PlayWithArrays()
        {
            int count = ReadInt32("How many names? ", 1);

            //array of strings that contains names
            string[] names = new string[count];
            for(int i = 0; i < count; ++i)
            {
                Console.WriteLine("Name? ");
                names[i] = Console.ReadLine();
            };

            //for(int i =0; i < names.Length; ++i)
            foreach(string name in names)
            {
                //read only - not allowed
                //name = "";
                string str = name;
                str =  "";
                //Console.WriteLine(names[i]);
                Console.WriteLine(name);//names replaces names[i]
            }
        }

        private static void PlayWithStrings()
        {
            //string hoursString = "10";
            //int hours = Int32.Parse(hoursString);
            //int hours;
            //bool result = Int32.TryParse(hoursString,out hours);
            //bool result = Int32.TryParse(hoursString, out int hours); best practice use

            //hoursString = hours.ToString();

            //Console.ReadLine().ToString();

            //string message = "Hello\tWorld";
            //string filePath = "C:\\Temp\\Test";

            //verbatim strings
            //string filePath2 = @"C:\Temp\Test";

            //concat
            string fName = "John";
            string lName = "Doe";
            string name = fName + " " + lName;
            Console.WriteLine("Hello " + name);// approach 1
            
            //string formating
            Console.WriteLine("Hello {0} {1}", fName, lName);//approach 2
            string str = String.Format("Hello {0} {1}", fName, lName);//approach 3
            Console.WriteLine(str);

            //approach 4
            Console.WriteLine($"Hello {fName} {lName}"); //dollar sign is needed
            string test = $"{fName} {lName}";   //can use it to assign to variables

            //Null vs Empty
            string missing = null;
            string empty = "";
            string empty2 = String.Empty;
            
            //checking for empty strings
            //if(fName.Length == 0)
            //if(fName != null && fName != "")
            if(!String.IsNullOrEmpty(fName))    //prefered way
            {
                Console.WriteLine(fName);
            }

            //other stuff
            string upperCaseName = fName.ToUpper();
            string lowerCaseName = fName.ToLower();

            //string comparison
            bool areEqual = fName == lName; //false if case is different
            areEqual = fName.ToLower() == lName.ToLower();
            areEqual = String.Compare(fName, lName, true) == 0;

            bool startsWithA = fName.StartsWith("A");
            bool endsWithA = fName.EndsWith("A");
            bool hasA = fName.IndexOf("A") >= 0;
            string subset = fName.Substring(4);

            //clean up functions needs to be assigned to a new string
            string cleanMe = fName.Trim(); // trim removes all white space from the string
                                           // TrimStart only front; TrimEnd only end
            string makeLonger = fName.PadLeft(20);// makes string longer with white space also a pad right

           
        }

        private static bool DisplayMenu()
        {
            while (true)
            {
                Console.WriteLine("A)dd Movie");
                Console.WriteLine("E)dit Movie");
                Console.WriteLine("D)elete Movie");
                Console.WriteLine("V)iew Movies");
                Console.WriteLine("Q)uit");

                string input = Console.ReadLine();
                switch (input[0])
                {
                    case 'a':
                    case 'A': AddMovie(); return true;

                    case 'e':
                    case 'E': EditMovie(); return true;

                    case 'd':
                    case 'D': DeleteMovie(); return true;

                    case 'v':
                    case 'V': ViewMovies(); return true;

                    case 'q':
                    case 'Q': return false;

                    default: Console.WriteLine("Please enter a valid Value."); break;
                };
            };
        }
        private static void AddMovie()
        {
            name = ReadString("Enter a name: ", true);
            description = ReadString("Enter a description: ", true);
            runLength = ReadInt32("Enter run length(in minutes): ", 0);
        }

        private static void EditMovie()
        {
            Console.WriteLine("EditMovie");
        }

        private static void DeleteMovie()
        {
            Console.WriteLine("DeleteMovie");
        }

        private static void ViewMovies()
        {
            Console.WriteLine("ViewMovies");
        }

        //helper functions
        private static int ReadInt32(string message, int minValue)
        {
            while (true)
            {
                Console.WriteLine(message);
                string input = Console.ReadLine();

                if (Int32.TryParse(input, out int result))
                {
                    if (result >= minValue)
                    {
                        return result;
                    }
                };
                Console.WriteLine($"You must enter an interger value >= {minValue}");
            };
        }

        private static string ReadString( string message )
        {
            return ReadString(message, false);
        }

        private static string ReadString( string message, bool required )
        {
            while (true)
            {
                Console.WriteLine(message);
                string input = Console.ReadLine();

                if (!String.IsNullOrEmpty(input) || !required)
                {
                    return input;
                }
                Console.WriteLine("You must enter a value");
            };
        }

        //use on Lab1 to bring things up scope
        //declare variables at the bottom to pass them to all things needed

        //A movie
        static string name;
        static string description;
        static int runLength;
        static DateTime releaseDate;


    }
}
