using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Commerce.DevMod.Models
{
    public class MCommon
    {
        public class MViewObjects
        {
            public class MViewProducts
            {
                public string ProductId { get; set; }
                public string New { get; set; }
                public string DiscountedPercent { get; set; }
                public string ImageUrl1 { get; set; }
                public string Name1 { get; set; }
                public string Description { get; set; }
                public string Size { get; set; }
                public string Price { get; set; }


            }
        }


        public class MDataObjects
        { 
            [Serializable]
            public class MCartModal
            {
                public string ProductId { get; set; }
                public string Name { get; set; }
                public string Size { get; set; }
                public string Price { get; set; }
                public string TotalPrice { get; set; }
                public string Units { get; set; }
                public string Image { get; set; }
            }

            [Serializable]
            public class MSelectedItems
            {
                public string Value { get; set; }
                public string Text { get; set; }
            }

            [Serializable]
            public class MCheckOutDetails
            {
                public string FirstName { get; set; }
                public string LastName { get; set; }
                public string Email{ get; set; }
                public string Address { get; set; }
                public string Phone1 { get; set; }
                public string AdditionalPhoneNumber { get; set; }
                public string AlternateEmail { get; set; }
            }

            [Serializable]
            public class MCheckOutProductDetails
            {
                public string ProductId { get; set; }
                public string Name { get; set; }
                public string ImageUrl { get; set; }
                public string Price { get; set; }
                public string color { get; set; }
                public string units { get; set; }
            }
        }
    }
}