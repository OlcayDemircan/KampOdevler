using System;
using System.Collections.Generic;
using System.Text;
using StarbucksAndNero.Entities;
using StarbucksAndNero.Concrete;

namespace StarbucksAndNero.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
        

        
    }
}
