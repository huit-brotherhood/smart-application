using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            this.cbKhoa.SelectedValueChanged += cbKhoa_SelectedValueChanged;
            this.cbLop.SelectedValueChanged += cbLop_SelectedValueChanged;
            dataSinhVien.CellClick += dataSinhVien_CellClick;
            dataDiem.CellClick += dataDiem_CellClick;
            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
            btnThem.Click += btnThem_Click;
            btnClose.Click += btnClose_Click;
        }

        void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void btnThem_Click(object sender, EventArgs e)
        {
            if(txMaSV.Text.Length>0 && cbMonHoc.SelectedValue!=null)
            {
                if(txDiem.Text.Length>0)
                {
                    DiemBLL diemBLL = new DiemBLL();
                    Diem diem = new Diem();
                    diem.MaMonHoc = cbMonHoc.SelectedValue.ToString();
                    diem.MaSinhVien = txMaSV.Text;
                    diem.Diem1 = double.Parse(txDiem.Text);
                    bool flag = diemBLL.ThemDiem(diem);
                    if(flag )
                    {
                        MessageBox.Show("Them thanh cong");
                        LoadDiem();
                    }
                    else
                    {
                        MessageBox.Show("Them that bai");
                    }

                }
            }
        }

        void btnXoa_Click(object sender, EventArgs e)
        {
            if(txMaSV.Text.Length>0 && cbMonHoc.SelectedValue!=null)
            {
                DiemBLL diemBLL =new DiemBLL();
                bool flag = diemBLL.XoaDiemMonHoc(txMaSV.Text, cbMonHoc.SelectedValue.ToString());
                if (flag)
                {
                    MessageBox.Show("Xoa thanh cong");
                    LoadDiem();
                }
                else
                {
                    MessageBox.Show("Xoa that bai");
                }
            }
        }

        void btnSua_Click(object sender, EventArgs e)
        {
            if(txMaSV.Text.Length> 0 && cbMonHoc.SelectedValue!=null)
            {
                if(txDiem.Text.Length>0)
                {
                    var rowSelected= dataDiem.CurrentRow;
                    DiemBLL diemBLL = new DiemBLL();
                    bool flag = diemBLL.SuaDiem(txMaSV.Text,rowSelected.Cells[1].Value.ToString(), double.Parse(txDiem.Text));
                    if(flag)
                    {
                        MessageBox.Show("Sua thanh cong");
                        LoadDiem();
                    }
                    else
                    {
                        MessageBox.Show("Sua that bai");
                    }
                }
            }
            txMaSV.Enabled = false;
        }

      
        
        void dataDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowSelected = dataDiem.CurrentRow;
            txMaSV.Text = rowSelected.Cells[0].Value.ToString();
            cbMonHoc.SelectedValue = rowSelected.Cells[1].Value.ToString();
            txDiem.Text = rowSelected.Cells[2].Value.ToString();


            txMaSV.Enabled = false;
        }

        void dataSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadDiem();
            txMaSV.Text = dataSinhVien.CurrentRow.Cells[0].Value.ToString();
        }
        public void LoadDiem()
        {
            var rowSelected = dataSinhVien.CurrentRow;
            DiemBLL diemBLL = new DiemBLL();
            dataDiem.DataSource = diemBLL.GetDiemSinhVien(rowSelected.Cells[0].Value.ToString());
            dataDiem.Columns[3].Visible = false;
            dataDiem.Columns[4].Visible = false;
        }
        void cbLop_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cbLop.SelectedValue!=null)
            {
                SinhVienBLL svBLL = new SinhVienBLL();
                dataSinhVien.DataSource = svBLL.GetSinhViensFilter(cbLop.SelectedValue.ToString());
                dataSinhVien.Columns[4].Visible = false;
            }
           
        }

        
        void cbKhoa_SelectedValueChanged(object sender, EventArgs e)
        {
            LopBLL lopbll = new LopBLL();
            cbLop.DataSource = lopbll.GetLopsFilter(cbKhoa.SelectedValue.ToString());
            cbLop.DisplayMember = "TenLop";
            cbLop.ValueMember = "MaLop";
            //throw new NotImplementedException();
        }

        void Form1_Load(object sender, EventArgs e)
        {
            KhoaBLL khoabll = new KhoaBLL();

            cbKhoa.DataSource = khoabll.GetKhoas();
            cbKhoa.DisplayMember = "Tenkhoa";
            cbKhoa.ValueMember = "MaKhoa";


            MonHocBLL mhBLL = new MonHocBLL();
            cbMonHoc.DataSource = mhBLL.GetMonHocs();
            cbMonHoc.DisplayMember = "TenMonHoc";
            cbMonHoc.ValueMember = "MaMonHoc";
        }
    }
}
