<%@ Page Title="" Language="C#" MasterPageFile="~/WebMod/MasterPages/Commerce.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="E_Commerce.WebMod.ContentPages.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:UpdatePanel ID="upDefault" runat="server">
        <ContentTemplate>
            <div class="container main-container headerOffset globalPaddingBottom">
                <!-- Main component call to action -->
                <div class="col-lg-12 text-center">
                    <div class="home-intro">
                        <h2>Discover a Better Shopping <span>Experience</span> -  clothes, fashion &amp; more </h2>
                    </div>
                    <hr />
                </div>
                <div style="clear: both"></div>
                <div class="col-sm-10 show-case-wrapper center-block relative">
                    <div id="productShowCase" class="owl-carousel owl-theme" style="opacity: 1; display: block;">
                        <div class="owl-wrapper-outer autoHeight" style="height: 380px;">
                            <div id="slider" class="owl-wrapper" style="width: 7560px; left: 0px; display: block;">
                                <div class="owl-item" style="width: 945px;">
                                    <div class="product-slide">
                                        <div class="col-sm-5 product-slide-left">
                                            <a class="product-slide-img">
                                                <img alt="img" src="../../Scripts/images/24.jpg" class="img-responsive" /></a>
                                        </div>
                                        <div class="col-sm-7">
                                            <div class="product-slide-inner ">
                                                <h1 class="product-title">Lorem ipsum dolor sit amet</h1>
                                                <h3 class="product-code">Product Code : DEN1098</h3>
                                                <div class="product-price"><span class="price-sales">$70</span> <span class="price-standard">$95</span> </div>
                                                <div class="details-description">
                                                    <p>Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui blandit praesent luptatum </p>
                                                </div>

                                            </div>
                                        </div>

                                    </div>
                                </div>
                                <div class="owl-item" style="width: 945px;">
                                    <div class="product-slide">
                                        <div class="col-sm-5 product-slide-left">
                                            <a class="product-slide-img">
                                                <img alt="img" src="../../Scripts/images/30.jpg" class="img-responsive"></a>
                                        </div>
                                        <div class="col-sm-7 ">
                                            <div class="product-slide-inner ">
                                                <h1 class="product-title">Lorem ipsum dolor sit amet</h1>
                                                <h3 class="product-code">Product Code : DEN1098</h3>
                                                <div class="product-price"><span class="price-sales">$70</span> <span class="price-standard">$95</span> </div>
                                                <div class="details-description">
                                                    <p>Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui blandit praesent luptatum </p>
                                                </div>

                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="owl-item" style="width: 945px;">
                                    <div class="product-slide">
                                        <div class="col-sm-5 product-slide-left">
                                            <a class="product-slide-img">
                                                <img alt="img" src="../../Scripts/images/a2.jpg" class="img-responsive"></a>
                                        </div>
                                        <div class="col-sm-7 ">
                                            <div class="product-slide-inner">
                                                <h1 class="product-title">Lorem ipsum dolor sit amet</h1>
                                                <h3 class="product-code">Product Code : DEN1098</h3>
                                                <div class="product-price"><span class="price-sales">$70</span> <span class="price-standard">$95</span> </div>
                                                <div class="details-description">
                                                    <p>Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui blandit praesent luptatum Duis autem vel </p>
                                                </div>

                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="owl-item" style="width: 945px;">
                                    <div class="product-slide">
                                        <div class="col-sm-5 product-slide-left">
                                            <a class="product-slide-img">
                                                <img alt="img" src="../../Scripts/images/5.jpg" class="img-responsive"></a>
                                        </div>
                                        <div class="col-sm-7 ">
                                            <div class="product-slide-inner  ">
                                                <h1 class="product-title">Lorem ipsum dolor sit amet</h1>
                                                <h3 class="product-code">Product Code : DEN1098</h3>
                                                <div class="product-price"><span class="price-sales">$70</span> <span class="price-standard">$95</span> </div>
                                                <div class="details-description">
                                                    <p>Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui blandit praesent luptatum</p>
                                                </div>

                                            </div>
                                        </div>
                                    </div>
                                </div>

                            </div>
                        </div>




                    </div>
                    <!--/#productShowCase -->

                    <div style="clear: both;"></div>
                    <a id="ps-next" class="ps-nav"><i class="fa fa-angle-right"></i></a><a id="ps-prev" class="ps-nav"><i class="fa fa-angle-left"></i></a>
                </div>
                <!--/.show-case-wrapper -->
                <div class="row featuredPostContainer ">
                    <div class="featured-category"></div>
                    <div class="col-lg-12">
                        <h3 class="boxes-title-1"><span>NEW ARRIVALS</span></h3>
                    </div>
                    <div style="clear: both;"></div>
                    <div id="productslider" class="owl-carousel owl-theme" style="opacity: 1; display: block;">
                        <div class="owl-wrapper-outer">
                            <div id="newArrivals" class="owl-wrapper" style="width: 5400px; left: 0px; display: block;">

                                <asp:Repeater ID="repNewArrivals" runat="server" ClientIDMode="Static" OnItemCommand="repNewArrivals_ItemCommand">
                                    <ItemTemplate>
                                        <div class="owl-item" style="width: 300px;">
                                            <div class="item">
                                                <div class="product">
                                                    <div class="image">

                                                        <asp:Image ID="imgProduct" runat="server" ImageUrl='<%# Eval("ImageUrl1") %>' CssClass="img-responsive" />
                                                        <div class="promotion">
                                                            <span class="new-product">
                                                                <asp:Label ID="lblNew" Text='<%# Eval("New") %>' runat="server"></asp:Label>
                                                            </span><span class="discount">
                                                                <asp:Label ID="lblDiscountedPercent" Text='<%# Eval("DiscountedPercent") %>' runat="server"></asp:Label>

                                                            </span>
                                                        </div>
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
                                        </div>


                                    </ItemTemplate>

                                </asp:Repeater>

                            </div>
                        </div>

                    </div>
                    <!--/.productslider-->

                </div>
                <!--/.featuredPostContainer-->



            </div>
            <!-- /main container -->

            <div class="w100 sectionCategory">
                <div class="container">
                    <div class="sectionCategoryIntro text-center">
                        <h1>Featured Categories</h1>
                        <p>All the featured categories are displayed here</p>
                    </div>
                    <div class="row subCategoryList clearfix">

                        <asp:Repeater ID="repFeaturedCategories" runat="server" ClientIDMode="Static" OnItemCommand="repFeaturedCategories_ItemCommand">
                            <ItemTemplate>
                                <div class="col-md-2 col-sm-3 col-xs-4  col-xs-mini-6  text-center ">
                                    <div class="thumbnail equalheight" style="height: 213px;">
                                        <span class="subCategoryThumb">
                                            <asp:Image ID="imgProduct" runat="server" ImageUrl='<%# Eval("ImageUrl") %>' CssClass="img-rounded" />
                                        </span>
                                        <a class="subCategoryTitle"><span>
                                            <asp:LinkButton runat="server" Text='<%# Eval("Code") %>'></asp:LinkButton>
                                            <asp:LinkButton ID="lkName" runat="server" Text='<%# Eval("Name") %>'></asp:LinkButton>
                                        </span></a>
                                    </div>
                                </div>
                            </ItemTemplate>
                        </asp:Repeater>

                    </div>


                    <!--/.row-->

                </div>
                <!--/.container-->
            </div>

            <div class="container main-container">

                <!-- Main component call to action -->

                <div class="morePost row featuredPostContainer style2 globalPaddingTop ">
                    <div class="col-lg-12">
                        <h3 class="boxes-title-1"><span>FEATURED PRODUCT</span></h3>
                    </div>
                    <div class="container">
                        <div class="row xsResponse">

                            <asp:Repeater ID="repFeaturedProducts" runat="server" OnItemCommand="repFeaturedProducts_ItemCommand">
                                <ItemTemplate>
                                    <div class="item col-lg-3 col-md-3 col-sm-4 col-xs-6">
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
                        <!--/.container-->
                    </div>
                    <!--/.featuredPostContainer-->




                    <!--/.section-block-->

                </div>
                <!--main-container-->

            </div>
        </ContentTemplate>
    </asp:UpdatePanel>


</asp:Content>
