using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class ShopManager
    {
        public void Manager()
        {
            var shopList = new ShopList();
            shopList.SortShopList();
            shopList.ShowShopList();
            shopList.MachShopList();
            shopList.SortByCatagory();
        }
    }
}
