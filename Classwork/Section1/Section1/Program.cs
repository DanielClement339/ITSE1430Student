/*
 * ITSE 1430
 * Daniel Clement
 */
using System;

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
                //read only
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

        private static void PlayWithObjects()
        {
            int hours = 10;
            Int32 hoursFull = 10;
            var areEqual = hours == hoursFull;


            var obj1 = "Hello";
            DisplayObject(obj1); // all types derive from object
            
        }

        private static void DisplayObject( object value)
        {
            if (value == null)
                return;
            //approach 1
            if (value is string) // is operator is used to see if an object is a certain type or derived from a type
            {
                var str = (string)value;    //type casting
                Console.WriteLine(str);
            } else
            {
                var str = value.ToString();
                Console.WriteLine(str);
            };

            //approach 2
            var str2 = value as string; //does the approach 1 check automatically. if false returns null
            if (str2 != null)           //as operator is a cleaner form of type casting
                Console.WriteLine(str2);//run-time safe
            else
                Console.WriteLine(value.ToString());
           
            //approach 3
            var str3 = value as string;
            Console.WriteLine((str3 != null) ? str3.ToString() : value.ToString());

            //approach 4
            //null coalescing
            //returns the first non-null expression
            var str4 = value as string;
            Console.WriteLine((str4 ?? value).ToString());

            //approach 5** pattern matching
            //depends on what you are doing for if you use this
            //new to the language
            //var str5 = value is string;
            if (value is string str5)
                Console.WriteLine(str5.ToString());
            else
                Console.WriteLine(value.ToString());

            //approach 6** best practices now 
            //null conditional
            //if expression isnt null it executess the functon
            var str6 = value as string;
            Console.WriteLine(str6?.ToString());

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
            description = ReadString("Enter a description: ");
            runLength = ReadInt32("Enter run length(in minutes): ", 0);
        }

        private static void EditMovie()
        {
            ViewMovies();

            var newName = ReadString("Enter a name(or press enter for default): ", false);
            if (!String.IsNullOrEmpty(newName))
                name = newName;

            var newDescription = ReadString("Enter a description(or press enter for default): ", false);
            if (!String.IsNullOrEmpty(newDescription))
                description = newDescription;

            var newRunLength = ReadInt32("Enter run length(in minutes): ", 0);
            if (newRunLength > 0)
                runLength = newRunLength;
        }

        private static void DeleteMovie()
        {

            if(Confirm("Are You sure you want to delete this movie?"))
            {
                //"Delete" the movie
                name = null;
                description = null;
                runLength = 0;
            };
        }

        private static bool Confirm( string message )
        {
            Console.WriteLine($"{message} (Y/N)");
            do
            {
                ConsoleKeyInfo key = Console.ReadKey(true);

                switch (key.KeyChar)
                {
                    case 'y':
                    case 'Y':
                    return true;
                    case 'n':
                    case 'N':
                    return false;
                }
            } while (true);
        }

        private static void ViewMovies()
        {
            if(String.IsNullOrEmpty(name))
            {
                Console.WriteLine("No movies available");
                return;
            }

            Console.WriteLine(name);
            if (!String.IsNullOrEmpty(description))
                Console.WriteLine(description);
            
            Console.WriteLine($"The run length is {runLength} mins");
        }

        //helper functions
        private static int ReadInt32(string message, int minValue)
        {
            while (true)
            {
                Console.WriteLine(message);
                var input = Console.ReadLine();

                //int.TryParse(); can use primtives aswell but the standard is if you are using framework functions use framework type
                if (Int32.TryParse(input, out var result))//can use out var instead of out int
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
        //static DateTime releaseDate;
    }
}
