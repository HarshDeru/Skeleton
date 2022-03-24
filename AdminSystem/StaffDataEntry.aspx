<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 316px;
        }
        .auto-style1 {
            font-weight: bold;
        }
    </style>
</head>
<body style="height: 366px">
    <form id="form1" runat="server">
        <asp:Label ID="lblStaffID" runat="server" Text="Staff ID" Height="19px" width="87px"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="txtStaffID" runat="server" Width="146px" height="22px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnFind" runat="server" CssClass="auto-style1" height="26px" Text="Find" width="58px" OnClick="btnFind_Click" />
        <br />
        <br />
        <asp:Label ID="lblStaffFullName" runat="server" Text="Staff Name" width="87px"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="txtStaffName" runat="server" Width="146px" height="22px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblStaffRole" runat="server" Text="Staff Role" width="87px"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="txtStaffRole" runat="server" Width="146px" height="22px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblStaffHireDate" runat="server" Text="Staff HireDate"></asp:Label>
&nbsp;<asp:TextBox ID="txtStaffHireDate" runat="server" Width="146px" height="22px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblStaffSalary" runat="server" Text="Staff Salary" width="87px"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="txtStaffSalary" runat="server" Width="145px" height="22px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblStaffGender" runat="server" Text="Staff Gender" width="87px"></asp:Label>
&nbsp;
        &nbsp;<asp:DropDownList ID="dblGender" runat="server" height="27px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" width="152px">
            <asp:ListItem Value="False">Female</asp:ListItem>
            <asp:ListItem Value="True">Male</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="lblError" runat="server" Text="[lblError]" Visible="False" ForeColor="Red"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" Width="58px" CssClass="auto-style1" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" CssClass="auto-style1" height="26px" width="58px" />
    </form>
</body>
</html>
