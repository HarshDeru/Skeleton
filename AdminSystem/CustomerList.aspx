<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstCustomerList" runat="server" Height="316px" Width="364px"></asp:ListBox>
        <br />
        <br />
        <asp:Button ID="btnAdd" runat="server" Height="35px" OnClick="btnAdd_Click" Text="Add" Width="80px" />
    &nbsp;
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" Height="36px" Width="81px" />
        &nbsp;
        <asp:Button ID="btnDelete" runat="server" Height="36px" OnClick="btnDelete_Click" Text="Delete" Width="74px" />
        <br />
        <br />
        <asp:Label ID="lblStatement" runat="server" Text="Enter the name"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="txtFilter" runat="server" Height="18px" Width="340px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" Text="Apply" />
&nbsp;
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server" Width="420px"></asp:Label>
    </form>
</body>
</html>
