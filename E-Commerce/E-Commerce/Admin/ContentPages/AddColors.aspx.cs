using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Commerce.Admin.ContentPages
{
    public partial class AddColors : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lkSave_Click(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                DevMod.Models.MColor mb = new DevMod.Models.MColor();
                DevMod.Classes.CColor cb = new DevMod.Classes.CColor();
                mb.Name = txtColorName.Text;
                if (cb.Save(mb) > 0)
                {
                    SendMessageToPage("New Color Added");
                }
                else
                {
                    SendMessageToPage("New Color was not Added");
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