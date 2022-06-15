using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class DataOperation
    {
        public List<(string cutomerName, double purchaseAmount, DateTime purchaseDate)> MergeData(List<Customer> customers, List<Purchase> purchases)
        {
            var query = from c in customers
                        join p in purchases
                        on c.Id equals p.CustomerId
                        select (c.Name, p.Amount, p.PurchasedOn);
            return (List<(string cutomerName, double purchaseAmount, DateTime purchaseDate)>)query;
        }
    }
}
