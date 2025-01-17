<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MultiView.aspx.cs" Inherits="demoasp.MultiView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
                <asp:View ID="View1" runat="server">
                    <h1>View 1</h1>
                    <p>
                        <br />
                        Name:&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Enter the name" ForeColor="Red"></asp:RequiredFieldValidator>
                        <br />
                        <br />
                        Branch:&nbsp;&nbsp;<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                        <br />
                        <br />
                        City:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </p>
                    <p>
                        Email:&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox4" ErrorMessage="Enter Email" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </p>
                    <p>
                        Age:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox5" ErrorMessage="Age must be above 18" ForeColor="Red" MaximumValue="60" MinimumValue="18"></asp:RangeValidator>
                        &nbsp;&nbsp;&nbsp;&nbsp;
                        </p>
                    <p>
                        Password:&nbsp;
                        <asp:TextBox ID="TextBox6" runat="server" TextMode="Password"></asp:TextBox>
                    </p>
                    <p>
                        Confirm Passsword:&nbsp;
                        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox6" ControlToValidate="TextBox7" ErrorMessage="Enter same as above" ForeColor="Red"></asp:CompareValidator>
                    </p>
                    <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Next" />
                </asp:View>
                <asp:View ID="View2" runat="server">
                    <h1>View 2</h1>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Previous" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button2" runat="server" Text="Next" OnClick="Button2_Click" />
                </asp:View>
            </asp:MultiView>
        </div>
    </form>
</body>
</html>
