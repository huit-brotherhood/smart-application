using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace _2001216316_PhanNgocBaoVinh_Buoi1.Controller
{
    class HandleForm2 : Form
    {
        public HandleForm2()
        {

        }

        public void handle(Control.ControlCollection control)
        {
            foreach(Control item in control)
            {
                if(item.GetType() == typeof(TextBox))
                {
                    TextBox tx = (TextBox)item;
                    tx.Text = String.Empty;
                    
                }
            }
        }

      
    }
}
