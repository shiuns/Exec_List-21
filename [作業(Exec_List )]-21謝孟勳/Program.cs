using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _作業_Exec_List____21謝孟勳
{
    //宣告一個 List<Product> 變數, 存放多筆購買商品
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> items = new List<int>();
            items.Add(1);
            items.Add(3);
            items.Add(18);
            items.Add(35);
            items.Add(359);

            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
