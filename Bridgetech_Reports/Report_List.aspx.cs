using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Diagnostics;

namespace Bridgetech_Reports
{
    public partial class Report_List : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["facilityid"] = 3; //This can be set upon user login
        }
        
        protected void ReportClick(object sender, CommandEventArgs e)
        {
            Session["RDLFileName"] = e.CommandArgument.ToString();
            Response.Redirect("Report_Details.aspx");
        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

    }
}