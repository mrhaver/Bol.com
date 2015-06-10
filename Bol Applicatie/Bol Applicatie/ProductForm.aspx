<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductForm.aspx.cs" Inherits="Bol_Applicatie.ProductForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .Winkelwagen {
            position: absolute;
            right: 57%;
            top: 21px;
            width: 108px;
            height: 29px;
            margin-bottom: 0px;
        }
        .Recensies {
            position: absolute;
            left: 25%;
        }
        .newStyle1 {
            position: absolute;
            top: 20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <h1>
        <asp:Label ID="lblProduct" runat="server" Text="Label"></asp:Label>
        &nbsp;&nbsp;&nbsp; <asp:Button ID="btnInlog" runat="server" style="margin-left: 46px" Text="InlogForm" OnClick="btnInlog_Click" />
        <asp:Button ID="btnCategorie" runat="server" Text="CategorieForm" OnClick="btnCategorie_Click" style="margin-left: 8px" />
        <asp:Button ID="btnVerlanglijst" runat="server" OnClick="btnVerlanglijst_Click1" style="margin-left: 13px" Text="Verlanglijst" />
        <asp:Button ID="btnWinkelwagen" runat="server" OnClick="btnWinkelwagen_Click1" style="margin-left: 11px" Text="Winkelwagen" />
        </h1>
    <div>
    
        Productfoto<br />
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
        <asp:Button ID="btnNaarVerlanglijst" runat="server" style="margin-left: 23px" Text="Naar Verlanglijst" OnClick="btnNaarVerlanglijst_Click" />
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
