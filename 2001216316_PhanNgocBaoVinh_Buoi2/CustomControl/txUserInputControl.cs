using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CustomControl
{
    public class txUserInputControl : TextBox
    {

        public txUserInputControl()
        {
            this.Leave += txUserInputControl_Leave;
        }

        void txUserInputControl_Leave(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            if (this.Text.Length == 0)
            {
                MessageBox.Show("Khong duoc bo trong ten dang nhap");
            }
        }

        void txUserInputControl_TextChanged(object sender, EventArgs e)
        {
         
            //throw new NotImplementedException();
        }
    }
}
