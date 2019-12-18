<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeBehind="food.aspx.cs" Inherits="FoddASP.admin.food" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cph_content" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <div class="p-6">
                <div class="text-center">
                    <h1 class="h4 text-gray-900 mb-4">Thêm Thực Phẩm!</h1>
                </div>
                <div class="user">
                    <div class="form-group row">
                        <%--name--%>
                        <div class="col-sm-4">
                            <asp:TextBox ID="txtName" runat="server" type="text" CssClass="form-control form-control-user" placeholder="Tên Thực Phẩm"></asp:TextBox>

                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ValidationGroup="fail-group" CssClass="text-danger" ErrorMessage="Tên Thực Phẩm đang bị bỏ trống" ControlToValidate="txtName"></asp:RequiredFieldValidator>
                        </div>
                        <%--   price--%>
                        <div class="col-sm-4">
                            <asp:TextBox ID="txt_price" runat="server" type="number" CssClass="form-control form-control-user" placeholder="Giá"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ForeColor="Red" runat="server" ValidationGroup="fail-group" ControlToValidate="txt_price" ErrorMessage="Không được bỏ trống"></asp:RequiredFieldValidator>
                            
                        </div>
                        <%--price-promo--%>
                        <div class="col-sm-4">
                            <asp:TextBox ID="txt_price_promo" runat="server" type="number" CssClass="form-control form-control-user" placeholder="Giá Quảng Cáo"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ValidationGroup="fail-group" ForeColor="Red" runat="server" ControlToValidate="txt_price_promo" ErrorMessage="Không được bỏ trống"></asp:RequiredFieldValidator>
                            
                        </div>
                    </div>

                </div>
                <div class="form-group row">
                    <%--hinh nhỏ--%>
                    <div class="col-sm-6  mb-3 mb-sm-0">
                        <asp:Label ID="Label1" runat="server" Text="Chọn Thumb"></asp:Label><br />
                        <br />
                        <asp:FileUpload ID="FileUpload1" runat="server" /><br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" ValidationGroup="fail-group" ControlToValidate="FileUpload1" runat="server" ForeColor="Red" ErrorMessage="Thumb đang bị bỏ trống"></asp:RequiredFieldValidator>
                    </div>

                    <%-- hình lớn--%>
                    <div class="col-sm-6 mb-3 mb-sm-0">
                        <asp:Label ID="Label2" runat="server" Text="Chọn Image"></asp:Label><br />
                        <br />
                        <asp:FileUpload ID="FileUpload2" runat="server" /><br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator10" ValidationGroup="fail-group" ControlToValidate="FileUpload2" runat="server" ForeColor="Red" ErrorMessage="Image đang bị bỏ trống"></asp:RequiredFieldValidator>
                    </div>
                </div>
               
                <div class="form-group row">
                    <%-- percent_promo--%>
                    <div class="col-sm-4">
                        <asp:TextBox ID="txt_percent_promo" runat="server" type="number" CssClass="form-control form-control-user" placeholder="Phần trăm giảm giá"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" ForeColor="Red" runat="server" ControlToValidate="txt_percent_promo" ValidationGroup="fail-group" ErrorMessage="Không được bỏ trống"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="RangeValidator1" runat="server" ValidationGroup="fail-group" ControlToValidate="txt_percent_promo" ErrorMessage="Số bạn nhập không vượt quá 2 chữ số"
                            ForeColor="Red" MaximumValue="99" MinimumValue="0"></asp:RangeValidator>
                    </div>
                    <%--đánh giá--%>
                    <div class="col-sm-4">
                        <asp:TextBox ID="txt_rating" runat="server" type="number" CssClass="form-control form-control-user" placeholder="Đánh Giá"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" ForeColor="Red" ValidationGroup="fail-group" runat="server" ControlToValidate="txt_rating" ErrorMessage="Không được bỏ trống"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ValidationGroup="fail-group" ID="RegularExpressionValidator2" runat="server" CssClass="text-danger" ErrorMessage="Bạn Phải Nhập chữ số từ 1 -5" ControlToValidate="txt_rating" ValidationExpression="[1-5]"></asp:RegularExpressionValidator>
                        <asp:RangeValidator ID="RangeValidator2" runat="server" ValidationGroup="fail-group" ControlToValidate="txt_sold" ErrorMessage="Số bạn nhập không vượt quá 1 chữ số"
                            ForeColor="Red" MaximumValue="2" MinimumValue="0"></asp:RangeValidator>
                    </div>
                    <%--đã bán--%>
                    <div class="col-sm-4">
                        <asp:TextBox ID="txt_sold" runat="server" type="number" CssClass="form-control form-control-user" placeholder="Đã bán"></asp:TextBox>

                        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" ForeColor="Red" runat="server" ValidationGroup="fail-group" ControlToValidate="txt_sold" ErrorMessage="Không được bỏ trống"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="RangeValidator3" runat="server" ValidationGroup="fail-group" ControlToValidate="txt_sold" ErrorMessage="không vượt quá 100 sản phẩm"
                            ForeColor="Red" MaximumValue="100" MinimumValue="0"></asp:RangeValidator>
                    </div>
                </div>
                <div class="form-group row">
                    <%--mô tả--%>
                    <div class="col-sm-12  mb-3 mb-sm-0">
                        <asp:TextBox ID="txt_mota" runat="server" type="text" CssClass="form-control form-control-user" placeholder="Mô Tả"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ValidationGroup="fail-group" runat="server" CssClass="text-danger" ErrorMessage="Mô tả đang bị bỏ trống" ControlToValidate="txt_mota"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="form-group row">
                    <%--Point--%>
                    <div class="col-sm-6  mb-3 mb-sm-0">
                        <asp:TextBox ID="txt_point" runat="server" type="text" CssClass="form-control form-control-user" placeholder="Điểm"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ValidationGroup="fail-group" CssClass="text-danger" ErrorMessage="Điểm đang bị bỏ trống" ControlToValidate="txt_point"></asp:RequiredFieldValidator>
                    </div>

                    <%--đơn vị--%>
                    <div class="col-sm-6  mb-3 mb-sm-0">

                        <asp:TextBox ID="txt_unit" runat="server" type="text" CssClass="form-control form-control-user" placeholder="Đơn vị"></asp:TextBox>

                        <asp:RequiredFieldValidator ID="rfv_unit" runat="server" ValidationGroup="fail-group" CssClass="text-danger" ErrorMessage="Unit đang bị bỏ trống" ControlToValidate="txt_unit"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="form-group row">

                    <asp:DropDownList ID="ddl_type" runat="server" CssClass="col-sm-6 ">
                        <asp:ListItem Enabled="true" Value="-1">--Type--</asp:ListItem>
                        <asp:ListItem Value="0">Rau</asp:ListItem>
                        <asp:ListItem Value="1">Củ</asp:ListItem>
                        <asp:ListItem Value="2">Quả</asp:ListItem>
                    </asp:DropDownList>
                    
                    <br />

                    <asp:DropDownList ID="ddl_status" runat="server" CssClass="col-sm-6  ">
                        <asp:ListItem Enabled="true" Value="-1">--Status--</asp:ListItem>
                        <asp:ListItem Value="0">Active</asp:ListItem>
                        <asp:ListItem Value="1">Disable</asp:ListItem>
                    </asp:DropDownList>

                </div>

                <br />
                <div class="form-group row">
                    <div class="col-sm-4  mb-3 mb-sm-0">
                        <asp:Button ValidationGroup="fail-group" ID="btn_add_food" OnClick="btn_add_food_Click" runat="server" Text="Thêm Thực Phẩm" CssClass="btn btn-primary btn-user btn-block" />
                    </div>
                     <div class="col-sm-4  mb-3 mb-sm-0">
                        <asp:Button ValidationGroup="fail-group" ID="btn_add_update" OnClick="btn_add_update_Click" runat="server" Text="Cập Nhật Thực Phẩm" CssClass="btn btn-success btn-user btn-block" />
                    </div>
                    <div class="col-sm-4  mb-3 mb-sm-0">
                        <asp:Button ID="btn_lst_food" OnClick="btn_lst_food_Click" runat="server" Text="Danh Sách Thực Phẩm" CssClass="btn btn-danger btn-user btn-block" />
                    </div>
                </div>

            </div>

            <div id="txtKQ" style="color:red" runat="server">KQ...</div>
        </div>
    </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cph_js" runat="server">
</asp:Content>
