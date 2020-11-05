<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="galeri_ekle.aspx.cs" Inherits="MyWebSite.galeri_ekle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-md-12">
        <div class="card">
            <div class="card-header">
                <h4 class="card-title">Yeni Resim Ekle</h4>
            </div>
            <div class="card-body">
                <div class="row">
                    <div class="col-md-12  pl-1  pr-1">
                        <div class="form-group">
                            <label>Resim</label>
                            <asp:FileUpload ID="FileUpload1" runat="server" />
                        </div>
                    </div>
                    <div class="col-md-12  pl-1  pr-1">
                        <div class="form-group">
                            <label>Başlık</label>
                            <asp:TextBox ID="txtTitle" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-md-12 pl-1  pr-1">
                        <div class="form-group">
                            <label for="exampleInputEmail1">Fiyat</label>
                            <asp:TextBox ID="txtPrice"  CssClass="form-control" runat="server"></asp:TextBox>

                        </div>
                    </div>
                    
                </div>

            </div>

            <asp:Button ID="btnSave" CssClass="btn btn-info btn-fill pull-right" OnClick="btnSave_Click" runat="server" Text="Kaydet" />
            <div class="clearfix"></div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Footer" runat="server">
</asp:Content>
