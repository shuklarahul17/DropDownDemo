<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Dropdownlistdemo.aspx.cs" Inherits="Dropdownlistdemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server" DataValueField="CityId" DataTextField="CityName">
            </asp:DropDownList>
            <br />
            <br />
            <asp:DropDownList ID="DropDownList2" runat="server">
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem Selected="True">Female</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:DropDownList ID="DropDownList3" runat="server">
            </asp:DropDownList>
        </div>
    </form>
</body>
</html>
