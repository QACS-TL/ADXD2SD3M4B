using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    /// <summary>
    /// The BetterCustomer class can happily delegate the logging activity
    /// to  the FileLogger class and can concentrate on customer
    /// related activities. However, it is still being instantiated from
    /// within the BetterCustomer class which still means the BetterCustomer
    /// has more than one responsibility.
    /// </summary>
    public class B_BetterCustomer
    {
        private FileLogger fileLogger = new FileLogger();
        public virtual void AddToMailingList(string MailingListDetails)
        {
            try
            {
                //Code to validate and format mailing list details and add them to database goes here
                throw new Exception(MailingListDetails);
            }
            catch (Exception ex)
            {
                fileLogger.Handle(ex.Message);
            }
        }
    }
}
