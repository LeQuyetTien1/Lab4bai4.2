using Lab4;
using Lab4bai4;
using System;
public class Program
{
    static void Main(string[] args)
    {
        NhanVienBanHang a = new NhanVienBanHang();
        a.Ten = "Tien";
        a.DiaChi = "Ha Noi";
        a.Soluongbanduoc = 50;
        a.HienThi();
        a.TinhLuong(a.Soluongbanduoc);
        CongNhan b=new CongNhan();
        b.Ten = "Nam";
        b.DiaChi = "Ha Noi";
        b.Soluongsanpham = 30;
        b.HienThi();
        b.TinhLuong(b.Soluongsanpham);
    }
}