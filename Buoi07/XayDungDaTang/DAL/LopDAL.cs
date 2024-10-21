using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class LopDAL
    {
        QLSinhVienDataContext ql = new QLSinhVienDataContext();
        public LopDAL()
        {

        }
        public List<Lop> GetLops()
        {
            return ql.Lops.ToList();
        }
        public List<Lop> GetLopsFilter(string makhoa)
        {
            var list = ql.Lops.Where(t => t.MaKhoa == makhoa).Select(t => t).ToList();
            return list;
        }
    }
}
