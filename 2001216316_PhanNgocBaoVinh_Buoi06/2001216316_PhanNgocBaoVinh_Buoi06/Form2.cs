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
    public partial class Form2 : Form
    {
        XuLy xuly = new XuLy();
        public Form2()
        {

            InitializeComponent();
            this.Load += Form2_Load;
            btnAdd.Click += btnAdd_Click;
            dataMonHocs.CellClick += dataMonHocs_CellClick;
            btnDelete.Click += btnDelete_Click;
            btnSua.Click += btnSua_Click;
            btnClosed.Click += btnClosed_Click;
        }

        void btnClosed_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void btnSua_Click(object sender, EventArgs e)
        {
            MonHoc mh = new MonHoc();
            mh.TenMonHoc = txtTenMon.Text;
            mh.MaMonHoc = txtMaMon.Text;
            bool flag = xuly.EditMonHoc(mh);
            if (flag)
            {
                MessageBox.Show("Sua thanh cnog");
                loadMH();

            }
            else
            {
                MessageBox.Show("sua that bai");
                return;

            }
        }

        void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtMaMon.Text.Length != 0)
            {
                bool flag = xuly.DeleteMonHoc(txtMaMon.Text);
                if (flag)
                {
                    MessageBox.Show("xoa thanh cong");
                    loadMH();
                }
                else
                {
                    MessageBox.Show("Xoa that bai");
                    return;
                }
            }
        }

        void dataMonHocs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var valueSelected = dataMonHocs.CurrentRow;
            txtTenMon.Text = valueSelected.Cells[1].Value.ToString();
            txtMaMon.Text = valueSelected.Cells[0].Value.ToString();
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            MonHoc mh = new MonHoc();
            mh.TenMonHoc = txtTenMon.Text;
            mh.MaMonHoc = txtMaMon.Text;
            if (xuly.KiemTraMonHoc(mh.MaMonHoc))
            {
                MessageBox.Show("trung key");
                return;
            }
            bool flag = xuly.ThemMonHoc(mh);
            if (flag)
            {
                MessageBox.Show("Them thanh cong");
                loadMH();
            }
            else
            {
                MessageBox.Show("loi");
                return;
            }
        }

        void Form2_Load(object sender, EventArgs e)
        {
            loadMH();
        }
        public void loadMH()
        {
            dataMonHocs.DataSource = xuly.Load_MH();

        }
    }
}
