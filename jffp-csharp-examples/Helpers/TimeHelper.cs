using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jffp_csharp_examples.Helpers
{
    public static class TimeHelper
    {
        public static string DisplayElapsedTime(DateTime timeStart, DateTime timeEnd)
        {
            double totalSeconds = (timeEnd - timeStart).TotalSeconds;

            if (totalSeconds > TimeSpan.MaxValue.TotalSeconds)
                totalSeconds = TimeSpan.MaxValue.TotalSeconds;

            TimeSpan time = TimeSpan.FromSeconds(totalSeconds);

            return time.ToString(@"hh\:mm\:ss\:fff");
        }
    }
}
