<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SS_SessionStateDemo01.aspx.cs" Inherits="Practical4.SS_SessionStateDemo01" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Server Side Session Management using Session State</h1>
            First Name : <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
            <br />
            Last Name : <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnSetSessionState" runat="server" Text="Set Session State Data" OnClick="btnSetSessionState_Click" />
        </div>
    </form>
</body>
</html>
