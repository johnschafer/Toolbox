<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AppointSetterForm.aspx.cs" Inherits="AppointmentSetter.AppointSetterForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblClientFirstName" runat="server" Text="Client First Name:" Width="125px"></asp:Label>
            <asp:TextBox ID="txtClientFirstName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblClientLastName" runat="server" Text="Client Last Name:" Width="125px"></asp:Label>
            <asp:TextBox ID="txtClientLastName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblDOB" runat="server" Text="DOB:" Width="125px"></asp:Label>
            <asp:TextBox ID="txtDOB" runat="server" TextMode="DateTime" ToolTip="mm/dd/yyyy"></asp:TextBox>
            <br />
            <asp:Label ID="lblStaffFirstName" runat="server" Text="Staff First Name:" Width="125px"></asp:Label>
            <asp:TextBox ID="txtStaffFirstName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblStaffLastName" runat="server" Text="Staff Last Name:" Width="125px"></asp:Label>
            <asp:TextBox ID="txtStaffLastName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblSpecialty" runat="server" Text="Specialty:" Width="125px"></asp:Label>
            <asp:TextBox ID="txtSpecialty" runat="server" ToolTip="If the client is over 70, specialty must be geriatrics."></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblServiceStartDate" runat="server" Text="Start Date:" Width="125px"></asp:Label>
            <asp:TextBox ID="txtServiceStartDate" runat="server" TextMode="DateTimeLocal"></asp:TextBox>
            <br />
            <asp:Label ID="lblServiceEndDate" runat="server" Text="End Date:" Width="125px"></asp:Label>
            <asp:TextBox ID="txtServiceEndDate" runat="server" TextMode="DateTimeLocal"></asp:TextBox>
            <br />
            <asp:Label ID="lblService" runat="server" Text="Service:" Width="125px"></asp:Label>
            <asp:TextBox ID="txtService" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnAddAppointment" runat="server" OnClick="btnAddAppointment_Click" Text="Add Appointment" />
        </div>
        <asp:GridView ID="gvAppointment" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
