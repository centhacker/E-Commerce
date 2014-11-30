using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Commerce.WebMod.MasterPages
{
    public partial class Commerce : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                if ((List<DevMod.Models.MCommon.MDataObjects.MCartModal>)Session["currentModal"] != null)
                {
                    List<DevMod.Models.MCommon.MDataObjects.MCartModal> cartProducts =
                  (List<DevMod.Models.MCommon.MDataObjects.MCartModal>)Session["currentModal"];
                    repCartModal.DataSource = cartProducts;
                    repCartModal.DataBind();
                    List<string> q = ((from o in cartProducts
                                       select o.Price).ToList());
                    List<float> prices = q.Select(float.Parse).ToList();

                    float cartPrice = 0;
                    if (q.Count > 0)
                    {
                        cartPrice = prices.Sum();
                    }                  
                    btnCart.Text = "Cart ($" + cartPrice.ToString() + ")";


                }
            }
        }

        protected void btnCart_Click(object sender, EventArgs e)
        {

        }






        protected void repCartModal_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            string commandName = e.CommandName.ToString();
            string commandArgument = e.CommandArgument.ToString();
            if (string.Equals(commandName, "DeleteProduct"))
            {
                List<DevMod.Models.MCommon.MDataObjects.MCartModal> cartProducts =
                    (List<DevMod.Models.MCommon.MDataObjects.MCartModal>)Session["currentModal"];
                if (cartProducts.Exists(o => o.ProductId == commandArgument))
                {
                    DevMod.Models.MCommon.MDataObjects.MCartModal mc = new DevMod.Models.MCommon.MDataObjects.MCartModal();
                    mc.ProductId = commandArgument;
                    cartProducts.RemoveAll(o => o.ProductId == commandArgument);
                    repCartModal.DataSource = cartProducts;
                    repCartModal.DataBind();
                    Session["currentModal"] = cartProducts;
                }
            }

        }

        protected void btnCheckout_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebMod/ContentPages/Checkout.aspx");
        }
    }
}