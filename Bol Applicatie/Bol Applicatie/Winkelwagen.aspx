<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Winkelwagen.aspx.cs" Inherits="Bol_Applicatie.Winkelwagen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <h1>Winkelwagen</h1>
    <div>
    
        Winkelwagen Producten<br />
        <asp:ListBox ID="ListBox2" runat="server" Height="273px" Width="215px"></asp:ListBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Reken Af" />
        <asp:Button ID="Button2" runat="server" style="margin-left: 31px" Text="Verwijder" />
    
    </div>
    </form>
</body>
</html>
