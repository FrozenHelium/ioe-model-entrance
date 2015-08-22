using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model_Entrance
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //if (!CheckForCD())
            //{
            //    MessageBox.Show("Please insert the provided CD to run this software.");
            //    return;
            //}
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new QuestionPage());
        }

        private static bool CheckForCD()
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();

            foreach (DriveInfo d in allDrives)
            {
                if (d.DriveType == DriveType.CDRom && d.IsReady == true)
                {
                    FileInfo[] files = d.RootDirectory.GetFiles("setup.dll", SearchOption.AllDirectories);
                    if (files.Length > 0)
                    {
                        StreamReader file = File.OpenText(files[0].FullName);
                        String text = file.ReadToEnd();
                        if (text.Contains("ioe_model_entrance = frobi"))
                            return true;
                    }
                }
            }
            return false;
        }
    }
}
