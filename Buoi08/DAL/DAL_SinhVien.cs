using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
   public class DAL_SinhVien
    {
       QLSinhVienDataContext db = new QLSinhVienDataContext();
       public DAL_SinhVien()
       {

       }

       public List<SinhVien> getSinhVienTheoLop(Lop pLop)
       {
           return db.SinhViens.Where(sv => sv.MaLop == pLop.MaLop).ToList();
       }
    }
}
