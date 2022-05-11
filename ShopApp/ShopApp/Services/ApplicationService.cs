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

        }
    }
}
