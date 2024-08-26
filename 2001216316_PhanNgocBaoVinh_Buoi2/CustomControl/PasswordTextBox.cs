using System;
using System.Windows.Forms;

namespace CustomControl
{
    public class PasswordTextBox : TextBox
    {
        private ErrorProvider error;

        public PasswordTextBox()
        {
            error = new ErrorProvider();
            this.TextChanged += PasswordTextBox_TextChanged;
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            string text = this.Text;
            bool hasInvalidCharacter = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsLetterOrDigit(text[i]))
                {
                    hasInvalidCharacter = true;
                    break;  
                }
            }

            if (hasInvalidCharacter)
            {
                error.SetError(this, "Chỉ cho phép nhập ký tự dac biet.");
            }
            else
            {
                error.Clear(); 
            }
        }
    }
}
