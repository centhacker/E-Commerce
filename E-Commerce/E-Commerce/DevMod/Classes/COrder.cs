using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Commerce.DevMod.Classes
{
    public class COrder
    {
        public int Save(Models.MOrderMaster model, List<Models.MOrderLine> orderLine)
        {
            try
            {
                E_Commerce.DBMod.OrderMaster om = new DBMod.OrderMaster();

                om.Date = model.Date;
                om.OrderId = model.OrderId;
                om.total = model.Total;
                E_Commerce.DBMod.CDBHandler.cdc.OrderMasters.InsertOnSubmit(om);
                E_Commerce.DBMod.CDBHandler.cdc.SubmitChanges();
                int OrderId = DBMod.CDBHandler.cdc.OrderMasters.Max(o => o.id);
                for (int i = 0; i < orderLine.Count; i++)
                {

                    E_Commerce.DBMod.OrderLine mol = new E_Commerce.DBMod.OrderLine();
                    mol.AdditionalPhoneNumber = orderLine[i].AdditionalPhoneNumber;
                    mol.Address = orderLine[i].Address;
                    mol.AlternatEmail = orderLine[i].AlternateEmail;
                    mol.BrandId = orderLine[i].BrandId;
                    mol.CategoryId = orderLine[i].CategoryId;
                    mol.Color = orderLine[i].color;
                    mol.FirstName = orderLine[i].FirstName;
                    mol.Email = orderLine[i].Email;
                    mol.SubTotal = (Convert.ToSingle(orderLine[i].units) * Convert.ToSingle(orderLine[i].Price)).ToString();
                    mol.ProductImage = orderLine[i].ImageUrl;
                    mol.LastName = orderLine[i].LastName;
                    mol.Name = orderLine[i].Name;
                    mol.OrderId = OrderId.ToString();
                    mol.PhoneNumber1 = orderLine[i].Phone1;
                    mol.Price = orderLine[i].Price;
                    mol.ProductId = orderLine[i].ProductId;
                    mol.SubTotal = orderLine[i].SubTotal;
                    mol.Units = orderLine[i].units;
                    E_Commerce.DBMod.CDBHandler.cdc.OrderLines.InsertOnSubmit(mol);
                    E_Commerce.DBMod.CDBHandler.cdc.SubmitChanges();


                }
                return 1;
            }
            catch
            {
                return -1;

            }
        }
    }
}