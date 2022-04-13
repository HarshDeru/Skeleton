<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <p>
        Are you sure you want to delete this record?</p>
    <form id="form1" runat="server">
        <p>
            <asp:Button ID="btnYes" runat="server" Height="27px" OnClick="btnYes_Click" Text="Yes" Width="45px" />
&nbsp;&nbsp;
            <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" Text="No" width="45px" />
        </p>
&nbsp;<div>
        </div>
    </form>
</body>
</html>
