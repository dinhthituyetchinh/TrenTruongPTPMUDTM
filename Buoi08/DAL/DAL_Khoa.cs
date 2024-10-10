using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{  
    public class DAL_Khoa
    {
        QLSinhVienDataContext db = new QLSinhVienDataContext();
        public DAL_Khoa()
        {

        }

        public List<Khoa> getKhoa()
        {
            return db.Khoas.Select(khoa => khoa).ToList();
        }
    }
}
