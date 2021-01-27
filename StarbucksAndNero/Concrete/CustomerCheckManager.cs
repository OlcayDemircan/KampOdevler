using System;
using System.Collections.Generic;
using System.Text;
using StarbucksAndNero.Abstract;
using StarbucksAndNero.Entities;

namespace StarbucksAndNero.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
