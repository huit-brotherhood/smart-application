using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class SinhVienBLL
    {
        SinhVienDAL svDAL = new SinhVienDAL();
        public SinhVienBLL()
        {

        }

        public List<DTO.SinhVien> GetSinhViens()
        {
            return svDAL.GetSinhViens();
        }
        public List<DTO.SinhVien> GetSinhViensFilter(string malop){
            return svDAL.GetSinhViensFilter(malop);
        }
    }
}
