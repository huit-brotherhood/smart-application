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
    public partial class Form3 : Form
    {
        XuLy xl = new XuLy();
        public Form3()
        {
            InitializeComponent();
            cbMaKhoa.SelectedValueChanged += cbMaKhoa_SelectedValueChanged;
            btnSearch.Click += btnSearch_Click;
        }

        void btnSearch_Click(object sender, EventArgs e)
        {
            //if(txtHoTen.Text.Trim().Length!=0 && t)
            //throw new NotImplementedException();
        }

        void cbMaKhoa_SelectedValueChanged(object sender, EventArgs e)
        {
            cbMaLop.DataSource = null;
            cbMaLop.DataSource = xl.LoadLopTheoMaKhoa(cbMaKhoa.SelectedValue.ToString());
            cbMaLop.DisplayMember = "MaLop";
            cbMaLop.ValueMember = "MaLop";
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Load_SV();
            InitComboBox();
        }
        public void Load_SV()
        {
            data.DataSource = xl.Load_SV();
        }
        public void InitComboBox()
        {
            cbMaKhoa.DataSource = xl.Load_Khoa();
            cbMaKhoa.DisplayMember = "MaKhoa";
            cbMaKhoa.ValueMember = "MaKhoa";

           
        }
    }
}
