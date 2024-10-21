using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class SinhVienDAL
    {
        QLSinhVienDataContext ql = new QLSinhVienDataContext();
        public SinhVienDAL()
        {

        }
        public List<SinhVien> GetSinhViens()
        {
            return ql.SinhViens.ToList();
        }
        public List<SinhVien> GetSinhViensFilter(string malop)
        {
            List<SinhVien> list = new List<SinhVien>();
            list = ql.SinhViens.Where(t => t.MaLop == malop).Select(t=>t).ToList();
            return list;
        }
       
    }
}
