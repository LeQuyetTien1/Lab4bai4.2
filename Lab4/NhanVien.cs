using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal abstract class NhanVien
    {
        public string Ten {  get; set; }
        public string DiaChi {  get; set; }
        public abstract void TinhLuong(int Soluong);
        public abstract void HienThi();
    }
}
