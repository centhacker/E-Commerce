using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Commerce.DevMod.Classes
{
    public class CColor
    {
        public List<Models.MColor> GetAll() 
        {
            List<Models.MColor> allColors = new List<Models.MColor>();
            var q = from o in DBMod.CDBHandler.cdc.ColorMasters
                    select o;
            foreach (var item in q)
            {
                Models.MColor mc = new Models.MColor();
                mc.id = item.id.ToString();
                mc.Name = item.Name;
                allColors.Add(mc);
            }
            return allColors;
        }
        public int Save(Models.MColor mb)
        {
            try
            {
                DBMod.ColorMaster cm = new DBMod.ColorMaster();
                cm.Name = mb.Name;
                DBMod.CDBHandler.cdc.ColorMasters.InsertOnSubmit(cm);
                DBMod.CDBHandler.cdc.SubmitChanges();
                return 1;
            }
            catch
            {
                return -1;

            }
        }
    }
}