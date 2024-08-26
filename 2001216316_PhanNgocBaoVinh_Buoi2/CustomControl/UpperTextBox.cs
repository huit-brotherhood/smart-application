using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CustomControl
{
    public class UpperTextBox : TextBox
    {
        public UpperTextBox()
        {
            this.KeyPress += UpperTextBox_KeyPress;
        }

        void UpperTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar>=97 && e.KeyChar<=122)
            {
                e.Handled = true;
            }
            //throw new NotImplementedException();
        }
    }
}
