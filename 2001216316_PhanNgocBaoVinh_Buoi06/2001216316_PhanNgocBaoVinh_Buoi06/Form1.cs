using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2001216316_PhanNgocBaoVinh_Buoi06
{
    public partial class Form1 : Form
    {
        XuLy xl = new XuLy();
        public Form1()
        {
            InitializeComponent();
               btnXoaKhoa.Click += btnXoaKhoa_Click;
            btnThem.Click += btnThem_Click;
            this.Load += Form1_Load;
        }

        void btnThem_Click(object sender, EventArgs e)
        {
            Khoa khoa = new Khoa();
            khoa.TenKhoa = txtTenKhoa.Text;
            khoa.MaKhoa = txtMaKhoa.Text;

            bool flag = xl.ThemKhoa(khoa);
            if(flag)
            {
                MessageBox.Show("thanh cong");
                txtMaKhoa.Text = "";
                txtTenKhoa.Text = "";
                loadKhoa();
            }
            else
            {
                MessageBox.Show("loi");
                return;
            }
            //throw new NotImplementedException();
        }
        public void loadKhoa()
        {
            dataKhoas.DataSource = xl.Load_Khoa();
        }
        void btnXoaKhoa_Click(object sender, EventArgs e)
        {
            // chay thanh cong roi =))
            List<string> list = new List<string>();
            if (dataKhoas.SelectedRows != null)
            {
                foreach (DataGridViewRow item in dataKhoas.SelectedRows)
                {
                    list.Add(item.Cells[0].Value.ToString());
                }
            }

            bool flag = xl.XoaKhoaNhieu(list);
            if(flag)
            {
                loadKhoa();
            }
        }

        void Form1_Load(object sender, EventArgs e)
        {
            dataMonHocs.DataSource = xl.TongDiemSinhVienTheoMonHoc();
            dataSinhViens.DataSource = xl.LoadSinhViensLops();
            loadKhoa();
            //throw new NotImplementedException();
        }
    }
}
