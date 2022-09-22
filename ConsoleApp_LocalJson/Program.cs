using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp_LocalJson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Year:");
            string year=Console.ReadLine();
            Console.WriteLine("Month:");
            string month=Console.ReadLine().PadLeft(2,'0');

            string jsonPath = year + ".json";

            if(!File.Exists(jsonPath))
            {
                Console.WriteLine("不存在：" + jsonPath);
            }
            else
            {
                System.IO.StreamReader sr = File.OpenText(jsonPath);
                string json = sr.ReadToEnd();
                Console.WriteLine("json=");
                Console.WriteLine(json);

                List<string> HolidayListInMonth = new List<string>();

                var root = JsonConvert.DeserializeObject<Holidays>(json);

                var keys = root.Holiday.Keys;
                Console.WriteLine("Key=:");
                foreach (var key in keys)
                {
                    if (key.StartsWith(month))
                    {
                        Console.WriteLine(key);
                        HolidayListInMonth.Add(key);
                    }
                }
                Console.WriteLine("Value=:");
                foreach (var value in HolidayListInMonth)
                {
                    Console.WriteLine(value);
                }
            }
            
            Console.ReadKey();

        }
    }
}
