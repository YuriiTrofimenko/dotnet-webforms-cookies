<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <span>Привет, куки!</span>
            <asp:Button ID="setLangCookieButton" runat="server" Text="Set Language Cookie" OnClick="setLangCookieButton_Click" />
            <asp:Button ID="deleteLangCookieButton" runat="server" Text="Delete Language Cookie" OnClick="deleteLangCookieButton_Click" />
        </div>
        <asp:Label runat="server" ID="output" />
    </form>
</body>
</html>
