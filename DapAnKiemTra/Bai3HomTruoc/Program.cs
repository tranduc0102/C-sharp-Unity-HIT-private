using System;
using System.Collections.Generic;

namespace Bai3HomTruoc
{
    internal class Program
    {
        static void ThemDuLieu(Dictionary<string, Dictionary<string, int>> quanLy)
        {
            Console.WriteLine("Nhập tên nhân viên: ");
            string name = Console.ReadLine();

            if (!quanLy.ContainsKey(name))
            {
                quanLy[name] = new Dictionary<string, int>();
            }

            bool tiepTuc = true;
            while (tiepTuc)
            {
                Console.WriteLine("Nhập tên sản phẩm: ");
                string product = Console.ReadLine();
                Console.WriteLine("Nhập số lượng sản phẩm đã bán: ");
                int quantity;
                while (!int.TryParse(Console.ReadLine(), out quantity) || quantity < 0)
                {
                    Console.WriteLine("Số lượng không hợp lệ, vui lòng nhập lại: ");
                }

                if (quanLy[name].ContainsKey(product))
                {
                    quanLy[name][product] += quantity; 
                }
                else
                {
                    quanLy[name][product] = quantity; 
                }

                Console.WriteLine("Bạn có muốn thêm sản phẩm khác? (y/n)");
                string answer = Console.ReadLine();
                tiepTuc = answer.ToLower() == "y";
            }
        }

        static string TinhNhanVienBanNhieuNhat(Dictionary<string, Dictionary<string, int>> quanLy)
        {
            string bestEmployee = null;
            int maxSales = 0;

            foreach (var employee in quanLy)
            {
                int totalSales = 0;
                foreach (var product in employee.Value)
                {
                    totalSales += product.Value;
                }

                if (totalSales > maxSales)
                {
                    maxSales = totalSales;
                    bestEmployee = employee.Key;
                }
            }

            return bestEmployee;
        }

        static string TinhSanPhamBanChayNhat(Dictionary<string, Dictionary<string, int>> quanLy)
        {
            Dictionary<string, int> productSales = new Dictionary<string, int>();

            foreach (var employee in quanLy)
            {
                foreach (var product in employee.Value)
                {
                    if (productSales.ContainsKey(product.Key))
                    {
                        productSales[product.Key] += product.Value;
                    }
                    else
                    {
                        productSales[product.Key] = product.Value;
                    }
                }
            }

            string bestSellingProduct = null;
            int maxSales = 0;
            foreach (var product in productSales)
            {
                if (product.Value > maxSales)
                {
                    maxSales = product.Value;
                    bestSellingProduct = product.Key;
                }
            }

            return bestSellingProduct;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Dictionary<string, Dictionary<string, int>> quanLy = new Dictionary<string, Dictionary<string, int>>
            {
                { "td1", new Dictionary<string, int>
                    {
                        { "sp1", 2 },
                        { "sp2", 3 }
                    }
                },
                {
                    "td2",new Dictionary<string, int>
                    {
                        {"sp1", 1 },
                        {"sp2", 1 }
                    }
                }
            };
            int choice;
            while (true) {
                Console.WriteLine("_______Danh mục quản lý_______");
                Console.WriteLine("Chọn 1: Thêm dữ liệu mới");
                Console.WriteLine("Chọn 2: Tìm nhân viên bán nhiều hàng nhất");
                Console.WriteLine("Chọn 3: Tìm sản phẩm bán nhiều nhất");
                Console.WriteLine("Chọn bất kì lựa chọn khác trên để thoát");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice) {
                    case 1:
                        ThemDuLieu(quanLy); break;
                    case 2:
                        string bestEmployee = TinhNhanVienBanNhieuNhat(quanLy);
                        Console.WriteLine($"Nhân viên bán được tổng số lượng sản phẩm nhiều nhất là: {bestEmployee}");
                        Console.WriteLine();
                        break;
                     case 3:
                        string bestSellingProduct = TinhSanPhamBanChayNhat(quanLy);
                        Console.WriteLine($"Sản phẩm bán chạy nhất là: {bestSellingProduct}");
                        Console.WriteLine();
                        break;
                    default:
                        return;

                }
            }
        }
    }
}
