using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLL_SinhVien
    {
        DAL_SinhVien dt = new DAL_SinhVien();
        public BLL_SinhVien()
        {

        }

        public List<SinhVien> GetSVTheoLop(Lop pLop)
        {
            return dt.getSinhVienTheoLop(pLop);
        }
    }
}
