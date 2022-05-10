using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagement.ConsoleApp.Services
{
    public class WarehouseService
    {
        private List<WarehouseItem> _items;
        public WarehouseService() //constructor
        {
            _items = new List<WarehouseItem>();
        }
        public void Add(string name, string price)
        {
            WarehouseItem item = new WarehouseItem()
            {
                Name = name,
                Price = price
            };
            _items.Add(item);
        }
        public void Remove(string name)
        {
            _items = _items.Where(i => i.Name != name).ToList();
        }
        public List<WarehouseItem> GetAll()
        {
            return _items;
        }
    }
}
