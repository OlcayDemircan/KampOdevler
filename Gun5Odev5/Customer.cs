using System;
using System.Collections.Generic;
using System.Text;

namespace Gun5Odev5
{
    class Customer
    {
        //Müşteri bilgilerini tutan Class
        public int Id { get; set; }
        public long NationalityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
