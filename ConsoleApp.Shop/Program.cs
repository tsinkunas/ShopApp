using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("----------------------------\n" +
                    "List - Show all items in the shop\n" +
                    "Buy - buy some items (Example: Buy Candy 20)\n" +
                    "Add - add new items (Example: Add Cup 30)\n" +
                    "Exit - exit from the program\n" +
                    "-----------------------------\n" +
                    "please select a command:");
            string inputArray = Console.ReadLine();
            inputArray = inputArray.ToLower();
            string[] input = inputArray.Split(" ");
            var shop = new Shop();
                      
            while (input[0] != "exit")
            {
                try
                {
                    switch (input[0])
                    {
                        case "list":
                            shop.List();
                            break;

                        case "buy":
                            shop.Buy(input[1], input[2]);
                            break;

                        case "add":
                            shop.Add(input[1], input[2]);
                            break;

                        default:
                            Console.WriteLine("Wrong command, please try again!");
                            break;

                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong command, please try again!");
                }
                inputArray = Console.ReadLine();
                inputArray = inputArray.ToLower();
                input = inputArray.Split(" ");
            }

        }
    }
}
