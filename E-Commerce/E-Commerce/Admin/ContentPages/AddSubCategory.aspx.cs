using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Commerce.Admin.ContentPages
{
    public partial class AddSubCategory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lkSave_Click(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                DevMod.Models.MSubCategory mb = new DevMod.Models.MSubCategory();
                DevMod.Classes.CSubCategory cb = new DevMod.Classes.CSubCategory();
                if (fuImage1.HasFile)
                {
                    string fileName1 = fuImage1.FileName;
                    fuImage1.PostedFile.SaveAs(Server.MapPath("~\\Images\\" + fileName1.Trim()));
                    string path1 = "~\\Images\\" + fileName1.Trim();
                    mb.ImageUrl = path1;
                    mb.Code = txtSubCategoryCode.Text;
                    mb.Name = txtSubCategoryName.Text;

                    if (cb.Save(mb) > 0)
                    {
                        SendMessageToPage("New Sub Category Added");
                    }
                    else
                    {
                        SendMessageToPage("New Sub Category was not Added");
                    }
                }
                else
                {
                    SendMessageToPage("Please select an image");
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