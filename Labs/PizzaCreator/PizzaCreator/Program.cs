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
                Console.Clear();
                Console.WriteLine("1) New Order");
                Console.WriteLine("2) Modify Order");
                Console.WriteLine("3) Display Order");
                Console.WriteLine("4) Quit");
                Console.WriteLine($"Your total is: ${totalPrice}");

                string input = Console.ReadLine();
                switch (input[0])
                {
                    case '1': NewOrder(); return true;        // makes a new order

                    case '2': ModifyOrder(); return true;                   //modifies order

                    case '3': DisplayOrder(); return true;                  // displays the order as a whole

                    case '4': return false;                                 //quit the program

                    default: Console.WriteLine($"Please enter a valid Value."); break;
                };
            }
        }

        private static void NewOrder()
        {
            Console.Clear();
            Console.WriteLine("New Order");
            GetPizzaSize();
            GetPizzaMeats();
            GetPizzaVeggies();
            GetPizzaSauce();
            GetPizzaCheese();
            GetPizzaDelivery();
            DisplayMenu();
        }

        private static bool GetPizzaSize()
        {
           while(true)
            {
                Console.Clear();
                Console.WriteLine("Please choose one of the following pizza sizes");
                Console.WriteLine("1) Small($5)");
                Console.WriteLine("2) Medium($6.25)");
                Console.WriteLine("3) Large($8.75)");

                string input = Console.ReadLine();
                switch (input[0])
                {
                    case '1':
                        {
                            totalPrice += 5.00m;
                            sizePrice = 5.00m;
                            pizzaSize = "Small";
                            return true;
                        }
                    case '2':
                        {
                            totalPrice += 6.25m;
                            sizePrice = 6.25m;
                            pizzaSize = "Medium";
                            return true;
                        }
                    case '3':
                        {
                            totalPrice += 8.75m;
                            sizePrice = 8.75m;
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
                Console.Clear();
                Console.WriteLine("Select as many of the meats as you want to add on\nEach option is $0.75 Extra");
                //bacon
                if (!baconSelected)
                    Console.WriteLine("1) Bacon");
                else
                    Console.WriteLine("1) Bacon - Selected");

                //ham
                if (!hamSelected)
                    Console.WriteLine("2) Ham");
                else
                    Console.WriteLine("2) Ham - Selected");

                //peperoni
                if (!pepperoniSelected)
                    Console.WriteLine("3) Pepperoni");
                else
                    Console.WriteLine("3) Pepperoni - Selected");

                //sausage
                if (!sausageSelected)
                    Console.WriteLine("4) Sausage");
                else
                    Console.WriteLine("4) Sausage - Selected");

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
                            for(int index = 0; index < numSelected; ++index)
                            {
                                if(baconSelected)
                                {
                                    meats[index] = "Bacon";
                                    baconSelected = false;
                                    totalPrice += 0.75m;                                  
                                }
                                else if(hamSelected)
                                {
                                    meats[index] = "Ham";
                                    totalPrice += 0.75m;
                                    hamSelected = false;
                                }
                                else if(pepperoniSelected)
                                {
                                    meats[index] = "Pepperoni";
                                    totalPrice += 0.75m;
                                    pepperoniSelected = false;
                                }
                                else if(sausageSelected)
                                {
                                    meats[index] = "Sausage";
                                    totalPrice += 0.75m;
                                    sausageSelected = false;
                                }
                            }
                            return true;
                        }
                    default: Console.WriteLine($"Please enter a valid Value."); break;
                }
            }
        }

        private static bool GetPizzaVeggies()
        {
            int numSelected = 0;
            bool oliveSelected = false;
            bool mushroomSelected = false;
            bool onionSelected = false;
            bool pepperSelected = false;

            while(true)
            {
                Console.Clear();
                Console.WriteLine("Select as many of the veggies as you want to add on\nEach option is $0.50 Extra");
                if(!oliveSelected)
                    Console.WriteLine("1) Black Olives");
                else
                    Console.WriteLine("1) Black Olives - Selected");

                if (!mushroomSelected)
                    Console.WriteLine("2) Mushrooms");
                else
                    Console.WriteLine("2) Mushrooms - Selected");

                if (!onionSelected)
                    Console.WriteLine("3) Onions");
                else
                    Console.WriteLine("3) Onions - Selected");

                if (!pepperSelected)
                    Console.WriteLine("4) Peppers");
                else
                    Console.WriteLine("1) Peppers - Selected");

                Console.WriteLine("5) Continue");


                string input = Console.ReadLine();
                switch (input[0])
                {
                    case '1':
                        {
                            if(!oliveSelected)
                            {
                                oliveSelected = true;
                                numSelected++;
                            }
                            else
                            {
                                oliveSelected = false;
                                numSelected--;
                            }
                        }break;
                    case '2':
                        {
                            if(!mushroomSelected)
                            {
                                mushroomSelected = true;
                                numSelected++;
                            }
                            else
                            {
                                mushroomSelected = false;
                                numSelected--;
                            }
                        }
                        break;
                    case '3':
                        {
                            if(!onionSelected)
                            {
                                onionSelected = true;
                                numSelected++;
                            }
                            else
                            {
                                onionSelected = false;
                                numSelected--;
                            }
                        }
                        break;
                    case '4':
                        {
                            if (!pepperSelected)
                            {
                                pepperSelected = true;
                                numSelected++;
                            }
                            else
                            {
                                pepperSelected = false;
                                numSelected--;
                            }
                        }
                        break;
                    case '5':
                        {
                            for (int index = 0; index < numSelected; ++index)
                            {
                                if (oliveSelected)
                                {
                                    vegtables[index] = "Black Olives";
                                    oliveSelected = false;
                                    totalPrice += 0.50m;
                                }
                                else if (mushroomSelected)
                                {
                                    vegtables[index] = "Mushrooms";
                                    totalPrice += 0.50m;
                                    mushroomSelected = false;
                                }
                                else if (onionSelected)
                                {
                                    vegtables[index] = "Onions";
                                    totalPrice += 0.50m;
                                    onionSelected = false;
                                }
                                else if (pepperSelected)
                                {
                                    vegtables[index] = "Peppers";
                                    totalPrice += 0.50m;
                                    pepperSelected = false;
                                }
                            }
                            return true;
                        }
                    default: Console.WriteLine($"Please enter a valid Value."); break;
                }

            }
        }

        private static bool GetPizzaSauce()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Please choose one of the following pizza sauces");
                Console.WriteLine("1) Traditional($0)");
                Console.WriteLine("2) Garlic($1)");
                Console.WriteLine("3) Oregano($1)");

                string input = Console.ReadLine();
                switch (input[0])
                {
                    case '1':
                        {
                            sauce = "Traditional";
                            saucePrice = 0.00m;
                            return true;
                        }
                    case '2':
                        {
                            totalPrice += 1.00m;
                            saucePrice = 1.00m;
                            sauce = "Garlic";
                            return true;
                        }
                    case '3':
                        {
                            totalPrice += 1.00m;
                            saucePrice = 1.00m;
                            sauce = "Oregano";
                            return true;
                        }
                    default: Console.WriteLine("Please enter a Value. between 1-3"); break;
                }
            }
        }

        private static bool GetPizzaCheese()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Please choose either the regular amount of cheese or extra cheese");
                Console.WriteLine("1) Regular($0)");
                Console.WriteLine("2) Extra($1.25)");

                string input = Console.ReadLine();
                switch (input[0])
                {
                    case '1':
                        {
                            cheese = "Regular";
                            cheesePrice = 0.00m;
                            return true;
                        }
                    case '2':
                        {
                            totalPrice += 1.25m;
                            cheesePrice = 1.25m;
                            cheese = "Extra";
                            return true;
                        }
                    default: Console.WriteLine("Please enter a Value. between 1 and 2"); break;
                }
            }
        }

        private static bool GetPizzaDelivery()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Please choose between take out or delivery");
                Console.WriteLine("1) Take Out($0)");
                Console.WriteLine("2) Delivery($2.50)");

                string input = Console.ReadLine();
                switch (input[0])
                {
                    case '1':
                        {
                            delivery = "Take Out";
                            return true;
                        }
                    case '2':
                        {
                            totalPrice += 2.50m;
                            deliveryPrice = 2.50m;
                            delivery = "Delivery";
                            return true;
                        }
                    default: Console.WriteLine("Please enter a Value. between 1 and 2"); break;
                }
            }
        }

        private static void ModifyOrder()
        {
            Console.Clear();
            Console.WriteLine("Modify Order");
            if (String.IsNullOrEmpty(pizzaSize))
            {
                Console.WriteLine("You have not made an order to modify yet.\nPress enter to continue");
                Console.ReadLine();
                DisplayMenu();
            }
        }

        private static void DisplayOrder()
        {
            Console.Clear();
            if (String.IsNullOrEmpty(pizzaSize))
            {
                Console.WriteLine("You have not made an order to Display yet yet.\nPress enter to continue");
                Console.ReadLine();
                DisplayMenu();
            }
            Console.WriteLine("Your Order is:");
            Console.WriteLine($"{pizzaSize}         ${sizePrice}");
            Console.WriteLine($"{delivery}          ${deliveryPrice}");
            if (!String.IsNullOrEmpty(meats[0]))
            {
                Console.WriteLine("Meats - $0.75 for each one");
                foreach (string meat in meats)
                {
                    if (!String.IsNullOrEmpty(meat))
                    {
                        Console.WriteLine($"   {meat}");
                    }
                }
            }
            if (!String.IsNullOrEmpty(vegtables[0]))
            {
                Console.WriteLine("Vegtables - $0.50 for each one");
                foreach (string veggie in vegtables)
                {
                    if (!String.IsNullOrEmpty(veggie))
                    {
                        Console.WriteLine($"   {veggie}");
                    }
                }
            }
            Console.WriteLine($"{cheese} cheese     ${cheesePrice}");
            Console.WriteLine($"{sauce} sauce       ${saucePrice}");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"Total               ${totalPrice}");

            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            DisplayMenu();
        }
        static decimal totalPrice = 0.00m;
        static string pizzaSize;
        static decimal sizePrice = 0.00m;
        static string[] meats = new string[4];
        static string[] vegtables = new string[4];
        static string sauce;
        static decimal saucePrice = 0.00m;
        static string cheese;
        static decimal cheesePrice = 0.00m;
        static string delivery;
        static decimal deliveryPrice = 0.00m;
    }
}
