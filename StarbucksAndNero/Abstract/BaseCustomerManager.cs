using StarbucksAndNero.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarbucksAndNero.Abstract
{
   public abstract class  BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to dc : " + customer.FirstName);
        }
    }
}
