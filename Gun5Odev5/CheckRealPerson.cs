using System;
using System.Collections.Generic;
using System.Text;

namespace Gun5Odev5
{
    class CheckRealPerson : ICheckRealPerson
    {
        // Kayıt yaptırmak isteyenin gerçek kişi olup olmadığını sorgulayan Class yapısı. Bilgiler doğruysa "true" değeri döndürülür.
        public bool CheckPerson(Customer customer)
        {
            if (customer.NationalityId == 123456789 && customer.FirstName == "Olcay" && customer.LastName == "Demircan" && customer.DateOfBirth.Year == 1981)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
