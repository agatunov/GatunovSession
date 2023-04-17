using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GatunovSession
{
    public partial class ValidateForm : Form
    {
        public ValidateForm()
        {
            InitializeComponent();
        }

        private void validateButton_Click(object sender, EventArgs e)
        {
            var errors = new StringBuilder();
            var validator = new Validator();

            if (!validator.ValidateTextByCharsCount(3, 25, firstnameTextBox.Text))
            {
                errors.AppendLine("У поля имя минимальное количество символом - 3, максимальное - 25");
            }
            if (!validator.ValidateTextByCharsCount(2, 30, surnameTextBox.Text))
            {
                errors.AppendLine("У поля имя минимальное количество символом - 2, максимальное - 25");
            }
            if (!validator.ValidateEmail(emailTextBox.Text))
            {
                errors.AppendLine("У поля электронная почта маска вида X@X.X, где X - любой количество символов");
            }

            MessageBox.Show(errors.Length > 0 ? errors.ToString() : "Данные верны");
        }
    }
}
