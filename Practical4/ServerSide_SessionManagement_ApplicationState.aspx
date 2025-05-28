<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ServerSide_SessionManagement_ApplicationState.aspx.cs" Inherits="Practical4.ServerSide_SessionManagement_ApplicationState" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Server side Session Mangement Using Application State</h1>
            <asp:Label ID="lblVisitorsCount" runat="server" Text=""></asp:Label><br />
            <asp:Label ID="lblOnlineVisitorsCount" runat="server" Text=""></asp:Label><br />
            <asp:Button ID="btnClearSession" runat="server" Text="Clear Session" OnClick="btnClearSession_Click" />
        </div>
    </form>
</body>
</html>
