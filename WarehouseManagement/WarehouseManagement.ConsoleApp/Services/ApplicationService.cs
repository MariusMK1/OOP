using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagement.ConsoleApp.Services
{
    public class ApplicationService
    {
        private WarehouseService _warehouseService;
        public ApplicationService()
        {
            _warehouseService = new WarehouseService();
        }
        public void Process (string command)
        {
            if(command.StartsWith("Add"))
            {
                string[] splitCommand = command.Split(" ");
                _warehouseService.Add(splitCommand[1], splitCommand[2]);
            }
            else if (command.StartsWith("Remove"))
            {
                string[] splitCommand = command.Split(" ");
                _warehouseService.Remove(splitCommand[1]);
            }
            else if (command.StartsWith("List"))
            {
                List<WarehouseItem> items = _warehouseService.GetAll();
                foreach(var item in items)
                {
                    //Console.WriteLine("ItemName: " + item.Name + " ItemPrice: " + item.Price);
                    Console.WriteLine($"ItemName: {item.Name} ItemPrice: {item.Price}");
                }
            }
            else if (command.StartsWith("Exit"))
            {
                throw new Exception();
            }
            else
            {
                Console.WriteLine("Incorrect command");
            }
            // Interpretet if command is valid
            // Parse the command type and information
            // Call appropiate WarehouseService command
        }
    }
}
