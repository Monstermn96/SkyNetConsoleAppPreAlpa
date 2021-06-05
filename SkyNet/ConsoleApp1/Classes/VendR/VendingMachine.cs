using System;
using System.Collections.Generic;

namespace SkyNetOS
{
    public class VendingMachine
    {
        public static void VenderStart()
        {
            Item.StockInventory();//Stock Machine            
            MainMenu();
        }

        public static void MainMenu()
        {
            Console.WriteLine("Select an option to continue: ");
            Console.WriteLine("\n\n(1) Display Vending Machine Items");
            Console.WriteLine("(2) Purchase");
            Console.WriteLine("(3) Exit");
            Console.Write("\nChoice: ");
            string userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                Console.Clear();
                //ListInventory(Item.Inventory);
                Console.WriteLine(ListInventory(Item.Inventory));
                Console.Write("\n\n To return to Main Menu press enter.");
                string returntoMenu = Console.ReadLine();

                if (returntoMenu != null)
                {
                    Console.Clear();
                    MainMenu();
                }
            }
            else if (userChoice == "2")
            {
                Console.Clear();
                LogGenerator.Log($"-----------------Log Start ({DateTime.Now})----------------");
                Transaction.PurchaceMenu();
            }
            else if (userChoice == "3")
            {
                Console.Clear();
                OSMain.Main();
            }
            else
            {
                Console.Clear();
                OSMain.Main();
            }
        }

        public static string ListInventory(List<Item> stock)
        {
            string stringToDisplay = "";
            foreach (Item currentItem in stock)
            {

                if (currentItem.Stock == 0)
                {
                    //Console.WriteLine(currentItem.Slot + "|" + currentItem.Name + "|" + currentItem.Price + "|" + currentItem.Type + "|" + "SOLD OUT");
                    stringToDisplay += (currentItem.Slot + "|" + currentItem.Name + "|" + currentItem.Price + "|" + currentItem.Type + "|" + "SOLD OUT\n");
                }
                else if (currentItem.Stock != 0)
                {
                    //Console.WriteLine(currentItem.Slot + "|" + currentItem.Name + "|" + currentItem.Price + "|" + currentItem.Type + "|" + currentItem.Stock);
                    stringToDisplay += (currentItem.Slot + "|" + currentItem.Name + "|" + currentItem.Price + "|" + currentItem.Type + "|" + currentItem.Stock + "\n");
                }
            }
            return stringToDisplay;
        }
    }
}
