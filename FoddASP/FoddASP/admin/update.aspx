<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeBehind="update.aspx.cs" Inherits="FoddASP.admin.update" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="<%=Page.ResolveUrl("~/admin/") %>vendor/datatables/dataTables.bootstrap4.min.css" rel="stylesheet">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cph_content" runat="server">
    <h1 class="h3 mb-2 text-gray-800">Danh Sách Sản Phẩm
    </h1>

    <!-- DataTales Example -->
    <div class="card shadow mb-4">
        <div class="card-header py-3">
            <h6 class="m-0 font-weight-bold text-primary">Danh Sách Sản Phẩm</h6>
        </div>
        <div class="card-body">
            <div class="table-responsive">
                <table class="table table-bordered" id="dataTable" width="100%" cellspacing="0">
                    <thead>
                        <tr>
                            <th>User Name</th>
                            <th>Pasword</th>
                            <th>Name</th>
                            <th>Phone</th>
                            <th>Role</th>
                            <th>Update</th>
                        </tr>
                    </thead>
                    <tfoot>
                        <tr>
                            <th>User Name</th>
                            <th>Pasword</th>
                            <th>Name</th>
                            <th>Phone</th>
                            <th>Role</th>
                            <th>Update</th>
                        </tr>
                    </tfoot>
                    <tbody>
                        
                    </tbody>
                </table>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cph_js" runat="server">
    <!-- Page level plugins -->
    <script src="<%=Page.ResolveUrl("~/admin/") %>vendor/datatables/jquery.dataTables.min.js"></script>
    <script src="<%=Page.ResolveUrl("~/admin/") %>vendor/datatables/dataTables.bootstrap4.min.js"></script>

    <!-- Page level custom scripts -->
    <script src="<%=Page.ResolveUrl("~/admin/") %>js/demo/datatables-demo.js"></script>
</asp:Content>
