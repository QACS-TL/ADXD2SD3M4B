using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    /// <summary>
    /// Old customer. Implements new ISaleV2 (which extends ISale)
    /// Thus old classes can continue to implement ISale whilst new classes
    /// can make use of (are forced to) implement the new features of the ISaleV2 interface
    /// </summary>
    public abstract class B_NewerCustomer:ISaleV2, IDiscount
    {
        protected ILogger logger;

        //Different kinds of logger (File, Event, Database...) can now be injected 
        public B_NewerCustomer(ILogger logger)
        {
            this.logger = logger;
        }

        public abstract decimal GetDiscount(decimal TotalSales);

        public virtual void AddSaleToDatabase(string product, decimal totalSales)
        {
            try
            {
                // Database code goes here
                logger.Handle($"product: {product} sold for {totalSales:C} and successfully logged to database");
            }
            catch (Exception exn)
            {
                logger.Handle(exn.Message);
            }
        }

        public virtual int RetrieveLoyaltyPoints()
        {
            // code to Read from the database goes here
            return 100;
        }

    }

}
