using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sign_out
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            int number_of_seconds; // Number of seconds to wait
            if (args.Length > 0)
            {
                string argument = args[0].ToLower().Trim();
                if (argument == "/c")
                {
                    MessageBox.Show("This screensaver does not support configuration");
                    return;
                }
                else if (argument == "/p"){
                    MessageBox.Show("This screensaver does not support previews");
                    return;
                }
                else if (argument == "/s")
                {
                    number_of_seconds = 600;
                }
                else if (argument == "/r")
                {
                    number_of_seconds = 10;
                }
                else
                {
                    MessageBox.Show("Parameter " + argument + " is not supported");
                    return;
                }
            }
            else // Screensavers with no argument default to configuration
            {
                MessageBox.Show("This screensaver does not support configuration");
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LogoutWindow(number_of_seconds));
        }
    }
}
