﻿<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>PDF Vision .Net</title>
</head>
<body style="font-size: 12pt">
    <form id="form1" runat="server">
    <div>
        <span style="font-size: 11pt"><span style="font-family: Arial">Select any TIFF file:</span><br />
        </span>
        <asp:FileUpload ID="FileUpload1" runat="server" Font-Names="Arial" Font-Size="11pt" /><br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Convert to PDF" Font-Names="Arial" Font-Size="11pt" /><br />
        <br />
        <p>
        <asp:Label ID="Result" runat="server" Font-Names="Arial" Font-Size="11pt"></asp:Label>&nbsp;</p>        </div>
    </form>
</body>
</html>
