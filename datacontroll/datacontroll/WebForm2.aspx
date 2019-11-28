<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="datacontroll.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="mssv" DataSourceID="SqlDataSource2" AllowPaging="True" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="mssv" HeaderText="mssv" ReadOnly="True" SortExpression="mssv" />
                <asp:BoundField DataField="hoten" HeaderText="hoten" SortExpression="hoten" />
                <asp:BoundField DataField="tenlop" HeaderText="tenlop" SortExpression="tenlop" />
                <asp:BoundField DataField="hinh" HeaderText="hinh" SortExpression="hinh" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:DataControllConnectionString %>" SelectCommand="SELECT sv.mssv, sv.hoten, l.tenlop, l.hinh FROM [SinhVien] sv, Lop l WHERE sv.malop = l.malop and sv.xoa=0 and sv.malop = ''+@malop+''">
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList1" DefaultValue="TH17A" Name="MaLop" PropertyName="SelectedValue" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DataControllConnectionString %>" SelectCommand="SELECT sv.mssv, sv.hoten, l.tenlop, l.hinh FROM [SinhVien] sv, Lop l WHERE sv.malop = l.malop and sv.xoa=0 and sv.hoten like'%'+@hoten+'%'">
            <SelectParameters>
                <asp:ControlParameter ControlID="TextBox1" Name="hoten" PropertyName="Text" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem>TH17A</asp:ListItem>
            <asp:ListItem>TH17B</asp:ListItem>
            <asp:ListItem>TH17C</asp:ListItem>
            <asp:ListItem>TH17D</asp:ListItem>
        </asp:DropDownList>
        
    </div>
    </form>
</body>
</html>
