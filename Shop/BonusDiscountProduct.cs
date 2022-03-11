using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class BonusDiscountProduct : Product
    {
        private double BonuProductCost { get; set; } = 8;
        public BonusDiscountProduct(int data, int count)
        {
            Data = data;
            Count = count;
            FinaleCost = Cost - BonuProductCost;
            Catagory = "Bonus";
        }
    }
}
