﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 316px;
        }
    </style>
</head>
<body style="height: 366px">
    <form id="form1" runat="server">
        <asp:Label ID="lblStaffID" runat="server" Text="Staff ID" Height="19px" width="87px"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="txtStaffID" runat="server" Width="146px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblStaffFullName" runat="server" Text="Staff Name" width="87px"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="txtStaffName" runat="server" Width="146px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblStaffRole" runat="server" Text="Staff Role" width="87px"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="txtStaffRole" runat="server" Width="144px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblStaffHireDate" runat="server" Text="Staff HireDate"></asp:Label>
&nbsp;<asp:TextBox ID="txtStaffHireDate" runat="server" Width="145px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblStaffSalary" runat="server" Text="Staff Salary" width="87px"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="txtStaffSalary" runat="server" Width="145px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblStaffGender" runat="server" Text="Staff Gender" width="87px"></asp:Label>
&nbsp;
        <asp:CheckBox ID="chkStaffGenderMale" runat="server" OnCheckedChanged="chkStaffGenderMale_CheckedChanged" Text="Male" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="chkStaffGenderFemale" runat="server" OnCheckedChanged="chkStaffGenderFemale_CheckedChanged" Text="Female" />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server" Text="[lblError]" Visible="False"></asp:Label>
        <br />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" Width="58px" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
