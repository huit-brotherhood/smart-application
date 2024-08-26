using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CustomControlPassword
{
    public class txUserPassword : TextBox
    {
        public txUserPassword()
        {
            this.PasswordChar = '*';
            this.Leave += txUserPassword_Leave;
        }

        void txUserPassword_Leave(object sender, EventArgs e)
        {
            if (this.Text.Length == 0)
            {
                MessageBox.Show("Khong duoc bo trong ten dang nhap");
            }
            //throw new NotImplementedException();
        }
    }
}
