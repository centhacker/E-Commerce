using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace E_Commerce.WebMod.ContentPages
{
    public partial class AllProducts : System.Web.UI.Page
    {


        #region form events
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                CacheData();
            }
        }

        protected void btnPriceRange_Click(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                if (string.IsNullOrWhiteSpace(txtRangeTo.Text) || string.IsNullOrWhiteSpace(txtRangeFrom.Text))
                {

                    List<DevMod.Models.MCommon.MViewObjects.MViewProducts> allProducts =
                        (List<DevMod.Models.MCommon.MViewObjects.MViewProducts>)HttpContext.Current.Cache["allProducts"];
                    string Range = rdbPriceRanges.SelectedItem.Text.ToString();
                    if (!string.Equals(Range, "No Range"))
                    {
                        string toPrice = Range.Split('-')[0], fromPrice = Range.Split('-')[1];

                        allProducts = (from o in allProducts
                                       where Convert.ToSingle(o.Price) <=
                                       Convert.ToSingle(fromPrice)
                                       &&
                                       Convert.ToSingle(o.Price) >=
                                       Convert.ToSingle(toPrice)
                                       select o).ToList();
                    }

                    BindPagingRepeater(0, itemsPerPage, allProducts);
                    BindAllProducts(0, itemsPerPage, allProducts);

                }
                else
                {
                    List<DevMod.Models.MCommon.MViewObjects.MViewProducts> allProducts =
                        (List<DevMod.Models.MCommon.MViewObjects.MViewProducts>)HttpContext.Current.Cache["allProducts"];
                    string Range = rdbPriceRanges.SelectedItem.Text.ToString();

                    string toPrice = txtRangeTo.Text, fromPrice = txtRangeFrom.Text;

                    allProducts = (from o in allProducts
                                   where Convert.ToSingle(o.Price) <=
                                   Convert.ToSingle(fromPrice)
                                   &&
                                   Convert.ToSingle(o.Price) >=
                                   Convert.ToSingle(toPrice)
                                   select o).ToList();


                    BindPagingRepeater(0, itemsPerPage, allProducts);
                    BindAllProducts(0, itemsPerPage, allProducts);
                }
            }
        }

        protected void ddlProductsPerPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            itemsPerPage = Convert.ToInt32(ddlProductsPerPage.SelectedValue);
            List<DevMod.Models.MCommon.MViewObjects.MViewProducts> allProducts =
                   (List<DevMod.Models.MCommon.MViewObjects.MViewProducts>)HttpContext.Current.Cache["allProducts"];
            BindAllProducts(0, itemsPerPage, allProducts);
            BindPagingRepeater(0, itemsPerPage, allProducts);
        }

        protected void repFeaturedProducts_ItemCommand(object source, RepeaterCommandEventArgs e)
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

        protected void repCategories_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {

                List<DevMod.Models.MCategory> Categories = (List<DevMod.Models.MCategory>)
                            HttpContext.Current.Cache["allCategories"];
                List<DevMod.Models.MSubCategory> subCategories = (List<DevMod.Models.MSubCategory>)
                    HttpContext.Current.Cache["allSubCategories"];
                List<DevMod.Models.MCategoryContainer> allCategoryContainer = (List<DevMod.Models.MCategoryContainer>)
                    HttpContext.Current.Cache["allCategoryContainer"];

                Label lblCategoryName = (Label)e.Item.FindControl("lblCategoryName");
                string CategoryId = lblCategoryName.Text;

                subCategories = (from asc in subCategories
                                 join acc in allCategoryContainer
                                 on asc.id equals acc.SubCategoryId
                                 join ac in Categories
                                 on acc.CategoryId equals ac.id
                                 where ac.Name == CategoryId
                                 select asc).ToList();
                Label lblCategoryCount = (Label)e.Item.FindControl("lblCategoryCount");
                lblCategoryCount.Text = subCategories.Count.ToString();
                Repeater repSubCategories = (Repeater)(e.Item.FindControl("repSubCategories"));
                repSubCategories.DataSource = subCategories;
                repSubCategories.DataBind();

            }
        }

        protected void repColors_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
        }

        protected void repColors_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {

            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {

                CheckBox lblCategoryName = (CheckBox)e.Item.FindControl("cblColors");
                HtmlContainerControl small = (HtmlContainerControl)e.Item.FindControl("small");
                small.Attributes.Add("style", "background-color:" + lblCategoryName.Text);



            }
        }

        protected void repPaging_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            string commandName = e.CommandName.ToString();
            string pageNumber = e.CommandArgument.ToString();
            if (commandName == "PageLoad")
            {
                switch (pageNumber)
                {
                    case "«":
                        {

                            break;
                        }
                    case "»":
                        {

                            break;
                        }
                    default:
                        List<DevMod.Models.MCommon.MViewObjects.MViewProducts> allProducts =
                   (List<DevMod.Models.MCommon.MViewObjects.MViewProducts>)HttpContext.Current.Cache["allProducts"];
                        BindPagingRepeater(Convert.ToInt32(pageNumber), itemsPerPage, allProducts);
                        PageNumber = Convert.ToInt32(pageNumber);
                        BindAllProducts(PageNumber, itemsPerPage, allProducts);
                        break;
                }
            }
        }

        protected void btnColorFilter_Click(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                List<DevMod.Models.MCommon.MViewObjects.MViewProducts> allProducts =
                    (List<DevMod.Models.MCommon.MViewObjects.MViewProducts>)HttpContext.Current.Cache["allProducts"];
                List<DevMod.Models.MCommon.MDataObjects.MSelectedItems> selectedItems =
                    new List<DevMod.Models.MCommon.MDataObjects.MSelectedItems>();
                List<DevMod.Models.MProductContainer> allProductContainer =
                            (List<DevMod.Models.MProductContainer>)HttpContext.Current.Cache["allProductContainer"];
                List<DevMod.Models.MColor> allColors =
                    (List<DevMod.Models.MColor>)HttpContext.Current.Cache["allColors"];
                for (int i = 0; i < repColors.Items.Count; i++)
                {
                    CheckBox cb = (CheckBox)repColors.Items[i].FindControl("cblColors");
                    if (cb.Checked)
                    {
                        DevMod.Models.MCommon.MDataObjects.MSelectedItems mss = new DevMod.Models.MCommon.MDataObjects.MSelectedItems();
                        mss.Value = cb.Text;
                        mss.Text = cb.Text;
                        selectedItems.Add(mss);
                    }
                }
                if (!cblColorsAll.Checked)
                {
                    allProducts = (from ap in allProducts
                                   join pc in allProductContainer on ap.ProductId equals pc.ProductId
                                   join cl in allColors on pc.ColorId equals cl.id
                                   join si in selectedItems on cl.Name equals si.Text
                                   select ap).ToList();
                }
                
                BindPagingRepeater(0, itemsPerPage, allProducts);
                BindAllProducts(0, itemsPerPage, allProducts);
            }
        }

        protected void btnBrand_Click(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                List<DevMod.Models.MCommon.MViewObjects.MViewProducts> allProducts =
                    (List<DevMod.Models.MCommon.MViewObjects.MViewProducts>)HttpContext.Current.Cache["allProducts"];
                List<DevMod.Models.MCommon.MDataObjects.MSelectedItems> selectedItems =
                    new List<DevMod.Models.MCommon.MDataObjects.MSelectedItems>();
                List<DevMod.Models.MProductContainer> allProductContainer =
                            (List<DevMod.Models.MProductContainer>)HttpContext.Current.Cache["allProductContainer"];
                foreach (ListItem item in cblBrands.Items)
                {
                    if (item.Selected)
                    {
                        string value = item.Value;
                        string text = item.Text;
                        DevMod.Models.MCommon.MDataObjects.MSelectedItems mss =
                            new DevMod.Models.MCommon.MDataObjects.MSelectedItems();
                        mss.Value = value;
                        mss.Text = text;
                        selectedItems.Add(mss);
                    }
                }
                if (!selectedItems.Exists(o => o.Value == "-1"))
                {
                    allProducts = (from ap in allProducts
                                   join pc in allProductContainer on ap.ProductId equals pc.ProductId
                                   join si in selectedItems on pc.BrandId equals si.Value
                                   select ap).ToList();
                }

                BindPagingRepeater(0, itemsPerPage, allProducts);
                BindAllProducts(0, itemsPerPage, allProducts);
            }
        }

        protected void repCategories_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }

        protected void repSubCategories_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            string commandArgument = e.CommandArgument.ToString();
            string commandName = e.CommandName.ToString();
            switch (commandName)
            {
                case "category":
                    {
                        Label categoryName = (Label)e.Item.NamingContainer.NamingContainer.FindControl("lblCategoryName");
                        List<DevMod.Models.MCommon.MViewObjects.MViewProducts> allProducts =
                            (List<DevMod.Models.MCommon.MViewObjects.MViewProducts>)HttpContext.Current.Cache["allProducts"];
                        List<DevMod.Models.MProductContainer> allProductContainer =
                            (List<DevMod.Models.MProductContainer>)HttpContext.Current.Cache["allProductContainer"];
                        List<DevMod.Models.MCategory> allCategories = (List<DevMod.Models.MCategory>)HttpContext.Current.Cache["allCategories"];
                        string categoryId = allCategories.Where(o => o.Name == categoryName.Text).Select(o => o.id).FirstOrDefault().ToString();
                        allProducts = (from o in allProducts
                                       join a in allProductContainer
                                       on o.ProductId equals a.ProductId
                                       where a.CategoryId == categoryId && a.SubCategoryId == commandArgument
                                       select o).ToList();
                        BindAllProducts(0, itemsPerPage, allProducts);
                        BindPagingRepeater(0, itemsPerPage, allProducts);
                        break;
                    }
                default:
                    break;
            }

        }

        protected void btnResetCategories_Click(object sender, EventArgs e)
        {
            ResetProducts();
        }

        protected void btnResetPrice_Click(object sender, EventArgs e)
        {
            ResetProducts();
        }

        protected void btnResetBrands_Click(object sender, EventArgs e)
        {
            ResetProducts();
        }

        protected void btnResetColors_Click(object sender, EventArgs e)
        {
            ResetProducts();
        }

        protected void btnResetDiscount_Click(object sender, EventArgs e)
        {
            ResetProducts();
        }

        #endregion





        #region Private functions and variables
        public int PageNumber
        {
            get
            {
                if (ViewState["PageNumber"] != null)
                {
                    return Convert.ToInt32(ViewState["PageNumber"]);
                }
                else
                {
                    return 1;
                }
            }
            set { ViewState["PageNumber"] = value; }
        }

        public int itemsPerPage
        {
            get
            {
                if (ViewState["itemsPerPage"] != null)
                {
                    return Convert.ToInt32(ViewState["itemsPerPage"]);
                }
                else
                {
                    return 1;
                }
            }
            set { ViewState["itemsPerPage"] = value; }
        }

        public void BindItemsPerPageDll()
        {
            Dictionary<int, string> Items = new Dictionary<int, string>();
            itemsPerPage = 3;
            Items.Add(3, "3 Items");
            Items.Add(6, "6 Items");
            Items.Add(9, "9 Items");
            Items.Add(15, "15 Items");
            Items.Add(24, "24 Items");
            Items.Add(-1, "All Items");
            ddlProductsPerPage.DataTextField = "Value";
            ddlProductsPerPage.DataValueField = "Key";
            ddlProductsPerPage.DataSource = Items;
            ddlProductsPerPage.DataBind();
        }

        public void BindPagingRepeater(int CurrentPage, int ItemsPerPage, List<DevMod.Models.MCommon.MViewObjects.MViewProducts> allProducts)
        {
            repPaging.Visible = true;
            List<DevMod.SMO.SharedMemoryObjects.Pager> PagerData = new List<DevMod.SMO.SharedMemoryObjects.Pager>();
            double pages = Convert.ToDouble(Math.Round(Convert.ToDecimal(allProducts.Count / ItemsPerPage)));
            DevMod.SMO.SharedMemoryObjects.Pager p = new DevMod.SMO.SharedMemoryObjects.Pager();
            if (itemsPerPage == -1)
            {
                pages = 0;
            }
            // p.Class = "";
            // p.PageNumber = "«";
            // PagerData.Add(p);
            for (int i = 0; i <= pages; i++)
            {
                p = new DevMod.SMO.SharedMemoryObjects.Pager();
                if (i == CurrentPage)
                {
                    p.Class = "active";
                }
                else
                {
                    p.Class = "";
                }
                p.PageNumber = (i).ToString();
                p.PageDisplay = (i + 1).ToString();
                PagerData.Add(p);



            }
            p = new DevMod.SMO.SharedMemoryObjects.Pager();
            // p.Class = "";
            // p.PageNumber = "»";
            // PagerData.Add(p);

            if (PagerData.Count == 1)
            {
                repPaging.Visible = false;
            }
            repPaging.DataSource = PagerData;
            repPaging.DataBind();
        }

        private void BindAllBrands()
        {
            List<DevMod.Models.MBrand> allBrands = (List<DevMod.Models.MBrand>)
                         HttpContext.Current.Cache["allBrands"];
            Dictionary<int, string> brands = new Dictionary<int, string>();
            brands.Add(-1, "All Brands");
            foreach (var item in allBrands)
            {
                brands.Add(Convert.ToInt32(item.id), item.Name);
            }
            cblBrands.DataSource = brands;
            cblBrands.DataTextField = "Value";
            cblBrands.DataValueField = "Key";
            cblBrands.DataBind();
        }

        private void BindNewArrivals()
        {
            List<DevMod.Models.MCommon.MViewObjects.MViewProducts> newArrivals = new List<DevMod.Models.MCommon.MViewObjects.MViewProducts>();
            DevMod.Classes.CCommon.CViewObjects cv = new DevMod.Classes.CCommon.CViewObjects();
            newArrivals = cv.GetAllFeaturedProducts();
            repFeaturedProducts.DataSource = newArrivals;
            repFeaturedProducts.DataBind();
        }

        private void BindPriceRanges()
        {
            List<DevMod.Models.MPrice> allPrice = (List<DevMod.Models.MPrice>)HttpContext.Current.Cache["allPrice"];
            Dictionary<int, string> priceRanges = new Dictionary<int, string>();
            priceRanges.Add(-1, "No Range");
            foreach (var item in allPrice)
            {
                priceRanges.Add(Convert.ToInt32(item.id), item.From + " - " + item.To);
            }
            rdbPriceRanges.DataSource = priceRanges;
            rdbPriceRanges.DataTextField = "Value";
            rdbPriceRanges.DataValueField = "Key";
            rdbPriceRanges.DataBind();

        }

        private void BindAllColors()
        {
            List<DevMod.Models.MColor> allColors = (List<DevMod.Models.MColor>)HttpContext.Current.Cache["allColors"];

            repColors.DataSource = allColors;
            repColors.DataBind();

        }

        private void BindCategoriesRepeater()
        {
            List<DevMod.Models.MCategory> Categories = (List<DevMod.Models.MCategory>)
                            HttpContext.Current.Cache["allCategories"];
            repCategories.DataSource = Categories;
            repCategories.DataBind();

        }

        private void CacheData()
        {
            List<DevMod.Models.MCategory> allCategories = new List<DevMod.Models.MCategory>();
            List<DevMod.Models.MPrice> allPrice = new List<DevMod.Models.MPrice>();
            List<DevMod.Models.MProductContainer> allProductContainer = new List<DevMod.Models.MProductContainer>();
            List<DevMod.Models.MSubCategory> allSubCategories = new List<DevMod.Models.MSubCategory>();
            List<DevMod.Models.MCategoryContainer> allCategoryContainer = new List<DevMod.Models.MCategoryContainer>();
            List<DevMod.Models.MBrand> allBrands = new List<DevMod.Models.MBrand>();
            List<DevMod.Models.MColor> allColors = new List<DevMod.Models.MColor>();
            List<DevMod.Models.MCommon.MViewObjects.MViewProducts> allProducts = new List<DevMod.Models.MCommon.MViewObjects.MViewProducts>();
            DevMod.Classes.CSubCategory msc = new DevMod.Classes.CSubCategory();
            DevMod.Classes.CCommon.CViewObjects cv = new DevMod.Classes.CCommon.CViewObjects();
            DevMod.Classes.CCategory mc = new DevMod.Classes.CCategory();
            DevMod.Classes.CCategoryContainer mcc = new DevMod.Classes.CCategoryContainer();
            DevMod.Classes.CPrice cp = new DevMod.Classes.CPrice();
            DevMod.Classes.CBrand cb = new DevMod.Classes.CBrand();
            DevMod.Classes.CColor cc = new DevMod.Classes.CColor();
            DevMod.Classes.CProductContainer cpc = new DevMod.Classes.CProductContainer();
            allPrice = cp.GetAll();
            allSubCategories = msc.GetAll();
            allCategories = mc.GetAll();
            allCategoryContainer = mcc.GetAll();
            allBrands = cb.GetAll();
            allColors = cc.GetAll();
            allProductContainer = cpc.GetAll();
            allProducts = cv.GetAllProducts();
            HttpContext.Current.Cache.Remove("allPrice");
            HttpContext.Current.Cache.Remove("allCategories");
            HttpContext.Current.Cache.Remove("allSubCategories");
            HttpContext.Current.Cache.Remove("allCategoryContainer");
            HttpContext.Current.Cache.Remove("allProductContainer");
            HttpContext.Current.Cache["allSubCategories"] = allSubCategories;
            HttpContext.Current.Cache["allCategories"] = allCategories;
            HttpContext.Current.Cache["allCategoryContainer"] = allCategoryContainer;
            HttpContext.Current.Cache["allPrice"] = allPrice;
            HttpContext.Current.Cache["allBrands"] = allBrands;
            HttpContext.Current.Cache["allColors"] = allColors;
            HttpContext.Current.Cache["allProducts"] = allProducts;
            HttpContext.Current.Cache["allProductContainer"] = allProductContainer;
            BindCategoriesRepeater();
            BindPriceRanges();
            BindAllBrands();
            BindAllColors();
            BindItemsPerPageDll();
            BindAllProducts(0, itemsPerPage, allProducts);
            BindPagingRepeater(0, itemsPerPage, allProducts);

        }

        private void ResetProducts()
        {
            List<DevMod.Models.MCommon.MViewObjects.MViewProducts> allProducts =
                   (List<DevMod.Models.MCommon.MViewObjects.MViewProducts>)HttpContext.Current.Cache["allProducts"];
            BindItemsPerPageDll();
            BindAllProducts(0, itemsPerPage, allProducts);
            BindPagingRepeater(0, itemsPerPage, allProducts);
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

        private void BindAllProducts(int pageNumber, int ItemsPerPage, List<DevMod.Models.MCommon.MViewObjects.MViewProducts> allProducts)
        {
            lblProductsShowing.Text = "All";
            if (itemsPerPage != -1)
            {
                allProducts = allProducts.Skip(pageNumber * ItemsPerPage).Take(ItemsPerPage).ToList();
                int to = 0;
                int till = 0;
                int total = 0;
                total = (allProducts).Count;
                to = pageNumber * itemsPerPage;
                till = to + itemsPerPage;
                string label = (to + 1) + " to " + till + " of " + total;
                lblProductsShowing.Text = label;
            }


            repFeaturedProducts.DataSource = allProducts;
            repFeaturedProducts.DataBind();

        }

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

        #endregion


























    }
}