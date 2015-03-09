<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student.aspx.cs" Inherits="ASP_WebForms_Basics.Student" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <td>
            <asp:Label Text="First Name:" runat="server" />
            <asp:TextBox id="txStudentFirstName" runat="server"></asp:TextBox> 
            <asp:RequiredFieldValidator runat="server" ErrorMessage="Can't be left empty !" ControlToValidate="txStudentFirstName"></asp:RequiredFieldValidator>
        </td>
        <td>
            <asp:Label Text="Last Name:" runat="server" />
            <asp:TextBox id="txStudentLastName" runat="server"></asp:TextBox>   
            <asp:RequiredFieldValidator runat="server" ErrorMessage="Can't be left empty !" ControlToValidate="txStudentLastName"></asp:RequiredFieldValidator>          
        </td>
        <asp:Button runat="server" id="buttonValid" Text="Add student." />
    </form>

    <div>
       <asp:Label runat= "server" id="lblResponse" />
    </div>
</body>
</html>
