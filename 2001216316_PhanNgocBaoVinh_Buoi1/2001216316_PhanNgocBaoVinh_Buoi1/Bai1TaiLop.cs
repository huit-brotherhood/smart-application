using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2001216316_PhanNgocBaoVinh_Buoi1.Controller;
namespace _2001216316_PhanNgocBaoVinh_Buoi1
{
    public partial class Bai1TaiLop : Form
    {
        HandleBaiTap1 handle = new HandleBaiTap1();
        int dong = 0;
        public Bai1TaiLop(int dong)
        {
            InitializeComponent();
            this.dong = dong;
        }

        private void Bai1TaiLop_Load(object sender, EventArgs e)
        {
            this.tableLayoutPanel1.RowCount = dong;
            this.tableLayoutPanel1.ColumnCount = dong;
            this.progressBar1.Maximum = (dong*dong);
            this.progressBar2.Maximum = (dong * dong);
            handle.Generate_ProgressBar(progressBar1, progressBar2);
            handle.load_board(this.tableLayoutPanel1.Controls, dong);
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
