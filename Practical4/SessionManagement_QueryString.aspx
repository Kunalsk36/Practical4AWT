<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SessionManagement_QueryString.aspx.cs" Inherits="Practical4.SessionManagement_QueryString" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Session Management using Query String!</h1>
        <div>
            <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label><br /><br />
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" /><br /><br />
            <asp:Label ID="lblCount" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
