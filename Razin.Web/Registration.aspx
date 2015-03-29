<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Razin.Web.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="RegistrationStyleSheet.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
        <h1>EMPLOYEE REGISTRATION</h1>

        Name<br/>
        <asp:TextBox ID="txtname" Width="150px" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfv_name" runat="server" ControlToValidate="txtname" ErrorMessage="Enter Employee Name" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
        <br/>
        <br/>
        Address<br/>
        <asp:TextBox ID="txAddress" Width="150px" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfv_address" runat="server" ControlToValidate="txAddress" ErrorMessage="Enter Employee Address" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
        <br/>
        <br/>
        Email ID<br/>
        <asp:TextBox ID="txtEmailid" Width="150px" runat="server"></asp:TextBox>
                         <asp:RegularExpressionValidator ID="rev_email" runat="server" ControlToValidate="txtEmailid" ErrorMessage="Invlaid Email ID" Font-Bold="True" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" Display="Dynamic"></asp:RegularExpressionValidator>
                         <asp:RequiredFieldValidator ID="rfv_email" runat="server" ControlToValidate="txtEmailid" ErrorMessage="Enter Email ID" Font-Bold="True" ForeColor="Red" Display="Dynamic" ></asp:RequiredFieldValidator>
        <br/>
        <br/> 
        Mobile Number<br/>
        <asp:TextBox ID="txtmobile" Width="150px" runat="server" TextMode="Phone"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfv_mobile" runat="server" ControlToValidate="txtmobile" ErrorMessage="Enter Contact Number" Font-Bold="True" ForeColor="Red" Display="Dynamic" ></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="rev_mobile" runat="server" ControlToValidate="txtmobile" Display="Dynamic" ErrorMessage="Invalid Phonne Number" Font-Bold="True" ForeColor="Red" ValidationExpression="^[1-9][0-9]{9}$"></asp:RegularExpressionValidator>
        <br/>
        <br/>
        Designation<br/>
        <asp:TextBox ID="txtdesignation" Width="150px" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfv_designation" runat="server" ControlToValidate="txtdesignation" ErrorMessage="Enter Employee's Designation" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
        <br/>
        <br/>
        Base Salary<br/>
        <asp:TextBox ID="txtsalary" Width="150px" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfv_salary" runat="server" ControlToValidate="txtsalary" ErrorMessage="Enter Employee Salary" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rv_salary" runat="server" ControlToValidate="txtsalary" Display="Dynamic" ErrorMessage="Enter Valid Salary" Font-Bold="True" ForeColor="Red" MaximumValue="3000000" MinimumValue="1" Type="Currency"></asp:RangeValidator>
        <br/>
        <br/>
        Employee Type<br/>
        <asp:DropDownList ID="ddl_emptype" runat ="server" Width="150">
                       <asp:ListItem Value ="0">"SELECT"</asp:ListItem>
                       <asp:ListItem>Full-Time</asp:ListItem>
                       <asp:ListItem>Part-Time</asp:ListItem>
        </asp:DropDownList>
        <br/>
        <br/>
        <asp:Button ID="BtnSave" runat="server" Width="100px" Text="Save" OnClick="BtnSave_Click" />
        <br /><br /><br />
        <asp:HyperLink runat="server" ID="hyp_empDetails" NavigateUrl="EmployeeDetails.aspx" Text="Employee Details"></asp:HyperLink>
    
    </div>
    </form>
</body>
</html>
