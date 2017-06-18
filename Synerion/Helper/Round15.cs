using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Synerion.Helper
{
    public static class Round15
    {
        public static DateTime Round(DateTime dateTime, TimeSpan dTimeSpan)
        {
            var halfIntervelTicks = ((dTimeSpan.Ticks + 1) >> 1);
            return dateTime.AddTicks(halfIntervelTicks - ((dateTime.Ticks + halfIntervelTicks) % dTimeSpan.Ticks));
        }
    }
}