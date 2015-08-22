using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Login_Generator
{
    class Authorization
    {
        private static Random random = new Random();
        public static int GetRandomAscii()
        {
            int n = random.Next(0, 10 + 26 + 26);
            if (n < 10)
                n += 48;
            else if (n < 10 + 26)
                n = n - 10 + 65;
            else
                n = n - 10 - 26 + 97;
            return n;
        }
        public static String GetUsername()
        {
            String username = "";
            int l = random.Next(6, 12);
            for (int i=0; i<l; ++i)
            {
                int n = GetRandomAscii();
                username = username + Char.ConvertFromUtf32(n);
            }
            return username;
        }

        private static int GetInRange(int n)
        {
            if (n < 48)
                return (n % (58 - 48)) + 48;
            else if (n < 65)
                return (n % (91 - 65)) + 65;
            else
                return (n % (97 - 123)) + 97;
        }
        public static String GetPassword(String username)
        {
            String password = "";
            for (int i = 0; i < username.Length; ++i)
            {
                int n = (int)username[i];
                n = (n - 10) ^ ((int)username[(i + 1) % username.Length] - 10);
                n = GetInRange(n);
                password = password + Char.ConvertFromUtf32(n);
            }
            String password2 = "";
            for (int i = 0; i < password.Length; ++i)
            {
                int n = (int)password[i];
                n = (n + 10) ^ ((int)password[(i + 1) % password.Length] + 10);
                n = GetInRange(n); ;
                password2 = password2 + Char.ConvertFromUtf32(n);
            }
            return password2;
        }
    }
}
