using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_MonHoc
    {
        QLSinhVienDataContext db = new QLSinhVienDataContext();
        public DAL_MonHoc()
        {

        }

        public List<MonHoc> getMonHoc()
        {
            return db.MonHocs.Select(mh => mh).ToList();
        }
    }
}
