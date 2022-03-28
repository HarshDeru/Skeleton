<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblCustomerID" runat="server" Text="Customer ID" width="92px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtCustomerID" runat="server" Width="347px" MaxLength="4" TextMode="Number"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnFind" runat="server" Height="25px" OnClick="btnFind_Click" Text="Find" Width="66px" />
        </div>
        <p>
            <asp:Label ID="lblCustomerName" runat="server" Text="Full Name" width="92px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtCustomerName" runat="server" width="355px"></asp:TextBox>
        </p>
        <asp:Label ID="lblCustomerDateOfBirth" runat="server" Text="Date Of Birth" width="92px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtCustomerDateOfBirth" runat="server" width="355px"></asp:TextBox>
        <p>
            <asp:Label ID="lblCustomerGender" runat="server" Text="Gender" width="92px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="ddlCustomerGender" runat="server" Height="16px" Width="140px">
                <asp:ListItem Value="False">Female</asp:ListItem>
                <asp:ListItem Value="True">Male</asp:ListItem>
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <asp:Label ID="lblCustomerAddress" runat="server" Text="Address" width="92px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtCustomerAddress" runat="server" OnTextChanged="TextBox3_TextChanged" Width="355px"></asp:TextBox>
        <p>
            <asp:Label ID="lblCustomerNumber" runat="server" Text="Phone Number"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtCustomerNumber" runat="server" OnTextChanged="TextBox4_TextChanged" width="355px"></asp:TextBox>
        </p>
        <asp:Label ID="lblCustomerEmail" runat="server" Text="Email" width="92px"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtCustomerEmail" runat="server" width="355px"></asp:TextBox>
&nbsp;<p>
            <asp:Label ID="lblError" runat="server" width="235px"></asp:Label>
        </p>
        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" Text="Ok" Width="66px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" Width="68px" />
    </form>
</body>
</html>
