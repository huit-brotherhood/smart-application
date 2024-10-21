using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;  
namespace BLL
{
    public class MonHocBLL
    {
        MonHocDAL mh = new MonHocDAL();
        public MonHocBLL()
        {

        }
        public List<MonHoc> GetMonHocs()
        {
            return mh.GetMonHocs();
        }
    }
}
