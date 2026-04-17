using OpenClosedPrinciple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    public class PlatinumCustomer : B_GoodCustomer
    {
        public override decimal GetDiscountedPrice(decimal TotalSales)
        {
            return TotalSales - 15 * TotalSales / 100;
        }
    }
}

