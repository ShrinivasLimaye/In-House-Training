<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WebFormsPanel.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Panel Control Example</title>
    <style type="text/css">
        .auto-style2 {
            width: 214px;
        }
        .auto-style3 {
            width: 211px;
        }
        .auto-style4 {
            height: 26px;
            width: 211px;
        }
        .auto-style5 {
            width: 184px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 37px">
            <asp:Label ID="Label2" runat="server" Font-Size="22pt" style="z-index: 1; top: 13px; position: absolute; right: 263px; left: 255px; height: 32px" Text="Panel Example"></asp:Label>
        </div>
        <asp:Panel ID="Panel1" runat="server">
            <table style="border-right: maroon thin solid; border-top: maroon thin solid; border-left: maroon thin solid; border-bottom: maroon thin solid">
                <tr>
                    <td colspan="2" style="text-align: center; border-bottom: maroon thin solid">
                        <span style="font-size: 16pt">Personal Details :</span></td>
                </tr>
                <tr>
                    <td style="width: 100px; text-align: right;">Name :</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 100px; text-align: right;">Address :</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 100px; text-align: right;">Contact :</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 100px; text-align: right;">Email :</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 100px; height: 26px"></td>
                    <td class="auto-style4">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Next" /></td>
                </tr>
            </table>
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server">
            <table style="border-right: maroon thin solid; border-top: maroon thin solid; border-left: maroon thin solid; border-bottom: maroon thin solid">
                <tr>
                    <td colspan="2" style="text-align: center; border-bottom: maroon thin solid">
                        <span style="font-size: 16pt">Educational Details(Percentage) :</span></td>
                </tr>
                <tr>
                    <td style="width: 100px; text-align: right;">10th :</td>
                    <td style="width: 100px">
                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 100px; text-align: right;">12th :</td>
                    <td style="width: 100px">
                        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 100px; text-align: right;">BE :</td>
                    <td style="width: 100px">
                        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 100px"></td>
                    <td style="width: 100px">
                        <asp:Button ID="Button2" runat="server" Text="Back" Width="56px" OnClick="Button2_Click" />
                        <asp:Button ID="Button3" runat="server" Text="Next" Width="56px" OnClick="Button3_Click" />
                    </td>
                </tr>
            </table>
        </asp:Panel>
        <asp:Panel ID="Panel3" runat="server">
             <table style="border-right: maroon thin solid; border-top: maroon thin solid; border-left: maroon thin solid; border-bottom: maroon thin solid">
                <tr>
                    <td colspan="2" style="text-align: center; border-bottom: maroon thin solid">
                        <span style="font-size: 16pt">Technical Proficiency</span></td>
                </tr>
                <tr>
                    <td style="text-align: right;" class="auto-style5">Experience(In Years)</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox8" runat="server" style="z-index: 1; left: -1px; top: 2px; position: relative; width: 52px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="text-align: right;" class="auto-style5">Known Languages</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox></td>
                </tr>
          
                <tr>
                    <td class="auto-style5"></td>
                    <td class="auto-style2">
                        <asp:Button ID="Button4" runat="server" Text="Back" Width="56px" OnClick="Button4_Click" />
                        <asp:Button ID="Button5" runat="server" Text="Submit" Width="56px" OnClick="Button5_Click" />
                    </td>
                </tr>
            </table>
        </asp:Panel>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 173px; top: 536px; position: absolute; height: 118px; width: 426px"></asp:Label>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
