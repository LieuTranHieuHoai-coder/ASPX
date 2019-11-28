<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="datacontroll.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Button" />
        <br />
        
        <asp:DataList ID="DataList1" OnItemCommand="DataList1_ItemCommand" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" DataKeyField="MSSV" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="Both" >
            <AlternatingItemStyle BackColor="#CCCCCC" />
            <EditItemTemplate>
                <asp:Label ID="Label1" runat="server" Text='<%# Eval("MSSV") %>'></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="True" Text='<%# Eval("HoTen") %>'></asp:TextBox>
                <asp:Button ID="Button3" runat="server" CommandName="c" Text="Cập nhật" />
                <asp:Button ID="Button4" runat="server" CommandName="h" Text="Hủy" />
            </EditItemTemplate>
            <FooterStyle BackColor="#CCCCCC" />
            <FooterTemplate>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <asp:Button ID="Button5" runat="server" CommandName="t" Text="Button" />
            </FooterTemplate>
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <ItemTemplate>
                MSSV:
                <asp:Label ID="MSSVLabel" runat="server" Text='<%# Eval("MSSV") %>' />
                HoTen:
                <asp:Label ID="HoTenLabel" runat="server" Text='<%# Eval("HoTen") %>' />
                MaLop:
                <asp:Label ID="MaLopLabel" runat="server" Text='<%# Eval("MaLop") %>' />
                Xoa:
                <asp:Label ID="XoaLabel" runat="server" Text='<%# Eval("Xoa") %>' />
                <asp:Button ID="Button1" runat="server" CommandName="s" Text="Sửa" />
                <asp:Button ID="Button2" runat="server" CommandName="x" Text="Xóa" />
                <br />
<br />
            </ItemTemplate>
            <SelectedItemStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        </asp:DataList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DataControllConnectionString %>" SelectCommand="SELECT * FROM [SinhVien]" DeleteCommand="DELETE FROM [SinhVien] WHERE [MSSV] = @MSSV" InsertCommand="INSERT INTO [SinhVien] ([MSSV], [HoTen], [MaLop], [Xoa]) VALUES (@MSSV, @HoTen, @MaLop, @Xoa)" UpdateCommand="UPDATE [SinhVien] SET [HoTen] = @HoTen, [MaLop] = @MaLop, [Xoa] = @Xoa WHERE [MSSV] = @MSSV">
            <DeleteParameters>
                <asp:Parameter Name="MSSV" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="MSSV" Type="String" />
                <asp:Parameter Name="HoTen" Type="String" />
                <asp:Parameter Name="MaLop" Type="String" />
                <asp:Parameter Name="Xoa" Type="Int32" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="HoTen" Type="String" />
                <asp:Parameter Name="MaLop" Type="String" />
                <asp:Parameter Name="Xoa" Type="Int32" />
                <asp:Parameter Name="MSSV" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
        
<%--        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:Button ID="thêm" runat="server" OnClick="Button5_Click" Text="Button" CommandName="t" />--%>
        
    </div>
    </form>
</body>
</html>
