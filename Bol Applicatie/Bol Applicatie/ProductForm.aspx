<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductForm.aspx.cs" Inherits="Bol_Applicatie.ProductForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .Winkelwagen {
            position: absolute;
            right: 10%;
            top: 79px;
            width: 108px;
        }
        .Recensies {
            position: absolute;
            left: 25%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <h1>ProductNaam</h1>
    <div>
    
        Productfoto<asp:Button ID="Button1" runat="server" CssClass="Winkelwagen" Height="38px" Text="Winkelwagen" />
        <asp:Button ID="btnVerlanglijst" runat="server" style="margin-left: 0px; position: absolute; left: 70%; top: 79px; height: 35px; width: 117px" Text="Verlanglijst" />
        <br />
        <asp:Image ID="Image1" runat="server" Height="264px" Width="277px" />
        <br />
        Productbeschrijving:<br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Hier komt de productbeschrijving te staan"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Button ID="btnNaarWinkelwagen" runat="server" Text="Naar Winkelwagen" />
        <asp:Button ID="btnNaarWinkelwagen0" runat="server" style="margin-left: 23px" Text="Naar Verlanglijst" />
        <br />
        <br /> 
    </div>

    <div id="Vragen_Recensies">
        Vragen<asp:Label ID="Label2" runat="server" CssClass="Recensies" Text="Recensies"></asp:Label>
        <br />
        <asp:ListBox ID="ListBox1" runat="server" Height="308px" Width="279px"></asp:ListBox>
        <asp:ListBox ID="ListBox2" runat="server" Height="308px" Width="279px" CssClass="Recensies"></asp:ListBox>
        <br />
        <br />
        <asp:Button ID="btnKiesVraag" runat="server" Text="Kies" />
        <asp:Button ID="btnStelVraag" runat="server" style="margin-left: 52px" Text="Stel Vraag" />
        <asp:Button ID="btnSchrijfRecensie" runat="server" CssClass="Recensies" Text="Schrijf Recensie" />
    </div>
    </form>
</body>
</html>
