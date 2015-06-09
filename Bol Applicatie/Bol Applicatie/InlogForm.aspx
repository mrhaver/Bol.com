<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InlogForm.aspx.cs" Inherits="Bol_Applicatie.InlogForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Bol_Applicatie {
            text-align: center;
        }
        .auto-style1 {
            text-align: center;
        }
        .newStyle1 {
            position: absolute;
            left: 35%;
        }
        .newStyle2 {
            position: relative;
            top: 20px;
            left: 0px;
            margin-left: 34px;
        }
        .GebrWW {
            position: absolute;
            left: 45%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="Bol_Applicatie">
    
        <h1>Bol Applicatie</h1>
    
    </div>

    <div class="auto-style1">
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" CssClass="newStyle1" Text="Gebruikersnaam: "></asp:Label>
        <asp:TextBox ID="tbGebruikersnaam" runat="server" CssClass="GebrWW"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" CssClass="newStyle1" Text="Wachtwoord: "></asp:Label>
        <asp:TextBox ID="tbWachtwoord" runat="server" CssClass="GebrWW"></asp:TextBox>
        <br />
        <asp:Button ID="btnLogIn" runat="server" CssClass="newStyle2" style="margin-left: 0px" Text="Log In" OnClick="btnLogIn_Click" />
        <asp:Button ID="btnMaakGebruiker" runat="server" CssClass="newStyle2" Text="Maak Gebruiker" OnClick="btnMaakGebruiker_Click" />
        <br />

    </div>
    </form>
</body>
</html>
