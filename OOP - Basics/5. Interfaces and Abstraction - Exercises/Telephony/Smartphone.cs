using System;
using System.Collections.Generic;
using System.Linq;
using Telephony.Interfaces;

namespace Telephony
{
    public class Smartphone : ICaller, IBrowser
    {
        
        public string Call(string gsmNumber)
        {
            if (gsmNumber.Any(d => !char.IsDigit(d)))
                throw new ArgumentException("Invalid number!");

            return $"Calling... {gsmNumber}";
        }

        public string Browser(string url)
        {
            if(url.Any(u => char.IsDigit(u)))
                throw new ArgumentException("Invalid URL!");

            return $"Browsing: {url}!";
        }
    }
}
