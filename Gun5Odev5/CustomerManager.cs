using System;
using System.Collections.Generic;
using System.Text;
using MernisServiceReference;

namespace Gun5Odev5
{
    class CustomerManager : ICustomerManager
    {
        // Müşteri ekleme, bilgi güncelleme ve silme görevlerini tutan Class yapısı.

        //Burada ICheckRealPerson interface ile bir değişken tanımlıyoruz.
        ICheckRealPerson _checkRealPerson;

        //Aşağıdaki kodlar Customer Manager Class'ının "constructor" yapısıdır. Bu sayede _checkRealPerson değişkenine değer atıyoruz.
        public CustomerManager(ICheckRealPerson checkRealPerson)
        {
            _checkRealPerson = checkRealPerson;
        }

        public void Add(Customer customer)
        {
            // Kayıt yaptırmak isteyen kişinin gerçek olup olmadığının sonucuna göre kayıt işleminin yapılışı ya da kişiye hata mesajı gösterilmesi
            if (_checkRealPerson.CheckPerson(customer)==true)
            {
                Console.WriteLine("Sn. " + customer.FirstName + " " + customer.LastName + " kaydınız başarıyla yapılmıştır");
            }
            else
            {
                Console.WriteLine("Sn. " + customer.FirstName + " " + customer.LastName + " hatalı bilgi girdiniz. Lütfen kontrol edip tekrar deneyiniz.");
            }
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Sn. " + customer.FirstName + " " + customer.LastName + " kaydınız başarıyla silinmiştir.");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Sn. " + customer.FirstName + " " + customer.LastName + " kaydınız başarıyla yenilenmiştir.");
        }
    }
}
