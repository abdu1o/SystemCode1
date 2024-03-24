using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Threading;

namespace SystemCode1
{
    class Program
    {
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);

        [DllImport("Kernel32.dll")]
        public static extern bool Beep(int frequency, int duration);

        [DllImport("User32.dll")]
        public static extern bool MessageBeep(uint type);

        static void Main()
        {
            //task 1
            MessageBox(IntPtr.Zero, "Kapara Oleksandr", "About", 0);
            MessageBox(IntPtr.Zero, "17 y. o.", "About", 0);
            MessageBox(IntPtr.Zero, "Sho?", "About", 0);

            //task2
            UserWindow userWindow = new UserWindow();
            userWindow.Activate();
            userWindow.ShowDialog();

            //task3
            for (int i = 0; i < 3; i++)
            {
                Beep(500, 200);
                Thread.Sleep(500);
            }

            for (int i = 0; i < 3; i++)
            {
                MessageBeep(0xFFFFFFFF);
                Thread.Sleep(500);
            }
        }
    }
}
