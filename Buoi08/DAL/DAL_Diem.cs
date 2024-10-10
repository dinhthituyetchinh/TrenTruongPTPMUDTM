using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
   public class DAL_Diem
    {
       QLSinhVienDataContext db = new QLSinhVienDataContext();
       public DAL_Diem()
       {

       }

       public List<Diem> getDiemTheoSV(SinhVien pSV)
       {
           return db.Diems.Where(d => d.MaSinhVien == pSV.MaSinhVien).ToList();
       }
    }
}
