using System;
using System.IO;
using Scriban;

namespace html
{
    class Program
    {
        class Item
        {
            public string name { get; set; }
            public int quantity { get; set; }
            public string unit { get; set; }
        }
        static Item[] items = { new Item { name = "milk", quantity = 1, unit = "l" },
                                new Item { name = "potato", quantity = 2, unit = "kg" },
                                };
        static void Main(string[] args)
        {
            
            var fileName = "template.sbn";
            var content = File.ReadAllText(fileName);
            var template = Template.Parse(content, fileName);
            var result = template.Render(new { 
                UserName = "User Name",
                Address = "3 Smith St, Smithville",
                Items = items
            });
            
            var path = @".\index.html";
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.Write(result);
            }
        }
    }
}
