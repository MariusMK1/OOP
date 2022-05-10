using Shop.ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.ConsoleApp.Services
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
            if (command.StartsWith("Add"))
            {
                string[] splitCommand = command.Split(" ");
                _shopService.Add(splitCommand[1], splitCommand[2]);
            }
            else if (command.StartsWith("Remove"))
            {
                string[] splitCommand = command.Split(" ");
                _shopService.Remove(splitCommand[1]);
            }
            else if (command.StartsWith("Show"))
            {
                List<ShopItem> Items = _shopService.Show();
                foreach(ShopItem item in Items)
                {
                    Console.WriteLine($"ItemName: {item.Name} ItemQuantity: {item.Quantity}");
                }
            }
            else if (command.StartsWith("Set"))
            {
                string[] splitCommand = command.Split(" ");
                _shopService.Update(splitCommand[1], splitCommand[2]);
            }
        }
    }
}
