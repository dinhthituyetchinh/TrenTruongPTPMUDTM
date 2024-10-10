using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
   public class BLL_Lop
    {
       DAL_Lop dt = new DAL_Lop();
       public BLL_Lop()
       {

       }
       public List<Lop> DSLop(Khoa pKhoa)
       {
           return dt.getLopTheoKhoa(pKhoa);
       }
    }
}
