using Elmah;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Firehose.Web.Infrastructure
{
    // Lifted from http://stackoverflow.com/a/14770142/496857
    public static class Logger
    {
        public static void Error(Exception ex, string contextualMessage = null)
        {
            try
            {
                // log error to Elmah
                if (contextualMessage != null)
                {
                    // log exception with contextual information that's visible when 
                    // clicking on the error in the Elmah log
                    var annotatedException = new Exception(contextualMessage, ex);
                    ErrorLog.GetDefault(null).Log(new Error(annotatedException));
                }
                else
                {
                    ErrorLog.GetDefault(null).Log(new Error(ex));
                }
            }
            catch (Exception)
            {
                // uh oh! just keep going
            }
        }
    }
}