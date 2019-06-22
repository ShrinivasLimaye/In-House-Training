<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Assignment_2__19_6_2019_.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <p>
            <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 10px; top: 53px; position: absolute; width: 650px" Text="Label"></asp:Label>
        </p>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 184px; top: 113px; position: absolute; height: 28px; bottom: 485px; width: 145px;"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 185px; top: 232px; position: absolute; width: 64px; height: 28px;" Text="Login" />
        <p>
            <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 183px; top: 179px; position: absolute; height: 28px; width: 145px;"></asp:TextBox>
        </p>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 60px; top: 119px; position: absolute; width: 74px;" Text="Username"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 60px; top: 189px; position: absolute; width: 78px" Text="Password"></asp:Label>
        <p>
            <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 156px; top: 293px; position: absolute; width: 102px"></asp:Label>
        </p>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="z-index: 1; left: 288px; top: 233px; position: absolute; width: 66px; height: 28px" Text="Register" />
        <p>
            <asp:Label ID="Label5" runat="server" style="z-index: 1; top: 290px; position: absolute; width: 95px; left: 306px; height: 22px"></asp:Label>
        </p>
    </form>
</body>
</html>
