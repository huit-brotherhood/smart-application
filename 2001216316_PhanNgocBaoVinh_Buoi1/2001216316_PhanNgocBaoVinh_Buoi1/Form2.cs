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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            loadData();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }
        public void loadData()
        {
            int topPosition = 30;
           for(int i = 0 ; i < 4;i++)
           {
               TextBox tx = new TextBox();
               tx.Size = new System.Drawing.Size(326, 20);
               tx.Left = 10;
               tx.Top = topPosition;
               topPosition += 30;
               tx.Text = "textbox" + i;
               this.Controls.Add(tx);

           }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HandleForm2 hd = new HandleForm2();
            hd.handle(this.Controls);
        }
    }
}
