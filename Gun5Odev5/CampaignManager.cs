using System;
using System.Collections.Generic;
using System.Text;

namespace Gun5Odev5
{
    class CampaignManager : ICampaignManager
    {
        public void Discount(Game game)
        {
            
            Console.WriteLine(game.NameOfGame+" isimli ürün indirim kampanyasına alınmıştır. Fiyatı "+game.PriceOfGame+" TL'den"+game.PriceOfGame*0.8+" TL'ye indirilmiştir.");
        }

        public void TwoForOne(Game game)
        {
            Console.WriteLine(game.NameOfGame + " ürün 2 alan bir bedava kampanyasına alınmıştır.");
        }
    }
}
