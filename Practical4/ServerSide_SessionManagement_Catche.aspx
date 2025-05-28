<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ServerSide_SessionManagement_Catche.aspx.cs" Inherits="Practical4.ServerSide_SessionManagement_Catche" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Server Side Session Management using Cache</h1>
            First Name: <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox><br />
            Last Name: <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox><br /><br />
            <asp:Button ID="btnSubmit" runat="server" Text="SetData" OnClick="btnSubmit_Click" />
        </div>
    </form>
</body>
</html>
