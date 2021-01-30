using System;
using System.Collections.Generic;
using System.Text;

namespace Gun5Odev5
{
    interface ICheckRealPerson
    {
        // Müşterinin gerçek bir kişi olup olmadığını sorgulayan Class yapısının Interface yapısı
        bool CheckPerson(Customer customer);
    }
}
