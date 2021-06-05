using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SkyNetOS
{
    public class Transaction
    {
        public static decimal userMoney = 0.00M;
        public static bool userAddingMoney = true;
        public static void PurchaceMenu()
        {

            Console.WriteLine("(1) Feed Money");
            Console.WriteLine("(2) Select Product");
            Console.WriteLine("(3) Finish Transaction");
            Console.WriteLine($"Current money provided ${userMoney}");


            Console.Write("\nSelect an option to continue: ");
            string userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                userAddingMoney = true;


                Console.Write("\nTo stop feeding money please enter anything other than a dollar amount\n");
                while (userAddingMoney)
                {
                    Console.Write("\nPlease insert money. ($1/$5/$10)bills only: $");
                    try
                    {
                        int addedMoney = int.Parse(Console.ReadLine());
                        userMoney += addedMoney;
                        LogGenerator.Log($"{DateTime.Now} FEED MONEY: ${addedMoney}.00 ${userMoney}");
                    }
                    catch (Exception ex)
                    {
                        userAddingMoney = false;
                    }
                }
                Console.Clear();
                PurchaceMenu();
            }

            else if (userChoice == "2")
            {
                Console.Clear();
                ListInventory();
                Console.WriteLine($"\n\nCurrent money available ${userMoney}");
                Purchase();
            }
            else if (userChoice == "3")
            {
                Console.Clear();
                Console.WriteLine(EndTransaction(userMoney));
                Thread.Sleep(4000);

                LogGenerator.Log($"-----------------Log End ({DateTime.Now})------------------\n");
                VendingMachine.MainMenu();
            }
            else
            {
                Console.Clear();
                PurchaceMenu();
            }
        }
        public static void Purchase()
        {
            userAddingMoney = false;
            Console.Write("\nTo select an item, enter its slot code (ex A1): ");
            string userItemChoice = Console.ReadLine();

            if (!Item.Inventory.Exists(currentItem => currentItem.Slot.ToLower() == userItemChoice.ToLower()))
            {
                Console.WriteLine("This item does not exist... Returning to the purchase menu.");
                Thread.Sleep(4000);
                Console.Clear();
                PurchaceMenu();
            }

            foreach (Item currentItem in Item.Inventory)
            {


                if (currentItem.Slot == userItemChoice || currentItem.Slot.ToLower() == userItemChoice.ToLower())
                {
                    if (currentItem.Stock > 0)
                    {
                        if (currentItem.Price < userMoney)
                        {
                            currentItem.Stock -= 1;
                            userMoney -= currentItem.Price;
                            Console.WriteLine($"\nDispensing {currentItem.Name}, {currentItem.Price} \nYou have ${userMoney} \n{currentItem.Sound}\n\n\n\n\n");
                            LogGenerator.Log($"{DateTime.Now} {currentItem.Name} {currentItem.Slot}: ${userMoney + currentItem.Price} ${userMoney}");

                        }
                    }
                    else if (currentItem.Stock == 0)
                    {
                        Console.WriteLine("Item is sold out please choose another item.");
                        Thread.Sleep(4000);
                        Console.Clear();
                        PurchaceMenu();
                    }

                }

            }
            PurchaceMenu();
        }

        public static string EndTransaction(decimal endingMoney)
        {
            LogGenerator.Log($"{DateTime.Now} GIVE CHANGE: ${endingMoney} $0.00 ");
            decimal dollars = 0, quarters = 0, dimes = 0, nickels = 0;
            while (endingMoney >= 1.00m)
            {
                dollars = Math.Truncate((endingMoney / 1.00m));
                endingMoney = endingMoney % 1.00m;
            }
            while (endingMoney >= 0.25m)
            {
                quarters = Math.Truncate((endingMoney / 0.25m));
                endingMoney = endingMoney % 0.25m;
            }
            while (endingMoney >= 0.10m)
            {
                dimes = Math.Truncate((endingMoney / 0.10m));
                endingMoney = endingMoney % 0.10m;
            }
            while (endingMoney >= 0.05m)
            {
                nickels = Math.Truncate((endingMoney / 0.05m));
                endingMoney = endingMoney % 0.05m;
            }

            return $"Dispensing change dollars: {dollars}, quarters: {quarters}, dimes: {dimes}, nickels: {nickels}";

        }

        public static void ListInventory()
        {
            foreach (Item currentItem in Item.Inventory)
            {

                if (currentItem.Stock == 0)
                {
                    Console.WriteLine(currentItem.Slot + "|" + currentItem.Name + "|" + currentItem.Price + "|" + currentItem.Type + "|" + "SOLD OUT");

                }
                else if (currentItem.Stock != 0)
                {
                    Console.WriteLine(currentItem.Slot + "|" + currentItem.Name + "|" + currentItem.Price + "|" + currentItem.Type + "|" + currentItem.Stock);
                }

            }
        }
    }
}
