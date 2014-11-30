using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Commerce.Admin.ContentPages
{
    public partial class AddCategory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lkSave_Click(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                DevMod.Models.MCategory mb = new DevMod.Models.MCategory();
                DevMod.Classes.CCategory cb = new DevMod.Classes.CCategory();
                mb.Code = txtCategoryCode.Text;
                mb.Name = txtCategoryName.Text;
                if (cb.Save(mb) > 0)
                {
                    SendMessageToPage("New Category Added");
                }
                else
                {
                    SendMessageToPage("New Category was not Added");
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