using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B12
{
    public class SinhVien
    {
        private string _MaSV;
        private string _HoTen;
        private string _Lop;
        private NguyenVong _NguyenVong;
        public int Phong { get; set; }
        public NguyenVong NguyenVong
        {
            get { return _NguyenVong; }
            set { _NguyenVong = value; }
        }

        public string Lop
        {
            get { return _Lop; }
            set { _Lop = value; }
        }
        public string HoTen
        {
            get { return _HoTen; }
            set { _HoTen = value; }
        }
        public string MaSV
        {
            get { return _MaSV; }
            set { _MaSV = value; }
        }

        public SinhVien()
        {

        }

        public int NguyenVong1
        {
            get { return NguyenVong != null ? NguyenVong.NguyenVong1 : 0; }
        }

        public int NguyenVong2
        {
            get { return NguyenVong != null ? NguyenVong.NguyenVong2 : 0; }
        }

        public int NguyenVong3
        {
            get { return NguyenVong != null ? NguyenVong.NguyenVong3 : 0; }
        }
    }
}
