using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Commerce.Admin.ContentPages
{
    public partial class ProductContainer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                FirstGridViewRow();


            }

        }

        protected void grdSales_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            SetRowData();
            if (ViewState["CurrentTable"] != null)
            {
                DataTable dt = (DataTable)ViewState["CurrentTable"];
                DataRow drCurrentRow = null;
                int rowIndex = Convert.ToInt32(e.RowIndex);
                if (dt.Rows.Count > 1)
                {
                    dt.Rows.Remove(dt.Rows[rowIndex]);
                    drCurrentRow = dt.NewRow();
                    ViewState["CurrentTable"] = dt;
                    grdSales.DataSource = dt;
                    grdSales.DataBind();

                    for (int i = 0; i < grdSales.Rows.Count - 1; i++)
                    {
                        grdSales.Rows[i].Cells[0].Text = Convert.ToString(i + 1);
                    }
                    SetPreviousData();
                }
            }
        }



        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
            AddNewRow();
        }

        protected void lkSave_Click(object sender, EventArgs e)
        {

        }

        #region private functions
        private void SaveProductsProperties()
        {
            for (int rowIndex = 0; rowIndex < grdSales.Rows.Count; rowIndex++)
            {
                DropDownList ddlProducts =
                      (DropDownList)grdSales.Rows[rowIndex].Cells[0].FindControl("ddlProducts");

                DropDownList ddlCategory =
                  (DropDownList)grdSales.Rows[rowIndex].Cells[1].FindControl("ddlCategory");

                DropDownList ddlBrand =
                                        (DropDownList)grdSales.Rows[rowIndex].Cells[2].FindControl("ddlBrand");

                DropDownList ddlColor =
                (DropDownList)grdSales.Rows[rowIndex].Cells[3].FindControl("ddlColor");

                DropDownList ddlSubCategory =
              (DropDownList)grdSales.Rows[rowIndex].Cells[4].FindControl("ddlSubCategory");
            }
        }
        private void FirstGridViewRow()
        {
            DataTable dt = new DataTable();
            DataRow dr = null;
            dt.Columns.Add(new DataColumn("Products", typeof(string)));

            dt.Columns.Add(new DataColumn("Category", typeof(string)));

            dt.Columns.Add(new DataColumn("Brand", typeof(string)));
            dt.Columns.Add(new DataColumn("Color", typeof(string)));
            dt.Columns.Add(new DataColumn("Sub Category", typeof(string)));

            dr = dt.NewRow();


            dr["Products"] = string.Empty;

            dr["Category"] = string.Empty;
            dr["Brand"] = string.Empty;
            dr["Color"] = string.Empty;
            dr["Sub Category"] = string.Empty;


            dt.Rows.Add(dr);

            ViewState["CurrentTable"] = dt;

            grdSales.DataSource = dt;
            grdSales.DataBind();
            AddNewRow();
            SetRowData();
            if (ViewState["CurrentTable"] != null)
            {
                DataTable dtOld = (DataTable)ViewState["CurrentTable"];
                DataRow drCurrentRow = null;
                int rowIndex = Convert.ToInt32(0);
                if (dtOld.Rows.Count > 1)
                {
                    dtOld.Rows.Remove(dt.Rows[rowIndex]);
                    drCurrentRow = dtOld.NewRow();
                    ViewState["CurrentTable"] = dtOld;
                    grdSales.DataSource = dtOld;
                    grdSales.DataBind();

                    for (int i = 0; i < grdSales.Rows.Count - 1; i++)
                    {
                        grdSales.Rows[i].Cells[0].Text = Convert.ToString(i + 1);
                    }
                    SetPreviousData();
                }
            }

        }
        private void AddNewRow()
        {
            int rowIndex = 0;

            if (ViewState["CurrentTable"] != null)
            {
                DataTable dtCurrentTable = (DataTable)ViewState["CurrentTable"];
                DataRow drCurrentRow = null;
                if (dtCurrentTable.Rows.Count > 0)
                {
                    for (int i = 1; i <= dtCurrentTable.Rows.Count; i++)
                    {

                        DropDownList ddlProducts =
                       (DropDownList)grdSales.Rows[rowIndex].Cells[0].FindControl("ddlProducts");

                        DropDownList ddlCategory =
                          (DropDownList)grdSales.Rows[rowIndex].Cells[1].FindControl("ddlCategory");

                        DropDownList ddlBrand =
                                                (DropDownList)grdSales.Rows[rowIndex].Cells[2].FindControl("ddlBrand");

                        DropDownList ddlColor =
                        (DropDownList)grdSales.Rows[rowIndex].Cells[3].FindControl("ddlColor");

                        DropDownList ddlSubCategory =
                      (DropDownList)grdSales.Rows[rowIndex].Cells[4].FindControl("ddlSubCategory");

                        drCurrentRow = dtCurrentTable.NewRow();

                        try
                        {
                            ////Added these lines
                            //DevMod.Models.MProducts mp = new DevMod.Models.MProducts();
                            //DevMod.Models.MCategory mc = new DevMod.Models.MCategory();
                            //DevMod.Models.MColor mco = new DevMod.Models.MColor();
                            //DevMod.Models.MSubCategory msb = new DevMod.Models.MSubCategory();
                            //DevMod.Models.MBrand mb = new DevMod.Models.MBrand();
                            //GetAll(mp, ddlProducts);
                            //GetAll(mc, ddlCategory);
                            //GetAll(mco, ddlColor);
                            //GetAll(msb, ddlSubCategory);
                            //GetAll(mb, ddlBrand);

                            ////****************
                        }
                        catch
                        {

                        }

                        dtCurrentTable.Rows[i - 1]["Products"] = ddlProducts.SelectedValue;

                        dtCurrentTable.Rows[i - 1]["Category"] = ddlCategory.SelectedValue;
                        dtCurrentTable.Rows[i - 1]["Brand"] = ddlBrand.SelectedValue;
                        dtCurrentTable.Rows[i - 1]["Color"] = ddlColor.SelectedValue;
                        dtCurrentTable.Rows[i - 1]["Sub Category"] = ddlSubCategory.SelectedValue;




                        rowIndex++;
                    }
                    dtCurrentTable.Rows.Add(drCurrentRow);
                    ViewState["CurrentTable"] = dtCurrentTable;


                    grdSales.DataSource = dtCurrentTable;
                    grdSales.DataBind();
                }
            }
            else
            {
                Response.Write("ViewState is null");
            }
            SetPreviousData();
        }
        private void SetPreviousData()
        {
            int rowIndex = 0;
            if (ViewState["CurrentTable"] != null)
            {
                DataTable dt = (DataTable)ViewState["CurrentTable"];
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        DropDownList ddlProducts =
                       (DropDownList)grdSales.Rows[rowIndex].Cells[0].FindControl("ddlProducts");

                        DropDownList ddlCategory =
                          (DropDownList)grdSales.Rows[rowIndex].Cells[1].FindControl("ddlCategory");

                        DropDownList ddlBrand =
                                                (DropDownList)grdSales.Rows[rowIndex].Cells[2].FindControl("ddlBrand");

                        DropDownList ddlColor =
                        (DropDownList)grdSales.Rows[rowIndex].Cells[3].FindControl("ddlColor");

                        DropDownList ddlSubCategory =
                      (DropDownList)grdSales.Rows[rowIndex].Cells[4].FindControl("ddlSubCategory");
                        //Added these lines

                        ////Added these lines
                        DevMod.Models.MProducts mp = new DevMod.Models.MProducts();
                        DevMod.Models.MCategory mc = new DevMod.Models.MCategory();
                        DevMod.Models.MColor mco = new DevMod.Models.MColor();
                        DevMod.Models.MSubCategory msb = new DevMod.Models.MSubCategory();
                        DevMod.Models.MBrand mb = new DevMod.Models.MBrand();
                        GetAll(mp, ddlProducts);
                        GetAll(mc, ddlCategory);
                        GetAll(mco, ddlColor);
                        GetAll(msb, ddlSubCategory);
                        GetAll(mb, ddlBrand);

                        ////****************

                        //****************

                        ddlProducts.SelectedValue = dt.Rows[i]["Products"].ToString();

                        ddlCategory.SelectedValue = dt.Rows[i]["Category"].ToString();

                        ddlBrand.SelectedValue = dt.Rows[i]["Brand"].ToString();

                        ddlColor.SelectedValue = dt.Rows[i]["Color"].ToString();

                        ddlSubCategory.SelectedValue = dt.Rows[i]["Sub Category"].ToString();
                        rowIndex++;
                    }
                }
            }
        }
        private void SetRowData()
        {
            int rowIndex = 0;

            if (ViewState["CurrentTable"] != null)
            {
                DataTable dtCurrentTable = (DataTable)ViewState["CurrentTable"];
                DataRow drCurrentRow = null;
                if (dtCurrentTable.Rows.Count > 0)
                {
                    for (int i = 1; i <= dtCurrentTable.Rows.Count; i++)
                    {

                        DropDownList ddlProducts =
                         (DropDownList)grdSales.Rows[rowIndex].Cells[0].FindControl("ddlProducts");

                        DropDownList ddlCategory =
                          (DropDownList)grdSales.Rows[rowIndex].Cells[1].FindControl("ddlCategory");

                        DropDownList ddlBrand =
                                                (DropDownList)grdSales.Rows[rowIndex].Cells[2].FindControl("ddlBrand");

                        DropDownList ddlColor =
                        (DropDownList)grdSales.Rows[rowIndex].Cells[3].FindControl("ddlColor");

                        DropDownList ddlSubCategory =
                      (DropDownList)grdSales.Rows[rowIndex].Cells[4].FindControl("ddlSubCategory");

                        drCurrentRow = dtCurrentTable.NewRow();


                        dtCurrentTable.Rows[i - 1]["Products"] = ddlProducts.SelectedValue;

                        dtCurrentTable.Rows[i - 1]["Category"] = ddlCategory.SelectedValue;
                        dtCurrentTable.Rows[i - 1]["Brand"] = ddlBrand.SelectedValue;
                        dtCurrentTable.Rows[i - 1]["Color"] = ddlColor.SelectedValue;
                        dtCurrentTable.Rows[i - 1]["Sub Category"] = ddlSubCategory.SelectedValue;


                        rowIndex++;
                    }

                    ViewState["CurrentTable"] = dtCurrentTable;
                    //grvStudentDetails.DataSource = dtCurrentTable;
                    //grvStudentDetails.DataBind();
                }
            }
            else
            {
                Response.Write("ViewState is null");
            }
            //SetPreviousData();
        }
        private Dictionary<int, string> GetAll(DevMod.Models.MProducts model, DropDownList ddl)
        {
            Dictionary<int, string> items = new Dictionary<int, string>();
            List<DevMod.Models.MProducts> allBrands = new List<DevMod.Models.MProducts>();
            if (HttpContext.Current.Cache["allBrands"] != null)
            {
                allBrands = (List<DevMod.Models.MProducts>)HttpContext.Current.Cache["allProducts"];
            }
            else
            {
                DevMod.Classes.CProducts cb = new DevMod.Classes.CProducts();
                allBrands = cb.GetAll();
            }
            foreach (var item in allBrands)
            {
                items.Add(Convert.ToInt32(item.id), item.Name1);
            }
            ddl.DataTextField = "Value";
            ddl.DataValueField = "Key";
            ddl.DataSource = items;
            ddl.DataBind();
            return items;
        }
        private Dictionary<int, string> GetAll(DevMod.Models.MBrand model, DropDownList ddl)
        {
            Dictionary<int, string> items = new Dictionary<int, string>();
            List<DevMod.Models.MBrand> allBrands = new List<DevMod.Models.MBrand>();
            if (HttpContext.Current.Cache["allBrands"] != null)
            {
                allBrands = (List<DevMod.Models.MBrand>)HttpContext.Current.Cache["allBrands"];
            }
            else
            {
                DevMod.Classes.CBrand cb = new DevMod.Classes.CBrand();
                allBrands = cb.GetAll();
            }
            foreach (var item in allBrands)
            {
                items.Add(Convert.ToInt32(item.id), item.Name);
            }
            ddl.DataTextField = "Value";
            ddl.DataValueField = "Key";
            ddl.DataSource = items;
            ddl.DataBind();
            return items;
        }
        private Dictionary<int, string> GetAll(DevMod.Models.MCategory model, DropDownList ddl)
        {
            Dictionary<int, string> items = new Dictionary<int, string>();
            List<DevMod.Models.MCategory> allBrands = new List<DevMod.Models.MCategory>();
            if (HttpContext.Current.Cache["allBrands"] != null)
            {
                allBrands = (List<DevMod.Models.MCategory>)HttpContext.Current.Cache["allCategories"];
            }
            else
            {
                DevMod.Classes.CCategory cb = new DevMod.Classes.CCategory();
                allBrands = cb.GetAll();
            }
            foreach (var item in allBrands)
            {
                items.Add(Convert.ToInt32(item.id), item.Name);
            }
            ddl.DataTextField = "Value";
            ddl.DataValueField = "Key";
            ddl.DataSource = items;
            ddl.DataBind();
            return items;
        }
        private Dictionary<int, string> GetAll(DevMod.Models.MColor model, DropDownList ddl)
        {
            Dictionary<int, string> items = new Dictionary<int, string>();
            List<DevMod.Models.MColor> allBrands = new List<DevMod.Models.MColor>();
            if (HttpContext.Current.Cache["allBrands"] != null)
            {
                allBrands = (List<DevMod.Models.MColor>)HttpContext.Current.Cache["allColors"];
            }
            else
            {
                DevMod.Classes.CColor cb = new DevMod.Classes.CColor();
                allBrands = cb.GetAll();
            }
            foreach (var item in allBrands)
            {
                items.Add(Convert.ToInt32(item.id), item.Name);
            }
            ddl.DataTextField = "Value";
            ddl.DataValueField = "Key";
            ddl.DataSource = items;
            ddl.DataBind();
            return items;
        }
        private Dictionary<int, string> GetAll(DevMod.Models.MSubCategory model, DropDownList ddl)
        {
            Dictionary<int, string> items = new Dictionary<int, string>();
            List<DevMod.Models.MSubCategory> allBrands = new List<DevMod.Models.MSubCategory>();
            if (HttpContext.Current.Cache["allBrands"] != null)
            {
                allBrands = (List<DevMod.Models.MSubCategory>)HttpContext.Current.Cache["allSubCategories"];
            }
            else
            {
                DevMod.Classes.CSubCategory cb = new DevMod.Classes.CSubCategory();
                allBrands = cb.GetAll();
            }
            foreach (var item in allBrands)
            {
                items.Add(Convert.ToInt32(item.id), item.Name);
            }
            ddl.DataTextField = "Value";
            ddl.DataValueField = "Key";
            ddl.DataSource = items;
            ddl.DataBind();
            return items;
        }
        #endregion


    }
}