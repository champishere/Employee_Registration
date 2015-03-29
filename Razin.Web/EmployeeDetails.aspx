<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeDetails.aspx.cs" Inherits="Razin.Web.EmployeeDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="RegistrationStyleSheet.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
        <asp:DropDownList runat="server" ID="ddl_emp" AutoPostBack="True" >
        <asp:ListItem Value ="0">"SELECT"</asp:ListItem>
                <asp:ListItem>Full-Time</asp:ListItem>
                <asp:ListItem>Part-Time</asp:ListItem>
   </asp:DropDownList>
        <br/>
        <br/>
        <br/>
        <asp:GridView runat="server" AutoGenerateColumns="False" DataKeyNames="EmployeeId" DataSourceID="SqlDataSource_empDetails" AllowSorting="True">
            <Columns>
                <asp:BoundField DataField="EmployeeId" HeaderText="EmployeeId" InsertVisible="False" ReadOnly="True" SortExpression="EmployeeId"/>
                <asp:BoundField DataField="EmployeeName" HeaderText="EmployeeName" SortExpression="EmployeeName" />
                <asp:BoundField DataField="EmployeeAddress" HeaderText="EmployeeAddress" SortExpression="EmployeeAddress" />
                <asp:BoundField DataField="EmailId" HeaderText="EmailId" SortExpression="EmailId" />
                <asp:BoundField DataField="MobileNumber" HeaderText="MobileNumber" SortExpression="MobileNumber" />
                <asp:BoundField DataField="Designation" HeaderText="Designation" SortExpression="Designation" />
                <asp:BoundField DataField="Emptype" HeaderText="Emptype" SortExpression="Emptype" />
                <asp:BoundField DataField="Month" HeaderText="Month" SortExpression="Month" />
            </Columns>
        </asp:GridView>
    
        <asp:SqlDataSource ID="SqlDataSource_empDetails" runat="server" ConnectionString="<%$ ConnectionStrings:EmployeeDbConnectionString %>" SelectCommand="SELECT [EmployeeId], [EmployeeName], [EmployeeAddress], [EmailId], [MobileNumber], [Designation], [Emptype], [Month] FROM [EmployeeRegistration] WHERE ([Emptype] = @Emptype)">
            <SelectParameters>
                <asp:ControlParameter ControlID="ddl_emp" DefaultValue="%%" Name="Emptype" PropertyName="SelectedValue" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource><br /><br /><br />
        <asp:HyperLink runat="server" ID="hyp_home" NavigateUrl="Registration.aspx" Text="Home"></asp:HyperLink>
    
    </div>
    </form>
</body>
</html>
