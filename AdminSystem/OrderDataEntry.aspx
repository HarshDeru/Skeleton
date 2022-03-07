<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblOrderID" runat="server" Text="Order ID" width="163px"></asp:Label>
            <asp:TextBox ID="txtOrderID" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblCustomerID" runat="server" Text="CustomerID" width="163px"></asp:Label>
            <asp:TextBox ID="txtCustomerID" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblOrderDescription" runat="server" Text="Order Description" width="163px"></asp:Label>
            <asp:TextBox ID="txtOrderDescription" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblOrderDateTime" runat="server" Text="Order Date/Time" width="163px"></asp:Label>
            <asp:TextBox ID="txtOrderDateTime" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblOrderTotalAmount" runat="server" Text="Order Total Amount" width="163px"></asp:Label>
            <asp:TextBox ID="txtOrderTotalAmount" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblOrderDispatched" runat="server" Text="Order Dispatched" width="163px"></asp:Label>
            <asp:DropDownList ID="dblOrderDispatched" runat="server" height="27px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" width="152px">
            <asp:ListItem Value="False">False</asp:ListItem>
            <asp:ListItem>True</asp:ListItem>
        </asp:DropDownList>
            <br />
            <br />
            <asp:CheckBox ID="chkActive" runat="server" Text="Active" />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
&nbsp;
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </div>
    </form>
</body>
</html>
