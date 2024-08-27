using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2001216316_PhanNgocbaoVinh_Buoi3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            uC_DangNhap1.SomeChanged += uC_DangNhap1_SomeChanged;
        }

        void uC_DangNhap1_SomeChanged(object sender, EventArgs e)
        {
            if(uC_DangNhap1.Flag ==1)
            {
                //MessageBox.Show("thanh cong2");
                this.Hide();
                SinhVien n = new SinhVien();
                n.ShowDialog();
                this.Close();
            }
       
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            uC_DangNhap1.Cnn = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=db_may28;Integrated Security=True";            
        }
   
    }
}
