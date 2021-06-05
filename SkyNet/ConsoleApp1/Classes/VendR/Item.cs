using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SkyNetOS
{
    public class Item
    {
        public string Slot { get; private set; }
        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public string Type { get; private set; }
        public int Stock { get; set; }
        public string Sound 
        { 
            get 
            {
                if (this.Type =="Chip")
                {
                    return "Crunch Crunch, Yum!";
                }
                else if (this.Type == "Candy")
                {
                    return "Munch Munch, Yum!";
                }
                else if(this.Type == "Drink")
                {
                    return "Glug Glug, Yum!";
                }
                else if(this.Type == "Gum")
                {
                    return "Chew Chew, Yum!";
                }
                else
                {
                    return "SOMETHING WENT WRONG!";
                }
            } 
        }

        public static List<Item> Inventory = new List<Item>();


        public static void StockInventory()
        {
            
            using (StreamReader inputFile = new StreamReader(@"C:\Users\Student\Desktop\Sideprojects\SkyNetConsoleApp\SkyNetConsoleAppPreAlpa\SkyNet\ConsoleApp1\InputFiles\vendingmachine.csv"))
            {
                while (!inputFile.EndOfStream)
                {
                   //[0]      [1]      [2]  [3]
                    //A1|Potato Crisps|3.05|Chip
                    
                    string line = inputFile.ReadLine();

                    string[] words = line.Split('|');

                    Item currentItem = new Item(words[0], words[1], Decimal.Parse(words[2]), words[3]); // creates each item


                    // Add each word to allItems
                    Inventory.Add(currentItem);
                }
            }
        }
        public Item(string slot, string name, decimal price, string type)
        {
            this.Slot = slot;
            this.Name = name;
            this.Price = price;
            this.Type = type;
            this.Stock = 5;
        }
    }
}
