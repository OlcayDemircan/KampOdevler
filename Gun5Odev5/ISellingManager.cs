using System;
using System.Collections.Generic;
using System.Text;

namespace Gun5Odev5
{
    interface ISellingManager
    {
        //Satış yönetimi yapılan sınıfın Interface yapısı
        void AddBasket(Customer customer, Game game);

        void Buy(Customer customer, Game game);
    }
}
