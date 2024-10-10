using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLL_Diem
    {
        DAL_Diem dt = new DAL_Diem();
        public BLL_Diem()
        {

        }

        public List<Diem> DSDiemTheoSinhVien(SinhVien pSV)
        {
            return dt.getDiemTheoSV(pSV);
        }
    }
}
