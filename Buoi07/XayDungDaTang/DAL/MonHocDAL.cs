using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
  
    public class MonHocDAL
    {
        QLSinhVienDataContext ql = new QLSinhVienDataContext();
        public MonHocDAL()
        {

        }
        public List<MonHoc> GetMonHocs()
        {
            return ql.MonHocs.ToList();
        }
    }
}
