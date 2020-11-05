<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="DessertDüzenle.aspx.cs" Inherits="MyWebSite.DessertDüzenle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <div class="col-md-12">
        <div class="card">
            <div class="card-header">
                <h4 class="card-title">Tatlı Düzenle</h4>
            </div>
            <div class="card-body">
                <div class="row">
                    <div class="col-md-12  pl-1  pr-1">
                        <div class="form-group">
                            <label>tatlı adı</label>
                            <asp:TextBox ID="txttatlıname" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-md-12  pl-1  pr-1">
                        <div class="form-group">
                            <label>fiyat</label>
                            <asp:TextBox ID="txtfiyat" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    
                    
            <asp:Button ID="btnUpdate" CssClass="btn btn-info btn-fill pull-right" OnClick="btnUpdate_Click" runat="server" Text="Güncelle" />
            <div class="clearfix"></div>
        </div>
    </div>
            </div>
      </div>
            </asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Footer" runat="server">
</asp:Content>
