using ShopApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Services
{
    public class ShopService
    {
        private List<ShopItem> _items;
        public ShopService()
        {
            _items = new List<ShopItem>();
        }
        public void Add(string name, string quantity)
        {
            ShopItem item = new ShopItem()
            {
                Name = name,
                Quantity = quantity
            };
            if (!_items.Any(x => x.Name == name))
            {
                _items.Add(item);
            }
            else
            {
                Console.WriteLine("This item already exists!");
            }
        }
        public void Remove(string name)
        {
            _items = _items.Where(i => i.Name != name).ToList();
        }
        public List<ShopItem> ShowInventory()
        {
            return _items;
        }
        public void Update(string name, string quantity)
        {
            foreach (ShopItem item in _items)
            {
                if (item.Name == name)
                {
                    item.Quantity = quantity;
                }
            }
        }
    }
}
