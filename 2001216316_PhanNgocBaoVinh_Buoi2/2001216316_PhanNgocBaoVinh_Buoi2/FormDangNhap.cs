using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2001216316_PhanNgocBaoVinh_Buoi2
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
            this.button1.Click += button1_Click;
        }

        void button1_Click(object sender, EventArgs e)
        {
            if(txUserInputControl1.Text.Length==0 && txUserInputControl1.Text.Length==0)
            {
                MessageBox.Show("Hhehe khong cho ban dang dnhap dau");
            }
            else
            {
                this.Hide();
                Form1 n = new Form1(txUserInputControl1.Text);
                n.ShowDialog();
                this.Close();
                
            }
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void txUserInputControl1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

  
    }
}
