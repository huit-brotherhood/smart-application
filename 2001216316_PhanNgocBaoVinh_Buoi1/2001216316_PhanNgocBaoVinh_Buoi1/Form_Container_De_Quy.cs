using _2001216316_PhanNgocBaoVinh_Buoi1.Controller;
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
    public partial class Form_Container_De_Quy : Form
    {
        XuLyFormDeQuy generate = new XuLyFormDeQuy();
        public Form_Container_De_Quy()
        {
            InitializeComponent();
        }

        private void Form_Container_De_Quy_Load(object sender, EventArgs e)
        {
          
            generate.Generate_Container(this.Controls);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            generate.remove_textBox(this.Controls);
        }
    }
}
