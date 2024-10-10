using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class BLL_MonHoc
    {
        DAL_MonHoc dt = new DAL_MonHoc();
        public BLL_MonHoc()
        {

        }

        public List<MonHoc> getDSMH()
        {
            return dt.getMonHoc();
        }
    }
}
