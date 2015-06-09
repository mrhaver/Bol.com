<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MaakAccountForm.aspx.cs" Inherits="Bol_Applicatie.MaakAccountForm" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

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
        }
    </style>
</head>
<body>
    <h1>Maak Account</h1>
    <form id="form1" runat="server">
    <div id="AccountInfo">
    
        <asp:Label ID="Label1" runat="server" Text="Voornaam: "></asp:Label>
        <asp:TextBox ID="tbVoornaam" runat="server" CssClass="AccountInfo"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Achternaam: "></asp:Label>
        <asp:TextBox ID="tbAchternaam" runat="server" CssClass="AccountInfo"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Geslacht: "></asp:Label>
        <asp:RadioButton ID="rbtnMan" runat="server" CssClass="AccountInfo" Text="Man" Value="Geslacht"/>
        <asp:RadioButton ID="rbtnVrouw" runat="server" CssClass="rbtnVrouw" Text="Vrouw" Value="Geslacht"/>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Email: "></asp:Label>
        <asp:TextBox ID="tbEmail" runat="server" CssClass="AccountInfo"></asp:TextBox>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Gebruikersnaam: "></asp:Label>
        <asp:TextBox ID="tbGebruikersnaam" runat="server" CssClass="AccountInfo"></asp:TextBox>
        <br />
        <asp:Label ID="Label6" runat="server" Text="Wachtwoord: "></asp:Label>
        <asp:TextBox ID="tbWachtwoord" runat="server" CssClass="AccountInfo"></asp:TextBox>
        <br />
        <asp:Label ID="Label7" runat="server" Text="Budget: "></asp:Label>
        <asp:DropDownList ID="ddlBudget" runat="server" CssClass="AccountInfo" Width="142px">
            <asp:ListItem>10</asp:ListItem>
            <asp:ListItem>15</asp:ListItem>
            <asp:ListItem>20</asp:ListItem>
            <asp:ListItem>25</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="btnMaak" runat="server" OnClick="btnMaak_Click" Text="Maak Aan" Width="112px" />
        <asp:Button ID="btnAnnuleer" runat="server" OnClick="btnAnnuleer_Click" style="margin-left: 95px" Text="Annuleren" Width="119px" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
