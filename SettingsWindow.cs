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
    public partial class SettingsWindow : Form
    {
        // these are the defaults
        private UInt16 FocusedOpacity = 95;
        private UInt16 UnFocusedOpacity = 50;
        private Color FontColor = Color.Black;
        private Color BackgroundColor = Color.LightGray;

        public bool WasSaved = false;  // Used to signal the caller whether the settings were saved.

        public SettingsWindow()
        {
            InitializeComponent();

            // Try to load and display the defaults.
            try
            {
                FocusedOpacity = Settings.Default.FocusedOpacity;
                UnFocusedOpacity = Settings.Default.UnFocusedOpacity;
                FontColor = Settings.Default.FontColor;
                BackgroundColor = Settings.Default.BackgroundColor;

                lFontColorText.Text = FontColor.Name;
                lBackgroundColorText.Text = BackgroundColor.Name;
                nudFocusedOpacity.Value = FocusedOpacity;
                nudUnFocusedOpacity.Value = UnFocusedOpacity;
            }
            catch 
            {
                MessageBox.Show("Error loading settings!", "RADUTC Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }

        private void btnFontColor_Click(object sender, EventArgs e)
        {
            cdSelect.Color = FontColor;
            if (cdSelect.ShowDialog() == DialogResult.OK)
            {
                FontColor = cdSelect.Color;
                lFontColorText.Text = FontColor.Name;
            }
        }

        private void btnBackgroundColor_Click(object sender, EventArgs e)
        {
            cdSelect.Color = BackgroundColor;
            if (cdSelect.ShowDialog() == DialogResult.OK)
            {
                BackgroundColor = cdSelect.Color;
                lBackgroundColorText.Text = BackgroundColor.Name;
            }
        }

        private void btnCan_Click(object sender, EventArgs e)
        {
            WasSaved = false;
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (CheckWindowItems())
            {
                SaveSettings();
                this.Close();
            }
        }

        private bool CheckWindowItems()
        {
            bool retIsOK = false;
            if (BackgroundColor.Name == FontColor.Name)
                MessageBox.Show("Background Color cannot be the same as Font Color.", "RADUTC Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                retIsOK = true;
            return retIsOK;
        }

        private void SaveSettings()
        {
            Settings.Default.FocusedOpacity = System.Convert.ToUInt16(nudFocusedOpacity.Value);
            Settings.Default.UnFocusedOpacity = System.Convert.ToUInt16(nudUnFocusedOpacity.Value);
            Settings.Default.FontColor = FontColor;
            Settings.Default.BackgroundColor = BackgroundColor;
            Settings.Default.Save();
            WasSaved = true;
        }
    }
}
