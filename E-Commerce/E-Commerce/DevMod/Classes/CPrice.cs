using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Commerce.DevMod.Classes
{
    public class CPrice
    {
        public List<Models.MPrice> GetAll() 
        {
            List<Models.MPrice> allPrices = new List<Models.MPrice>();
            var q = from o in DBMod.CDBHandler.cdc.PriceMasters
                    select o;
            foreach (var item in q)
            {
                Models.MPrice mp = new Models.MPrice();
                mp.From = item.FromPrice;
                mp.To = item.ToPrice;
                mp.id = item.id.ToString();
                allPrices.Add(mp);
            }
            return allPrices;
        }
    }
}