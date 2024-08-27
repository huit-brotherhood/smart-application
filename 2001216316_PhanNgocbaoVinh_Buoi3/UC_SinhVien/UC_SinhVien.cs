using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomConnection;
namespace UC_SinhVien
{
    public partial class UC_SinhVien : UserControl
    {
        SqlClass sql = new SqlClass();
        string cnn;

        public string Cnn
        {
            get { return cnn; }
            set { cnn = value; }
        }
        public UC_SinhVien()
        {
            InitializeComponent();
            txMSSV.KeyDown += txMSSV_KeyDown;
        }

        private void txMSSV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txMSSV.Text.Length == 0)
                {
                    MessageBox.Show("KHONG DUOC BO TRONG MSSV");
                }
                else
                {
                    sql.CreateConnection(cnn);
                    DataTable dt = sql.getDatatable("select*from SINHVIEN where mssv = '" + txMSSV.Text + "'");
                    if (dt.Rows.Count>0)
                    {
                        lbCMND.Text = dt.Rows[0][5].ToString();
                        lbMaLop.Text = dt.Rows[0][2].ToString();
                        lbNgaySinh.Text = dt.Rows[0][3].ToString();
                        lbGioiTinh.Text = dt.Rows[0][4].ToString();
                        lbHoTen.Text = dt.Rows[0][1].ToString();
                    }
                    else
                    {
                        MessageBox.Show("KHONG TIM THAY MSSV TREN");
                    }
                    sql.close();
                }
            }
        }
    }
}
