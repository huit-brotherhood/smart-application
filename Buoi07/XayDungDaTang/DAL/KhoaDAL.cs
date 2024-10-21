using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class KhoaDAL
    {
        QLSinhVienDataContext ql = new QLSinhVienDataContext();
        public KhoaDAL()
        {

        }

        public List<Khoa> GetKhoas()
        {
            return ql.Khoas.ToList();
        }


    }
}
