<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AccountInformatie.aspx.cs" Inherits="Bol_Applicatie.AccountInformatie" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .AccountInfo {
            position: absolute;
            left: 10%;
        }
        .rbtnVrouw {
            position: absolute;
            left: 15%;
            top: 566px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <h1>AccountInformatie<asp:Button ID="btnInlog" runat="server" style="margin-left: 46px" Text="InlogForm" OnClick="btnInlog_Click" />
        <asp:Button ID="btnCategorie" runat="server" Text="CategorieForm" OnClick="btnCategorie_Click" />
        <asp:Button ID="btnWinkelwagen" runat="server" OnClick="btnVerlanglijst_Click" Text="Winkelwagen" />
        </h1>
    <div>
    
        <br />
        Verlanglijstje<br />
        <asp:ListBox ID="lbVerlanglijst" runat="server" Height="326px" Width="447px"></asp:ListBox>
        <br />
        <asp:Button ID="btnExWinkelwagen" runat="server" Text="Exporteer Naar Winkelwagen" OnClick="btnExWinkelwagen_Click" />
        <asp:Button ID="btnVerwijder" runat="server" style="margin-left: 23px" Text="Verwijder" OnClick="btnVerwijder_Click" />
    
        <br />
    
    </div>

    <div>

        <br />
        Wijzig Gegevens<br />
    
        <asp:Label ID="Label1" runat="server" Text="Voornaam: "></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" CssClass="AccountInfo"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Achternaam: "></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" CssClass="AccountInfo"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Email: "></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" CssClass="AccountInfo"></asp:TextBox>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Gebruikersnaam: "></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server" CssClass="AccountInfo"></asp:TextBox>
        <br />
        <asp:Label ID="Label6" runat="server" Text="Wachtwoord: "></asp:Label>
        <asp:TextBox ID="TextBox5" runat="server" CssClass="AccountInfo"></asp:TextBox>
        <br />
        <asp:Button ID="Button3" runat="server" Text="Bevestig" />
        <br />

    </div>
    </form>
</body>
</html>
