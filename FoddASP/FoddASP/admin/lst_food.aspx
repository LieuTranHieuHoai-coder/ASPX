<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeBehind="lst_food.aspx.cs" Inherits="FoddASP.admin.lst_food" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cph_content" runat="server">
    <h1 class="h3 mb-2 text-gray-800">Danh Sách Thực Phẩm
        
    </h1>

    <!-- DataTales Example -->
    <div class="card shadow mb-4">
        <div class="card-header py-3">
            <h6 class="m-0 font-weight-bold text-primary">Tìm Kiếm Thực Phẩm</h6>

            <div class="form-group row">
                <div class="col-sm-6">
                    <asp:TextBox ID="txt_tim" runat="server"></asp:TextBox>
                    <asp:Button ID="btn_tim" runat="server" OnClick="btn_tim_Click" Text="Tìm" />
                    <asp:Button ID="btn_add" runat="server" OnClick="btn_add_Click" Text="Thêm" />
                </div>
                <div class="col-sm-6">
                </div>
            </div>

        </div>
        <div class="card-body">
            <div class="table-responsive">

                <table class="table table-striped table-hover " style="width: 100%;">
                    <tr style="font-weight: bold; color: black; text-align: center">
                        <td>Id</td>
                        <td>Name</td>
                        <td>Description</td>
                        <td>Price</td>
                        <td>Price Promo</td>
                        <td>Thumb</td>
                        <td>Image</td>
                        <td>Unit</td>
                        <td>Percent Promo </td>
                        <td>Rating</td>
                        <td>Sold</td>
                        <td>Point</td>
                        <td>Type</td>
                        <td>Status</td>
                        <td>User Name</td>
                        <td>Modified</td>
                        <td></td>
                    </tr>

                    <asp:Repeater ID="rpt_member" runat="server">

                        <ItemTemplate>

                            <tr style="color: black; text-align: center">

                                <td><%#Eval("Id") %></td>
                                <td><%#Eval("Name") %></td>
                                <td><%#Eval("Description") %></td>
                                <td><%#Eval("Price") %></td>
                                <td><%#Eval("Price_Promo") %></td>
                                <td>
                                    <img style="width: 100px; height: 100px" src="img/<%#Eval("Thumb")%>" /></td>
                                <td>
                                    <img style="width: 100px; height: 100px" src="img/<%#Eval("img") %>" /></td>
                                <td><%#Eval("Unit") %></td>
                                <td><%#Eval("Percent_Promo") %></td>
                                <td><%#Eval("Rating") %></td>
                                <td><%#Eval("Sold") %></td>
                                <td><%#Eval("Point") %></td>
                                <td><%#Eval("Type") %></td>
                                <td><%#Eval("Status") %></td>
                                <td><%#Eval("UserName") %></td>
                                <td><%#Eval("Modified") %></td>
                                <td><a href="?edit=<%#Eval("id") %>">Edit</a></td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </table>

                <asp:Repeater ID="Repeater2" runat="server">
                    <ItemTemplate>
                        <a href="?page=<%#Eval("index") %><%if (Request["id"] != null) Response.Write("&id=" + Request["id"]); %>"><%#Eval("index") %> </a>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cph_js" runat="server">
</asp:Content>
