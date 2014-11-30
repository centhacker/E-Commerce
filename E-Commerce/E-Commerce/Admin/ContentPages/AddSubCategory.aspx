<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Master/Admin.Master" AutoEventWireup="true" CodeBehind="AddSubCategory.aspx.cs" Inherits="E_Commerce.Admin.ContentPages.AddSubCategory" %>
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
                                            <h2 class="block-title-2">Add New SubCategorys </h2>
                                            <h5><span style="color: red">Fields marked (*) are mandatory</span></h5>
                                        </div>


                                        <div class="col-xs-12 col-sm-8">
                                            <div class="form-group required">
                                                <label for="InputName">SubCategory Code<sup>*</sup> </label>
                                                <asp:TextBox ID="txtSubCategoryCode" runat="server" CssClass="form-control" ValidationGroup="frmAddress"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtSubCategoryCode" runat="server" SetFocusOnError="true" ErrorMessage="Please enter first Name" ValidationGroup="frmAddress" ForeColor="Red"></asp:RequiredFieldValidator>
                                            </div>
                                               <div class="form-group required">
                                                <label for="InputName">SubCategory Name <sup>*</sup> </label>
                                                <asp:TextBox ID="txtSubCategoryName" runat="server" CssClass="form-control" ValidationGroup="frmAddress"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="txtSubCategoryName" runat="server" SetFocusOnError="true" ErrorMessage="Please enter first Name" ValidationGroup="frmAddress" ForeColor="Red"></asp:RequiredFieldValidator>
                                            </div>
                                          <div class="form-group required">
                                                <label for="InputLastName">Image <sup>*</sup> </label>
                                                <asp:FileUpload ID="fuImage1" runat="server" CssClass="form-control" />
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
