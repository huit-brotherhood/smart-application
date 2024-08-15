using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2001216316_PhanNgocBaoVinh_Buoi1
{
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
        }

        private void InputForm_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = Int32.Parse(textBox1.Text.Trim());
                if (dong > 50)
                {
                    MessageBox.Show("Vui long nhap cap ma tran <=50");
                    return;
                }
                else
                {
                    this.Visible = false;
                    Bai1TaiLop bt1 = new Bai1TaiLop(dong);
                    bt1.Visible = true;
                }
            }             
             catch (Exception)
            {
                MessageBox.Show("Vui long nhap so");

             //   throw;
            }
        }
    }
}
