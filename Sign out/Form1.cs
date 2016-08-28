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
    public partial class Form1 : Form
    {
        int time_left = 10;
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool ExitWindowsEx(uint uFlags, uint dwReason);

        public static void WindowsLogOff()
        {
            ExitWindowsEx(0, 0);
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

            countdown_label.Text = ("Logging out in " + time_left.ToString());
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
                countdown_label.Text = ("Logging out in " + time_left.ToString());
            };
            timer.Start();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
