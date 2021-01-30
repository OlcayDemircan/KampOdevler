using System;
using System.Collections.Generic;
using System.Text;

namespace Gun5Odev5
{
    interface ICustomerManager
    {
        //Müşteri ekleme, güncelleme ve silme işlemi yapan "CustomerManager Class" için "Interface
        void Add(Customer customer);

        void Update(Customer customer);

        void Delete(Customer customer);
    }
}
