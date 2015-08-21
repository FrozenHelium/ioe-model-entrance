using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
           
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"logins.txt"))
            {
                for (int i = 0; i < 1000; ++i)
                {
                    String user = Authorization.GetUsername();
                    file.WriteLine("\n");
                    file.WriteLine("Usename: " + user);
                    file.WriteLine("Password: " + Authorization.GetPassword(user));
                }
            }
            Console.WriteLine("Login credentials generated successfully in logins.txt file");
        }
    }
}
