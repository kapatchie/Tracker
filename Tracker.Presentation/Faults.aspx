<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Faults.aspx.cs" Inherits="Tracker.Presentation.Faults" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="faultsGridView" runat="server" AutoGenerateColumns="False" OnRowCommand="faultsGridView_RowCommand">
            <Columns>
                <asp:BoundField DataField="Referencenumber" HeaderText="Reference Number" />
                <asp:BoundField DataField="Logger" HeaderText="Logger" />
                <asp:BoundField DataField="Time" HeaderText="Time" />
                <asp:BoundField DataField="TypeofFault" HeaderText="Type of Fault" />
                <asp:BoundField DataField="FaultDescription" HeaderText="Fault Description" />
                <asp:ButtonField Text="View" />
            </Columns>
        </asp:GridView>
        <br />
    </form>
</body>
</html>
