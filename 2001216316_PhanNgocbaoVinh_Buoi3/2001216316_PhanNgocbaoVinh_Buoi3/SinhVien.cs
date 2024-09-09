using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomConnection;
namespace _2001216316_PhanNgocbaoVinh_Buoi3
{
    public partial class SinhVien : Form
    {
        SqlClass sql = new SqlClass();
        string cnn = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=db_may28;Integrated Security=True";
        public SinhVien()
        {
            InitializeComponent();
            uC_SinhVien1.Cnn = cnn;
           
            init_Data();
            btnLuu.Click += BtnLuu_Click;
            btnXoa.Click += BtnXoa_Click;
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {               
                MessageBox.Show("Xóa thành công!");
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        dataGridView1.Rows.Remove(row);
                    }
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn dòng để xóa.");
            }
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = (DataTable)dataGridView1.DataSource;
                int flag = sql.UpdateData("SELECT*FROM SINHVIEN", dt);
                if (flag == 1)
                {
                    MessageBox.Show("Lưu thành công");
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm thất bại do trùng khóa chính");
            }
           
        }

        private void SinhVien_Load(object sender, EventArgs e)
        {

        }
        public void init_Data()
        {
            sql.CreateConnection(cnn);
            DataTable dt = sql.getDatatable("SELECT*FROM SINHVIEN");
            dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
            dataGridView1.DataSource = dt;       
        }
    }
}
