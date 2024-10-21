using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class DiemBLL
    {
        DiemDAL diemDAL = new DiemDAL();
        public DiemBLL()
        {

        }
        public List<Diem> GetDiemSinhVien(string masv)
        {
            return diemDAL.GetDiemSinhVien(masv);
        }
        public bool SuaDiem(string masv, string mamh, double diem)
        {
            return diemDAL.SuaDiem(masv, mamh, diem);
        }
        public bool ThemDiem(Diem diem)
        {
            return diemDAL.ThemDiem(diem);
        }
        public bool XoaDiemMonHoc(string masv, string monhoc)
        {
            return diemDAL.XoaDiemMonHoc(masv, monhoc);
        }
    }
}
