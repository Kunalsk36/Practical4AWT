<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SessionMgmt_ViewState.aspx.cs" Inherits="Practical4.SessionMgmt_ViewState" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblCounter" runat="server" Text="Label"></asp:Label>
            <asp:Button ID="Button1" runat="server" Text="Button" PostBackUrl="~/SessionMgmt_ViewState.aspx" />
        </div>
    </form>
</body>
</html>
