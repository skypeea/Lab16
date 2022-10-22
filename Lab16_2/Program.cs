using Lab16;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading.Tasks;


namespace Lab16_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string jsonString = String.Empty;
            using (StreamReader sr = new StreamReader("../../../Goods.json"))
            {
                jsonString = sr.ReadToEnd();
            };
            
            Goods[] goods = JsonSerializer.Deserialize<Goods[]>(jsonString);
            Goods max = goods[0];
            foreach (Goods g in goods)
            {
                if(g.Price>max.Price)
                    max = g;
            }
            Console.WriteLine("Самый дорогой товар - {0}, стоимость - {1}", max.Name, max.Price);
            Console.ReadKey();
        }
    }
}
