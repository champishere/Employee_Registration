<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exception.aspx.cs" Inherits="Razin.Web.Exception" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="RegistrationStyleSheet.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
        <img src="Image/error.jpg" />
        <br/>
        <br/>
        <br/>
        <asp:HyperLink runat="server" ID="hyp_goback" NavigateUrl="Registration.aspx">Registration Page</asp:HyperLink>
    </div>
    </form>
</body>
</html>
