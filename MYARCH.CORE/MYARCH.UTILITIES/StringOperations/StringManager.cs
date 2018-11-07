using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MYARCH.UTILITIES.StringOperations
{
    public static class StringManager
    {
        public static string ToSlug(string incomingText)
        {
            incomingText = incomingText.Replace("ş", "s");
            incomingText = incomingText.Replace("Ş", "s");
            incomingText = incomingText.Replace("İ", "i");
            incomingText = incomingText.Replace("I", "i");
            incomingText = incomingText.Replace("ı", "i");
            incomingText = incomingText.Replace("Ö", "o");
            incomingText = incomingText.Replace("ö", "o");
            incomingText = incomingText.Replace("ü", "u");
            incomingText = incomingText.Replace("Ü", "u");
            incomingText = incomingText.Replace("ç", "c");
            incomingText = incomingText.Replace("Ç", "c");
            incomingText = incomingText.Replace("ğ", "g");
            incomingText = incomingText.Replace("Ğ", "g");
            incomingText = incomingText.Replace(" ", "");
            incomingText = incomingText.Replace("---", "-");
            incomingText = incomingText.Replace("?", "");
            incomingText = incomingText.Replace("/", "");
            incomingText = incomingText.Replace(".", "");
            incomingText = incomingText.Replace("'", "");
            incomingText = incomingText.Replace("#", "");
            incomingText = incomingText.Replace("", "");

            string encodeUrl = (incomingText ?? "").ToLower();

            encodeUrl = Regex.Replace(encodeUrl, @"[^a-z0-9]", "-");
            encodeUrl = Regex.Replace(encodeUrl, @"-+", "-");
            encodeUrl = Regex.Replace(encodeUrl, @"\&+", "and");

            encodeUrl = encodeUrl.Replace("'", "");
            encodeUrl.Trim('-');

            return encodeUrl;
        }
    }
}
