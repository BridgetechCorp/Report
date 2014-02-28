<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Report_Details.aspx.cs" Inherits="Bridgetech_Reports.Report_Details" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <rsweb:reportviewer id="reportViewer" runat="server" Height="100%" width="100%" SizeToReportContent="True" AsyncRendering="False" ZoomMode="PageWidth" Font-Names="Verdana" Font-Size="8pt" ProcessingMode="Remote" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" >
            <ServerReport ReportPath="/BridgetechReporting/BusPassengerCountByMonth" ReportServerUrl="https://x56omh9lgr.reporting.windows.net/ReportServer" />
        </rsweb:reportviewer>        
    </div>
    </form>
</body>
</html>
