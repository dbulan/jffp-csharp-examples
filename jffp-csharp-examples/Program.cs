﻿using jffp_csharp_examples.Example_001;
using jffp_csharp_examples.Example_002;
using jffp_csharp_examples.Example_003;
using jffp_csharp_examples.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jffp_csharp_examples
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //var timeStart = DateTime.Now;
            //Console.WriteLine("MainStart");

            // example-001
            //ThreeAwait.Do(timeStart);
            //OneWhenAll.Do(timeStart);

            // example-002
            // Example002.Do();

            // example-003
            Example003.Do();

            //var timeEnd = DateTime.Now;
            //Console.WriteLine("MainEnd {0}", TimeHelper.DisplayElapsedTime(timeStart, timeEnd));

            Console.ReadKey();
        }
    }
}
