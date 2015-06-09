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
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <h1>Bol.com</h1>
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
    </div>

    </form>
</body>
</html>
