<%@ Page Language="C#" AutoEventWireup="true" CodeFile=".\Default.aspx.cs" Inherits="USP.TestApp.Web._Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome to Web Forms</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Welcome to ASP.NET Web Forms!</h1>
            <asp:Button ID="btnClickMe" runat="server" Text="Click Me" OnClick="btnClickMe_Click" />
        </div>
    </form>
</body>
</html>
