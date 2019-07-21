using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RADUTC.Properties;

namespace RADUTC
{
    public partial class FormUTC : Form
    {
        private UInt16 FocusedOpacity = 95;
        private UInt16 UnFocusedOpacity = 50;

        private DateTime LastDisplayedDateTimeUTC = new DateTime(2000, 04, 02);

        private object UpdateScreenLock = new object();

        public FormUTC()
        {
            InitializeComponent();
        }

        private void FormUTC_MouseEnter(object sender, EventArgs e)
        {
            this.Opacity = FocusedOpacity / 100.0;
        }

        private void FormUTC_MouseLeave(object sender, EventArgs e)
        {
            this.Opacity = UnFocusedOpacity / 100.0;
        }

        private void LabelMouseEnter(object sender, EventArgs e)
        {
            this.Opacity = FocusedOpacity / 100.0;
        }

        private void LabelMouseLeave(object sender, EventArgs e)
        {
            this.Opacity = UnFocusedOpacity / 100.0;
        }


        // This method of moving a window that has no borders is from 
        // https://stackoverflow.com/questions/1592876/make-a-borderless-form-movable
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void FormUTC_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }

        }


        private void LoadSettings()
        {
            try
            {
                this.BackColor = Settings.Default.BackgroundColor;
                lblUTCDate.ForeColor = lblUTCTime.ForeColor = Settings.Default.FontColor;
                FocusedOpacity = Settings.Default.FocusedOpacity;
                UnFocusedOpacity = Settings.Default.UnFocusedOpacity;
            }
            catch
            {
                // default
                this.BackColor = Color.LightGray;
                lblUTCDate.ForeColor = lblUTCTime.ForeColor = Color.Black;
                FocusedOpacity = 95;
                UnFocusedOpacity = 45;
            }
        }


        private void tsmiQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            abt About = new abt();
            About.ShowDialog();
        }

        private void FormUTC_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Save the window's location.
            Settings.Default.WindowLocation = this.Location;
            Settings.Default.Save();
        }

        private void FormUTC_Load(object sender, EventArgs e)
        {
            // Load Settings
            LoadInitialSettings();
        }

        //  Load all of the programs settings
        private void LoadInitialSettings()
        {
            if (Settings.Default.WindowLocation != null)
                this.Location = Settings.Default.WindowLocation;
        }

        private void tsmiSettings_Click(object sender, EventArgs e)
        {
            SettingsWindow settings = new SettingsWindow();
            settings.ShowDialog();
            if (settings.WasSaved)
            {
                // refresh the settings
                LoadSettings();
            }
        }

        private void FormUTC_Shown(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            // If this is the first time the timer has ticked, or is > 1 second since the first display, 
            // then display the change.

            DateTime CurrentDateTimeUTC = DateTime.UtcNow;

            if ((CurrentDateTimeUTC - LastDisplayedDateTimeUTC).TotalSeconds > 1)
            {
                lock (UpdateScreenLock)
                {
                    lblUTCDate.Text = CurrentDateTimeUTC.ToString("yyyy-MM-dd");
                    lblUTCTime.Text = CurrentDateTimeUTC.ToString("HHmmss");
                    LastDisplayedDateTimeUTC = CurrentDateTimeUTC;
                }
            }

        }

        private void tsmiCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(LastDisplayedDateTimeUTC.ToString("yyyy-MM-dd HHmmss"));
        }
    }
}
