using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fastener.BaseClasses
{
    public class ActivitySubmitEventArgs : EventArgs
    {
        public DateTime StartDate;
        public DateTime EndDate;
        public ActivitySubmitEventArgs(DateTime start_date, DateTime end_date) { StartDate = start_date; EndDate = end_date; }
    }
}
