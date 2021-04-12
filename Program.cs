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
        }
        static Item[] items = { new Item { name = "milk", quantity = 1 },
                                new Item { name = "potato", quantity = 2 },
                                };
        static void Main(string[] args)
        {
            
            var fileName = "template.sbn";
            var content = File.ReadAllText(fileName);
            var template = Template.Parse(content, fileName);
            var result = template.Render(new { 
                UserName = "User Name",
                Address = "1 Smith St, Smithville",
                Items = items
            });
            Console.WriteLine(result);
        }
    }
}
