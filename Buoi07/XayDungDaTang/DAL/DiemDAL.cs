using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DiemDAL
    {
        QLSinhVienDataContext ql = new QLSinhVienDataContext();
        public DiemDAL()
        {

        }
        public List<Diem> GetDiemSinhVien(string masv)
        {
            var exist = ql.Diems.Where(t => t.MaSinhVien == masv).ToList();
            if(exist!=null)
            {
                return exist;
            }
            return null;
        }
        public bool ThemDiem(Diem diem)
        {
            try
            {
                ql.Diems.InsertOnSubmit(diem);
                ql.SubmitChanges();
                return true;
            }
            catch 
            {
                return false;
            }
        }
        public bool SuaDiem(string masv,string mamh,double diem)
        {
            try
            {
                var exist = ql.Diems.Where(t => t.MaSinhVien == masv && t.MaMonHoc == mamh).FirstOrDefault();
                if(exist!=null)
                {
                    exist.Diem1 = diem;
                    ql.SubmitChanges();
                return true;
                }
                return false;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool XoaDiemMonHoc(string masv,string monhoc)
        {
            try
            {
                var exist = ql.Diems.Where(t => t.MaSinhVien == masv && t.MaMonHoc == monhoc).FirstOrDefault();
                if(exist!=null)
                {
                    ql.Diems.DeleteOnSubmit(exist);
                    ql.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
