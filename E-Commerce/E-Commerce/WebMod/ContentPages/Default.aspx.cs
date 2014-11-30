using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Commerce.WebMod.ContentPages
{
    public partial class Default : System.Web.UI.Page
    {

        #region page functions
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindNewArrivals();
                BindSubCategories();
                CacheData();
            }
        }



        protected void btnLoadMoreProducts_Click(object sender, EventArgs e)
        {

        }

        protected void repFeaturedProducts_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

            //cm.Masterlbltemp.Text = "123123123";
            string CommandName = e.CommandName;
            string CommandArgument = e.CommandArgument.ToString();
            switch (CommandName)
            {
                case "AddToCart":
                    {

                        BindCartModal(CommandArgument);
                        break;
                    }
                case "ProductDescription":
                    {
                        break;
                    }
                default:
                    break;
            }
        }

        protected void repNewArrivals_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            string CommandName = e.CommandName;
            string CommandArgument = e.CommandArgument.ToString();
            switch (CommandName)
            {
                case "AddToCart":
                    {

                        BindCartModal(CommandArgument);
                        break;
                    }
                case "ProductDescription":
                    {
                        OpenAllProductDetails(CommandArgument);
                        break;
                    }
                default:
                    break;
            }

        }

        protected void repFeaturedCategories_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            string CommandName = e.CommandName;
            string CommandArgument = e.CommandArgument.ToString();
            switch (CommandName)
            {
                case "AddToCart":
                    {

                        BindCartModal(CommandArgument);
                        break;
                    }
                case "ProductDescription":
                    {
                        OpenAllProductDetails(CommandArgument);
                        break;
                    }
                default:
                    break;
            }
        }
        #endregion
        #region Private functions
        private void BindCartModal(string ProductId)
        {
            List<DevMod.Models.MCommon.MDataObjects.MCartModal> cartProducts = new List<DevMod.Models.MCommon.MDataObjects.MCartModal>();
            List<DevMod.Models.MCommon.MViewObjects.MViewProducts> allProducts =
                   (List<DevMod.Models.MCommon.MViewObjects.MViewProducts>)HttpContext.Current.Cache["allProducts"];
            allProducts = allProducts.Where(o => o.ProductId == ProductId).ToList();
            DevMod.Models.MCommon.MDataObjects.MCartModal cm = new DevMod.Models.MCommon.MDataObjects.MCartModal();
            cm.ProductId = ProductId;
            cm.Name = allProducts[0].Name1;
            cm.Price = allProducts[0].Price;
            cm.Image = allProducts[0].ImageUrl1;

            if (allProducts.Count > 0)
            {
                if (Session["currentModal"] != null)
                {
                    cartProducts = (List<DevMod.Models.MCommon.MDataObjects.MCartModal>)Session["currentModal"];
                    if (!cartProducts.Exists(o => o.ProductId == ProductId))
                    {
                        cartProducts.Add(cm);
                        Session["currentModal"] = cartProducts;
                    }
                    else
                    {
                        SendMessageToPage("Product has already been Added");
                    }


                }
                else
                {
                    cartProducts.Add(cm);
                    Session["currentModal"] = cartProducts;
                }
            }

            Repeater rep = (Repeater)Master.FindControl("repCartModal");
            rep.DataSource = cartProducts;
            rep.DataBind();


            List<string> q = ((from o in cartProducts
                               select o.Price).ToList());
            List<float> prices = q.Select(float.Parse).ToList();

            float cartPrice = 0;
            if (q.Count > 0)
            {
                cartPrice = prices.Sum();
            }


            Button btnCart = (Button)Master.FindControl("btnCart");
            btnCart.Text = "Cart ($" + cartPrice.ToString() + ")";
            Label lblSubtotal = (Label)Master.FindControl("lblSubTotal");
            lblSubtotal.Text = cartPrice.ToString();

        }
        private void OpenAllProductDetails(string ProductId)
        {
            Response.Redirect("~/WebMod/ContentPages/ProductDetails.aspx?ProductId=" + ProductId);
        }
        private void BindNewArrivals()
        {
            List<DevMod.Models.MCommon.MViewObjects.MViewProducts> newArrivals = new List<DevMod.Models.MCommon.MViewObjects.MViewProducts>();
            DevMod.Classes.CCommon.CViewObjects cv = new DevMod.Classes.CCommon.CViewObjects();
            newArrivals = cv.GetAllNewArrivals();
            repNewArrivals.DataSource = newArrivals;
            repNewArrivals.DataBind();
            newArrivals = null;
            newArrivals = cv.GetAllFeaturedProducts();
            repFeaturedProducts.DataSource = newArrivals;
            repFeaturedProducts.DataBind();
        }

        private void BindSubCategories()
        {
            List<DevMod.Models.MSubCategory> subCategories = new List<DevMod.Models.MSubCategory>();
            DevMod.Classes.CSubCategory cs = new DevMod.Classes.CSubCategory();
            subCategories = cs.GetAll();
            subCategories = subCategories.Take(6).ToList();
            repFeaturedCategories.DataSource = subCategories;
            repFeaturedCategories.DataBind();
        }

        private void CacheData()
        {
            List<DevMod.Models.MProductContainer> allProductContainer = new List<DevMod.Models.MProductContainer>();
            List<DevMod.Models.MCategory> allCategories = new List<DevMod.Models.MCategory>();
            List<DevMod.Models.MPrice> allPrice = new List<DevMod.Models.MPrice>();
            List<DevMod.Models.MSubCategory> allSubCategories = new List<DevMod.Models.MSubCategory>();
            List<DevMod.Models.MCategoryContainer> allCategoryContainer = new List<DevMod.Models.MCategoryContainer>();
            List<DevMod.Models.MBrand> allBrands = new List<DevMod.Models.MBrand>();
            List<DevMod.Models.MColor> allColors = new List<DevMod.Models.MColor>();
            List<DevMod.Models.MCommon.MViewObjects.MViewProducts> allProducts = new List<DevMod.Models.MCommon.MViewObjects.MViewProducts>();
            List<DevMod.Models.MProducts> allCompleteProducts = new List<DevMod.Models.MProducts>();
            DevMod.Classes.CProducts ccp = new DevMod.Classes.CProducts();
            DevMod.Classes.CSubCategory msc = new DevMod.Classes.CSubCategory();
            DevMod.Classes.CCommon.CViewObjects cv = new DevMod.Classes.CCommon.CViewObjects();
            DevMod.Classes.CCategory mc = new DevMod.Classes.CCategory();
            DevMod.Classes.CCategoryContainer mcc = new DevMod.Classes.CCategoryContainer();
            DevMod.Classes.CPrice cp = new DevMod.Classes.CPrice();
            DevMod.Classes.CBrand cb = new DevMod.Classes.CBrand();
            DevMod.Classes.CColor cc = new DevMod.Classes.CColor();
            DevMod.Classes.CProductContainer cpc = new DevMod.Classes.CProductContainer();
            allProductContainer = cpc.GetAll();
            allPrice = cp.GetAll();
            allCompleteProducts = ccp.GetAll();
            allSubCategories = msc.GetAll();
            allCategories = mc.GetAll();
            allCategoryContainer = mcc.GetAll();
            allBrands = cb.GetAll();
            allColors = cc.GetAll();
            allProducts = cv.GetAllProducts();
            HttpContext.Current.Cache.Remove("allProductContainer");
            HttpContext.Current.Cache.Remove("allCompleteProducts");
            HttpContext.Current.Cache.Remove("allPrice");
            HttpContext.Current.Cache.Remove("allCategories");
            HttpContext.Current.Cache.Remove("allSubCategories");
            HttpContext.Current.Cache.Remove("allCategoryContainer");
            HttpContext.Current.Cache["allSubCategories"] = allSubCategories;
            HttpContext.Current.Cache["allCategories"] = allCategories;
            HttpContext.Current.Cache["allCategoryContainer"] = allCategoryContainer;
            HttpContext.Current.Cache["allPrice"] = allPrice;
            HttpContext.Current.Cache["allBrands"] = allBrands;
            HttpContext.Current.Cache["allColors"] = allColors;
            HttpContext.Current.Cache["allProducts"] = allProducts;
            HttpContext.Current.Cache["allCompleteProducts"] = allCompleteProducts;
            HttpContext.Current.Cache["allProductContainer"] = allProductContainer;

        }

        

        private void SendMessageToPage(string Message)
        {
            Label lblMessage = (Label)Master.FindControl("lblMessage");

            lblMessage.Text = Message;

            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append(@"<script language='javascript'>");
            sb.Append(@"$('#modalMessage').modal('show');");
            sb.Append(@"</script>");
            System.Web.UI.ScriptManager.RegisterStartupScript(this, this.GetType(), "JCall1", sb.ToString(), false);
        }
        #endregion


    }
}