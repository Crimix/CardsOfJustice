using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class ConsoleHandler
    {

        public static void ShowConsole()
        {
            var console = GetConsoleWindow();
            ShowWindow(console, 5);
        }

        public static void HideConsole()
        {
            var console = GetConsoleWindow();
            ShowWindow(console, 0);
        }

        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);


    }
}
