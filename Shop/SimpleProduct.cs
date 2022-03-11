using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class SimpleProduct : Product
    {
        public SimpleProduct(int data, int count)
        {
            Data = data;
            Count = count;
            FinaleCost = Cost;
            Catagory = "Simple";
        }
    }
}
