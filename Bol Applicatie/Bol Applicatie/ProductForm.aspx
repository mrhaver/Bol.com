<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductForm.aspx.cs" Inherits="Bol_Applicatie.ProductForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .Winkelwagen {
            position: absolute;
            right: 62%;
            top: 103px;
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
    <h1>
        <asp:Label ID="lblProduct" runat="server" Text="Label"></asp:Label>
        </h1>
    <div>
    
        Productfoto<asp:Button ID="btnWinkelWagen" runat="server" CssClass="Winkelwagen" Height="38px" Text="Winkelwagen" OnClick="btnWinkelWagen_Click" />
        <asp:Button ID="btnVerlanglijst" runat="server" style="margin-left: 0px; position: absolute; left: 21%; top: 103px; height: 35px; width: 117px" Text="Verlanglijst" OnClick="btnVerlanglijst_Click" />
        <br />
        <asp:Image ID="Image1" runat="server" Height="264px" Width="277px" />
        <br />
        Productbeschrijving:<br />
        <br />
        <asp:Label ID="lblProductBeschrijving" runat="server" Text="Hier komt de productbeschrijving te staan"></asp:Label>
        <br />
        <br />
        Prijs:
        <asp:Label ID="lblPrijs" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnNaarWinkelwagen" runat="server" Text="Naar Winkelwagen" OnClick="btnNaarWinkelwagen_Click" />
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
