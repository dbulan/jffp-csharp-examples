using jffp_csharp_examples.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jffp_csharp_examples.Example_003
{
    public static class Example003
    {
        public static void Do()
        {
            RunWhenAll(); // result in 3 seconds
            //RunThreeAwait(); // result in 9 seconds
        }

        private static async Task RunThreeAwait()
        {
            var timeStart = DateTime.Now;
            Console.WriteLine("Start");

            int roll1 = await GetDataAsync();
            int roll2 = await GetDataAsync();
            int roll3 = await GetDataAsync();
            int rollSum = roll1 + roll2 + roll3;

            Console.WriteLine("RunThreeAwait Sum: {0}", rollSum);

            var timeFinish = DateTime.Now;
            Console.WriteLine("Finish: In {0} seconds!", TimeHelper.DisplayElapsedTime(timeStart, timeFinish));
        }

        private static async Task RunWhenAll()
        {
            var timeStart = DateTime.Now;
            Console.WriteLine("Start");

            var roll1 = GetDataAsync();
            var roll2 = GetDataAsync();
            var roll3 = GetDataAsync();

            await Task.WhenAll(roll1, roll2, roll3);

            int rollSum = (int)(roll1.Result + roll2.Result + roll3.Result);

            Console.WriteLine("RunWhenAll Sum: {0}", rollSum);

            var timeFinish = DateTime.Now;
            Console.WriteLine("Finish: In {0} seconds!", TimeHelper.DisplayElapsedTime(timeStart, timeFinish));
        }

        private static async Task<int> GetDataAsync()
        {
            await Task.Delay(3000);
            return 3;
        }
    }
}
