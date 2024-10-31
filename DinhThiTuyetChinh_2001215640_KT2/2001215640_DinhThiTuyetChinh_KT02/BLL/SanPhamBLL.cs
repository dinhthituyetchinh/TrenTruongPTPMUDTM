using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
   public class SanPhamBLL
    {
       SanPhamDAL sp = new SanPhamDAL();
       public SanPhamBLL()
       {

       }


       public List<SanPham> GetAllSanPham()
       {
           return sp.GetAllSP();
       }
    }
}
