<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Master/Admin.Master" AutoEventWireup="true" CodeBehind="AddCategory.aspx.cs" Inherits="E_Commerce.Admin.ContentPages.AddCategory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:UpdatePanel ID="upProducts" runat="server">
        <ContentTemplate>
            <div class="container main-container headerOffset">
                <div class="row">
                    <div class="col-lg-9 col-md-9 col-sm-12">
                        <div class="row userInfo">
                            <div class="col-xs-12 col-sm-12">
                                <div class="w100 clearfix">
                                    <div class="row userInfo">
                                        <div class="col-lg-8">
                                            <h2 class="block-title-2">Add New Categorys </h2>
                                            <h5><span style="color: red">Fields marked (*) are mandatory</span></h5>
                                        </div>


                                        <div class="col-xs-12 col-sm-8">
                                            <div class="form-group required">
                                                <label for="InputName">Category Code<sup>*</sup> </label>
                                                <asp:TextBox ID="txtCategoryCode" runat="server" CssClass="form-control" ValidationGroup="frmAddress"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtCategoryCode" runat="server" SetFocusOnError="true" ErrorMessage="Please enter first Name" ValidationGroup="frmAddress" ForeColor="Red"></asp:RequiredFieldValidator>
                                            </div>
                                               <div class="form-group required">
                                                <label for="InputName">Category Name <sup>*</sup> </label>
                                                <asp:TextBox ID="txtCategoryName" runat="server" CssClass="form-control" ValidationGroup="frmAddress"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="txtCategoryName" runat="server" SetFocusOnError="true" ErrorMessage="Please enter first Name" ValidationGroup="frmAddress" ForeColor="Red"></asp:RequiredFieldValidator>
                                            </div>
                                         

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
