using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class ShopList
    {
        public List<Product> products;
        
        public void GetShopList()
        {
            products = new List<Product>()
            {
                new SimpleProduct(5, 5),
                new PercentDiscountProduct(4, 3, 5),
                new SimpleProduct(2, 10),
                new TransportDiscountProduct(8, 10),
                new SimpleProduct(10, 3),
                new BonusDiscountProduct(10, 3),
                new TransportDiscountProduct(1, 11),
                new SimpleProduct(6, 5),
                new BonusDiscountProduct(25, 3),
                new PercentDiscountProduct(31, 10, 8),
            };
        }

        public void SortShopList()
        {
            Console.WriteLine("Sorted Shop List:\n");
            GetShopList();
            var sortShopList = from list in products
                               orderby list.Data
                               select list;
            foreach(Product pr in sortShopList)
            {
                Console.WriteLine("+-----------------------+\n" +
                  $"|Product: {pr.ProductName}\n" +
                  $"|Cost: {pr.Cost}\n" +
                  $"|Data: {pr.Data}\n" +
                  $"|Count: {pr.Count}\n" +
                  $"|Final Cost {pr.FinaleCost}\n" +
                  "+-----------------------+\n");
            }
        }

        public void ShowShopList()
        {
            Console.WriteLine("Shop List:\n");
            GetShopList();
            foreach (Product pr in products)
            {
                Console.WriteLine("+-----------------------+\n" +
                                  $"|Product: {pr.ProductName}\n" +
                                  $"|Cost: {pr.Cost}\n" +
                                  $"|Data: {pr.Data}\n" +
                                  $"|Count: {pr.Count}\n" +
                                  $"|Final Cost {pr.FinaleCost}\n" +
                                  "+-----------------------+\n");
            }
        }

        public void MachShopList()
        {
            Console.WriteLine("The product was purchased on the 10th :\n");
            GetShopList();
            foreach(Product pr in products)
            {
                if(pr.Data == 10)
                {
                    Console.WriteLine("+-----------------------+\n" +
                                      $"|Product: {pr.ProductName}\n" +
                                      $"|Cost: {pr.Cost}\n" +
                                      $"|Data: {pr.Data}\n" +
                                      $"|Count: {pr.Count}\n" +
                                      $"|Final Cost {pr.FinaleCost}\n" +
                                      "+-----------------------+\n");
                }
            }
        }

        public void SortByCatagory()
        {
            Console.WriteLine("Sort Shop List by catagory:\n");
            GetShopList();
            var simpleShopList = from list in products
                                  where list.Catagory == "Simple"
                                  select list;
            Console.WriteLine("Sorted by Simple:\n");
            foreach(Product pr in simpleShopList)
            {
                Console.WriteLine("+-----------------------+\n" +
                                  $"|Catagory: {pr.Catagory}\n" +
                                  $"|Product: {pr.ProductName}\n" +
                                  $"|Cost: {pr.Cost}\n" +
                                  $"|Data: {pr.Data}\n" +
                                  $"|Count: {pr.Count}\n" +
                                  $"|Final Cost {pr.FinaleCost}\n" +
                                  "+-----------------------+\n");
            }
            var percentShopList = from list in products
                                 where list.Catagory == "Percent"
                                 select list;
            Console.WriteLine("Sorted by Percent:\n");
            foreach (Product pr in percentShopList)
            {
                Console.WriteLine("+-----------------------+\n" +
                                  $"|Catagory: {pr.Catagory}\n" +
                                  $"|Product: {pr.ProductName}\n" +
                                  $"|Cost: {pr.Cost}\n" +
                                  $"|Data: {pr.Data}\n" +
                                  $"|Count: {pr.Count}\n" +
                                  $"|Final Cost {pr.FinaleCost}\n" +
                                  "+-----------------------+\n");
            }
            var transportShopList = from list in products
                                  where list.Catagory == "Transport"
                                  select list;
            Console.WriteLine("Sorted by Transport:\n");
            foreach (Product pr in transportShopList)
            {
                Console.WriteLine("+-----------------------+\n" +
                                  $"|Catagory: {pr.Catagory}\n" +
                                  $"|Product: {pr.ProductName}\n" +
                                  $"|Cost: {pr.Cost}\n" +
                                  $"|Data: {pr.Data}\n" +
                                  $"|Count: {pr.Count}\n" +
                                  $"|Final Cost {pr.FinaleCost}\n" +
                                  "+-----------------------+\n");
            }
            var bonusShopList = from list in products
                                  where list.Catagory == "Bonus"
                                  select list;
            Console.WriteLine("Sorted by Bonus:\n");
            foreach (Product pr in bonusShopList)
            {
                Console.WriteLine("+-----------------------+\n" +
                                  $"|Catagory: {pr.Catagory}\n" +
                                  $"|Product: {pr.ProductName}\n" +
                                  $"|Cost: {pr.Cost}\n" +
                                  $"|Data: {pr.Data}\n" +
                                  $"|Count: {pr.Count}\n" +
                                  $"|Final Cost {pr.FinaleCost}\n" +
                                  "+-----------------------+\n");
            }
        }
    }
}
