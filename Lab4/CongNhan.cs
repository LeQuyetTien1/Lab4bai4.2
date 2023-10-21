using Lab4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4bai4
{
    internal class CongNhan: NhanVien
    {
        public int Soluongsanpham {  get; set; }
        public override void TinhLuong(int Soluongsanpham)
        {
            Console.WriteLine("Luong cua cong nhan: " + (Soluongsanpham * 100 + 5000));
        }
        public override void HienThi()
        {
            Console.WriteLine("Ten cong vien: " + Ten);
            Console.WriteLine("Dia chi cong vien: " + DiaChi);
        }
    }
}
