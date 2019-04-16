<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .newStyle1 {
        }
        .newStyle2 {
            width: 100%;
        }
    </style>
    <link href="StyleSheet1.css" rel="stylesheet" type="text/css" />
    <link href="StyleSheet1.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin: auto; border-style: ridge; background-color: #1B1599; font-family: sans-serif; color: #FFFFFF; height: 100%; top: 0px; left: 0px; width: 835px;" dir="ltr">
            <asp:Button ID="Button1" runat="server" BackColor="#757373" BorderColor="White" BorderStyle="Ridge" Font-Bold="False" Font-Names="Lucida Console" Font-Size="Small" ForeColor="White" Height="20px" OnClick="Button1_Click" style="border-style: outset; margin-left: 10px; margin-right: 10px; margin-top: 11px; margin-bottom: 10px" Text="Parse Xml" Width="134px" />
            <asp:TextBox ID="TextBox1" runat="server" BackColor="#1B15A3" BorderStyle="Ridge" Font-Bold="False" Font-Names="Lucida Console" Font-Size="Small" ForeColor="#757373" Height="20px" OnTextChanged="TextBox1_TextChanged" style="border-style: inset; border-width: 2px; margin: 10px" Width="649px">https://gist.githubusercontent.com/Nydhal/4c974a804d08cdaa5936d59a1b753794/raw/4700bc5652dafa981e84c1ee719ebdd766e4b973/Hotels.xml</asp:TextBox>
            <br />
            <asp:Button ID="Button2" runat="server" BackColor="#089FA1" BorderColor="White" BorderStyle="Ridge" Font-Bold="False" Font-Names="Lucida Console" Font-Size="Small" ForeColor="White" Height="20px" OnClick="Button2_Click" style="border-style: outset; margin-left: 10px; margin-right: 10px; margin-top: 11px; margin-bottom: 10px" Text="Verify Xsd" Width="134px" />
            <asp:TextBox ID="TextBox3" runat="server" BackColor="#1B15A3" BorderStyle="Ridge" Font-Bold="False" Font-Names="Lucida Console" Font-Size="Small" ForeColor="#757373" Height="20px" OnTextChanged="TextBox2_TextChanged" style="border-style: inset; border-width: 2px; margin-left: 10px; margin-right: 10px; margin-bottom: 10px;" Width="649px">https://gist.githubusercontent.com/Nydhal/4c974a804d08cdaa5936d59a1b753794/raw/4700bc5652dafa981e84c1ee719ebdd766e4b973/Hotels.xsd</asp:TextBox>
            <br />
            <asp:Button ID="Button3" runat="server" BackColor="#089FA1" BorderColor="White" BorderStyle="Ridge" Font-Bold="False" Font-Names="Lucida Console" Font-Size="Small" ForeColor="White" Height="20px" OnClick="Button3_Click" style="border-style: outset; margin-left: 10px; margin-right: 10px; margin-top: 11px; margin-bottom: 10px" Text="Search XPath" Width="134px" />
            <asp:TextBox ID="TextBox4" runat="server" BackColor="#1B15A3" BorderStyle="Ridge" Font-Bold="False" Font-Names="Lucida Console" Font-Size="Small" ForeColor="#757373" Height="20px" OnTextChanged="TextBox3_TextChanged" style="border-style: inset; border-width: 2px; margin: 10px" Width="649px">/Hotels/Hotel[@Stars=&quot;**&quot;]/Name</asp:TextBox>
            <br />
            <asp:TextBox ID="TextBox2" runat="server" BackColor="#1B15A3" ForeColor="White" OnTextChanged="TextBox2_TextChanged" style="position: relative; top: 0px; left: 0px; width: 814px; height: 412px; margin: 10px" TextMode="MultiLine" Wrap="False"></asp:TextBox>
            <br />
        </div>
    </form>
</body>
</html>
