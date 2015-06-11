<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VraagForm.aspx.cs" Inherits="Bol_Applicatie.VraagForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <h1>Vraag</h1>
    <div id="Vraag">
        
        <br />
        <asp:Label ID="Label1" runat="server" Text="De Gestelde Vraag"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Antwoorden"></asp:Label>
        <br />
        <asp:ListBox ID="ListBox2" runat="server" Height="252px" Width="264px"></asp:ListBox>
        <br />
        <asp:Button ID="btnAntwoord" runat="server" Text="Laat Antwoord Zien" />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Antwoord:"></asp:Label>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Het gekozen gegeven antwoord"></asp:Label>
        
    </div>
    </form>
</body>
</html>
