using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2001216316_PhanNgocBaoVinh_Buoi06
{
    public class XuLy
    {
        QLSINHVIENDataContext db = new QLSINHVIENDataContext();
        public XuLy()
        {

        }
        public IEnumerable<MonHoc> Load_MH()
        {
            return db.MonHocs.ToList();
        }
        public IEnumerable<object> Load_SV()
        {
            return db.SinhViens.Select(t => new { t.MaSinhVien, t.HoTen,t.NgaySinh,t.Lop.TenLop }).ToList();
        }
        public IEnumerable<object> Load_Khoa()
        {
            return db.Khoas.ToList();
        }
        public List<SinhVien> LaySinhVienDauTien()
        {
            var ex = db.SinhViens.Select(t => t).Skip(0).Take(1).ToList();
            return ex;
        }
        public List<SinhVien> LaySinhVienCuoiCung()
        {
            var ex = db.SinhViens.Select(t => t).OrderByDescending(t => t.MaSinhVien).Skip(0).Take(1).ToList();
            return ex;
        }
        public IEnumerable<object> LaySinhVienThu2VaThu3()
        {
            return db.SinhViens.Skip(1).Take(2).ToList();
        }
        public IEnumerable<object> SapXepSinhVienGiamTheoTen()
        {
            var list = db.SinhViens.ToList();
            list.Sort((a, b) => b.HoTen.CompareTo(a.HoTen));
            return list;
        }
        public IEnumerable<object> LoaiBoSinhVienTrungNhau()
        {
            var list = db.SinhViens.Distinct().Select(t => new { t.MaSinhVien, t.HoTen }).ToList();
            return list;
        }

        public IEnumerable<object> LayKhoaTheoMaKhoa(string makhoa)
        {
            var list = db.Khoas.Where(t => t.MaKhoa == makhoa).ToList();
            return list;
        }
        public IEnumerable<object> LayDieuKienTheoHo(string ho)
        {
            var list = db.SinhViens.Select(t => new { t.MaSinhVien, t.HoTen }).Where(t => t.HoTen.Contains(ho)).ToList();
            return list;
        }
        public IEnumerable<object> LoadSinhViensLops()
        {
            var list = db.SinhViens.Select(t => new { t.Lop.TenLop, t.MaSinhVien, t.HoTen }).ToList();
            return list;
        }
        public IEnumerable<object> TongDiemSinhVienTheoMonHoc()
        {
            var list = db.Diems.GroupBy(t => t.MaMonHoc)
                .Select(g => new
            {
                MaMonHoc = g.Key,
                TongDiem = g.Sum(t => t.Diem1)
            }).ToList();
            return list;
        }

        public bool ThemKhoa(Khoa khoa)
        {
            try
            {
                db.Khoas.InsertOnSubmit(khoa);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public int XoaKhoa(string maKhoa)
        {
            try
            {
                var exist = db.Khoas.Where(t => t.MaKhoa == maKhoa).FirstOrDefault();
                if (exist != null)
                {
                    db.Khoas.DeleteOnSubmit(exist);
                    db.SubmitChanges();
                    return 1;
                }
                return 0;
            }
            catch (Exception)
            {

                return 0;
            }
        }

        public bool XoaKhoaNhieu(List<String> makhoas)
        {
            try
            {
                List<Khoa> listKhoa = new List<Khoa>();
                for (int i = 0; i < makhoas.Count; i++)
                {
                    var khoaExist = db.Khoas.Where(t => t.MaKhoa == makhoas[i]).FirstOrDefault();
                    listKhoa.Add(khoaExist);
                }
                db.Khoas.DeleteAllOnSubmit(listKhoa);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                //throw;
            }
        }

        public bool ThemMonHoc(MonHoc mh)
        {
            try
            {
                db.MonHocs.InsertOnSubmit(mh);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DeleteMonHoc(string id)
        {
            try
            {
                var exists = db.MonHocs.Where(t => t.MaMonHoc == id).FirstOrDefault();
                if (exists != null)
                {
                    db.MonHocs.DeleteOnSubmit(exists);
                    db.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool EditMonHoc(MonHoc mh)
        {
            try
            {
                var exists = db.MonHocs.Where(t => t.MaMonHoc == mh.MaMonHoc).FirstOrDefault();
                if(exists!=null)
                {
                    exists.TenMonHoc = mh.TenMonHoc;
                    db.SubmitChanges();
                return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
        public bool XoaMonHoc(string id)
        {
            try
            {
                var exist = db.MonHocs.Where(t => t.MaMonHoc == id).FirstOrDefault();
                if(exist!=null)
                {
                    db.MonHocs.DeleteOnSubmit(exist);
                    db.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool KiemTraMonHoc(string id)
        {
            try
            {
                if(db.MonHocs.Where(t=>t.MaMonHoc==id).Count()>0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool ThemSinhVien(SinhVien sv)
        {
            try
            {
                db.SinhViens.InsertOnSubmit(sv);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public IEnumerable<Lop> LoadLop()
        {
            var list = db.Lops.ToList();
            return list;
        }

        public IEnumerable<Lop> LoadLopTheoMaKhoa(string id)
        {
            var list = db.Lops.Where(t => t.MaKhoa == id).ToList();
            return list;
        }
    }
}
