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
        public BLL_Khoa()
        {

        }
        public static async Task<List<Khoa>> getDSKhoa(string rootName)
        {
            return await DAL_FB_Khoa.GetThongTinKhoa(rootName);
        }
    }
}
