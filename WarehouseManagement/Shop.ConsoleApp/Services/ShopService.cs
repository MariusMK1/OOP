using Shop.ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.ConsoleApp.Services
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
            _items.Add(item);
        }
        public void Remove(string name)
        {
            _items = _items.Where(i => i.Name != name).ToList();
        }
        public List<ShopItem> Show()
        {
            return _items;
        }
        public void Update(string name, string quantity)
        {
            foreach(ShopItem item in _items)
            {
                if(item.Name == name)
                {
                    item.Quantity = quantity;
                }
            }
        }
    }
}
