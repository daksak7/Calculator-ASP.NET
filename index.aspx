<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="HMW1_23137564450.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Hesap Makinesi</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" BorderWidth="1px"></asp:Label>
        <br />
        <asp:Label ID="Label2" runat="server"></asp:Label>
        <br />
        <asp:Label ID="Label3" runat="server"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox1" runat="server" EnableTheming="True" OnTextChanged="TextBox1_TextChanged" ReadOnly="True" Width="181px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Height="40px" Text="1" Width="40px" OnClick="Button2_Click" />
&nbsp;<asp:Button ID="Button3" runat="server" Height="40px" OnClick="Button3_Click" Text="2" Width="40px" />
&nbsp;<asp:Button ID="Button4" runat="server" Height="40px" Text="3" Width="40px" OnClick="Button4_Click" />
&nbsp;<asp:Button ID="Button5" runat="server" Height="40px" Text="/" Width="40px" />
        <br />
        <br />
        <asp:Button ID="Button6" runat="server" Height="40px" Text="4" Width="40px" OnClick="Button6_Click" />
&nbsp;<asp:Button ID="Button7" runat="server" Height="40px" Text="5" Width="40px" OnClick="Button7_Click" />
&nbsp;<asp:Button ID="Button8" runat="server" Height="40px" Text="6" Width="40px" OnClick="Button8_Click" />
&nbsp;<asp:Button ID="Button9" runat="server" Height="40px" OnClick="Button9_Click" Text="*" Width="40px" />
        <br />
        <br />
        <asp:Button ID="Button10" runat="server" Height="40px" Text="7" Width="40px" OnClick="Button10_Click" />
&nbsp;<asp:Button ID="Button11" runat="server" Height="40px" Text="8" Width="40px" OnClick="Button11_Click" />
&nbsp;<asp:Button ID="Button12" runat="server" Height="40px" Text="9" Width="40px" OnClick="Button12_Click" />
&nbsp;<asp:Button ID="Button13" runat="server" Height="40px" Text="-" Width="40px" OnClick="Button13_Click" />
        <br />
        <br />
        <asp:Button ID="Button14" runat="server" Height="40px" Text="0" Width="40px" OnClick="Button14_Click" />
&nbsp;<asp:Button ID="Button15" runat="server" Height="40px" Text="CLC" Width="40px" OnClick="Button15_Click" />
&nbsp;<asp:Button ID="Button16" runat="server" Height="40px" OnClick="Button16_Click" Text="=" Width="40px" />
&nbsp;<asp:Button ID="Button17" runat="server" Height="40px" Text="+" Width="40px" OnClick="Button17_Click" />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Hesapla" />
    </form>
</body>
</html>
