<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="anasayfa.aspx.cs" Inherits="MyWebSite.anasayfa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="col-md-12">
        <div class="card card-plain table-plain-bg">
            <div class="card-header ">
                <h4 class="card-title">ADMINS</h4>
            </div>
           <div>

           </div>
                <div class="row">

            <div class="col-xs-12 col-sm-6 col-md-4">
                <div class="image-flip" ontouchstart="this.classList.toggle('hover');">
                    <div class="mainflip">
                        <div class="frontside">
                            <div class="card">
                                <div class="card-body text-center">
                                    
                                    <h4 class="card-title">Burak Pala</h4>
                                    <p class="card-text"> - Computer Engineering</p>
                                    <p class="card-text">Adnan Menderes University </p>
                                    <a href="https://mail.google.com/mail/u/0/#inbox" target="_blank"><i class="fa fa-google-plus"></i></a>
                                    <a href="" target="_blank"><i class="fa fa-facebook"></i></a>
                                    <a href=""target="_blank" ><i class="fa fa-twitter"></i></a>
                                    <a href="" target="_blank"><i class="fa fa-linkedin"></i></a>
                                </div>
                            </div>
                        </div>
                        
                    </div>
                </div>
            </div>
            <!-- ./Team member -->
            <!-- Team member -->
            <div class="col-xs-12 col-sm-6 col-md-4">
                <div class="image-flip"  ontouchstart="this.classList.toggle('hover');">
                    <div class="mainflip">
                        <div class="frontside">
                            <div class="card">
                               
                            </div>
                        </div>
                        <div class="backside">
                            
                        </div>
                    </div>
                </div>
            </div>
          
        </div>
               

            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Footer" runat="server">
</asp:Content>
