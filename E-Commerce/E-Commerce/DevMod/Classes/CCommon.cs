using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Commerce.DevMod.Classes
{
    public class CCommon
    {
        public class CViewObjects
        {
            public List<Models.MCommon.MViewObjects.MViewProducts> GetAllNewArrivals()
            {
                List<Models.MCommon.MViewObjects.MViewProducts> allNewArrivals = new List<Models.MCommon.MViewObjects.MViewProducts>();
                List<Models.MProducts> allProducts = new List<Models.MProducts>();
                List<Models.MNewArrivals> allRawNewArrivals = new List<Models.MNewArrivals>();
                List<Models.MProductContainer> allProductsContainer = new List<Models.MProductContainer>();
                List<Models.MSize> allSizes = new List<Models.MSize>();

                Classes.CNewArrivals cNewArrvivals = new CNewArrivals();
                Classes.CProducts cp = new CProducts();
                Classes.CProductContainer cpc = new CProductContainer();
                Classes.CSize cs = new CSize();


                allRawNewArrivals = cNewArrvivals.GetAll();
                allProducts = cp.GetAll();
                allProductsContainer = cpc.GetAll();
                allSizes = cs.GetAll();



                foreach (var item in allRawNewArrivals)
                {
                    Models.MCommon.MViewObjects.MViewProducts newArrivals = new Models.MCommon.MViewObjects.MViewProducts();
                    newArrivals.ProductId = item.ProductId;
                    newArrivals.Description = (from o in allProducts
                                               where o.id == item.ProductId
                                               select o.Description).FirstOrDefault();
                    newArrivals.DiscountedPercent = (from o in allProductsContainer
                                                     where o.ProductId == item.ProductId
                                                     select o.DiscountedPercent).FirstOrDefault();
                    newArrivals.ImageUrl1 = (from o in allProducts
                                             where o.id == item.ProductId
                                             select o.ImageUrl1).FirstOrDefault();
                    newArrivals.Name1 = (from o in allProducts
                                         where o.id == item.ProductId
                                         select o.Name1).FirstOrDefault();
                    newArrivals.New = "New";
                    newArrivals.ProductId = item.ProductId;
                    List<Models.MProductContainer> tempallProductsContainer = allProductsContainer.Where(o => o.ProductId == item.ProductId).ToList();
                    foreach (var p in tempallProductsContainer)
                    {

                        newArrivals.Size += (from o in allSizes
                                             where o.id == p.SizeId
                                             select o.Size).FirstOrDefault() + " / ";
                    }
                    newArrivals.Price = (from o in allProducts
                                         where o.id == item.ProductId
                                         select o.Price).FirstOrDefault();
                    allNewArrivals.Add(newArrivals);

                }


                
                return allNewArrivals;
            }



            public List<Models.MCommon.MViewObjects.MViewProducts> GetAllFeaturedProducts()
            {
                List<Models.MCommon.MViewObjects.MViewProducts> allFeaturedProducts = new List<Models.MCommon.MViewObjects.MViewProducts>();
                List<Models.MProducts> allProducts = new List<Models.MProducts>();
                List<Models.MNewArrivals> allRawNewArrivals = new List<Models.MNewArrivals>();
                List<Models.MProductContainer> allProductsContainer = new List<Models.MProductContainer>();
                List<Models.MSize> allSizes = new List<Models.MSize>();

                Classes.CNewArrivals cNewArrvivals = new CNewArrivals();
                Classes.CProducts cp = new CProducts();
                Classes.CProductContainer cpc = new CProductContainer();
                Classes.CSize cs = new CSize();


                allRawNewArrivals = cNewArrvivals.GetAll();
                allProducts = cp.GetAll();
                allProductsContainer = cpc.GetAll();
                allSizes = cs.GetAll();



                foreach (var item in allProducts)
                {
                    Models.MCommon.MViewObjects.MViewProducts newArrivals = new Models.MCommon.MViewObjects.MViewProducts();
                    newArrivals.ProductId = item.id;
                    newArrivals.Description = (from o in allProducts
                                               where o.id == item.id
                                               select o.Description).FirstOrDefault();
                    newArrivals.DiscountedPercent = (from o in allProductsContainer
                                                     where o.ProductId == item.id
                                                     select o.DiscountedPercent).FirstOrDefault();
                    newArrivals.ImageUrl1 = (from o in allProducts
                                             where o.id == item.id
                                             select o.ImageUrl1).FirstOrDefault();
                    newArrivals.Name1 = (from o in allProducts
                                         where o.id == item.id
                                         select o.Name1).FirstOrDefault();

                    newArrivals.ProductId = item.id;
                    List<Models.MProductContainer> tempallProductsContainer = allProductsContainer.Where(o => o.ProductId == item.id).ToList();
                    foreach (var p in tempallProductsContainer)
                    {

                        newArrivals.Size += (from o in allSizes
                                             where o.id == p.SizeId
                                             select o.Size).FirstOrDefault() + " / ";
                    }
                    newArrivals.Price = (from o in allProducts
                                         where o.id == item.id
                                         select o.Price).FirstOrDefault();
                    allFeaturedProducts.Add(newArrivals);

                }
                allFeaturedProducts = allFeaturedProducts.Take(8).ToList();
                return allFeaturedProducts;
            }

            public List<Models.MCommon.MViewObjects.MViewProducts> GetAllProducts()
            {
                List<Models.MCommon.MViewObjects.MViewProducts> allFeaturedProducts = new List<Models.MCommon.MViewObjects.MViewProducts>();
                List<Models.MProducts> allProducts = new List<Models.MProducts>();
                List<Models.MNewArrivals> allRawNewArrivals = new List<Models.MNewArrivals>();
                List<Models.MProductContainer> allProductsContainer = new List<Models.MProductContainer>();
                List<Models.MSize> allSizes = new List<Models.MSize>();

                Classes.CNewArrivals cNewArrvivals = new CNewArrivals();
                Classes.CProducts cp = new CProducts();
                Classes.CProductContainer cpc = new CProductContainer();
                Classes.CSize cs = new CSize();


                allRawNewArrivals = cNewArrvivals.GetAll();
                allProducts = cp.GetAll();
                allProductsContainer = cpc.GetAll();
                allSizes = cs.GetAll();



                foreach (var item in allProducts)
                {
                    Models.MCommon.MViewObjects.MViewProducts newArrivals = new Models.MCommon.MViewObjects.MViewProducts();
                    newArrivals.ProductId = item.id;
                    newArrivals.Description = (from o in allProducts
                                               where o.id == item.id
                                               select o.Description).FirstOrDefault();
                    newArrivals.DiscountedPercent = (from o in allProductsContainer
                                                     where o.ProductId == item.id
                                                     select o.DiscountedPercent).FirstOrDefault();
                    newArrivals.ImageUrl1 = (from o in allProducts
                                             where o.id == item.id
                                             select o.ImageUrl1).FirstOrDefault();
                    newArrivals.Name1 = (from o in allProducts
                                         where o.id == item.id
                                         select o.Name1).FirstOrDefault();

                    newArrivals.ProductId = item.id;
                    List<Models.MProductContainer> tempallProductsContainer = allProductsContainer.Where(o => o.ProductId == item.id).ToList();
                    foreach (var p in tempallProductsContainer)
                    {

                        newArrivals.Size += (from o in allSizes
                                             where o.id == p.SizeId
                                             select o.Size).FirstOrDefault() + " / ";
                    }
                    newArrivals.Price = (from o in allProducts
                                         where o.id == item.id
                                         select o.Price).FirstOrDefault();
                    allFeaturedProducts.Add(newArrivals);

                }
              
                return allFeaturedProducts;
            }
        }
    }
}