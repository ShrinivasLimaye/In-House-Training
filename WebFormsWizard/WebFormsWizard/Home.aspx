<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WebFormsWizard.Home" %>


<!DOCTYPE html>

<script runat="server">
    protected void WizardStep4_Activate(object sender, System.EventArgs e) {
        Label5.Text = "Name: " + TextBox1.Text.ToString() +
                      "<br />Address: " + TextBox2.Text.ToString() +
                      "<br />Contact: " + TextBox3.Text.ToString() +
                      "<br />Email: " + TextBox4.Text.ToString() +
                      "<br />Address: " + TextBox2.Text.ToString() +
                      "<br />Latest Qualification: " + RadioButtonList1.SelectedItem.Text.ToString()+
                      "<br />Specialization(Branch): " + RadioButtonList2.SelectedItem.Text.ToString()+
                      "<br />Favorite Language: " + RadioButtonList3.SelectedItem.Text.ToString();
                      }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Wizard Control Resume Builder</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Wizard ID="Wizard1" runat="server" HeaderStyle-Font-Size="Larger" HeaderStyle-ForeColor="Crimson" ActiveStepIndex="0" Height="242px" OnFinishButtonClick="Wizard1_FinishButtonClick" Width="465px">
<HeaderStyle Font-Size="Larger" ForeColor="Crimson"></HeaderStyle>
            <WizardSteps>
                <asp:WizardStep ID="WizadStep1" runat="server" title="Personal Information">
                    <asp:Label ID="Label1" runat="server" Text="Name" AssociatedControlID="TextBox1"></asp:Label>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label2" runat="server" Text="Address" AssociatedControlID="TextBox2"></asp:Label>
                    <asp:TextBox ID="TextBox2" runat="server" Width="132px"></asp:TextBox>
                    <br />
                     <asp:Label ID="Label7" runat="server" Text="Contact" AssociatedControlID="TextBox3"></asp:Label>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    <br />
                     <asp:Label ID="Label8" runat="server" Text="Email" AssociatedControlID="TextBox4"></asp:Label>
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </asp:WizardStep>
                 <asp:WizardStep ID="WizardStep2" runat="server" title="Latest Qualification?">
                    <asp:Label ID="Label4" runat="server" Text="" AssociatedControlID="RadioButtonList1"></asp:Label>
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                        <asp:ListItem Selected="True">BE</asp:ListItem>
                        <asp:ListItem>MSc</asp:ListItem>
                        <asp:ListItem>BSc</asp:ListItem>
                        <asp:ListItem>Diploma</asp:ListItem>
                    </asp:RadioButtonList>
                </asp:WizardStep>
                <asp:WizardStep ID="WizardStep3" runat="server" title="Specialization(Branch)?">
                    <asp:Label ID="Label6" runat="server" Text="" AssociatedControlID="RadioButtonList1"></asp:Label>
                    <asp:RadioButtonList ID="RadioButtonList2" runat="server" Height="106px">
                        <asp:ListItem Selected="True">Computer</asp:ListItem>
                        <asp:ListItem>IT</asp:ListItem>
                        <asp:ListItem>Mechanical</asp:ListItem>
                    </asp:RadioButtonList>
                </asp:WizardStep>
                <asp:WizardStep ID="WizardStep4" runat="server" title="Favorite Language?">
                    <asp:Label ID="Label3" runat="server" Text="" AssociatedControlID="RadioButtonList1"></asp:Label>
                    <asp:RadioButtonList ID="RadioButtonList3" runat="server">
                        <asp:ListItem Selected="True">Java</asp:ListItem>
                        <asp:ListItem>Python</asp:ListItem>
                        <asp:ListItem>C#</asp:ListItem>
                    </asp:RadioButtonList>
                </asp:WizardStep>
           
                <asp:WizardStep ID="WizardStep5" runat="server" Title="Generate" OnActivate="WizardStep4_Activate">
                    <asp:Label ID="Label5" runat="server" Font-Size="X-Large" ForeColor="DarkGoldenrod"></asp:Label>
                </asp:WizardStep>
            </WizardSteps>
        </asp:Wizard>
    
    </div>
    </form>
</body>
</html>