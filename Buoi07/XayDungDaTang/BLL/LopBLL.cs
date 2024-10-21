using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class LopBLL
    {
        LopDAL lopDAL = new LopDAL();
        public LopBLL()
        {


        }
        public List<Lop> GetLops()
        {
            return lopDAL.GetLops();
        }

        public List<Lop> GetLopsFilter(string maKhoa)
        {
            return lopDAL.GetLopsFilter(maKhoa);
        }
    }
}
