using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading.Tasks;

namespace Lab16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 5;
            Goods[] goods = new Goods[n];
            int code;
            string name;
            int price;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите код товара");
               code = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите название товара");
                name = Console.ReadLine();
                Console.WriteLine("Введите стоимость товара");
                price = Convert.ToInt32(Console.ReadLine());
                goods[i] = new Goods() {Code = code, Name = name, Price = price};
            }
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true
            };
            string jsonString = JsonSerializer.Serialize(goods, options);
            using (StreamWriter sw = new StreamWriter("../../Goods.json")) 
            {
                sw.WriteLine(jsonString);
            }
        }
    }
}
