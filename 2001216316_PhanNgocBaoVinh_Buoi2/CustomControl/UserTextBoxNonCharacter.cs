using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CustomControl
{
    public class UserTextBoxNonCharacter : TextBox
    {
        ErrorProvider error;
        public UserTextBoxNonCharacter()
        {
            this.KeyPress += UserTextBoxNonCharacter_KeyPress;
            error = new ErrorProvider();
        }

        void UserTextBoxNonCharacter_KeyPress(object sender, KeyPressEventArgs e)
        {
             if(Char.IsLetterOrDigit(e.KeyChar))
             {
                 error.Clear();
                 //e.Handled = true;
             }
             else{
                 error.SetError(this,"khong cho nhap ky tu dac biet");
             }
             //throw new NotImplementedException();
        }
    }
}
