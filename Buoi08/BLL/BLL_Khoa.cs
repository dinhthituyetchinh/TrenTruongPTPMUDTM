using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class BLL_Khoa
    {
        DAL_Khoa dt = new DAL_Khoa();
        public BLL_Khoa()
        {

        }
        public List<Khoa> getDSKhoa()
        {
            return dt.getKhoa();
        }
    }
}
