﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Winkelwagen.aspx.cs" Inherits="Bol_Applicatie.Winkelwagen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 485px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <h1>Winkelwagen</h1>
    <div style="height: 406px">
    
        Winkelwagen Producten<br />
        <asp:ListBox ID="lbWinkelwagen" runat="server" Height="273px" Width="215px"></asp:ListBox>
        <br />
        <asp:Button ID="btnBetaal" runat="server" Text="Reken Af" />
        <asp:Button ID="btnVerwijder" runat="server" style="margin-left: 31px" Text="Verwijder" />
    
        <br />
        <br />
        Prijs Winkelwagen: <asp:Label ID="lblPrijs" runat="server" Text="Label"></asp:Label>
        <br />
        Huidig Budget:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblBudget" runat="server" Text="Label"></asp:Label>
    
    </div>
    </form>
</body>
</html>
