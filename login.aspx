<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="LoginTest.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            
            <asp:Table ID="Table1" runat="server" CellPadding="10" GridLines="Both" HorizontalAlign="Center">
                <asp:TableRow>
                    <asp:TableCell>User: </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="userID" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>Password: </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="passwordID" runat="server" TextMode="Password"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell columnspan="2" HorizontalAlign="Center">
                        <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_click"/>
                
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                        ConnectionString="Data Source=DESKTOP-BK7LKU3\SQL2014;Initial Catalog=hello_world;Integrated Security=True" 
                        ProviderName="System.Data.SqlClient" SelectCommand="sp_consulta" SelectCommandType="StoredProcedure">
                        <SelectParameters>
                        <asp:ControlParameter ControlID="userID" Name="nombre" PropertyName="Text" Type="String" />
                        </SelectParameters>
                        </asp:SqlDataSource>
                    </asp:TableCell>
                </asp:TableRow>

            </asp:Table>
            
        </div>
    </form>
</body>
</html>
