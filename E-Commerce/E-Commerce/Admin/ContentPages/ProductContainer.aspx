<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Master/Admin.Master" AutoEventWireup="true" CodeBehind="ProductContainer.aspx.cs" Inherits="E_Commerce.Admin.ContentPages.ProductContainer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:UpdatePanel ID="upProducts" runat="server">
        <ContentTemplate>
            <div class="container main-container headerOffset">
                <div class="row">
                    <div class="col-lg-12 col-md-12 col-sm-12">
                        <div class="row userInfo">
                            <div class="col-xs-12 col-sm-12">
                                <div class="w100 clearfix">
                                    <div class="row userInfo">
                                        <div class="col-lg-8">
                                            <h2 class="block-title-2">Product Properties </h2>
                                            <h5><span style="color: red">Add New rows to add products properties</span></h5>
                                        </div>


                                        <div class="col-xs-12 col-sm-12">
                                            <asp:GridView ID="grdSales" runat="server"
                                                ShowFooter="True" AutoGenerateColumns="False"
                                                CellPadding="4" CssClass="table table-hover table-striped"
                                                GridLines="None" OnRowDeleting="grdSales_RowDeleting">
                                                <Columns>


                                                    <asp:TemplateField HeaderText="Products">
                                                        <ItemTemplate>
                                                            <asp:DropDownList ID="ddlProducts" runat="server" CssClass="grid-control form-control" AutoPostBack="true">
                                                            </asp:DropDownList>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>



                                                    <asp:TemplateField HeaderText="Category">
                                                        <ItemTemplate>
                                                            <asp:DropDownList ID="ddlCategory" runat="server" CssClass="grid-control form-control" AutoPostBack="true">
                                                            </asp:DropDownList>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>

                                                    <asp:TemplateField HeaderText="Brand">
                                                        <ItemTemplate>
                                                            <asp:DropDownList ID="ddlBrand" runat="server" CssClass="grid-control form-control" AutoPostBack="true">
                                                            </asp:DropDownList>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Color">
                                                        <ItemTemplate>
                                                            <asp:DropDownList ID="ddlColor" runat="server" CssClass="grid-control form-control" AutoPostBack="true">
                                                            </asp:DropDownList>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Sub Category">
                                                        <ItemTemplate>
                                                            <asp:DropDownList ID="ddlSubCategory" runat="server" CssClass="grid-control form-control" AutoPostBack="true">
                                                            </asp:DropDownList>
                                                        </ItemTemplate>

                                                        <FooterStyle HorizontalAlign="Left" />
                                                        <FooterTemplate>
                                                            <asp:Button ID="ButtonAdd" runat="server" Text="Add New Row" CssClass="btn btn-primary" OnClick="ButtonAdd_Click" />
                                                        </FooterTemplate>
                                                    </asp:TemplateField>

                                                    <asp:CommandField
                                                        ShowDeleteButton="True" />
                                                </Columns>


                                            </asp:GridView>

                                        </div>
                                        <div class="cartFooter w100">
                                            <div class="box-footer">
                                                <div class="pull-right">
                                                       <asp:LinkButton ID="lkSave" runat="server" CssClass="btn btn-primary " ValidationGroup="frmAddress" OnClick="lkSave_Click"><i class="fa-stop"></i>&nbsp;&nbsp;Save</asp:LinkButton>
                                                </div>

                                            </div>
                                        </div>


                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
