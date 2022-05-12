using ShopApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Services
{
    public class ApplicationService
    {
        private ShopService _shopService;
        public ApplicationService()
        {
            _shopService = new ShopService();
        }
        public void Process(string command)
        {
            if (command.StartsWith("ADD"))
            {
                try
                {
                    string[] splitComand = command.Split(" ");
                    _shopService.Add(splitComand[1], decimal.Parse(splitComand[2]), int.Parse(splitComand[3]));
                }
                catch
                {
                    Console.WriteLine("Comand was incorrect");
                }
            }
            else if (command.StartsWith("REMOVE"))
            {
                string[] splitCommand = command.Split(" ");
                _shopService.Remove(splitCommand[1]);
            }
            else if (command.Equals("SHOW INVENTORY"))
            {
                List<ShopItem> Items = _shopService.ShowInventory();
                foreach (ShopItem item in Items)
                {
                    Console.WriteLine($"ItemName: {item.Name} ItemPrice: {item.Price} ItemQuantity: {item.Quantity}");
                }
            }
            else if (command.StartsWith("SET"))
            {
                string[] splitCommand = command.Split(" ");
                _shopService.Update(splitCommand[1], int.Parse(splitCommand[2]));
            }
            else if (command.StartsWith("SHOW BALANCE"))
            {
                _shopService.Balance();
            }
            else if (command.StartsWith("BUY"))
            {
                string[] splitCommand = command.Split(" ");
                _shopService.Buy(splitCommand[1], int.Parse(splitCommand[2]));
            }
            else if (command.StartsWith("TOP UP"))
            {
                _shopService.TopUp();
            }
            else if (command.Equals("SHOW ITEMS"))
            {
                List<BoughtItem> Items = _shopService.ShowItems();
                Items.ForEach(item => Console.WriteLine($"BoughtItem: {item.Name} BoughtQuantity: {item.Quantity}"));
            }
            else if (command.StartsWith("EXIT"))
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("The command was not recognized");
            }
        }
    }
}
