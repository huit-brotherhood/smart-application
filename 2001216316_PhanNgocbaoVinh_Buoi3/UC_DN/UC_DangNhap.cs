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

namespace UC_DN
{
    public partial class UC_DangNhap : UserControl
    {
        string cnn;

        public string Cnn
        {
            get { return cnn; }
            set { cnn = value; }
        }
        SqlClass sql = new SqlClass();
        int flag;

        public int Flag
        {
            get { return flag; }
            set { flag = value; }
        }

        public UC_DangNhap()
        {
            InitializeComponent();
            btnDangNhap.Click += btnDangNhap_Click;
        }
        public event EventHandler SomeChanged;
        void btnDangNhap_Click(object sender, EventArgs e)
        {
            sql.CreateConnection(cnn);
            if (txMatKhau.Text.Length == 0 || txTenDN.Text.Length == 0)
            {
                MessageBox.Show("Không được bỏ trống mật khẩu bạn ơi!");
            }
            else
            {
                string query = "SELECT COUNT(*) FROM USERS WHERE TenDN = '" + txTenDN.Text + "' and MatKhau ='" + txMatKhau.Text + "'";
                int rs = (int)sql.ExcuteScalar(query);
                if (rs == 1)
                {
                    MessageBox.Show("Thành công");
                    Flag = 1;
                   
                }
                else
                {
                    Flag = 0;
                    MessageBox.Show("Không thành công");
                    sql.close();
                }
            }
            if (SomeChanged != null)
            {
                SomeChanged.Invoke(this, EventArgs.Empty);
            }
        }
       
        private void UC_DangNhap_Load(object sender, EventArgs e)
        {

        }
       
    }
}
