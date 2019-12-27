<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeBehind="member.aspx.cs" Inherits="FoddASP.admin.member" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="<%= Page.ResolveUrl("~") %>admin/vendor/datatables/dataTables.bootstrap4.min.css" rel="stylesheet" />
    <!-- Custom styles for this page -->

    <script src="https://code.jquery.com/jquery-latest.js"></script>
    <link href="https://cdn.datatables.net/1.10.20/css/jquery.dataTables.min.css" rel="stylesheet" />
    <script type="text/javascript" src="https://cdn.datatables.net/1.10.20/js/jquery.dataTables.min.js"></script>

    <%--<script type="text/javascript">
        //hàm in ra danh sách
        $(document).ready(function () {
            $.ajax({
                type: "POST",
                dataType: "json",
                url: "WebService1.asmx/GetData",
                paging: false,
                searching: false,
                success: function (data) {
                    var datatableVariable = $('#dTable').DataTable({
                        data: data,
                        columns: [
                            { 'data': 'UserName' },
                            //{ 'data': 'Status' },
                            { 'data': 'Pass' },
                            { 'data': 'Name' },
                            { 'data': 'Phone' },
                            { 'data': 'Role' }
                        ]
                    });

                }
            });

        });
            </script>--%>
    <%--hàm tìm kiếm--%>

    <%--<script>
            var user = $("#tim").val();
            $("#btn_tim").click(function () {
                $.ajax({
                    type: "POST",
                    dataType: "json",
                    data: "username:'" + user + "'",
                    url: "WebService1.asmx/SearchData",
                    paging: false,
                    searching: false,
                    success: function (data) {
                        var datatableVariable = $('#dTable').DataTable({
                            data:data,
                            columns: [
                                { 'data': 'UserName' },
                                //{ 'data': 'Status' },
                                { 'data': 'Pass' },
                                { 'data': 'Name' },
                                { 'data': 'Phone' },
                                { 'data': 'Role' }
                            ]
                        });
                    }
                })
            });
    </script>--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cph_content" runat="server">
    <h1 class="h3 mb-2 text-gray-800">Danh Sách Thành Viên
        
    </h1>

    <!-- DataTales Example -->
    <div class="card shadow mb-4">
        <div class="card-header py-3">
            <h6 class="m-0 font-weight-bold text-primary">Tìm Kiếm Thành Viên</h6>

            <div class="form-group row">
                <div class="col-sm-6">
                    <asp:TextBox ID="txt_tim" runat="server"></asp:TextBox>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Tìm" />
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Thêm" />
                </div>
            </div>
        </div>
        <div class="card-body">
            <div class="table-responsive">

                <table class="table table-striped table-hover " style="width: 100%;">
                    <tr style="font-weight: bold; color: black; text-align: center">
                        <td>UserName</td>
                        <td>Pass</td>
                        <td>Name</td>
                        <td>Phone</td>
                        <td>Role</td>
                        <td></td>
                    </tr>

                    <asp:Repeater ID="rpt_member" runat="server">

                        <ItemTemplate>

                            <tr style="color: black; text-align: center">

                                <td><%#Eval("username") %></td>
                                <td><%#Eval("pass") %></td>
                                <td><%#Eval("name") %></td>
                                <td><%#Eval("phone") %></td>
                                <td><%#Eval("role").ToString()=="1"?"User":"Admin" %></td>
                                <td>
                                    <a href="?edit=<%#Eval("username") %>">Edit</a>
                                </td>
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


    <script>
    
    </script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cph_js" runat="server">
    <!-- Page level plugins -->
    <script src="<%=Page.ResolveUrl("~") %>admin/vendor/datatables/jquery.dataTables.min.js"></script>
    <script src="<%=Page.ResolveUrl("~") %>admin/vendor/datatables/dataTables.bootstrap4.min.js"></script>

    <!-- Page level custom scripts -->
    <script src="<%=Page.ResolveUrl("~") %>admin/js/demo/datatables-demo.js"></script>


</asp:Content>
