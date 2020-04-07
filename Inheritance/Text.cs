using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Inheritance
{
    public class Text : PresentationObject
    {
        public int FontSize { get; set; }
        
        public string FontName { get; set; }

        public void AddHyperLink(string url)
        {
            Console.WriteLine($"we added a link to {url}.");
        }
    }
}
