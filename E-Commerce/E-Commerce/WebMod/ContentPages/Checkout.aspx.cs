using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Commerce.WebMod.ContentPages
{
    public partial class Checkout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                divPersonalDetails.Visible = true;
                divProductDetails.Visible = false;
                divPerosnalDetailsConfirmation.Visible = false;
                divProductDetailsConfirmation.Visible = false;
                bindCartData();
            }

        }



        protected void lkNext_Click(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                switch (nextButtonClick())
                {
                    case 1:
                        {
                            string firstName = txtFirstName.Text;
                            string lastName = txtLastName.Text;
                            string Address = txtAddress.Text;
                            string phoneNumber1 = txtPhone1.Text;
                            string additionalPhoneNumber = txtAdditionalPhoneNumber.Text;
                            string alternateEmail = txtAlternateEmail.Text;
                            string email = txtEmail.Text;
                            DevMod.Models.MCommon.MDataObjects.MCheckOutDetails mcd = new DevMod.Models.MCommon.MDataObjects.MCheckOutDetails();
                            mcd.AdditionalPhoneNumber = additionalPhoneNumber;
                            mcd.Address = Address;
                            mcd.AlternateEmail = alternateEmail;
                            mcd.Email = email;
                            mcd.FirstName = firstName;
                            mcd.LastName = lastName;
                            mcd.Phone1 = phoneNumber1;
                            Session["checkoutDetails"] = mcd;
                            break;
                        }
                    case 2:
                        {
                            if (grdProducts.Rows.Count > 0)
                            {
                                List<DevMod.Models.MCommon.MDataObjects.MCheckOutProductDetails> checkoutProducts =
                                    new List<DevMod.Models.MCommon.MDataObjects.MCheckOutProductDetails>();
                                for (int i = 0; i < grdProducts.Rows.Count; i++)
                                {
                                    string productId = grdProducts.Rows[i].Cells[0].Text.ToString();

                                    string Image = grdProducts.Rows[i].Cells[1].Text.ToString();
                                    string Name = grdProducts.Rows[i].Cells[2].Text.ToString();
                                    string Price = grdProducts.Rows[i].Cells[3].Text.ToString();
                                    DropDownList ddlColor = (DropDownList)grdProducts.Rows[i].FindControl("ddlColors");
                                    string Color = ddlColor.SelectedItem.Text;
                                    TextBox txtUnits = (TextBox)grdProducts.Rows[i].FindControl("txtUnits");
                                    string Units = txtUnits.Text;
                                    DevMod.Models.MCommon.MDataObjects.MCheckOutProductDetails mpc = new DevMod.Models.MCommon.MDataObjects.MCheckOutProductDetails();
                                    mpc.color = Color;
                                    mpc.ImageUrl = Image;
                                    mpc.Name = Name;
                                    mpc.Price = Price;
                                    mpc.ProductId = productId;
                                    mpc.units = Units;
                                    checkoutProducts.Add(mpc);

                                }

                                Session["checkoutProducts"] = checkoutProducts;



                                DevMod.Models.MCommon.MDataObjects.MCheckOutDetails mcd = new DevMod.Models.MCommon.MDataObjects.MCheckOutDetails();
                                if (Session["checkoutDetails"] != null)
                                {
                                    mcd = (DevMod.Models.MCommon.MDataObjects.MCheckOutDetails)Session["checkoutDetails"];
                                }
                                lblAdditionalPhoneNumber.Text = mcd.AdditionalPhoneNumber;
                                lblAddress.Text = mcd.Address;
                                lblAlternateEmail.Text = mcd.AlternateEmail;
                                lblEmail.Text = mcd.Email;
                                lblFirstName.Text = mcd.FirstName;
                                lblLastName.Text = mcd.LastName;
                                lblPhoneNumber1.Text = mcd.Phone1;
                            }
                            break;
                        }
                    case 3:
                        {
                            if (Session["checkoutProducts"] != null)
                            {
                                List<DevMod.Models.MCommon.MDataObjects.MCheckOutProductDetails> checkoutProducts =
                                   (List<DevMod.Models.MCommon.MDataObjects.MCheckOutProductDetails>)Session["checkoutProducts"];

                                grdProductConfirmation.DataSource = checkoutProducts;
                                grdProductConfirmation.DataBind();
                            }

                            break;
                        }
                    case 4:
                        {
                            if (grdProducts.Rows.Count > 0)
                            {
                                List<DevMod.Models.MOrderLine> orderLine = new List<DevMod.Models.MOrderLine>();
                                DevMod.Models.MOrderMaster mom = new DevMod.Models.MOrderMaster();
                                mom.Date = DateTime.Now.ToShortDateString();
                                mom.Total = lblTotal.Text;
                                for (int i = 0; i < grdProducts.Rows.Count; i++)
                                {

                                    DevMod.Models.MCommon.MDataObjects.MCheckOutDetails mcd = new DevMod.Models.MCommon.MDataObjects.MCheckOutDetails();
                                    DevMod.Models.MOrderLine mol = new DevMod.Models.MOrderLine();
                                    string productId = grdProducts.Rows[i].Cells[0].Text.ToString();

                                    string Image = grdProducts.Rows[i].Cells[1].Text.ToString();
                                    string Name = grdProducts.Rows[i].Cells[2].Text.ToString();
                                    string Price = grdProducts.Rows[i].Cells[3].Text.ToString();
                                    DropDownList ddlColor = (DropDownList)grdProducts.Rows[i].FindControl("ddlColors");
                                    string Color = ddlColor.SelectedItem.Text;
                                    TextBox txtUnits = (TextBox)grdProducts.Rows[i].FindControl("txtUnits");
                                    string Units = txtUnits.Text;
                                    string firstName = string.Empty, lastName = string.Empty, Address = string.Empty,
                                    phoneNumber1 = string.Empty, additionalPhoneNumber = string.Empty, alternateEmail = string.Empty, email = string.Empty;
                                    if (Session["checkoutDetails"] != null)
                                    {
                                        mcd = (DevMod.Models.MCommon.MDataObjects.MCheckOutDetails)Session["checkoutDetails"];
                                    }
                                    #region formdetails
                                    mol.AdditionalPhoneNumber = mcd.AdditionalPhoneNumber;
                                    mol.Address = mcd.Address;
                                    mol.AlternateEmail = mcd.AlternateEmail;
                                    mol.Email = mcd.Email;
                                    mol.FirstName = mcd.FirstName;
                                    mol.LastName = mcd.LastName;
                                    mol.Phone1 = mcd.Phone1;
                                    #endregion
                                    #region product details
                                    mol.color = Color;
                                    mol.ImageUrl = Image;
                                    mol.Name = Name;
                                    mol.Price = Price;
                                    mol.ProductId = productId;
                                    mol.units = Units;

                                    #endregion
                                    orderLine.Add(mol);

                                }

                                saveOrder(mom, orderLine);





                            }
                            break;
                        }
                    default:
                        break;
                }
            }

        }

        protected void lkPrev_Click(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {

                switch (prevButtonClick())
                {
                    case 1:
                        {
                            break;
                        }
                    case 2:
                        {
                            break;
                        }
                    case 3:
                        {
                            break;
                        }
                    case 4:
                        {
                            break;
                        }
                    default:
                        break;
                }
            }

        }

        private int nextButtonClick()
        {
            if (divPersonalDetails.Visible)
            {
                if (true)
                {
                    divPersonalDetails.Visible = false;
                    divProductDetails.Visible = true;
                    divPerosnalDetailsConfirmation.Visible = false;
                    divProductDetailsConfirmation.Visible = false;
                    liPersonalDetails.Attributes.Remove("class");
                    liProductDetails.Attributes.Add("class", "active");
                    return 1;
                }
            }
            else if (divProductDetails.Visible)
            {
                divPersonalDetails.Visible = false;
                divProductDetails.Visible = false;
                divPerosnalDetailsConfirmation.Visible = true;
                divProductDetailsConfirmation.Visible = false;
                liPersonalDetails.Attributes.Remove("class");
                liProductDetails.Attributes.Remove("class");
                liPerosnalDetailsConfirmation.Attributes.Add("class", "active");
                return 2;
            }
            else if (divPerosnalDetailsConfirmation.Visible)
            {
                divPersonalDetails.Visible = false;
                divProductDetails.Visible = false;
                divPerosnalDetailsConfirmation.Visible = false;
                divProductDetailsConfirmation.Visible = true;
                liPersonalDetails.Attributes.Remove("class");
                liProductDetails.Attributes.Remove("class");
                liPerosnalDetailsConfirmation.Attributes.Remove("class");
                liProductDetailsConfirmation.Attributes.Add("class", "active");
                return 3;
            }
            else if (divProductDetailsConfirmation.Visible)
            {
                //checkout now
                divPersonalDetails.Visible = false;
                divProductDetails.Visible = false;
                divPerosnalDetailsConfirmation.Visible = false;
                divProductDetailsConfirmation.Visible = true;
                liPersonalDetails.Attributes.Remove("class");
                liProductDetails.Attributes.Remove("class");
                liPerosnalDetailsConfirmation.Attributes.Remove("class");
                liProductDetailsConfirmation.Attributes.Add("class", "active");
                return 4;
            }
            return 1;
        }

        private int prevButtonClick()
        {
            if (divPersonalDetails.Visible)
            {
                divPersonalDetails.Visible = true;
                divProductDetails.Visible = false;
                divPerosnalDetailsConfirmation.Visible = false;
                divProductDetailsConfirmation.Visible = false;
                liPersonalDetails.Attributes.Add("class", "active");
                liProductDetails.Attributes.Remove("class");
                liPerosnalDetailsConfirmation.Attributes.Remove("class");
                liProductDetailsConfirmation.Attributes.Remove("class");
                return 1;
            }
            else if (divProductDetails.Visible)
            {
                divPersonalDetails.Visible = true;
                divProductDetails.Visible = false;
                divPerosnalDetailsConfirmation.Visible = false;
                divProductDetailsConfirmation.Visible = false;
                liPersonalDetails.Attributes.Add("class", "active");
                liProductDetails.Attributes.Remove("class");
                liPerosnalDetailsConfirmation.Attributes.Remove("class");
                liProductDetailsConfirmation.Attributes.Remove("class");
                return 2;
            }
            else if (divPerosnalDetailsConfirmation.Visible)
            {
                divPersonalDetails.Visible = false;
                divProductDetails.Visible = true;
                divPerosnalDetailsConfirmation.Visible = false;
                divProductDetailsConfirmation.Visible = false;
                liPersonalDetails.Attributes.Remove("class");
                liProductDetails.Attributes.Add("class", "active");
                liPerosnalDetailsConfirmation.Attributes.Remove("class");
                liProductDetailsConfirmation.Attributes.Remove("class");
                return 3;
            }
            else if (divProductDetailsConfirmation.Visible)
            {
                divPersonalDetails.Visible = false;
                divProductDetails.Visible = false;
                divPerosnalDetailsConfirmation.Visible = true;
                divProductDetailsConfirmation.Visible = false;
                liPersonalDetails.Attributes.Remove("class");
                liProductDetails.Attributes.Remove("class");
                liPerosnalDetailsConfirmation.Attributes.Add("class", "active");
                liProductDetailsConfirmation.Attributes.Remove("class");
                return 4;
            }
            return 1;
        }

        protected void grdProducts_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                int rowIndex = e.Row.RowIndex;
                DropDownList ddlColors = (DropDownList)e.Row.FindControl("ddlColors");
                List<DevMod.Models.MColor> allColors =
                        (List<DevMod.Models.MColor>)HttpContext.Current.Cache["allColors"];
                if ((List<DevMod.Models.MColor>)HttpContext.Current.Cache["allColors"] == null)
                {
                    DevMod.Classes.CColor cc = new DevMod.Classes.CColor();
                    allColors = cc.GetAll();
                }
                Dictionary<int, string> colorsDt = new Dictionary<int, string>();
                for (int i = 0; i < allColors.Count; i++)
                {
                    colorsDt.Add(Convert.ToInt32(allColors[i].id), allColors[i].Name);
                }
                ddlColors.DataValueField = "Key";
                ddlColors.DataTextField = "Value";
                ddlColors.DataSource = colorsDt;
                ddlColors.DataBind();
                //for (int i = 0; i < ddlColors.Items.Count; i++)
                //{
                //    ddlColors.Items[i].Attributes.Add("style", "color:" + ddlColors.Items[i].Text);
                //}
            }
        }

        #region private functions
        private void bindCartData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ProductId");
            dt.Columns.Add("ImageUrl");
            dt.Columns.Add("Name");
            dt.Columns.Add("Price");
            List<DevMod.Models.MCommon.MDataObjects.MCartModal> cartProducts = new List<DevMod.Models.MCommon.MDataObjects.MCartModal>();
            if (Session["currentModal"] != null)
            {
                cartProducts =
                  (List<DevMod.Models.MCommon.MDataObjects.MCartModal>)Session["currentModal"];

            }
            for (int i = 0; i < cartProducts.Count; i++)
            {
                string productId = cartProducts[i].ProductId;
                string imageUrl = cartProducts[i].Image;
                string Name = cartProducts[i].Name;
                string price = cartProducts[i].Price;


                dt.Rows.Add(productId, imageUrl, Name, price);
            }
            grdProducts.DataSource = dt;
            grdProducts.DataBind();


        }

        private void saveOrder(DevMod.Models.MOrderMaster mom, List<DevMod.Models.MOrderLine> orderLine)
        {
            DevMod.Classes.COrder co = new DevMod.Classes.COrder();
            if (co.Save(mom, orderLine) > 0)
            {
                SendMessageToPage("Your order has been sent");
            }
            else
            {
                SendMessageToPage("There was a problem sendingyour order");
            }
            return;
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