<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="challengeConditionalRadioButton.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Your Note Taking Preferences<br />
            <br />
            <asp:RadioButton ID="pencilButton" runat="server" GroupName="NoteGroup" Text="Pencil" />
            <br />
            <asp:RadioButton ID="penButton" runat="server" GroupName="NoteGroup" Text="Pen" />
            <br />
            <asp:RadioButton ID="phoneButton" runat="server" GroupName="NoteGroup" Text="Phone" />
            <br />
            <asp:RadioButton ID="tabletButton" runat="server" GroupName="NoteGroup" Text="Tablet" />
            <br />
            <br />
            <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="OK" />
            <br />
            <br />
            <asp:Image ID="resultImage" runat="server" />
        </div>
    </form>
</body>
</html>
