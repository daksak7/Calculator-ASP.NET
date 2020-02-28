<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="HMW1_23137564450.index" %>

<!DOCTYPE html>
<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous">
<script src="https://code.jquery.com/jquery-3.4.1.slim.min.js" integrity="sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js" integrity="sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6" crossorigin="anonymous"></script>  
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Hesap Makinesi</title>

</head>
<body>
    <br />
    <br />
    <br />
    <br />
    

    <form id="form1" runat="server" align="center">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="CALCULATOR" BorderWidth="1px"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server" EnableTheming="True" OnTextChanged="TextBox1_TextChanged" ReadOnly="True" Width="181px"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Button ID="Button2" runat="server" Height="40px" Text="1" Width="40px" OnClick="Button2_Click" />
&nbsp;<asp:Button ID="Button3" runat="server" Height="40px" OnClick="Button3_Click" Text="2" Width="40px" />
&nbsp;<asp:Button ID="Button4" runat="server" Height="40px" Text="3" Width="40px" OnClick="Button4_Click" />
&nbsp;<asp:Button ID="Button5" runat="server" Height="40px" Text="/" Width="40px" OnClick="Button5_Click" />
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
    </form>
      
</body>
</html>
