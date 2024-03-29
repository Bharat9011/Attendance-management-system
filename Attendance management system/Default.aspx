<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Attendance_management_system.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="CSS/LoginPage.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="heading">
                <label runat="server">Login page</label>
            </div>

            <div class="form">
                <div>
                    <asp:Image runat="server" ImageUrl="~/image/profile.png" ID="imagess" />
                </div>
                <asp:Label class="label" ID="Label1" Text="Email id" runat="server" />
                <br />
                <asp:TextBox ID="email" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label class="label" ID="Label2" Text="Password" runat="server" />
                <br />
                <asp:TextBox ID="password" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Button CssClass="bg-light-subtle" runat="server" Text="login" ID="login" OnClick="login_Click" />
                <br />
                <label runat="server" class="check">forgot password</label>
            </div>
        </div>
    </form>
</body>
</html>
