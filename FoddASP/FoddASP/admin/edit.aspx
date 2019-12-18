<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeBehind="edit.aspx.cs" Inherits="FoddASP.admin.edit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cph_content" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <div class="p-6">
                <div class="text-center">
                    <h1 class="h4 text-gray-900 mb-4">Edit Member
                        <asp:Label ID="lb_username" runat="server" Text=""></asp:Label></h1>

                </div>
                <div class="user">

                    <div class="form-group row">
                        <div class="col-sm-12">
                            
                            <asp:TextBox ID="txtName" runat="server" type="text" CssClass="form-control form-control-user" placeholder="Name"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ValidationGroup="fail-group" runat="server" CssClass="text-danger" ErrorMessage="Name của bạn đang bị bỏ trống" ControlToValidate="txtName"></asp:RequiredFieldValidator>
                        </div>

                    </div>
                    <div class="form-group row">
                        <div class="col-sm-12">
                             
                            <asp:TextBox ID="txtPhone" runat="server" type="number" CssClass="form-control form-control-user" placeholder="Phone"></asp:TextBox>

                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ValidationGroup="fail-group" runat="server" CssClass="text-danger" ErrorMessage="Phone đang bị bỏ trống" ControlToValidate="txtName"></asp:RequiredFieldValidator>

                            <asp:RegularExpressionValidator ValidationGroup="fail-group" ID="revPhone" runat="server" CssClass="text-danger" ErrorMessage="Bạn Phải Nhập 10 số" ControlToValidate="txtPhone" ValidationExpression="[0-9]{10}"></asp:RegularExpressionValidator>
                        </div>
                    </div>

                    <div class="form-group row">
                        <div class="col-sm-12">
                             
                            <asp:TextBox ID="txtPassword" runat="server" type="password" CssClass="form-control form-control-user" placeholder="Password"></asp:TextBox>

                            <asp:RequiredFieldValidator CssClass="text-danger" ValidationGroup="fail-group" ID="rvPass" runat="server" ErrorMessage="Bạn Chưa Nhập Password" ControlToValidate="txtPassword"></asp:RequiredFieldValidator>
                            <br />
                            <asp:RegularExpressionValidator ValidationGroup="fail-group" ID="revPassword" runat="server" ErrorMessage="Bạn Phải Nhập 3 đến 10 kí tự" ControlToValidate="txtPassword" CssClass="text-danger" ValidationExpression="[A-Za-z0-9]{3,10}"></asp:RegularExpressionValidator>
                        </div>
                    </div>
                    <div class="form-group row">

                        <asp:DropDownList ID="ddl_user" runat="server" CssClass="col-sm-12">
                            <asp:ListItem Enabled="true" Value="-1">--Role--</asp:ListItem>
                            <asp:ListItem Value="0">Admin</asp:ListItem>
                            <asp:ListItem Value="1">User</asp:ListItem>
                        </asp:DropDownList>

                    </div>

                    <div class="form-group row">

                        <div class="col-sm-12  mb-3 mb-sm-0">
                            <asp:Button ValidationGroup="fail-group" ID="btn_update" runat="server" Text="Update" OnClick="btn_update_Click" CssClass="btn btn-primary btn-user btn-block" />
                        </div>
                        <br />
                        <br />
                        <div class="col-sm-12  mb-3 mb-sm-0">
                            <asp:Button ID="btn_clear" runat="server" Text="Back" OnClick="btn_clear_Click" CssClass="btn btn-danger btn-user btn-block" />
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
