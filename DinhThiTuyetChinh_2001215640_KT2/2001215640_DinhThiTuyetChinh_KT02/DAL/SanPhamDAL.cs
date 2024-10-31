using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class SanPhamDAL
    {
        QLSPDataContext db = new QLSPDataContext();
        public SanPhamDAL()
        {

        }

        public List<SanPham> GetAllSP()
        {
            return db.SanPhams.ToList();
        }
    }
}
