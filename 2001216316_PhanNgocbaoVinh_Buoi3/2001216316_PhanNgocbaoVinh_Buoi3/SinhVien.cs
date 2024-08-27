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
            uC_SinhVien1.Cnn =  cnn;
            init_Data();
        }

        private void SinhVien_Load(object sender, EventArgs e)
        {

        }
        public void init_Data()
        {
            sql.CreateConnection(cnn);
            DataTable dt = sql.getDatatable("SELECT*FROM SINHVIEN");
            dataGridView1.DataSource = dt;
        }
    }
}
