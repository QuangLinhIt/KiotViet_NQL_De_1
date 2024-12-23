using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        int n;
        string input;
        do
        {
            Console.Write("Nhap so luong chai ban mua: ");
            input = Console.ReadLine();
        } while (!int.TryParse(input, out n) || n <= 0 || n >= 100000);

        int tong = TinhTongSoLuongNhanDuoc(n);
        Console.Write($"Tong so chai ban nhan la: {tong} ");
        Console.ReadLine();
    }

    static int TinhTongSoLuongNhanDuoc(int soLuongMua)
    {
        // Bắt đầu với số chai đã mua
        int soLuongMuaBanDau = soLuongMua; 
        int soLuongTang = 0;

        // Lặp cho đến khi không đủ 3 chai để tặng
        while (soLuongMua >= 3) 
        {
            // Số chai được tặng
            int soLuongDuocTang = soLuongMua / 3; 
            soLuongTang += soLuongDuocTang;
            // Cập nhật số chai còn lại
            soLuongMua = soLuongDuocTang + (soLuongMua % 3); 
        }
        // Tổng số chai nhận được
        int tongSoLuongNhan = soLuongMuaBanDau + soLuongTang;

        return tongSoLuongNhan; 
    }
}
