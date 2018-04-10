using System;
using System.Collections.Generic;
using System.Text;

namespace ZubMvvmc.Core
{
    public static class InsightsWrapper
    {
        public static void ReportException(Exception ex)
        {
            string exceptionDescription = ex.Message;
            string stackTrace = ex.StackTrace;
        }
    }
}
