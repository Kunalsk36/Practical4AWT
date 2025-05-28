<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SessionMgmt_HttpContext.aspx.cs" Inherits="Practical4.SessionMgmt_HttpContext" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Server side session management using Http Context</h1>
            <p>Enter Name: </p>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnStore" runat="server" Text="Store" OnClick="btnStore_Click" />
            <asp:Button ID="btnRetrive" runat="server" Text="Retrieve" OnClick="btnRetrive_Click" />
        </div>
    </form>
</body>
</html>
