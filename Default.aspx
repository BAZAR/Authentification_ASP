<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Page sans titre</title>
    <link rel="Stylesheet" href="~/css/index.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:TextBox runat="server" ID="txt_nom" placeHolder="Votre pseudo"></asp:TextBox>
    <asp:TextBox runat="server" ID="txt_password" placeHolder="Votre mot de passe" TextMode="Password"></asp:TextBox>
    <asp:Button runat="server" ID="btn_connecter" Text="Se connecter" 
            onclick="btn_connecter_Click" />
            
   
   
    </div>
    <asp:CheckBox ID="check_cookie" runat="server" Text=" " />
    <asp:Label ID="Label1" runat="server" Text="remembre me"></asp:Label>
    </form>
</body>
</html>
