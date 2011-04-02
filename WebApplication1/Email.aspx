<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Email.aspx.cs" Inherits="WebApplication1.WebForm1" Debug="true" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Email Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
    <tr>
    <td>TO: </td>
    <td> <asp:TextBox ID="txtTo" runat="server" Width="222px"></asp:TextBox></td>
    </tr>
    <tr>
    <td>Subject:</td>    
    <td><asp:TextBox ID="txtSubject" runat="server" Width="221px"></asp:TextBox></td>
    </tr>
   <tr><td>Message: </td>
   <td><asp:TextBox ID="txtMessage" TextMode="MultiLine" runat="server"></asp:TextBox></td>
   </tr>
   <tr><td colspan= "2" ><asp:Button ID="btnSend" runat="server" Text="Send" OnClick="btnSend_Click" /> </td></tr>
    
   
    </table>
    
        
    
       
    </div>
    </form>
</body>
</html>
