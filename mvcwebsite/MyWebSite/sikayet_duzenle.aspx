<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="sikayet_duzenle.aspx.cs" Inherits="MyWebSite.sikayet_duzenle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-md-12">
        <div class="card">
            <div class="card-header">
                <h4 class="card-title">Şikayet Düzenle</h4>
            </div>
            <div class="card-body">
                <div class="row">
                    <div class="col-md-12  pl-1  pr-1">
                        <div class="form-group">
                            <label>Ad Soyad</label>
                            <asp:TextBox ID="txtFullName" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-md-12  pl-1  pr-1">
                        <div class="form-group">
                            <label>Konu</label>
                            <asp:TextBox ID="txtSubject" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-md-12 pl-1  pr-1">
                        <div class="form-group">
                            <label for="exampleInputEmail1">Email</label>
                            <asp:TextBox ID="txtEmail" TextMode="Email" CssClass="form-control" runat="server"></asp:TextBox>

                        </div>
                    </div>
                    <div class="col-md-12  pl-1  pr-1">
                        <div class="form-group">
                            <label>Mesaj</label>
                            <asp:TextBox ID="txtMessage" TextMode="MultiLine" CssClass="form-control" runat="server"></asp:TextBox>

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
