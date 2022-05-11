using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.ConsoleApp.Models
{
    public class ShopItem
    {
        public string Name { get; set; }
        public string Quantity { get; set; }
        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public bool Equals(ShopItem other)
        {
            return this.Name.Equals(other.Name);
        }
    }
}
