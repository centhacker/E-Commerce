<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Master/Admin.Master" AutoEventWireup="true" CodeBehind="AddProducts.aspx.cs" Inherits="E_Commerce.Admin.ContentPages.AddProducts" %>

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
                                            <h2 class="block-title-2">Add New Products </h2>
                                            <h5><span style="color: red">Fields marked (*) are mandatory</span></h5>
                                        </div>


                                        <div class="col-xs-12 col-sm-8">
                                            <div class="form-group required">
                                                <label for="InputName">Product Name <sup>*</sup> </label>
                                                <asp:TextBox ID="txtProductName" runat="server" CssClass="form-control" ValidationGroup="frmAddress"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtProductName" runat="server" SetFocusOnError="true" ErrorMessage="Please enter first Name" ValidationGroup="frmAddress" ForeColor="Red"></asp:RequiredFieldValidator>
                                            </div>
                                            <div class="form-group required">
                                                <label for="InputLastName">Product Code<sup>*</sup> </label>
                                                <asp:TextBox ID="txtProductCode" runat="server" CssClass="form-control" ValidationGroup="frmAddress"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="txtProductCode" runat="server" SetFocusOnError="true" ErrorMessage="Please enter Last Name" ValidationGroup="frmAddress" ForeColor="Red"></asp:RequiredFieldValidator>
                                            </div>
                                            <div class="form-group">
                                                <label for="InputEmail">Product Name 2</label>
                                                <asp:TextBox ID="txtProductName2" runat="server" CssClass="form-control" ValidationGroup="frmAddress"></asp:TextBox>
                                            </div>
                                            <div class="form-group">
                                                <label for="InputEmail">Product Name 3</label>
                                                <asp:TextBox ID="txtProductName3" runat="server" CssClass="form-control" ValidationGroup="frmAddress"></asp:TextBox>
                                            </div>
                                            <div class="form-group required">
                                                <label for="InputLastName">Image 1<sup>*</sup> </label>
                                                <asp:FileUpload ID="fuImage1" runat="server" CssClass="form-control" />
                                            </div>
                                            <div class="form-group required">
                                                <label for="InputLastName">Image 2<sup>*</sup> </label>
                                                <asp:FileUpload ID="fuImage2" runat="server" CssClass="form-control" />
                                            </div>
                                            <div class="form-group required">
                                                <label for="InputLastName">Image 3<sup>*</sup> </label>
                                                <asp:FileUpload ID="fuImage3" runat="server" CssClass="form-control" />
                                            </div>
                                            <div class="form-group required">
                                                <label for="InputLastName">Price<sup>*</sup> </label>
                                                <asp:TextBox ID="txtPrice" runat="server" CssClass="form-control" TextMode="Number" ValidationGroup="frmAddress"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="txtPrice" runat="server" SetFocusOnError="true" ErrorMessage="Please enter Last Name" ValidationGroup="frmAddress" ForeColor="Red"></asp:RequiredFieldValidator>
                                            </div>
                                            <div class="form-group required">
                                                <label for="InputLastName">Product Description<sup>*</sup> </label>
                                                <asp:TextBox ID="txtDescription" runat="server" CssClass="form-control" ValidationGroup="frmAddress"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="txtDescription" runat="server" SetFocusOnError="true" ErrorMessage="Please enter Last Name" ValidationGroup="frmAddress" ForeColor="Red"></asp:RequiredFieldValidator>
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
