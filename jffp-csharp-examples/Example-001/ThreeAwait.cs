using jffp_csharp_examples.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace jffp_csharp_examples.Example_001
{
    /*
        ThreeAwait result is ~9 seconds
        OneWhenAll result is ~3 seconds
    */

    public static class ThreeAwait
    {
        private static string SITE_PATH = "http://localhost/jffp/jffp-phpjs-examples/example-1/?siteId=";

        public async static void Do(DateTime timeStart)
        {
            var site2 = await GetSite(String.Format("{0}{1}", SITE_PATH, 2));
            var site3 = await GetSite(String.Format("{0}{1}", SITE_PATH, 3));
            var site4 = await GetSite(String.Format("{0}{1}", SITE_PATH, 4));

            var sum = int.Parse(site2) + int.Parse(site3) + int.Parse(site4);

            Console.WriteLine("Sum: {0}", sum);

            var timeSum = DateTime.Now;
            Console.WriteLine("TimeSum {0}", TimeHelper.DisplayElapsedTime(timeStart, timeSum));
        }

        private async static Task<string> GetSite(string url)
        {
            HttpClient client = new HttpClient();

            var site = await client.GetStringAsync(url);
            Console.WriteLine(site);

            return site;
        }
    }
}
