using System;
using System.IO;
using Scriban;

namespace html
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileName = "template.sbn";
            var content = File.ReadAllText(fileName);
            var template = Template.Parse(content, fileName);
            var result = template.Render(new { UserName = "Gábor" });
            Console.WriteLine(result);
        }
    }
}
