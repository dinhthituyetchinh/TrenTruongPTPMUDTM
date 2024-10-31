using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2001215640_DinhThiTuyetChinh_KT02
{
    public class XuLy
    {
        QuanLySanPhamDataContext db;
        public XuLy()
        {

        }

        public List<NhaCungCap> getPhong()
        {
            using (db = new QuanLySanPhamDataContext())
            {
                return db.NhaCungCaps.Select(n => n).ToList();

            }
        }

        public bool ThemNCC(NhaCungCap nccNew)
        {
            using (db = new QuanLySanPhamDataContext())
            {
                db.NhaCungCaps.InsertOnSubmit(nccNew);
                db.SubmitChanges();
                return true;
            }
        }

        public bool XoaNCC(string ma)
        {
            using (db = new QuanLySanPhamDataContext())
            {
                var nccCanXoa = db.NhaCungCaps.SingleOrDefault(p => p.MaNCC == ma);
                if (nccCanXoa != null)
                {
                    db.NhaCungCaps.DeleteOnSubmit(nccCanXoa);
                    db.SubmitChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool SuaNCC(NhaCungCap ncc)
        {
            using (db = new QuanLySanPhamDataContext())
            {
                var nccCanSua = db.NhaCungCaps.SingleOrDefault(p => p.MaNCC == ncc.MaNCC);
                if (nccCanSua != null)
                {
                    nccCanSua.TenNCC = ncc.TenNCC;
                    ncc.DiaChi = ncc.DiaChi;
                    db.SubmitChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }


    }
}
