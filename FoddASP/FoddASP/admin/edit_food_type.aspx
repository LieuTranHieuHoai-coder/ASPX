<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeBehind="edit_food_type.aspx.cs" Inherits="FoddASP.admin.edit_food_type" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cph_content" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <div class="p-6">
                <div class="text-center">
                    <h1 class="h4 text-gray-900 mb-4">Chỉnh Sửa Food Type!
                    </h1>

                </div>
                <div class="user">

                    <div class="form-group row">
                        <div class="col-sm-12">
                            <asp:Label ID="Label2" runat="server" Text="Image"></asp:Label>
                            <br />
                            <asp:Image ID="Image1" Visible="true" runat="server" />

                            <asp:FileUpload ID="FileUpload1" runat="server" />
                        </div>
                    </div>

                    <div class="form-group row">
                        <div class="col-sm-6">
                            <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
                            <asp:TextBox ID="txtName" runat="server" type="text" CssClass="form-control form-control-user"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" CssClass="text-danger" ErrorMessage="Tên loại của bạn đang bị bỏ trống" ControlToValidate="txtName"></asp:RequiredFieldValidator>
                        </div>

                        <div class="col-sm-6">
                            <asp:Label ID="Label3" runat="server" Text="User Name"></asp:Label>
                            <asp:TextBox ID="txtUserName" runat="server" type="text" CssClass="form-control form-control-user"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" CssClass="text-danger" ErrorMessage="User Name của bạn đang bị bỏ trống" ControlToValidate="txtUserName"></asp:RequiredFieldValidator>
                        </div>

                    </div>

                    <div class="form-group row">
                        <div class="col-sm-6">
                            <asp:DropDownList ID="ddl_type_post" runat="server" class="col-sm-12">
                                <asp:ListItem Enabled="true" Value="-1">--Type Post--</asp:ListItem>
                                <asp:ListItem Value="0">0</asp:ListItem>
                                <asp:ListItem Value="1">1</asp:ListItem>
                            </asp:DropDownList>
                            <br />
                            <asp:Label ID="lb_post" runat="server" Text=""></asp:Label>
                        </div>

                        <div class="col-sm-6">
                            <asp:DropDownList ID="ddl_type_status" runat="server" CssClass="col-sm-12">
                                <asp:ListItem Enabled="true" Value="-1">--Status--</asp:ListItem>
                                <asp:ListItem Value="0">Active</asp:ListItem>
                                <asp:ListItem Value="1">Disable</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <br />
                        <asp:Label ID="lb_status" runat="server" Text=""></asp:Label>

                    </div>
                    <div class="form-group row">

                        <div class="col-sm-12 ">

                            <asp:Button ValidationGroup="fail-group" ID="btn_add" OnClick="btn_add_Click" runat="server" Text="Update" CssClass="btn btn-primary btn-user btn-block" />

                            <asp:Button ValidationGroup="fail-group" ID="btn_clear" OnClick="btn_clear_Click" runat="server" Text="Back" CssClass="btn btn-danger btn-user btn-block" />
                        </div>
                    </div>
                </div>
            </div>

        </div>

        <div id="txtKQ" style="color: red" runat="server">KQ...</div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cph_js" runat="server">
</asp:Content>
