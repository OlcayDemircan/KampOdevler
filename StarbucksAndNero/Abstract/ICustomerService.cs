using System;
using System.Collections.Generic;
using System.Text;
using StarbucksAndNero.Entities;

namespace StarbucksAndNero.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
    }
}
