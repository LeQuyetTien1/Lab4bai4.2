using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class NhanVienBanHang: NhanVien
    {
        public int Soluongbanduoc {  get; set; }
        
        public override void TinhLuong(int Soluongbanduoc)
        {
            Console.WriteLine("Luong cua nhan vien ban hang: " + (Soluongbanduoc * 100 + 5000));
        }
        public override void HienThi()
        {
            Console.WriteLine("Ten nhan vien: " + Ten);
            Console.WriteLine("Dia chi nhan vien: " + DiaChi);
        }
    }
}
