using System;
using System.Windows.Forms;
using RADUTC.Properties;
using System.Drawing;

namespace RADUTC
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the RADUTC.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(Handle_the_unhandled);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (args.Length==1 && args[0].ToLower()== "reset")
                SetDefaultSettings();
            else if (Settings.Default.FocusedOpacity < 10)
                SetDefaultSettings();
            else if (Settings.Default.UnFocusedOpacity < 10)
                SetDefaultSettings();
            else if (Settings.Default.FontColor == null)
                SetDefaultSettings();
            else if (Settings.Default.BackgroundColor == null)
                SetDefaultSettings();


            Application.Run(new FormUTC());
        }

        private static void SetDefaultSettings()
        {
            // default
            Settings.Default.FontColor = Color.Black;
            Settings.Default.BackgroundColor = Color.LightGray;
            Settings.Default.FocusedOpacity = 95;
            Settings.Default.UnFocusedOpacity = 45;
            Settings.Default.WindowLocation = new Point(10, 10);
            Settings.Default.Save();
        }

        static void Handle_the_unhandled(object sender, UnhandledExceptionEventArgs e)
        {
            try
            {
                Exception ex = (Exception)e.ExceptionObject;
                MessageBox.Show("Unhandled exception in RADUTC!  Program exiting.\n\n" +
                    ex.Message, "RADUTC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Application.Exit();  // ensure we get out of the program safely.
            }
        }
    }
}
