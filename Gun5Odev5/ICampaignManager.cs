using System;
using System.Collections.Generic;
using System.Text;

namespace Gun5Odev5
{
    interface ICampaignManager
    {
        //Kampanya Manager Class yapısına ait Interface
        void Discount(Game game);
        void TwoForOne(Game game);
    }
}
