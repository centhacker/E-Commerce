using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Commerce.DevMod.Models
{
    public class MOrderLine
    {
        public string id { get; set; }
        public string OrderId { get; set; }
        public string ProductId { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Price { get; set; }
        public string color { get; set; }
        public string units { get; set; }
        public string SubTotal { get; set; }
        public string BrandId { get; set; }
        public string CategoryId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone1 { get; set; }
        public string AdditionalPhoneNumber { get; set; }
        public string AlternateEmail { get; set; }
    }
}