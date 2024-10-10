using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_Lop
    {
        QLSinhVienDataContext db = new QLSinhVienDataContext();
        public DAL_Lop()
        {

        }

        public List<Lop> getLopTheoKhoa(Khoa pKhoa)
        {
            return db.Lops.Where(lop => lop.MaKhoa == pKhoa.MaKhoa).ToList();
        }
    }
}
