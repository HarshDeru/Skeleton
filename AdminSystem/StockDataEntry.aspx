<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblProductID" runat="server" Text="Product ID" width="114px"></asp:Label>
            <asp:TextBox ID="txtProductID" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblProductName" runat="server" Text="Product Name" width="114px"></asp:Label>
            <asp:TextBox ID="txtProductName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblProductPrice" runat="server" Text="Product Price" width="114px"></asp:Label>
            <asp:TextBox ID="txtProductPrice" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblProductQuantity" runat="server" Text="Product Quantity" width="114px"></asp:Label>
            <asp:TextBox ID="txtProductQuantity" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblProductShipped" runat="server" Text="Product Shipped" width="114px"></asp:Label>
            <asp:TextBox ID="txtProductShipped" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblProductAvailability" runat="server" Text="ProductAvailability"></asp:Label>
            <asp:DropDownList ID="dblProductAvailability" runat="server">
                <asp:ListItem>False</asp:ListItem>
                <asp:ListItem>True</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:CheckBox ID="chkActive" runat="server" Text="Active" />
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
            <br />
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="Ok" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </div>
    </form>
</body>
</html>
