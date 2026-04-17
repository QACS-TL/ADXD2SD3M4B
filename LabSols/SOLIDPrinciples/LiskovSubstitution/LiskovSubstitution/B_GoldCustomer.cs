using System;
using System.Runtime.InteropServices.Marshalling;

namespace LiskovSubstitution
{
    public class B_GoldCustomer : B_GoodCustomer
    {
        public B_GoldCustomer(FileLogger logger ) : base(logger)
        {

        }

        public B_GoldCustomer():this(new FileLogger())
        {
                
        }

        public override decimal GetDiscountedPrice(decimal price)
        {
            return price - (price * 10 / 100);
        }



    }
}
