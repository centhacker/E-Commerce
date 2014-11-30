using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Commerce.DBMod
{
    public class CDBHandler
    {
        CDBHandler() 
        {
            //cleaning garbage value
            cdc = null;
        }
        public static CommerceDataContext cdc = new CommerceDataContext();
    }
}