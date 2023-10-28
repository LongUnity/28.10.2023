using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spon
{
    internal class Vatpham
    {
        public string Item_name { get; set; }
        public int Power { get; set; }
        public double Power_rate { get; set; }
        public int Goldperdame { get; set; }
        public Vatpham() { }

        public void xuatThongtin()
        {
            Console.WriteLine($"Tên vật phẩm: {Item_name} - Chỉ số sức mạnh: {Power} - Hệ số sức mạnh: {Power_rate}" +
                $" - Số vàng quy đổi trên 1 sức công phá: {Goldperdame} - Sức công phá: {Power*Power_rate}");
        }
        public double soXuvang()
        {
            return Power * Power_rate * Goldperdame;
        }
    }
}
