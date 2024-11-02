using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapBuoi1
{
    internal class Bai2
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            double Vo = 20;
            double theTa = 30;
            double g = 9.8;
            double Vx;
            double Vy;
            //#Bài 2a;
            Vx = Vo * Math.Cos(theTa * Math.PI / 180);
            Console.WriteLine($"Vận tốc theo ban đầu theo phương ngang là: {Vx}");
            Vy = Vo * Math.Sin(theTa * Math.PI / 180);
            Console.WriteLine($"Vận tốc theo ban đầu theo phương dọc là: {Vy}");
            //Bài 2b:
            Console.WriteLine($"Thời gian vật đi lên điểm cao nhất: {Vo * Math.Sin(theTa * Math.PI / 180) / g}");
            // Bài 2c:
            Console.WriteLine($"Độ cao cực đại là: {Math.Pow(Vy, 2) / (2 * g)}");
            //Bài 2d:
            double tongThoiGianBay = 2 * Vy / g;
            double quangDuongCoTheDi = Vx * tongThoiGianBay;
            Console.WriteLine("Quãng đường ngang mà vật đã đi được khi rơi trở lại mặt đất là: " + quangDuongCoTheDi);


        }
    }
}
