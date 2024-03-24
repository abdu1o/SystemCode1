using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SystemCode1
{
    public partial class UserWindow : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, string lParam);

        const int WM_SETTEXT = 0x000C;
        const int WM_CLOSE = 0x0010;

        public UserWindow()
        {
            InitializeComponent();
        }

        private void searchButton_Click_1(object sender, EventArgs e)
        {
            IntPtr hWnd = FindWindow(null, "UserWindow");

            if (hWnd != IntPtr.Zero)
            {
                switch (operationComboBox.SelectedIndex)
                {
                    case 0:
                        string newTitle = "asd";
                        SendMessage(hWnd, WM_SETTEXT, IntPtr.Zero, newTitle);
                        break;
                    case 1:
                        SendMessage(hWnd, WM_CLOSE, IntPtr.Zero, null);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show("Error", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
