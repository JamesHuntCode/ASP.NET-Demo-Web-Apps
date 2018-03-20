﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CreateStaff.aspx.cs" Inherits="CreateStaff" %>

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
                <input id="FirstName" type="text" runat="server"/>
                <h3 class="sub-heading">Input Your Last Name Here:</h3>
                <input id="LastName" type="text" runat="server"/>
                <h3 class="sub-heading">Input Your Email Address Here:</h3>
                <input id="EmailAddress" type="text" runat="server"/>
                <h3 class="sub-heading">Input Your Password Here:</h3>
                <input id="Password" type="text" runat="server"/>
                <h3 class="sub-heading">Are You A Volunteer?</h3>
                <asp:CheckBox ID="VolunteerCheckbox" runat="server" text="Are you a volunteer?"/>
                <h3 class="sub-heading">Library Role:</h3>
                <asp:DropDownList ID="ChooseRole" runat="server"></asp:DropDownList>
                <h3 class="sub-heading">All Done? Submit your data below.</h3>
                <asp:Button ID="SubmitButton" runat="server" Text="Submit!" OnClick="SubmitButton_Click" />
            </div>
            <!-- end of new staff creation section -->
        </div>
        <!-- END OF PAGE CONTENT -->
    </form>
</body>
</html>
