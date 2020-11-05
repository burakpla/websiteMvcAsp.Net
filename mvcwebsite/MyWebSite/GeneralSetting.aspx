<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="GeneralSetting.aspx.cs" Inherits="MyWebSite.GeneralSetting" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-md-12"> 
        <div class="card">
            <div class="card-header">
                <h4 class="card-title">Ayarla-Düzenle</h4>
            </div>
            <div class="card-body">
                <div class="row">
                    <div class="col-md-12  pl-1  pr-1">
                        <div class="form-group">
                            <label>Site Başlığı</label>
                            <asp:TextBox ID="txtTitle" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-md-12  pl-1  pr-1">
                        <div class="form-group">
                            <label>Google Map (Harita)</label>
                            <asp:TextBox ID="txtGoogleMap" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                    </div>
                     <div class="col-md-12  pl-1  pr-1">
                        <div class="form-group">
                            <label>Email</label>
                            <asp:TextBox ID="txtEmail" TextMode="Email" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                    </div>
                     <div class="col-md-12  pl-1  pr-1">
                        <div class="form-group">
                            <label>Telefon</label>
                            <asp:TextBox ID="txtPhone" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                    </div>
                     <div class="col-md-12  pl-1  pr-1">
                        <div class="form-group">
                            <label>Fax</label>
                            <asp:TextBox ID="txtfax" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                    </div>
                     <div class="col-md-12  pl-1  pr-1">
                        <div class="form-group">
                            <label>Adres</label>
                            <asp:TextBox ID="txtAdress" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                    </div>
                     <div class="col-md-12  pl-1  pr-1">
                        <div class="form-group">
                            <label>Facebook</label>
                            <asp:TextBox ID="txtfacebook" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                    </div>
                     <div class="col-md-12  pl-1  pr-1">
                        <div class="form-group">
                            <label>Instagram</label>
                            <asp:TextBox ID="txtInstagram" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                    </div>
                     <div class="col-md-12  pl-1  pr-1">
                        <div class="form-group">
                            <label>Twitter</label>
                            <asp:TextBox ID="txtTwitter" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                    </div>
                     <div class="col-md-12  pl-1  pr-1">
                        <div class="form-group">
                            <label>Youtube</label>
                            <asp:TextBox ID="txtYoutube" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                    </div>

                    </div>
                </div>


            <asp:Button ID="btnUpdate" CssClass="btn btn-info btn-fill pull-right" OnClick="btnUpdate_Click" runat="server" Text="Güncelle" />
            <div class="clearfix"></div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Footer" runat="server">
</asp:Content>
