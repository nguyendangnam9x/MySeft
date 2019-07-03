<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SendEmailAttchment.aspx.cs" Inherits="SendEmailAttachment.SendEmailAttchment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Send Mail With Attachment</title>
</head>
<body>
    <form runat="server" name="from1">
        <table>
            <tr>
                <td colspan="2" style="text-align: center; font-weight: bold;">Send Email Attachment</td>
            </tr>
            <tr>
                <td>From:</td>
                <td><asp:TextBox ID="txtFrom" runat="server" MaxLength="40"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Password:</td>
                <td><asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox></td>
            </tr>
            <tr>
                <td>To:</td>
                <td><asp:TextBox ID="txtTo" runat="server" MaxLength="40"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Subject:</td>
                <td><asp:TextBox ID="txtSubject" Width="400" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Message:</td>
                <td><asp:TextBox ID="txtMessage" Width="400" TextMode="MultiLine" Rows="5" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Attach File:</td>
                <td> <asp:FileUpload ID="fileAttach" AllowMultiple="true" runat="server" /></td>
            </tr>
            <tr>
                <td></td>
                <td><asp:Button ID="btnSendEmail" runat="server" Text="Send Email" OnClick="btnSendEmail_Click" /></td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center; font-weight: bold;"><asp:Label ID="lblError" runat="server" Text=""></asp:Label></td>
            </tr>
        </table>
    </form>
</body>
</html>
