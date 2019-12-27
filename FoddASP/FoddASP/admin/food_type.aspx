<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeBehind="food_type.aspx.cs" Inherits="FoddASP.admin.food_type" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="<%= Page.ResolveUrl("~") %>admin/vendor/datatables/dataTables.bootstrap4.min.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cph_content" runat="server">
    <h1 class="h3 mb-2 text-gray-800">Danh Sách Loại Sản Phẩm
        
    </h1>

    <!-- DataTales Example -->
    <div class="card shadow mb-4">
        <div class="card-header py-3">
            <h6 class="m-0 font-weight-bold text-primary">FOOD TYPE!</h6>



            <div class="form-group row">
                <div class="col-sm-4 ">
                    <asp:TextBox ID="txt_tim" runat="server"></asp:TextBox>
                    <asp:Button ID="Button1" OnClick="btn_tim_Click" runat="server" Text="Tìm" />
                </div>
                <div class="col-sm-4">
                    <asp:Button ID="btn_them_loai" runat="server" OnClick="btn_them_loai_Click" Text="Thêm Loại Sản Phẩm" />
                </div>
                <div class="col-sm-4">
                    <asp:Button ID="btn_an" runat="server"  OnClick="btn_an_Click" Text="Ẩn Loại Sản Phẩm" />
                    <asp:Button ID="btn_all" runat="server"  OnClick="btn_all_Click" Text="Hiện Tất Cả" />
                </div>
            </div>
        </div>
        <div class="card-body">
            <div class="table-responsive">

                <table class="table table-striped table-borderless table-hover " style="width: 100%">
                    <tr style="font-weight: bold; color: black; text-align: center">
                        <td>id</td>
                        <td>Type Name</td>
                        <td>Type Post</td>
                        <td>Type Image</td>
                        <td>Status</td>
                        <td>User Name</td>
                        <td>Modified</td>
                        <td></td>
                    </tr>

                    <asp:Repeater ID="rpt_member" runat="server">

                        <ItemTemplate>

                            <tr style="color: black; text-align: center">

                                <td><%#Eval("type_id") %></td>
                                <td><%#Eval("type_name") %></td>
                                <td><%#Eval("type_pos") %></td>
                                <td>
                                    <img src="img/<%#Eval("type_img") %>" /></td>
                                <td><%#Eval("status").ToString()=="0"?"Active":"Disable" %></td>
                                <td>
                                    <%#Eval("username") %>
                                </td>
                                <td><%#Eval("modified") %></td>
                                <td><a href="?edit=<%#Eval("type_id") %>">Edit</a></td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </table>

                <asp:Repeater ID="Repeater2" runat="server">
                    <ItemTemplate>
                        <a href="?page=<%#Eval("index") %><%if (Request["id"] != null) Response.Write("&id=" + Request["id"]); %><%if (Request["an"] != null) Response.Write("&an=1"); %>"><%#Eval("index") %> </a>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cph_js" runat="server">
</asp:Content>
