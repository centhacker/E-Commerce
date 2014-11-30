using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Commerce.Admin.ContentPages
{
    public partial class AddProducts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lkSave_Click(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {

                try
                {
                    if (fuImage1.HasFile && fuImage2.HasFile && fuImage3.HasFile)
                    {
                        string filename1 = fuImage1.FileName;
                        string filename2 = fuImage2.FileName;
                        string filename3 = fuImage3.FileName;
                        fuImage1.PostedFile.SaveAs(Server.MapPath("~\\Images\\" + filename1.Trim()));
                        fuImage2.PostedFile.SaveAs(Server.MapPath("~\\Images\\" + filename2.Trim()));
                        fuImage3.PostedFile.SaveAs(Server.MapPath("~\\Images\\" + filename3.Trim()));
                        string path1 = "~\\Images\\" + filename1.Trim();
                        string path2 = "~\\Images\\" + filename2.Trim();
                        string path3 = "~\\Images\\" + filename3.Trim();
                        string Name = txtProductName.Text;
                        string Name2 = txtProductName2.Text;
                        string Name3 = txtProductName3.Text;
                        string Description = txtDescription.Text;
                        string Price = txtPrice.Text;
                        string Code = txtProductCode.Text;
                        DevMod.Classes.CProducts cp = new DevMod.Classes.CProducts();
                        DevMod.Models.MProducts mp = new DevMod.Models.MProducts();
                        mp.Code = Code;
                        mp.Name1 = Name;
                        mp.Name2 = Name2;
                        mp.Name3 = Name3;
                        mp.ImageUrl1 = path1;
                        mp.ImageUrl2 = path2;
                        mp.ImageUrl3 = path3;
                        mp.Description = Description;
                        mp.Price = Price;
                        if (cp.Save(mp) > 0)
                        {
                            SendMessageToPage("Product Successfully Saved");
                        }
                        else
                        {
                            SendMessageToPage("Product was not Saved");
                        }
                    }
                    else
                    {
                        SendMessageToPage("Please select images");
                    }
                   

                }
                catch
                {

                }
            }
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
    }
}