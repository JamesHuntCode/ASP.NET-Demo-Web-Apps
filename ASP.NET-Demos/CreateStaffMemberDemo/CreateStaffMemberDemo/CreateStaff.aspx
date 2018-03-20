<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CreateStaff.aspx.cs" Inherits="CreateStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Create Staff Demo App</title>
</head>
<body>
    <form id="form1" runat="server">
        <!-- PAGE CONTENT -->
        <div id="page-content">
            <!-- section where a new staff member is created -->
            <div id="create-new-staff-member">
                <h1 class="main-heading">Welcome! Please input your details to get started</h1>
                <h3 class="sub-heading">Input Your First Name Here:</h3>
                <input id="first-name" type="text" />
                <h3 class="sub-heading">Input Your Last Name Here:</h3>
                <input id="last-name" type="text" />
                <h3 class="sub-heading">Input Your Email Address Here:</h3>
                <input id="email-address" type="text" />
                <h3 class="sub-heading">Input Your Password Here:</h3>
                <input id="password" type="text" />
                <h3 class="sub-heading">Are You A Volunteer?</h3>
                <asp:DropDownList ID="ChooseRole" runat="server"></asp:DropDownList>
            </div>
            <!-- end of new staff creation section -->
        </div>
        <!-- END OF PAGE CONTENT -->
    </form>
</body>
</html>
