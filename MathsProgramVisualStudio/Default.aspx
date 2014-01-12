<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome to the Website</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Panel ID="pnlHolder" runat="server" style="z-index: 1; left: 13px; top: 18px; position: absolute; height: 555px; width: 1204px">
            <asp:Label ID="lblWelcomeText" runat="server" style="z-index: 1; left: 42px; top: 10px; position: absolute" Text="Welcome to the Website" Font-Names="Arial" Font-Size="X-Large"></asp:Label>
            <asp:TextBox ID="txtInput" runat="server" AutoCompleteType="Disabled" BorderStyle="Solid" style="z-index: 1; left: 100px; top: 95px; position: absolute" TabIndex="1" ToolTip="Input Data Value"></asp:TextBox>
            <asp:TextBox ID="txtOutput" runat="server" AutoCompleteType="Disabled" BorderStyle="Solid" ReadOnly="True" style="z-index: 1; left: 100px; top: 145px; position: absolute" ToolTip="Displays Mathematical Output"></asp:TextBox>
            <asp:Label ID="lblInputText" runat="server" Font-Names="Arial" Font-Size="Large" style="z-index: 1; left: 36px; top: 95px; position: absolute" Text="Input"></asp:Label>
            <asp:Label ID="lblOutputText" runat="server" Font-Names="Arial" Font-Size="Large" style="z-index: 1; left: 31px; top: 145px; position: absolute" Text="Output"></asp:Label>
            <asp:Button ID="btnAdd" runat="server" Font-Names="Arial" style="z-index: 1; left: 297px; top: 97px; position: absolute" Text="Add Value" ToolTip="Adds the number value for calculation" TabIndex="2" OnClick="btnAdd_Click" />
            <asp:Button ID="btnClear" runat="server" Font-Names="Arial" style="z-index: 1; left: 410px; top: 97px; position: absolute" TabIndex="3" Text="Clear" ToolTip="Clears all inputted values" width="90px" OnClick="Button1_Click" />
            <asp:Button ID="btnAverage" runat="server" Font-Names="Arial" style="z-index: 1; left: 349px; top: 192px; position: absolute" TabIndex="4" Text="Get Average" ToolTip="Get the average of all inputted data" OnClick="btnAverage_Click" />
            <asp:Button ID="btnMax" runat="server" Font-Names="Arial" style="z-index: 1; left: 349px; top: 288px; position: absolute" TabIndex="5" Text="Get Max Value" ToolTip="Gets the max value of all inputted data" width="107px" OnClick="btnMax_Click" />
            <asp:Button ID="btnMin" runat="server" Font-Names="Arial" style="z-index: 1; left: 349px; top: 242px; position: absolute" TabIndex="6" Text="Get Min Value" ToolTip="Gets the minimum value for all inputted data" width="107px" OnClick="btnMin_Click" />
            <asp:Label ID="lblSubtitle1" runat="server" Font-Names="Arial" style="z-index: 1; left: 325px; top: 148px; position: absolute; right: 724px" Text="Mathematical Controls"></asp:Label>
            <asp:Label ID="lblError" runat="server" Font-Names="Arial" style="z-index: 1; left: 43px; top: 234px; position: absolute; height: 18px"></asp:Label>
        </asp:Panel>
    </form>
</body>
</html>
