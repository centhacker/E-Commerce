using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Commerce.WebMod.ContentPages
{
    public partial class ProductDetails : System.Web.UI.Page
    {
        #region form Functions
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string ProductID = string.Empty;
                if (!string.IsNullOrWhiteSpace(Request.QueryString["ProductId"]))
                {
                    BindAllProductControls(Request.QueryString["ProductId"].ToString());
                }
            }
        }

        protected void lkimgzoom3_Click(object sender, EventArgs e)
        {
            string imgUrl = imgZoom3.ImageUrl.ToString();

            UpdateImage(imgUrl, 3);
        }

        protected void lkimgzoom2_Click(object sender, EventArgs e)
        {
            string imgUrl = imgZoom2.ImageUrl.ToString();


            UpdateImage(imgUrl, 2);
        }

        protected void lkimgzoom1_Click(object sender, EventArgs e)
        {
            string imgUrl = imgZoom1.ImageUrl.ToString();

            UpdateImage(imgUrl, 1);
        }
        protected void btnAddToCart_Click(object sender, EventArgs e)
        {
            BindCartModal(lblProductId.Text);
        }
        #endregion


        #region private functions
        private void BindAllProductControls(string ProductId)
        {
            List<DevMod.Models.MProducts> allProducts =
                      (List<DevMod.Models.MProducts>)HttpContext.Current.Cache["allCompleteProducts"];
            string productId = ProductId, productCode = string.Empty, productName = string.Empty, productImage1 = string.Empty,
                productImage2 = string.Empty, productImage3 = string.Empty, productDescription = string.Empty, productPrice = string.Empty
                , productDiscountedPrice = string.Empty;
            if (allProducts.Count > 0)
            {
                productDescription = allProducts.Where(o => o.id == productId).Select(o => o.Description).FirstOrDefault();
                productCode = allProducts.Where(o => o.id == productId).Select(o => o.Code).FirstOrDefault();
                productImage1 = allProducts.Where(o => o.id == productId).Select(o => o.ImageUrl1).FirstOrDefault();
                productImage2 = allProducts.Where(o => o.id == productId).Select(o => o.ImageUrl2).FirstOrDefault();
                productImage3 = allProducts.Where(o => o.id == productId).Select(o => o.ImageUrl3).FirstOrDefault();
                productPrice = allProducts.Where(o => o.id == productId).Select(o => o.Price).FirstOrDefault();
                productDiscountedPrice = GetDiscountedRate(productId);

                lblDescription.Text = productDescription;
                lblDiscountedPrice.Text = productDiscountedPrice;
                lblName.Text = productName;
                lblPrice.Text = productPrice;
                lblProductCode.Text = productCode;
                lblProductId.Text = productId;
                imgLarge.ImageUrl = productImage1;
                imgZoom1.ImageUrl = productImage1;
                imgZoom2.ImageUrl = productImage2;
                imgZoom3.ImageUrl = productImage3;
                imgZoom1.DataBind();
                imgZoom2.DataBind();
                imgZoom3.DataBind();
            }
            else
            {
                DevMod.Classes.CProducts cp = new DevMod.Classes.CProducts();
                allProducts = cp.GetAll();
                HttpContext.Current.Cache["allCompleteProducts"] = allProducts;
                BindAllProductControls(ProductId);

            }

        }
        private string GetDiscountedRate(string ProductId)
        {
            string discountedRate = string.Empty;
            List<DevMod.Models.MProductContainer> allProductContainer =
                          (List<DevMod.Models.MProductContainer>)HttpContext.Current.Cache["allProductContainer"];
            if (allProductContainer.Count > 0)
            {
                discountedRate = (from o in allProductContainer
                                  where o.ProductId == ProductId
                                  select o.DiscountedPrice).FirstOrDefault();
            }
            else
            {
                DevMod.Classes.CProductContainer cpc = new DevMod.Classes.CProductContainer();
                allProductContainer = cpc.GetAll();
                discountedRate = (from o in allProductContainer
                                  where o.ProductId == ProductId
                                  select o.DiscountedPrice).FirstOrDefault();



            }
            return discountedRate;
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
        private void UpdateImage(string imgUpdate, int lkButton)
        {
            switch (lkButton)
            {
                case 1:
                    {
                        lkimgzoom1.CssClass = "sp-current";
                        lkimgzoom2.CssClass = "";
                        lkimgzoom3.CssClass = "";
                        break;
                    }
                case 2:
                    {
                        lkimgzoom1.CssClass = "";
                        lkimgzoom2.CssClass = "sp-current";
                        lkimgzoom3.CssClass = "";
                        break;
                    }
                case 3:
                    {
                        lkimgzoom1.CssClass = "";
                        lkimgzoom2.CssClass = "";
                        lkimgzoom3.CssClass = "sp-current";
                        break;
                    }
                default:
                    break;
            }
            imgLarge.ImageUrl = imgUpdate;
            imgLarge.DataBind();
        }
        #endregion


    }
}