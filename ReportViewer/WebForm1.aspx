<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ReportViewer.WebForm1" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=12.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
   
        <asp:ScriptManager ID="ScriptManager2" runat="server">
    </asp:ScriptManager>
        <br />
        <rsweb:ReportViewer ID="ReportViewer1" runat="server" Width="901px">
             <LocalReport ReportPath="~\Report\Report1.rdlc">
            </LocalReport>
        </rsweb:ReportViewer>
 
    </form>
</body>
</html>
