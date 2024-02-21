using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using WMPLib;

namespace MusicPlayer
{
    internal static class Program
    {
        static bool isAlive = false;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string dllPath = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Interop.WMPLib.dll");
            string directoryPath = AppDomain.CurrentDomain.BaseDirectory;

            if (!File.Exists(dllPath))
            {
                byte[] fileBytes = Properties.Resources.Interop_WMPLib;

                File.WriteAllBytes(dllPath, fileBytes);
            }
            Form musicPlayer = new Form1();

            try
            {
                Application.Run(musicPlayer);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                musicPlayer.Close();
                Application.ExitThread();
            }

        }

    }
}
