<%@ Page Language="C#" AutoEventWireup="true" CodeFile="caculator.aspx.cs" Inherits="caculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:TextBox ID="TextBox1" runat="server" Width="146px"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="1" Width="46px" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="2" Width="46px" />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="3" Width="46px" />
        <asp:Button ID="Button15" runat="server" OnClick="Button15_Click" Text="AC" />
        <br />
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="4" Width="46px" />
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="5" Width="46px" />
        <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="6" Width="46px" />
        <asp:Button ID="Button11" runat="server" OnClick="Button11_Click" Text="+" Width="31px" />
        <br />
        <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="7" Width="46px" />
        <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" style="height: 21px" Text="8" Width="46px" />
        <asp:Button ID="Button9" runat="server" OnClick="Button9_Click" Text="9" Width="46px" />
        <asp:Button ID="Button12" runat="server" OnClick="Button12_Click" Text="-" Width="31px" />
        <br />
        <asp:Button ID="Button13" runat="server" OnClick="Button13_Click" Text="*" Width="46px" />
        <asp:Button ID="Button10" runat="server" OnClick="Button10_Click" Text="0" Width="46px" />
        <asp:Button ID="Button14" runat="server" OnClick="Button14_Click" Text="/" Width="46px" />
        <asp:Button ID="Button16" runat="server" OnClick="Button16_Click" Text="=" Width="32px" />
        <br />
    </form>
</body>
</html>
