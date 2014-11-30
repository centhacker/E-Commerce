<%@ Page Title="" Language="C#" MasterPageFile="~/WebMod/MasterPages/Commerce.Master" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="E_Commerce.WebMod.ContentPages.Checkout" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:UpdatePanel ID="upCheckout" runat="server">
        <ContentTemplate>
            <div class="container main-container headerOffset">
                <div class="row">
                    <div class="breadcrumbDiv col-lg-12">
                        <ul class="breadcrumb">
                            <li><a href="index.html">Home</a> </li>
                            <li><a href="cart.html">Products</a> </li>
                            <li class="active">Checkout </li>
                        </ul>
                    </div>
                </div>
                <!--/.row-->

                <div class="row">
                    <div class="col-lg-9 col-md-9 col-sm-7">
                        <h1 class="section-title-inner"><span><i class="glyphicon glyphicon-shopping-cart"></i>Checkout</span></h1>
                    </div>
                    <div class="col-lg-3 col-md-3 col-sm-5 rightSidebar">
                        <h4 class="caps">
                            <asp:LinkButton ID="lkBackToShopping" runat="server"><i class="fa fa-chevron-left"></i>&nbsp;&nbsp;Back to shopping </asp:LinkButton>

                        </h4>
                    </div>
                </div>
                <!--/.row-->

                <div class="row">
                    <div class="col-lg-9 col-md-9 col-sm-12">
                        <div class="row userInfo">
                            <div class="col-xs-12 col-sm-12">
                                <div class="w100 clearfix">
                                    <ul class="orderStep ">

                                        <li id="liPersonalDetails" class="active" runat="server">
                                            <a href="#"><i class="fa fa-map-marker "></i><span>Details</span> </a>

                                        </li>

                                        <li id="liProductDetails" runat="server"><a href="#">
                                            <i class="fa fa fa-envelope  "></i><span>Products Details</span></a>

                                        </li>
                                        <li id="liPerosnalDetailsConfirmation" runat="server">
                                            <a href="#"><i class="fa fa-truck "></i><span>Details Confirmation</span> </a>

                                        </li>
                                        <li id="liProductDetailsConfirmation" runat="server">
                                            <a href="#"><i class="fa fa-truck "></i><span>Product Confirmation</span> </a>

                                        </li>
                                    </ul>
                                    <!--/.orderStep end-->
                                </div>


                                <div class="w100 clearfix">
                                    <!-- row start-->
                                    <div id="divPersonalDetails" runat="server" class="row userInfo">
                                        <div class="col-lg-12">
                                            <h2 class="block-title-2">To add the address and details, please fill out the form below. </h2>
                                            <h5><span style="color: red">Fields marked (*) are mandatory</span></h5>
                                        </div>


                                        <div class="col-xs-12 col-sm-6">
                                            <div class="form-group required">
                                                <label for="InputName">First Name <sup>*</sup> </label>
                                                <asp:TextBox ID="txtFirstName" runat="server" CssClass="form-control" ValidationGroup="frmAddress"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtFirstName" runat="server" SetFocusOnError="true" ErrorMessage="Please enter first Name" ValidationGroup="frmAddress" ForeColor="Red"></asp:RequiredFieldValidator>
                                            </div>
                                            <div class="form-group required">
                                                <label for="InputLastName">Last Name <sup>*</sup> </label>
                                                <asp:TextBox ID="txtLastName" runat="server" CssClass="form-control" ValidationGroup="frmAddress"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="txtLastName" runat="server" SetFocusOnError="true" ErrorMessage="Please enter Last Name" ValidationGroup="frmAddress" ForeColor="Red"></asp:RequiredFieldValidator>
                                            </div>
                                            <div class="form-group">
                                                <label for="InputEmail">Email  <sup>*</sup></label>
                                                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" ValidationGroup="frmAddress"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="txtEmail" runat="server" SetFocusOnError="true" ErrorMessage="Please enter Email Address" ValidationGroup="frmAddress" ForeColor="Red"></asp:RequiredFieldValidator>
                                            </div>
                                            <div class="form-group">
                                                <label for="InputEmail">Address <sup>*</sup> </label>
                                                <asp:TextBox ID="txtAddress" TextMode="MultiLine" runat="server" CssClass="form-control" ValidationGroup="frmAddress"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ControlToValidate="txtAddress" runat="server" SetFocusOnError="true" ErrorMessage="Please enter delivery Address" ValidationGroup="frmAddress" ForeColor="Red"></asp:RequiredFieldValidator>
                                            </div>
                                        </div>
                                        <div class="col-xs-12 col-sm-6">
                                            <div class="form-group required">
                                                <label for="InputZip">Phone Number 1 <sup>*</sup> </label>
                                                <asp:TextBox ID="txtPhone1" runat="server" CssClass="form-control" ValidationGroup="frmAddress"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="txtPhone1" runat="server" SetFocusOnError="true" ErrorMessage="Please enter Phone Number" ValidationGroup="frmAddress" ForeColor="Red"></asp:RequiredFieldValidator>

                                            </div>

                                            <div class="form-group">
                                                <label for="InputAdditionalInformation">Additional Phone Number</label>
                                                <asp:TextBox ID="txtAdditionalPhoneNumber" runat="server" CssClass="form-control" ValidationGroup="frmAddress"></asp:TextBox>
                                            </div>
                                            <div class="form-group required">
                                                <label for="InputMobile">Alternate Email</label>
                                                <asp:TextBox ID="txtAlternateEmail" runat="server" CssClass="form-control" ValidationGroup="frmAddress"></asp:TextBox>
                                            </div>

                                        </div>

                                    </div>
                                    <!--/row end-->

                                    <!-- row start-->
                                    <div id="divProductDetails" runat="server" class="row userInfo">
                                        <div class="col-lg-12">
                                            <h2 class="block-title-2">Please select colors and units of each products </h2>
                                            <h5><span style="color: red">By default each product has 1 unit</span></h5>
                                        </div>


                                        <div class="col-xs-12 col-sm-12">
                                            <asp:GridView ID="grdProducts" runat="server"
                                                ShowFooter="True" AutoGenerateColumns="False"
                                                CellPadding="4" CssClass="table table-hover table-striped"
                                                GridLines="None" OnRowDataBound="grdProducts_RowDataBound">
                                                <Columns>
                                                    <asp:BoundField DataField="ProductId" HeaderText="Product" />
                                                    <asp:ImageField  DataImageUrlField="ImageUrl" ControlStyle-CssClass="img-responsive" HeaderText="Product" ControlStyle-Height="100px">
                                                    </asp:ImageField>
                                                    <asp:BoundField DataField="Name" HeaderText="Product" />
                                                    <asp:BoundField DataField="Price" HeaderText="Price" />
                                                    <asp:TemplateField HeaderText="Colors">
                                                        <ItemTemplate>
                                                            <asp:DropDownList ID="ddlColors" runat="server" CssClass="grid-control form-control">
                                                            </asp:DropDownList>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Units">
                                                        <ItemTemplate>
                                                            <asp:TextBox ID="txtUnits" TextMode="Number" runat="server" CssClass="grid-control form-control">
                                                            </asp:TextBox>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                </Columns>
                                            </asp:GridView>
                                        </div>


                                    </div>
                                    <!--/row end-->

                                    <!-- row start-->
                                    <div id="divProductDetailsConfirmation" runat="server" class="row userInfo">
                                        <div class="col-lg-12">
                                            <h2 class="block-title-2">Please review your order</h2>

                                        </div>
                                        <div class="col-xs-12 col-sm-12">
                                            <asp:GridView ID="grdProductConfirmation" runat="server"
                                                ShowFooter="True" AutoGenerateColumns="False"
                                                CellPadding="4" CssClass="table table-hover table-striped"
                                                GridLines="None">
                                                <Columns>

                                                    <asp:ImageField DataImageUrlField="ImageUrl" ControlStyle-CssClass="img-responsive" HeaderText="Product" ControlStyle-Height="100px">
                                                    </asp:ImageField>
                                                    <asp:BoundField DataField="Name" HeaderText="Product" />
                                                    <asp:BoundField DataField="Price" HeaderText="Price" />
                                                    <asp:BoundField DataField="Color" HeaderText="Color" />
                                                    <asp:BoundField DataField="Units" HeaderText="Units" />
                                                </Columns>
                                            </asp:GridView>
                                        </div>


                                    </div>
                                    <!--/row end-->

                                    <!-- row start-->
                                    <div id="divPerosnalDetailsConfirmation" runat="server" class="row userInfo">
                                        <div class="col-lg-12">
                                            <h2 class="block-title-2">Please review your details</h2>

                                        </div>

                                        <div class="col-xs-12 col-sm-6">
                                            <div class="form-group required">
                                                <label for="InputName">First Name <sup>*</sup> </label>
                                                <asp:Label ID="lblFirstName" runat="server" CssClass="form-control"></asp:Label>
                                            </div>
                                            <div class="form-group required">
                                                <label for="InputLastName">Last Name <sup>*</sup> </label>
                                                <asp:Label ID="lblLastName" runat="server" CssClass="form-control"></asp:Label>
                                            </div>
                                            <div class="form-group">
                                                <label for="InputEmail">Email  <sup>*</sup></label>
                                                <asp:Label ID="lblEmail" runat="server" CssClass="form-control"></asp:Label>
                                            </div>
                                            <div class="form-group">
                                                <label for="InputEmail">Address <sup>*</sup> </label>
                                                <asp:Label ID="lblAddress" TextMode="MultiLine" runat="server" CssClass="form-control"></asp:Label>
                                            </div>
                                        </div>
                                        <div class="col-xs-12 col-sm-6">
                                            <div class="form-group required">
                                                <label for="InputZip">Phone Number 1 <sup>*</sup> </label>
                                                <asp:Label ID="lblPhoneNumber1" runat="server" CssClass="form-control"></asp:Label>

                                            </div>

                                            <div class="form-group">
                                                <label for="InputAdditionalInformation">Additional Phone Number</label>
                                                <asp:Label ID="lblAdditionalPhoneNumber" runat="server" CssClass="form-control"></asp:Label>
                                            </div>
                                            <div class="form-group required">
                                                <label for="InputMobile">Alternate Email</label>
                                                <asp:Label ID="lblAlternateEmail" runat="server" CssClass="form-control"></asp:Label>
                                            </div>

                                        </div>

                                    </div>
                                    <!--/row end-->


                                </div>
                                <div class="cartFooter w100">
                                    <div class="box-footer">
                                        <div class="pull-left">
                                            <asp:LinkButton ID="lkPrev" runat="server" CssClass="btn btn-small" ValidationGroup="frmAddress" OnClick="lkPrev_Click"><i class="fa fa-arrow-circle-left"></i>&nbsp;&nbsp;Previous</asp:LinkButton>
                                        </div>
                                        <div class="pull-right">
                                            <asp:LinkButton ID="lkNext" runat="server" CssClass="btn btn-primary btn-small" ValidationGroup="frmAddress" OnClick="lkNext_Click">Next&nbsp; <i class="fa fa-arrow-circle-right"></i></asp:LinkButton>
                                        </div>
                                    </div>
                                </div>
                                <!--/ cartFooter -->

                            </div>
                        </div>
                        <!--/row end-->

                    </div>
                    <div class="col-lg-3 col-md-3 col-sm-12 rightSidebar">
                        <div class="w100 cartMiniTable">
                            <table id="cart-summary" class="std table">
                                <tbody>
                                    <tr>
                                        <td>Total products</td>
                                        <td class="price">
                                            <asp:Label ID="lblTotalProducts" runat="server"></asp:Label></td>
                                    </tr>
                                    <tr style="">
                                        <td>Shipping</td>
                                        <td class="price"><span class="success">Free shipping!</span></td>
                                    </tr>
                                    <tr class="cart-total-price ">
                                        <td>Total (tax excl.)</td>
                                        <td class="price">
                                            <asp:Label ID="lblTotal" runat="server"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>Discount</td>
                                        <td class="price" id="total-tax">$0.00</td>
                                    </tr>
                                    <tr>
                                        <td>Total </td>
                                        <td class=" site-color" id="total-price">
                                            <asp:Label ID="lblTotal2" runat="server"></asp:Label></td>
                                    </tr>
                                </tbody>
                                <tbody>
                                </tbody>
                            </table>
                        </div>
                        <!--  /cartMiniTable-->

                    </div>
                    <!--/rightSidebar-->

                </div>
                <!--/row-->

                <div style="clear: both"></div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
