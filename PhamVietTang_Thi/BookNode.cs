using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//23DH113104_PhamVietTang
namespace PhamVietTang_Thi
{
    internal class BookNode
    {
        public int MaSo;
        public string TenSach;
        public int SoLuong;
        public BookNode Left, Right;

        public BookNode(int maSo, string tenSach, int soLuong)
        {
            MaSo = maSo;
            TenSach = tenSach;
            SoLuong = soLuong;
            Left = Right = null;
        }
    }
}
