using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model_Entrance
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
            for (int i = 0; i < l; ++i)
            {
                int n = GetRandomAscii();
                username = username + Char.ConvertFromUtf32(n);
            }
            return username;
        }
        public static String GetPassword(String username)
        {
            String password = "";
            for (int i = 0; i < username.Length; ++i)
            {
                int n = (int)username[i];
                n = (n - 10) ^ ((int)username[(i + 1) % username.Length] - 10);
                n = n % (125 - 33);
                n += 33;
                password = password + Char.ConvertFromUtf32(n);
            }
            String password2 = "";
            for (int i = 0; i < password.Length; ++i)
            {
                int n = (int)password[i];
                n = (n + 10) ^ ((int)password[(i + 1) % password.Length] + 10);
                n = n % (125 - 33);
                n += 33;
                password2 = password2 + Char.ConvertFromUtf32(n);
            }
            return password2;
        }
    }
}
