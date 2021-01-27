using StarbucksAndNero.Abstract;
using StarbucksAndNero.Concrete;
using StarbucksAndNero.Entities;
using StarbucksAndNero.Adapters;
using MernisServiceReference;
using System;

namespace StarbucksAndNero
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            Customer customer = new Customer { DateofBirth = new DateTime(1981, 3, 31), FirstName = "Olcay", LastName = "Demircan", NationalityId = "11035944412" };
            customerManager.Save(customer);

        }
    }
}
