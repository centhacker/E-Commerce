using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Commerce.DevMod.Classes
{
    public class CCategory
    {

        public List<Models.MCategory> GetAll() 
        {
            List<Models.MCategory> getAll = new List<Models.MCategory>();
            var q = from o in DBMod.CDBHandler.cdc.CategoryMasters
                    select o;
            foreach (var item in q)
            {
                Models.MCategory mc = new Models.MCategory();
                mc.Code = item.Code;
                mc.id = item.id.ToString();
                mc.Name = item.Name.ToString();
                mc.Count = q.Count().ToString();
                getAll.Add(mc);
            }
            return getAll;
        }
        public int Save(Models.MCategory mb)
        {
            try
            {
                DBMod.CategoryMaster cm = new DBMod.CategoryMaster();
                cm.Code = mb.Code;
                cm.Name = mb.Name;
                DBMod.CDBHandler.cdc.CategoryMasters.InsertOnSubmit(cm);
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