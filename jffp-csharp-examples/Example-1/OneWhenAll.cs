using jffp_csharp_examples.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace jffp_csharp_examples.Example_1
{
    /*
        ThreeAwait result is ~9 seconds
        OneWhenAll result is ~3 seconds
    */

    public static class OneWhenAll
    {
        private static string SITE_PATH = "http://localhost/jffp/jffp-phpjs-examples/example-1/?siteId=";

        public async static void Do(DateTime timeStart)
        {
            var site2 = GetSite(String.Format("{0}{1}", SITE_PATH, 2));
            var site3 = GetSite(String.Format("{0}{1}", SITE_PATH, 3));
            var site4 = GetSite(String.Format("{0}{1}", SITE_PATH, 4));

            await Task.WhenAll(site2, site3, site4);
            var sum = int.Parse(site2.Result) + int.Parse(site3.Result) + int.Parse(site4.Result);

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
