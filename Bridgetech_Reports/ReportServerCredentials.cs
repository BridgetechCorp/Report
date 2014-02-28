using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Reporting.WebForms;
using System.Net;
using System.Security.Principal;

namespace Bridgetech_Reports
{

    /// <summary>
    /// Implementation of IReportServerCredentials to supply forms credentials to SQL Reporting using GetFormsCredentials() 
    /// </summary>
    [Serializable]
    public class ReportServerCredentials : IReportServerCredentials
    {
        public ReportServerCredentials()
        {
        }

        public WindowsIdentity ImpersonationUser
        {
            get
            {
                return null;
            }
        }

        public ICredentials NetworkCredentials
        {
            get
            {
                return null;
            }
        }

        public bool GetFormsCredentials(out Cookie authCookie, out string user, out string password, out string authority)
        {
            authCookie = null;
            user = "bridgetech_user";
            password = "Br1dg3t3c4";
            authority = "x56omh9lgr.reporting.windows.net";
            return true;
        }
    }
}