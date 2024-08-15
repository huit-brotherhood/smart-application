using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2001216316_PhanNgocBaoVinh_Buoi1.Controller
{
    class XuLyFormDeQuy : Form
    {
        public XuLyFormDeQuy()
        {

        }
        public void Generate_Container(Control.ControlCollection control)
        {
            Random random = new Random();
            int rd = random.Next(1, 10);
            Panel panelContainer = new Panel();
            panelContainer.Size = new System.Drawing.Size(500, 300);
            panelContainer.BorderStyle = BorderStyle.FixedSingle;
            panelContainer.Location = new System.Drawing.Point(15, 15);
            addPanel(panelContainer,rd);
            control.Add(panelContainer);
        }
        public void addPanel(Panel parent,int n)
        {
            if(n==0)
            {
                return;
            }
            Panel child = new Panel();
            child.Size = new System.Drawing.Size((int)(parent.Width / 1.125), (int)(parent.Height / 1.2));
            child.BorderStyle = BorderStyle.FixedSingle;
            child.Location = new System.Drawing.Point(10,10);
            TextBox tx = new TextBox();
            tx.Text = n + "hehe ";
            tx.Size = new System.Drawing.Size(child.Width/3, 20);
            tx.Location = new System.Drawing.Point((int)(child.Width/1.125), (int)(child.Height/1.2));
            child.Controls.Add(tx);
            parent.Controls.Add(child);
            addPanel(child,n-1);
        }

        public void remove_textBox(Control.ControlCollection controlCollection)
        {
            if (controlCollection.Count < 1)
            {
                return;
            }

            foreach (Control control in controlCollection)
            {
                if (control.GetType() == typeof(Button))
                {
                    continue;
                }

                if (control is TextBox textBox)
                {
                    textBox.Text = "";
                }

                if (control is Panel panel)
                {
                    remove_textBox(panel.Controls);
                }
            }
        }

    }
}
