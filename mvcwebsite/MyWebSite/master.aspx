<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="master.aspx.cs" Inherits="MyWebSite.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <section id="slider" class="slider">
        <div class="slider_overlay">
            <div class="container">
                <div class="row">
                    <div class="main_slider text-center">
                        <div class="col-md-12">
                            <div class="main_slider_content wow zoomIn" data-wow-duration="1s">
                                <ul>
                                    <li>
                                        <h1>Babuş Cafe</h1>
                                    </li>
                                </ul>
                                <p class="auto-style1"><em class="newStyle1">in your dreams</em></p>

                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </section>

    <section id="abouts" class="abouts">
        <div class="container">
            <div class="row">
                <div class="abouts_content">
                    <div class="col-md-6">
                        <div class="single_abouts_text text-center wow slideInLeft" data-wow-duration="1s">
                            <img src="assets/css/images/beer-hall.jpg" alt="" />

                        </div>
                    </div>

                    <div class="col-md-6">
                        <div class="single_abouts_text wow slideInRight" data-wow-duration="1s">
                            <h4>About us</h4>
                            <h3></h3>
                            <p>
                               Cafe or cafe with French original spelling, small business where customers are catered. The facility has a limited menu. 
                            </p>

                            <p>
                                The cafes, which are originally coffee-serving places, choose to become places where simple food and all kinds of hot and cold drinks will serve over time.
                            </p>
                            <p style="font-family: 'Comic Sans MS'; color: #800000; font-size: medium; text-decoration: underline; font-style: oblique;">Video From a Youtuber; </p>
                            <video src="assets/css/images/VLOG%20BEER%20HALL%20%20Bu%20video%20bol%20kalori%20içerir.mp4" controls="controls" height="230" width="350" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <section id="features" class="features">
        <div class="slider_overlay">
            <div class="container">
                <div class="row">

                    <div class="main_features_content_area  wow fadeIn" data-wow-duration="3s">
                        <div>
                        </div>
                    </div>
                </div>
                <div class="auto-style3">
                </div>

                <div class="main_features_content text-left">
                    <div class="col-md-6">
                        <div class="single_features_text">
                            <h4>Special Recipes</h4>
                            <h3>Taste of Precious</h3>
                            <p>
                                Baklava is the best
                            </p>
                            <p></p>
                            <div class="single_abouts_text text-center wow slideInLeft" data-wow-duration="1s">


                                <img src="assets/css/images/baklava2.jpg" alt="" />

                                <div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        </div>
    </section>

    <section id="portfolio" class="portfolio">
        <div class="container">
            <div class="row">
                <div class="portfolio_content text-center  wow fadeIn" data-wow-duration="5s">
                    <div class="col-md-12">
                        <div class="head_title text-center">
                            <h4>Delightful</h4>
                            <h3>Your Favorites</h3>
                        </div>

                        <div class="main_portfolio_content">
                            <asp:Repeater ID="rptGallery" runat="server">
                                <ItemTemplate>
                                    <div class="col-md-3 col-sm-4 col-xs-6 single_portfolio_text">
                                        <img src="<%# Eval("Photo") %>" alt="<%# Eval("Title") %>" style="width: 800px !important; height: 175px !important; display: block;" />
                                        <div class="portfolio_images_overlay text-center">
                                            <h6><%# Eval("Title") %></h6>
                                            <p class="product_price">$<%# Eval("Price") %></p>

                                        </div>
                                    </div>
                                </ItemTemplate>
                            </asp:Repeater>


                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <section id="ourPakeg" class="ourPakeg">
        <div class="container">
            <div class="main_pakeg_content">
                <div class="row">
                    <div class="head_title text-center">
                        <h4>Menu</h4>
                        <h3>Delicious</h3>
                    </div>

                    <div class="single_pakeg_one text-right wow rotateInDownRight">

                        <div class="col-md-6 col-md-offset-6 col-sm-8 col-sm-offset-4">
                            <div class="single_pakeg_text">
                                <div class="pakeg_title">
                                    <h4>Drinks</h4>
                                </div>

                                <ul>
                                    <asp:Repeater ID="rptDrinks" runat="server">
                                       <ItemTemplate>
                                             <li class="newStyle5"><%# Eval("DrinkName") %>.....................................$<%# Eval("DrinkPrice") %> </li>
                                       </ItemTemplate>
                                    </asp:Repeater>
                                   
                                    <%--<li class="newStyle5">Magıc Mojıto......................................................$23.5 </li>
                                    <li class="newStyle5">Beergarita........................................................$22.5 </li>
                                    <li><span class="newStyle4">Beer Sangrıa......................................................$14.5 </span></li>
                                    <li><span class="newStyle2">Mıx Frozen........................................................$17.5 </span></li>
                                    <li><span class="newStyle3">Hıtman............................................................$14.5 </span></li>--%>

                                </ul>
                            </div>

                        </div>
                    </div>

                    <div class="single_pakeg_two text-left wow rotateInDownLeft">
                        <div class="col-md-6 col-sm-8">
                            <div class="single_pakeg_text">
                                <div class="pakeg_title">
                                    <h4>Main course </h4>
                                </div>
                                <ul>
                                <asp:Repeater ID="rptMaınCourse" runat="server">
                                       <ItemTemplate>
                                             <li class="newStyle5"><%# Eval("MainCourseName") %>.....................................$<%# Eval("MainCoursePrice") %> </li>
                                       </ItemTemplate>
                                    </asp:Repeater>
                                </ul>
                                 
                            </div>
                        </div>
                    </div>

                    <div class="single_pakeg_three text-left wow rotateInDownRight">
                        <div class="col-md-6 col-md-offset-6 col-sm-8 col-sm-offset-4">
                            <div class="single_pakeg_text">
                                <div class="pakeg_title">
                                    <h4>Desserts</h4>
                                </div>
                                <ul>
                                 <asp:Repeater ID="rptDesserts" runat="server">
                                       <ItemTemplate>
                                             <li class="newStyle5"><%# Eval("DessertName") %>.....................................$<%# Eval("DessertsPrice") %> </li>
                                       </ItemTemplate>
                                    </asp:Repeater>
                                    
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    
</asp:Content>
