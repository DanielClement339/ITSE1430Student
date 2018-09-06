using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCreator
{
    class Program
    {
        
        static void Main(string[] args)
        {
            bool notQuit;
            do
            {
                notQuit = DisplayMenu();
            }
            while (notQuit);
        }

        private static bool DisplayMenu()
        {
            while (true)
            {
                Console.WriteLine("1) New Order");
                Console.WriteLine("2) Modify Order");
                Console.WriteLine("3) Display Order");
                Console.WriteLine("4) Quit");
                Console.WriteLine($"Your total is: {totalPrice}");

                string input = Console.ReadLine();
                switch (input[0])
                {
                    case '1': NewOrder(); return true;        // makes a new order

                    case '2': ModifyOrder(); return true;                   //modifies order

                    case '3': DisplayOrder(); return true;                  // displays the order as a whole

                    case '4': return false;                                 //quit the program

                    default: Console.WriteLine($"{input} is not a valid value.\nPlease enter a valid Value."); break;
                };
            }
        }

        private static void NewOrder()
        {
            Console.WriteLine("New Order");
            GetPizzaSize();
            Console.WriteLine($"Your size is {pizzaSize}");
            Console.WriteLine($"Your total is: {totalPrice}");
            GetPizzaMeats();
            GetPizzaVeggies();
            GetPizzaSauce();
            GetPizzaCheese();
            GetPizzaDelivery();
        }

        private static bool GetPizzaSize()
        {
           while(true)
            {

                Console.WriteLine("1) Small($5)");
                Console.WriteLine("2) Medium($6.25)");
                Console.WriteLine("3) Large($8.75)");

                string input = Console.ReadLine();
                switch (input[0])
                {
                    case '1':
                        {
                            totalPrice += 5.00m;
                            pizzaSize = "Small";
                            return true;
                        }
                    case '2':
                        {
                            totalPrice += 6.25m;
                            pizzaSize = "Medium";
                            return true;
                        }
                    case '3':
                        {
                            totalPrice += 8.75m;
                            pizzaSize = "Large";
                            return true;
                        }
                    default: Console.WriteLine("Please enter a Value. between 1-3"); break;
                }
            }
        }

        private static bool GetPizzaMeats()
        {
            int numSelected = 0;
            bool baconSelected = false;
            bool hamSelected = false;
            bool pepperoniSelected = false;
            bool sausageSelected = false;

            while(true)
            {
                Console.WriteLine("Select as many of the meats as you want to add on\n Each option is $0.75 Extra");
                //bacon
                if (!baconSelected)
                {
                    Console.WriteLine("1) Bacon");
                }
                else
                {
                    Console.WriteLine("1) Bacon - Selected");
                }
                //ham
                if (!hamSelected)
                {
                    Console.WriteLine("2) Ham");
                }
                else
                {
                    Console.WriteLine("2) Ham - Selected");
                }
                //peperoni
                if (!pepperoniSelected)
                {
                    Console.WriteLine("3) Pepperoni");
                }
                else
                {
                    Console.WriteLine("3) Pepperoni - Selected");
                }
                //sausage
                if (!sausageSelected)
                {
                    Console.WriteLine("4) Sausage");
                }
                else
                {
                    Console.WriteLine("4) Sausage - Selected");
                }
                Console.WriteLine("5) Continue");

                string input = Console.ReadLine();
                switch (input[0])
                {
                    case '1':
                        {
                            if (!baconSelected)
                            {
                                numSelected++;
                                baconSelected = true;
                            }
                            else
                            {
                                numSelected--;
                                baconSelected = false;
                            }
                        }
                        break;
                    case '2':
                        {
                            if (!hamSelected)
                            {
                                numSelected++;
                                hamSelected = true;
                            }
                            else
                            {
                                numSelected--;
                                hamSelected = false;
                            }
                        }
                        break;
                    case '3':
                        {
                            if (!pepperoniSelected)
                            {
                                numSelected++;
                                pepperoniSelected = true;
                            }
                            else
                            {
                                numSelected--;
                                pepperoniSelected = false;
                            }
                        }
                        break;
                    case '4':
                        {
                            if(!sausageSelected)
                            {
                                numSelected++;
                                sausageSelected = true;
                            }
                            else
                            {
                                numSelected--;
                                sausageSelected = false;
                            }
                            
                        }
                        break;
                    case '5':
                        {
                            int index = 0;
                            while(index <= numSelected)
                            {
                                if(baconSelected)
                                {
                                    meats[index] = "Bacon";
                                    totalPrice += 0.75m;
                                    baconSelected = false;
                                    index++;
                                }
                                else if(hamSelected)
                                {
                                    meats[index] = "Ham";
                                    totalPrice += 0.75m;
                                    hamSelected = false;
                                    index++;
                                }
                                else if(pepperoniSelected)
                                {
                                    meats[index] = "Pepperoni";
                                    totalPrice += 0.75m;
                                    pepperoniSelected = false;
                                    index++;
                                }
                                else if(sausageSelected)
                                {
                                    meats[index] = "Sausage";
                                    totalPrice += 0.75m;
                                    sausageSelected = false;
                                    index++;
                                }
                            }
                            return true;
                        } 
                }
            }
        }

        private static bool GetPizzaVeggies()
        {
            throw new NotImplementedException();
        }

        private static bool GetPizzaSauce()
        {
            throw new NotImplementedException();
        }

        private static bool GetPizzaCheese()
        {
            throw new NotImplementedException();
        }

        private static bool GetPizzaDelivery()
        {
            throw new NotImplementedException();
        }

        private static void ModifyOrder()
        {       
            Console.WriteLine("Modify Order");
        }

        private static void DisplayOrder()
        {
            Console.WriteLine("Display Order");
        }

        //helper functions
        private static string ReadString(string message)
        {
            return ReadString(message, false);
        }

        private static string ReadString(string message, bool required)
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
        static decimal totalPrice = 0.00m;
        static string pizzaSize;
        static string[] meats;
        static string[] vegtables;
        static string sauce;
        static string cheese;
        static string delivery;
    }
}
