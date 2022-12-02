using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studikasus_smk_nasional
{
    static internal class utilities
    {
        public static string generateCaptcha()
        {
                Random random = new Random();
                
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[6];

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var captcha = new String(stringChars);
            Console.WriteLine(captcha);
            return captcha;
            
            
        }
    }
}
