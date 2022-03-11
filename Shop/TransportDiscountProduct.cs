using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class TransportDiscountProduct : Product
    {
        private double TransportDiscount { get; set; } = 5;
        public TransportDiscountProduct(int data, int count)
        {
            Data = data;
            Count = count;
            FinaleCost = Cost - TransportDiscount;
            Catagory = "Transport";
        }
    }
}
