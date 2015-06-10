<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomeForm.aspx.cs" Inherits="Bol_Applicatie.HomeForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .Producten {
            position: absolute;
            left: 30%;
            top: 80px;
        }
        #Categorie {
            height: 383px;
        }
        .newStyle1 {
            position: relative;
            left: 15px;
        }
        .newStyle2 {
            position: absolute;
            left: 498px;
            top: 385px;
        }
        .newStyle3 {
            position: absolute;
            left: 699px;
            top: 420px;
            right: 911px;
        }
    </style>
</head>
<body style="height: 449px">
    <form id="form1" runat="server">
    <h1>Bol.com<asp:Button ID="btnInlog" runat="server" style="margin-left: 46px" Text="InlogForm" OnClick="btnInlog_Click" />
        <asp:Button ID="btnWinkelwagen" runat="server" Text="Winkelwagen" OnClick="btnCategorie_Click" />
        <asp:Button ID="btnVerlanglijst" runat="server" OnClick="btnVerlanglijst_Click" Text="Verlanglijst" />
        </h1>
    <div id="Categorie">
        Categorieën&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" CssClass="Producten" Text="Producten"></asp:Label>
        <br />


        <asp:ListBox ID="lbProducten" runat="server" CssClass="Producten" style="margin-left: 0px; top: 109px; left: 30%; width: 271px; height: 221px;"></asp:ListBox>
        <asp:ListBox ID="lbCategorieen" runat="server" Height="235px" Width="240px">
            <asp:ListItem></asp:ListItem>
        </asp:ListBox>
        <br />
        <asp:Button ID="btnVorige" runat="server" Text="Vorige" style="margin-left: 0px" OnClick="btnVorige_Click" />
        <asp:Button ID="btnKies" runat="server" style="margin-left: 125px" Text="Kies"  OnClick="btnKies_Click"/>
        <asp:Button ID="btnKiesProduct" runat="server" CssClass="Producten" style="margin-left: 0px; top: 333px; left: 30%;" Text="Kies" OnClick="btnKiesProduct_Click" />

        <br />
        
        <br />
        <asp:Label ID="Label2" runat="server" CssClass="newStyle2" Text="Zoek Product Op Naam"></asp:Label>
        <asp:TextBox ID="tbZoekOpNaam" runat="server" CssClass="newStyle3" style="top: 383px; right: 793px; left: 702px; margin-left: 0px"></asp:TextBox>
        <br />
        <asp:Button ID="btnZoek" runat="server" CssClass="newStyle3" OnClick="btnZoek_Click" Text="Zoek" />
    </div>

    </form>
</body>
</html>
