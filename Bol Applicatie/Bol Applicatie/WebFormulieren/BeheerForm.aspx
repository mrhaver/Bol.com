<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BeheerForm.aspx.cs" Inherits="Bol_Applicatie.BeheerForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .ProductToevoegen {
            position: relative;
            top: 20px;
        }
        .tbProducten {
            left: 12%;
            position: absolute;
        }
        #form1 {
            height: 610px;
        }
        .ZoekProduct {
            left: 300px;
            position: absolute;
            top: 555px;
        }
    </style>
</head>
<body style="height: 643px">
    <form id="form1" runat="server">
        <h1>Beheersysteem<asp:Button ID="btnInlogform" runat="server" OnClick="btnInlogform_Click" style="margin-left: 74px" Text="InlogForm" />
        </h1>
    <div id="ProductToevoegen" class="newStyle1">
                       
        <asp:Label ID="Label1" runat="server" Text="Naam: "></asp:Label>
        <asp:TextBox ID="tbNaam" runat="server" CssClass="tbProducten"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Beschrijving: "></asp:Label>
        <asp:TextBox ID="tbBeschrijving" runat="server" CssClass="tbProducten" Width="320px"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Prijs: "></asp:Label>
        <asp:TextBox ID="tbPrijs" runat="server" CssClass="tbProducten"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="btnVoegProductToe" runat="server" Text="Voeg Product Toe" OnClick="btnVoegProductToe_Click" />
                       
        <br />
        <br />
        <br />
        Kies voor welke categorie je&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br />
        een product wilt toevoegen<br />
        <asp:ListBox ID="lbCategorieen" runat="server" Height="205px" Width="229px"></asp:ListBox>
        <br />
        <br />
        <br />
        <br />
                       
    </div>
        <br />
    </form>
</body>
</html>
