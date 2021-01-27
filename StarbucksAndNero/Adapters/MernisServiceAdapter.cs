using System;
using System.Collections.Generic;
using System.Text;
using MernisServiceReference;
using StarbucksAndNero.Abstract;
using StarbucksAndNero.Entities;
using StarbucksAndNero.Concrete;
using StarbucksAndNero.Adapters;


namespace StarbucksAndNero.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.NationalityId), customer.FirstName, customer.LastName, customer.DateofBirth.Year);

        }
    }
}
