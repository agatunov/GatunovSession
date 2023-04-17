using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace GatunovSession
{
    public class Validator
    {
        public bool ValidateTextByCharsCount(int min, int max, string text) => text.Length >= min && text.Length <= max;
        public bool ValidateEmail(string email)
        {
            string pattern = @"\w+@\w+.\w+";
            return Regex.IsMatch(email, pattern);
        }
    }
}
