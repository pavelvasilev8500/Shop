using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class PercentDiscountProduct : Product
    {
        private double DiscountPercent { get; set; }
        public PercentDiscountProduct(int data, int count, double discountpercent)
        {
            Data = data;
            Count = count;
            DiscountPercent = discountpercent;
            FinaleCost = Cost * (1-DiscountPercent/100);
            Catagory = "Percent";
        }
    }
}
