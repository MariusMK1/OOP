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
        private List<BoughtItem> _boughtItems;
        public decimal _customerBalance;
        public ShopService()
        {
            _items = new List<ShopItem>();
            _boughtItems = new List<BoughtItem>();
            _customerBalance = 20.0M;
        }
        public void Add(string name, decimal price, int quantity)
        {
            ShopItem item = new ShopItem()
            {
                Name = name,
                Price = price,
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
        public List<BoughtItem> ShowItems()
        {
            return _boughtItems;
        }
        public void Update(string name, int quantity)
        {
            foreach (ShopItem item in _items)
            {
                if (item.Name == name)
                {
                    item.Quantity = quantity;
                }
            }
        }
        public void Buy(string name, int quantity)
        {
            if (_items.Any(x => x.Name == name))
            {
                if ((_items.Where(n => n.Name == name).Select(n => n.Quantity).First()) >= quantity)
                {
                    decimal boughtForPrice = (_items.Where(n => n.Name == name).Select(n => n.Price).First()) * quantity;
                    if (boughtForPrice <= _customerBalance)
                    {
                        BoughtItem item = new BoughtItem()
                        {
                            Name = name,
                            Quantity = quantity
                        };
                        if (!_boughtItems.Any(x => x.Name == name))
                        {
                            _boughtItems.Add(item);
                        }
                        else
                        {
                            _boughtItems = _boughtItems.Where(n => n.Name == name).Select(n => { n.Quantity += quantity; return n; }).ToList();
                        }
                        _customerBalance -= boughtForPrice;
                    }
                    else
                    {
                        Console.WriteLine("Customer does not have enough funds");
                    }
                }
                else
                {
                    Console.WriteLine("There is not enough stock of this item");
                }
            }
            else
            {
                Console.WriteLine("shop item is not found");
            }
        }
        public void Balance()
        {
            Console.WriteLine($"Your balance is: {_customerBalance}");
        }
        public void TopUp()
        {
            _customerBalance = 20.0M;
        }
    }
}
