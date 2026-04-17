using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceSegregation
{
    public class A_Enquiry : IDiscount
    {
        ILogger logger;

        public A_Enquiry(ILogger logger)
        {
            this.logger = logger;
        }

        decimal IDiscount.GetDiscount(decimal TotalSales)
        {
            //2% discount for enquiries
            return TotalSales - (TotalSales * 2/100);
        }
    }
}
