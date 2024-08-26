using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CustomControl
{
    public class MailTextBox : TextBox
    {
        ErrorProvider error;
        public MailTextBox()
        {
            this.Leave += MailTextBox_Leave;
            error = new ErrorProvider();
        }

        void MailTextBox_Leave(object sender, EventArgs e)
        {
            if(!IsValidEmailFormat(this.Text))
            {
                error.SetError(this, "Email khong hop le");
            }
            else
            {
                error.Clear();
            }
            //throw new NotImplementedException();
        }
        public static Regex _regex = new Regex(
      @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
     RegexOptions.CultureInvariant | RegexOptions.Singleline);

        public static bool IsValidEmailFormat(string emailInput)
        {
            return _regex.IsMatch(emailInput);
        }
    }
}
