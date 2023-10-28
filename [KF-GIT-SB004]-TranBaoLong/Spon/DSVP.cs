using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Spon
{
    internal class DSVP
    {
        public List<Vatpham> ds {  get; set; }
        public DSVP() { }
        public void cau1()
        {
            ds = new List<Vatpham>();
            ds.Add(new Buathan());
            ds.Add(new Baotay());
            ds.Add(new Honda());
            ds.Add(new Cayriu());
            ds.Add(new Caygay());
        }

        public void cau2()
        {
            foreach (Vatpham item in ds)
            {
                item.xuatThongtin();
            }
        }

        public double cau3()
        {
            double kq=0;
            foreach (Vatpham item in ds)
            {
                kq += item.soXuvang();
            }
            return kq;
        }
        public void cau4() 
        {
            Console.Write("Số vàng mà Spon thu thập được trong 1 ngày: ");
            int n = int.Parse(Console.ReadLine());            
            if (cau3()%n == 0)
            {
                Console.WriteLine();
                Console.WriteLine($"Cần {cau3() / n} ngày để Spon có thể giải cứu được đồng đội");                
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"Cần {(int)(cau3() / n)+1} ngày để Spon có thể giải cứu được đồng đội");
            }

        }
    }
}
