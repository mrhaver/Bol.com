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
            top: 262px;
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
    </form>
</body>
</html>
