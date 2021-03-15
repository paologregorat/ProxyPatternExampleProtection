using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProxyPatternExampleProtection.Concrete
{
    public class Document
    {
        public Document(string title, string text, string summary)
        {
            Title = title;
            Text = text;
            Summary = summary;
        }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Summary { get; set; }
    }
}
