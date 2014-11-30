<%@ Page Title="" Language="C#" MasterPageFile="~/WebMod/MasterPages/Commerce.Master" AutoEventWireup="true" CodeBehind="AllProducts.aspx.cs" Inherits="E_Commerce.WebMod.ContentPages.AllProducts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container main-container headerOffset">

        <!-- Main component call to action -->

        <div class="row">
            <div class="breadcrumbDiv col-lg-12">
                <ul class="breadcrumb">
                    <li><a href="Default.aspx">Home</a> </li>
                    <li class="active">All Products</li>
                </ul>
            </div>
        </div>
        <!-- /.row  -->

        <div class="row">

            <!--left column-->
            <asp:UpdatePanel ID="upLeftPanel" runat="server">
                <ContentTemplate>


                    <div class="col-lg-3 col-md-3 col-sm-12">
                        <div class="panel-group" id="accordionNo">
                            <!--Category-->
                            <div class="panel panel-default">
                                <div class="panel-heading">
                                    <h4 class="panel-title"><a data-toggle="collapse" class="collapseWill"><span class="pull-left"><i class="fa fa-caret-right"></i></span>Category </a><span class="pull-right clearFilter  label-danger">
                                        <asp:LinkButton ID="btnResetCategories" runat="server" OnClick="btnResetCategories_Click" Text="Reset" ForeColor="White"></asp:LinkButton>
                                    </span></h4>
                                </div>
                                <div id="collapseCategory" class="panel-collapse collapse in">
                                    <div class="panel-body">
                                        <ul class="nav nav-pills nav-stacked tree">
                                            <asp:Repeater ID="repCategories" runat="server" OnItemDataBound="repCategories_ItemDataBound" OnItemCommand="repCategories_ItemCommand">
                                                <ItemTemplate>
                                                    <li class=""><a class="dropdown-tree-a"><span class="badge pull-right">
                                                        <asp:Label ID="lblCategoryCount" runat="server" Text='<%# Eval("Count") %>'>
                                                        </asp:Label>
                                                    </span>

                                                        <asp:Label ID="lblCategoryName" runat="server" Text='<%# Eval("Name") %>'>
                                                        </asp:Label>
                                                    </a>
                                                        <ul class="category-level-2 dropdown-menu-tree">
                                                            <asp:Repeater ID="repSubCategories" runat="server" OnItemCommand="repSubCategories_ItemCommand">
                                                                <ItemTemplate>
                                                                    <li><a>
                                                                        <asp:LinkButton ID="lkSubName" runat="server" CommandArgument='<%# Eval("id") %>' CommandName="category">
                                                                            <asp:Label ID="lblSubCategoryName" runat="server" Text='<%# Eval("Name") %>'>
                                                                            </asp:Label>
                                                                        </asp:LinkButton>
                                                                    </a>
                                                                    </li>
                                                                </ItemTemplate>
                                                            </asp:Repeater>
                                                        </ul>
                                                    </li>
                                                </ItemTemplate>
                                            </asp:Repeater>




                                        </ul>
                                    </div>
                                </div>
                            </div>
                            <!--/Category menu end-->

                            <div class="panel panel-default">
                                <div class="panel-heading">
                                    <h4 class="panel-title"><a class="collapseWill" data-toggle="collapse" href="#">Price <span class="pull-left"><i class="fa fa-caret-right"></i></span></a>
                                        <span class="pull-right clearFilter  label-danger">
                                            <asp:LinkButton ID="btnResetPrice" runat="server" OnClick="btnResetPrice_Click" Text="Reset" ForeColor="White"></asp:LinkButton>
                                        </span></h4>
                                </div>
                                <div id="collapsePrice" class="panel-collapse collapse in">
                                    <div class="panel-body priceFilterBody">
                                        <!-- -->
                                        <asp:RadioButtonList ID="rdbPriceRanges" runat="server"></asp:RadioButtonList>

                                        <hr>
                                        <p>Enter a Price range </p>
                                        <form class="form-inline " role="form">
                                            <div class="form-group filter-textbox">
                                                <asp:TextBox ID="txtRangeFrom" runat="server" CssClass="form-control"></asp:TextBox>
                                            </div>
                                            <div class="form-group sp filter-textbox">
                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;---
                                            </div>
                                            <div class="form-group filter-textbox">
                                                <asp:TextBox ID="txtRangeTo" runat="server" CssClass="form-control"></asp:TextBox>
                                            </div>
                                            <asp:Button ID="btnPriceRange" runat="server" CssClass="btn btn-primary btn-xs btn-wide" Text="Filter" OnClick="btnPriceRange_Click"></asp:Button>
                                        </form>
                                    </div>
                                </div>
                            </div>
                            <!--/price panel end-->

                            <div class="panel panel-default">
                                <div class="panel-heading">
                                    <h4 class="panel-title"><a data-toggle="collapse" href="http://codepeoples.com/tanimdesign.net/tshop/html/category.html#collapseBrand" class="collapseWill">Brand <span class="pull-left"><i class="fa fa-caret-right"></i></span></a>
                                        <span class="pull-right clearFilter  label-danger">
                                            <asp:LinkButton ID="btnResetBrands" runat="server" OnClick="btnResetBrands_Click" Text="Reset" ForeColor="White"></asp:LinkButton>
                                        </span></h4>
                                </div>
                                <div id="collapseBrand" class="panel-collapse collapse in">
                                    <div class="panel-body ">
                                        <asp:CheckBoxList ID="cblBrands" runat="server"></asp:CheckBoxList>
                                        <asp:Button ID="btnBrand" CssClass="btn btn-primary btn-xs btn-wide" Text="Filter" runat="server" OnClick="btnBrand_Click" />
                                    </div>

                                </div>
                            </div>
                            <!--/brand panel end-->

                            <div class="panel panel-default">
                                <div class="panel-heading">
                                    <h4 class="panel-title"><a data-toggle="collapse" href="http://codepeoples.com/tanimdesign.net/tshop/html/category.html#collapseColor" class="collapseWill">Color <span class="pull-left"><i class="fa fa-caret-right"></i></span></a>
                                        <span class="pull-right clearFilter  label-danger">
                                            <asp:LinkButton ID="btnResetColors" runat="server" OnClick="btnResetColors_Click" Text="Reset" ForeColor="White"></asp:LinkButton>
                                        </span>
                                    </h4>
                                </div>
                                <div id="collapseColor" class="panel-collapse collapse in">
                                    <div class="panel-body smoothscroll  color-filter mCustomScrollbar _mCS_4" style="overflow: hidden;">

                                        <asp:CheckBox ID="cblColorsAll" runat="server" Text='All Colors'></asp:CheckBox>
                                        <br />
                                        <asp:Repeater ID="repColors" runat="server" OnItemCommand="repColors_ItemCommand" OnItemDataBound="repColors_ItemDataBound">
                                            <ItemTemplate>
                                                <asp:CheckBox ID="cblColors" runat="server" Text='<%# Eval("Name") %>'></asp:CheckBox>
                                                <small id="small" runat="server"></small>
                                                <br />
                                            </ItemTemplate>
                                            <FooterTemplate>
                                            </FooterTemplate>
                                        </asp:Repeater>
                                        <asp:Button ID="btnColorFilter" CssClass="btn btn-primary btn-xs btn-wide" Text="Filter" runat="server" OnClick="btnColorFilter_Click" />

                                    </div>
                                </div>
                            </div>
                            <!--/color panel end-->
                            <div class="panel panel-default">
                                <div class="panel-heading">
                                    <h4 class="panel-title"><a data-toggle="collapse" href="http://codepeoples.com/tanimdesign.net/tshop/html/category.html#collapseThree" class="collapseWill">Discount <span class="pull-left"><i class="fa fa-caret-right"></i></span></a>
                                         <span class="pull-right clearFilter  label-danger">
                                            <asp:LinkButton ID="btnResetDiscount" runat="server" OnClick="btnResetDiscount_Click" Text="Reset" ForeColor="White"></asp:LinkButton>
                                        </span>
                                    </h4>
                                </div>
                                <div id="collapseThree" class="panel-collapse collapse in">
                                    <div class="panel-body">
                                        <div class="block-element">
                                            <label style="display: none;">
                                                <input type="checkbox" name="tour" value="3" style="display: none;">
                                                Non-Discounted items
                                            </label>
                                            <span class="icr enabled" id="icr-45"><span class="icr__checkbox"></span><span class="icr__text">Non-Discounted items</span></span>
                                        </div>
                                        <div class="block-element">
                                            <label style="display: none;">
                                                <input type="checkbox" name="tour" value="3" style="display: none;">
                                                Discounted items
                                            </label>
                                            <span class="icr enabled" id="icr-46"><span class="icr__checkbox"></span><span class="icr__text">Discounted items</span></span>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <!--/discount  panel end-->
                        </div>
                    </div>


                    <div class="col-lg-9 col-md-9 col-sm-12">
                        <div class="parallax-section parallax-image-1" style="background-position: 50% 19px;">
                            <div class="w100 parallax-section-overley">
                                <div class="container">
                                    <div class="row">
                                        <div class="col-xs-12 col-sm-12 col-md-12 col-lg-12">
                                            <div class="parallax-content clearfix">
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <!--/.category-top-->

                        <div class="w100 productFilter clearfix">
                            <p class="pull-left">
                                Showing <strong>
                                    <asp:Label ID="lblProductsShowing" runat="server"></asp:Label>
                                </strong>products
                                
                            </p>

                            <div class="pagination no-margin-top pull-right">
                                <ul class="pagination no-margin-top">

                                    <asp:Repeater ID="repPaging" runat="server" OnItemCommand="repPaging_ItemCommand">
                                        <ItemTemplate>
                                            <li class='<%# Eval("class") %>'>
                                                <asp:LinkButton runat="server" CssClass="dropdown-tree-a" CommandArgument='<%# Eval("PageNumber") %>' CommandName="PageLoad">
                                                    <%# Eval("PageDisplay") %>
                                                </asp:LinkButton>
                                            </li>
                                        </ItemTemplate>
                                    </asp:Repeater>

                                </ul>


                            </div>
                            <br />
                            <div class="form-group reg-password " style="width: 50%; margin-top: 20px;">
                                <div>
                                    <label>Items Per Page:&nbsp;</label>
                                    <asp:DropDownList ID="ddlProductsPerPage" runat="server" CssClass="form-control input" OnSelectedIndexChanged="ddlProductsPerPage_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                                </div>
                            </div>

                        </div>
                        <!--/.productFilter-->

                        <!--/.productFilter-->
                        <div class="row  categoryProduct xsResponse clearfix">

                            <asp:Repeater ID="repFeaturedProducts" runat="server" OnItemCommand="repFeaturedProducts_ItemCommand">
                                <ItemTemplate>
                                    <div class="item col-sm-4 col-lg-4 col-md-4 col-xs-6">
                                        <div class="product">
                                            <div class="image">

                                                <asp:Image ID="imgProduct" runat="server" ImageUrl='<%# Eval("ImageUrl1") %>' CssClass="img-responsive" />
                                            </div>
                                            <div class="description">
                                                <h4>
                                                    <asp:LinkButton ID="lblProductName" runat="server" Text='<%# Eval("Name1") %>' CommandArgument='<%# Eval("ProductId") %>' CommandName="ProductDescription"></asp:LinkButton>
                                                </h4>
                                                <p>
                                                    <asp:LinkButton ID="lblDescription" runat="server" Text='<%# Eval("Description") %>' CommandArgument='<%# Eval("ProductId") %>' CommandName="ProductDescription"></asp:LinkButton>
                                                </p>
                                                <span class="size">
                                                    <asp:Label ID="lblSize" Text='<%# Eval("Size") %>' runat="server"></asp:Label>
                                                </span>

                                            </div>
                                            <div class="price">
                                                <span>
                                                    <asp:Label ID="lblPrice" Text='<%# Eval("Price") %>' runat="server"></asp:Label></span>
                                            </div>
                                            <div class="action-control">
                                                <a class="btn btn-primary">
                                                    <span class="add2cart">
                                                        <i class="glyphicon glyphicon-shopping-cart"></i>
                                                        <asp:Button ID="lbAddtoCart" runat="server" Text='Add To Cart' CssClass="btn btn-primary btn-inherit" CommandArgument='<%# Eval("ProductId") %>' CommandName="AddToCart"></asp:Button>

                                                    </span></a>
                                            </div>
                                        </div>
                                    </div>
                                </ItemTemplate>
                            </asp:Repeater>

                        </div>
                        <!--/.categoryProduct || product content end-->

                        <div class="w100 categoryFooter">
                        </div>
                        <!--/.categoryFooter-->
                    </div>

                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
        <!-- /.row  -->
    </div>
</asp:Content>
