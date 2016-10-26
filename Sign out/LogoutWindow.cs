using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows;


namespace Sign_out
{
    public partial class LogoutWindow : Form
    {
        int time_left = 10;
        public LogoutWindow(int time)
        {
            time_left = time;
            InitializeComponent();
        }

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool ExitWindowsEx(uint uFlags, uint dwReason);

        public static void WindowsLogOff()
        {
            ExitWindowsEx(4, 0);
            System.Windows.Forms.Application.Exit();
        }

        private void log_off_button_click(object sender, EventArgs e)
        {
            WindowsLogOff();
        }

        private void cancel_button_click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //launches the window fullscreen
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

            countdown_label.Text = ("Signing you out of Windows in " + time_left.ToString() + " seconds");
            //Starts timer
            var timer = new Timer { Interval = 1000 };
            timer.Tick += (o, args) =>
            {
                if(time_left == 0)
                {
                    WindowsLogOff();
                    System.Windows.Forms.Application.Exit();
                }
                time_left--;
                countdown_label.Text = ("Signing you out of Windows in " + time_left.ToString() + " seconds");
            };
            timer.Start();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
