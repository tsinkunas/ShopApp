using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Shop
{
    public class Shop
    {

        List<SellableItem> sellableItems = new List<SellableItem>
            {
                new SellableItem {Name = "Book", Quantity = 20},
                new SellableItem {Name = "Cup",  Quantity = 20},
                new SellableItem {Name = "Candy",  Quantity = 20},
            };


        public void List()
        {
            foreach (SellableItem sellableItem in sellableItems)
            {
                if (sellableItem.Quantity >= 0)
                {
                    Console.WriteLine($"Product: {sellableItem.Name} Quantity: {sellableItem.Quantity}");
                }

            }

        }
        public void Buy(string product, string quantity)
        {
           
            foreach (SellableItem sellableItem in sellableItems)
                {
                if (product == sellableItem.Name.ToLower())
                    {
                    if (Int32.Parse(quantity) <= sellableItem.Quantity)
                    {
                        sellableItem.Quantity = sellableItem.Quantity - Int32.Parse(quantity);
                        Console.WriteLine($"{sellableItem.Name}, of quantity: {quantity} is successfuly bought");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("We are sorry, but we do not have the quantity of this product");
                        return;
                    }
                    }
                    
                }
                Console.WriteLine("We are sorry, but this product is not available in the store");

        }

        public void Add(string product, string quantity)
        {
            foreach (SellableItem sellableItem in sellableItems)
            {
                if (product == sellableItem.Name.ToLower())
                {
                    sellableItem.Quantity = sellableItem.Quantity + Int32.Parse(quantity);
                    Console.WriteLine($"{sellableItem.Name}, of quantity: {quantity} is successfuly added");
                    return;
                    
                }

            }
            Console.WriteLine("We are sorry, but this product is not available in the store");
        }
    }
}
