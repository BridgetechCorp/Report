using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Reporting.WebForms;


namespace Bridgetech_Reports
{
    public partial class Report_Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            if (!this.Page.IsPostBack)
            {
               
                reportViewer.ServerReport.ReportServerUrl = new Uri(@"https://x56omh9lgr.reporting.windows.net/ReportServer");
                reportViewer.ServerReport.ReportPath = String.Format("/BridgetechReporting/{0}",Session["RDLFileName"]);
                reportViewer.ServerReport.ReportServerCredentials = new ReportServerCredentials();
                reportViewer.ProcessingMode = Microsoft.Reporting.WebForms.ProcessingMode.Remote;
                reportViewer.ServerReport.Refresh();

                List<Microsoft.Reporting.WebForms.ReportParameter> parms = new List<Microsoft.Reporting.WebForms.ReportParameter>();
                parms.Add(new Microsoft.Reporting.WebForms.ReportParameter("FacilityID", Session["facilityid"].ToString(), true));

                if (!string.IsNullOrWhiteSpace(Request.QueryString["ModemID"]))
                {
                    parms.Add(new Microsoft.Reporting.WebForms.ReportParameter("ModemID", Request.QueryString["ModemID"], true));
                }
                if (!string.IsNullOrWhiteSpace(Request.QueryString["ReportStartDate"]))
                {
                    parms.Add(new Microsoft.Reporting.WebForms.ReportParameter("ReportStartDate", Request.QueryString["ReportStartDate"], true));
                }
                if (!string.IsNullOrWhiteSpace(Request.QueryString["ReportEndDate"]))
                {
                    parms.Add(new Microsoft.Reporting.WebForms.ReportParameter("ReportEndDate", Request.QueryString["ReportEndDate"], true));
                }

                reportViewer.ServerReport.SetParameters(parms);
            }
        }


        
    }
}