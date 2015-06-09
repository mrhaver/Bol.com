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
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Beheersysteem</h1>
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
        <asp:Label ID="Label4" runat="server" Text="Bestandslocatie: "></asp:Label>
        <asp:TextBox ID="tbBestandslocatie" runat="server" CssClass="tbProducten" Width="320px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnVoegProductToe" runat="server" Text="Voeg Product Toe" />
        <asp:Button ID="btnPasProductAan" runat="server" style="margin-left: 50px" Text="Pas Product Aan" />
                       
    </div>

    <div id="Gerapporteerde Berichten">
        <h2>Verwijder Gerapporteerde Berichten</h2>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Vragen" />
        <asp:Button ID="Button2" runat="server" style="margin-left: 18px" Text="Reviews" />
        <asp:Button ID="Button3" runat="server" style="margin-left: 17px" Text="Antwoorden" />
        <br />
        <asp:ListBox ID="lbItems" runat="server" Height="216px" Width="365px"></asp:ListBox>
        <br />
        <asp:Button ID="Button4" runat="server" style="margin-left: 0px" Text="Verwijder" />
        <br />

    </div>
    </form>
</body>
</html>
