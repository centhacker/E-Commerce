<%@ Page Title="" Language="C#" MasterPageFile="~/WebMod/MasterPages/Commerce.Master" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs" Inherits="E_Commerce.WebMod.ContentPages.ProductDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:UpdatePanel ID="upProductDetail" runat="server">
        <ContentTemplate>
            <div class="container main-container headerOffset">
                <div class="row">
                    <div class="breadcrumbDiv col-lg-12">
                        <ul class="breadcrumb">
                            <li><a href="index.html">Home</a> </li>
                            <li><a href="category.html">PRODUCT COLLECTION</a> </li>
                            <li><a href="sub-category.html">TSHIRT</a> </li>
                            <li class="active">Lorem ipsum dolor sit amet </li>
                        </ul>
                    </div>
                </div>
                <div class="row transitionfx">

                    <!-- left column -->
                    <div class="col-lg-6 col-md-6 col-sm-6">
                        <!-- product Image and Zoom -->
                        <div class="main-image sp-wrap col-lg-12 no-padding" style="display: inline-block;">



                            <div class="sp-large">
                                <a href="#" class="">
                                    <asp:Image ID="imgLarge" runat="server" ImageUrl="../../Scripts/images/zoom1.jpg" CssClass="img-responsive" />

                                </a>
                            </div>
                            <div class="sp-thumbs sp-tb-active">
                                <a href="#">
                                    <asp:LinkButton ID="lkimgzoom1" runat="server" OnClick="lkimgzoom1_Click" CssClass="sp-current">
                                        <asp:Image ID="imgZoom1" runat="server" ImageUrl="../../Scripts/images/zoom1.jpg" CssClass="img-responsive" />
                                    </asp:LinkButton>

                                </a>
                                <a href="#">
                                    <asp:LinkButton ID="lkimgzoom2" runat="server" OnClick="lkimgzoom2_Click">
                                        <asp:Image ID="imgZoom2" runat="server" ImageUrl="../../Scripts/images/zoom2.jpg" CssClass="img-responsive" />
                                    </asp:LinkButton>
                                </a>
                                <a href="#">
                                    <asp:LinkButton ID="lkimgzoom3" runat="server" OnClick="lkimgzoom3_Click">
                                        <asp:Image ID="imgZoom3" runat="server" ImageUrl="../../Scripts/images/zoom3.jpg" CssClass="img-responsive" />
                                    </asp:LinkButton>
                                </a>
                            </div>
                        </div>
                    </div>
                    <!--/ left column end -->


                    <!-- right column -->
                    <div class="col-lg-6 col-md-6 col-sm-5">

                        <h1 class="product-title">
                            <asp:Label ID="lblName" runat="server"></asp:Label>
                        </h1>
                        <h3 class="product-code">Product Code :
                            <asp:Label ID="lblProductCode" runat="server"></asp:Label>
                        </h3>
                        <h3 class="product-code">
                            <asp:Label ID="lblProductId" runat="server"></asp:Label>
                        </h3>
                        <div class="product-price">
                            <span class="price-sales">Price :
                                <asp:Label ID="lblPrice" runat="server"></asp:Label>
                            </span>
                            <span class="price-standard">Discounted Price : 
                                <asp:Label ID="lblDiscountedPrice" runat="server"></asp:Label>
                            </span>
                        </div>

                        <div class="details-description">
                            <p>
                                <asp:Label ID="lblDescription" runat="server"></asp:Label>
                            </p>
                        </div>




                        <div class="cart-actions">
                            <div class="addto">
                                <asp:Button ID="btnAddToCart" runat="server" CssClass="button btn-primary btn-cart cart first" Text="Add to Cart" OnClick="btnAddToCart_Click"></asp:Button>
                                <asp:Button ID="btnCheckout" runat="server" CssClass="link-wishlist wishlist" Text="Checkout"></asp:Button>

                            </div>

                            <div style="clear: both"></div>

                            <h3 class="incaps"><i class="fa fa fa-check-circle-o color-in"></i>In stock</h3>
                            <h3 class="incaps"><i class="fa fa-minus-circle color-out"></i>Out of stock</h3>

                        </div>
                        <!--/.cart-actions-->

                        <div class="clear"></div>

                        <div class="product-tab w100 clearfix">

                            <ul class="nav nav-tabs">
                                <li class="active"><a href="#details" data-toggle="tab">Details</a></li>
                                <li><a href="#size" data-toggle="tab">Size</a></li>
                                <li><a href="#shipping" data-toggle="tab">Colors</a></li>
                            </ul>

                            <!-- Tab panes -->
                            <div class="tab-content">
                                <div class="tab-pane active" id="details">
                                    Sed ut eros felis. Vestibulum rutrum imperdiet nunc a interdum. In scelerisque libero ut elit porttitor commodo. Suspendisse laoreet magna nec urna fringilla viverra.<br>
                                    100% Cotton<br>
                                </div>
                                <div class="tab-pane" id="size">
                                    16" waist<br>
                                    34" inseam<br>
                                    10.5" front rise<br>
                                    8.5" knee<br>
                                    7.5" leg opening<br>
                                    <br>
                                    Measurements taken from size 30<br>
                                    Model wears size 31. Model is 6'2
                            <br>
                                    <br>
                                </div>

                                <div class="tab-pane" id="shipping">
                                    <table>
                                        <colgroup>
                                            <col style="width: 33%">
                                            <col style="width: 33%">
                                            <col style="width: 33%">
                                        </colgroup>
                                        <tbody>
                                            <tr>
                                                <td>Standard</td>
                                                <td>1-5 business days</td>
                                                <td>$7.95</td>
                                            </tr>
                                            <tr>
                                                <td>Two Day</td>
                                                <td>2 business days</td>
                                                <td>$15</td>
                                            </tr>
                                            <tr>
                                                <td>Next Day</td>
                                                <td>1 business day</td>
                                                <td>$30</td>
                                            </tr>
                                        </tbody>
                                        <tfoot>
                                            <tr>
                                                <td colspan="3">* Free on orders of $50 or more</td>
                                            </tr>
                                        </tfoot>
                                    </table>
                                </div>

                            </div>
                            <!-- /.tab content -->

                        </div>
                        <!--/.product-tab-->

                        <div style="clear: both"></div>


                        <!--/.product-share-->

                    </div>
                    <!--/ right column end -->

                </div>
                <!--/.row-->

                <div class="row recommended">

                    <h1>YOU MAY ALOS LIKE </h1>
                    <div id="SimilarProductSlider" class="owl-carousel owl-theme" style="opacity: 1; display: block;">
                        <div class="owl-wrapper-outer">
                            <div class="owl-wrapper" style="width: 3744px; left: 0px; display: block;">
                                <div class="owl-item" style="width: 234px;">
                                    <div class="item">
                                        <div class="product">
                                            <a class="product-image">
                                                <img src="../../Scripts/images/a1.jpg" alt="img">
                                            </a>
                                            <div class="description">
                                                <h4><a href="san-remo-spaghetti">YOUR LIFE</a></h4>
                                                <div class="price"><span>$57</span> </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="owl-item" style="width: 234px;">
                                    <div class="item">
                                        <div class="product">
                                            <a class="product-image">
                                                <img src="../../Scripts/images/a2.jpg" alt="img">
                                            </a>
                                            <div class="description">
                                                <h4><a href="san-remo-spaghetti">RED CROWN</a></h4>
                                                <div class="price"><span>$44</span> </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="owl-item" style="width: 234px;">
                                    <div class="item">
                                        <div class="product">
                                            <a class="product-image">
                                                <img src="../../Scripts/images/a3.jpg" alt="img">
                                            </a>
                                            <div class="description">
                                                <h4><a href="san-remo-spaghetti">WHITE GOLD</a></h4>
                                                <div class="price"><span>$35</span></div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="owl-item" style="width: 234px;">
                                    <div class="item">
                                        <div class="product">
                                            <a class="product-image">
                                                <img src="../../Scripts/images/a4.jpg" alt="img">
                                            </a>
                                            <div class="description">
                                                <h4><a href="san-remo-spaghetti">DENIM 4240</a></h4>
                                                <div class="price">$<span>55</span></div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="owl-item" style="width: 234px;">
                                    <div class="item">
                                        <div class="product">
                                            <a class="product-image">
                                                <img src="../../Scripts/images/30.jpg" alt="img">
                                            </a>
                                            <div class="description">
                                                <h4><a href="san-remo-spaghetti">CROWN ROCK</a></h4>
                                                <div class="price"><span>$500</span> </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="owl-item" style="width: 234px;">
                                    <div class="item">
                                        <div class="product">
                                            <a class="product-image">
                                                <img src="../../Scripts/images/a5.jpg" alt="img">
                                            </a>
                                            <div class="description">
                                                <h4><a href="san-remo-spaghetti">SLIM ROCK</a></h4>
                                                <div class="price"><span>$50 </span></div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="owl-item" style="width: 234px;">
                                    <div class="item">
                                        <div class="product">
                                            <a class="product-image">
                                                <img src="../../Scripts/images/36.jpg" alt="img">
                                            </a>
                                            <div class="description">
                                                <h4><a href="san-remo-spaghetti">ROCK T-Shirts </a></h4>
                                                <div class="price"><span>$130</span> </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="owl-item" style="width: 234px;">
                                    <div class="item">
                                        <div class="product">
                                            <a class="product-image">
                                                <img src="../../Scripts/images/13.jpg" alt="img">
                                            </a>
                                            <div class="description">
                                                <h4><a href="san-remo-spaghetti">Denim T-Shirts </a></h4>
                                                <div class="price"><span>$43</span> </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>


                    </div>
                    <!--/.recommended-->

                </div>


                <div style="clear: both"></div>


            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
