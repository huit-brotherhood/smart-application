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
    public partial class Form1 : Form
    {
        public Form1(string name)
        {
            InitializeComponent();

            this.statusBar1.Text = "Xin chao may " + name;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
