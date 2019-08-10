using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony.Core
{
    public class Engine
    {
        private Smartphone smartphone;

        public Engine()
        {
            this.smartphone = new Smartphone();
        }

        public void Run()
        {
            string[] inputNumbers = Console.ReadLine().Split();
            string[] inputUrls = Console.ReadLine().Split();

            foreach (string gsmNumber in inputNumbers)
            {
                try
                {
                    Console.WriteLine(smartphone.Call(gsmNumber));
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }

            foreach (string url in inputUrls)
            {
                try
                {
                    Console.WriteLine(smartphone.Browser(url));
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }
        }
    }
}
