using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16
{
    public class Goods
    {
        int code;
        string name;
        int price;

       public int Code
        {
            get
            { return code; }
            set { code = value; }
        }
        public string Name
        {
            get
            { return name; }
            set { name = value; }

        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
