using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spon
{
    internal class main
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //cau1
            DSVP arr = new DSVP();
            Console.WriteLine("Thông tin 5 loại vật phẩm mà Spon cần thu hoạch:");
            arr.cau1();
            //cau2
            arr.cau2();
            Console.WriteLine("-------------------");
            //cau3
            Console.WriteLine("Tổng số xu để mua cả 5 vật phẩm: " + arr.cau3());//500+210+960+450+140=2260            
            Console.WriteLine("-------------------");
            //cau4
            arr.cau4();
            Console.ReadKey();

        }
    }
}
