using System.Diagnostics;
using System.Text.RegularExpressions;

namespace BaiTapBuoi1
{
    internal class Bai1
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // Dùng để hiện tiếng việt 

            // # BÀI 1: 
            // Phương trình dao động điều hòa là: X(t) = A(wt + phi ) 
            // Trong đó A là biên độ giao động
            // W là tần số góc
            // wt + phi là pha dao động tại thời điểm điểm t
            // phi là pha ban đầu tại thời điểm t
            //Tần số góc: W = 2*PI*f = 2*PI/T;  // f là tần số dao động, f = 1/T = w/(2*PI) // T là chu kì
            double A = 5;
            double W = 2 * Math.PI;
            double aplha = -2 * Math.PI / 3;
            double t = 2.4;

            double T = 2 * Math.PI / W; // chu kì của nó là
            double deltaT = t / T;

            double quangDuong = Math.Floor(deltaT) * 4 * A;

            // Thời gian còn lại trong chu kỳ
            double thoiGianConLai = deltaT - Math.Floor(deltaT);

            double quangDuongConLai = Math.Floor((thoiGianConLai * 4)) * A; // Làm tròn
            /*  Console.WriteLine(Math.Floor((thoiGianConLai * 2)));*/
            thoiGianConLai = (thoiGianConLai * 2 - Math.Floor((thoiGianConLai * 2))) / 2;
            if (aplha >= 0)
            {
                quangDuongConLai = A * Math.Cos(aplha) + A * Math.Cos(W * thoiGianConLai * T - aplha);
            }
            else
            {
                quangDuongConLai += A - Math.Abs(A * Math.Cos(aplha)) + A - Math.Abs(A * Math.Cos(W * thoiGianConLai * T + aplha));
            }

            Console.WriteLine($"Quãng đường mà vật đi được là: {quangDuong + quangDuongConLai}");

        }
    }
}
