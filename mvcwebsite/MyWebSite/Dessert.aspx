<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="Dessert.aspx.cs" Inherits="MyWebSite.Dessert" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <div class="col-md-12">
        <div class="card card-plain table-plain-bg">
            <div class="card-header ">
                <h4 class="card-title"> TATLILAR</h4>
            </div>
            <div class="card-body table-full-width table-responsive">
                <table class="table table-hover">
                    <thead>
                        <tr>
                            <th>ID</th>
                            <th>Tatlı Adı</th>
                            <th>Fiyat</th>
                            <th>İşlemler</th>
                        </tr>
                    </thead>
                    <tbody>
                        <asp:Repeater ID="rptDesserts" runat="server">
                            <ItemTemplate>
                                <tr>
                                    <td><%# Eval("DessertID") %></td>
                                    <td><%# Eval("DessertName") %></td>
                                    <td><%# Eval("DessertsPrice") %></td>
                                    
                                    <td><a href="javascript:void(0)" class="btn btn-danger btn-xs dessertsil" data-id="<%# Eval("DessertID") %>" data-toggle="tooltip" title="Sil"><i class="fa fa-remove fa-fw"></i></a><br />
                                        <a href="/DessertDüzenle.aspx?id=<%# Eval("DessertID") %>" class="btn btn-warning btn-xs dessertdüzenle" data-toggle="tooltip" title="Düzenle"><i class="fa fa-refresh fa-fw"></i></a>
                                    </td>
                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>
                    </tbody>
                </table>
            </div>
        </div>
    </div></asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Footer" runat="server">
    <script type="text/javascript">
        var currentid;
        $(document).ready(function () {
            $(".dessertsil").click(function () {
                currentid = $(this).attr("data-id");
                swal({
                    title: "Tatlı silinecektir.Onaylıyor musunuz?",
                    showCancelButton: true,
                    cancelButtonText: "Vazgeç",
                    confirmButtonText: "Onayla",
                    type: "warning",
                    animation:"slide-from-top"
                }).then(function (result) {
                    if (result.value)//onayla derse
                    {
                        $.ajax({
                            url: "Dessert.aspx/DessertSil",
                            type: "POST",
                            contentType: "application/json;charset=utf-8",
                            data: JSON.stringify({ "id": currentid }),
                            success: function (data) {
                                if (data.d == "Başarılı") {
                                    swal("", "Silme İşlemi Başarılı", "success");
                                    setTimeout(function () {
                                        location.reload();
                                    }, 2000);
                                }
                                else {
                                    swal("", "Silme işlemi sırasında hata oluştu", "error");
                                }
                            },
                            error: function (err) {
                                alert(err);
                            }
                        })
                    }
                })
            })
        });
    </script>
</asp:Content>
