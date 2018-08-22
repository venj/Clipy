using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Threading;
using System.Windows.Forms;

namespace Clipy
{
    public partial class SettingsPane : Form
    {
        // For localization.
        private ResourceManager resmgr = new ResourceManager("Clipy.Strings", Assembly.GetExecutingAssembly());
        private CultureInfo ci = Thread.CurrentThread.CurrentUICulture;

        private Dictionary<string, Object> defaultSettings;
        private Dictionary<string, Object> DefaultSettings
        {
            get
            {
                if (defaultSettings == null)
                {
                    defaultSettings = new Dictionary<string, Object>();
                    defaultSettings.Add("monoFontName", "Consolas");
                    defaultSettings.Add("monoFontSize", 9.5F);
                    defaultSettings.Add("monoFontStyle", "Regular");
                    defaultSettings.Add("numberOfHistories", new decimal(50));
                    defaultSettings.Add("menuLength", new decimal(20));
                    defaultSettings.Add("itemsPerGroup", new decimal(10));
                    defaultSettings.Add("startAtLogin", true);
                }
                return defaultSettings;
            }
        }

        private Dictionary<string, Object> currentSettings;
        private Dictionary<string, Object> CurrentSettings
        {
            get
            {
                if (currentSettings == null)
                {
                    currentSettings = new Dictionary<string, Object>();
                    currentSettings.Add("monoFontName", Properties.Settings.Default.monoFontName);
                    currentSettings.Add("monoFontSize", Properties.Settings.Default.monoFontSize);
                    currentSettings.Add("monoFontStyle", Properties.Settings.Default.monoFontStyle);
                    currentSettings.Add("numberOfHistories", Properties.Settings.Default.numberOfHistories);
                    currentSettings.Add("menuLength", Properties.Settings.Default.menuLength);
                    currentSettings.Add("itemsPerGroup", Properties.Settings.Default.itemsPerGroup);
                    currentSettings.Add("startAtLogin", Properties.Settings.Default.startAtLogin);
                }
                return currentSettings;
            }
        }
        
        public SettingsPane()
        {
            InitializeComponent();
            loadCurrentSettingsToUI();
        }
        
        public void loadCurrentSettingsToUI()
        {
            // fill UI
            fontNameTextBox.Text = CurrentSettings["monoFontName"] + " " + CurrentSettings["monoFontSize"] + "pt " + CurrentSettings["monoFontStyle"];
            numberOfHistoriesStepper.Value = Convert.ToDecimal(CurrentSettings["numberOfHistories"]);
            menuLengthStepper.Value = Convert.ToDecimal(CurrentSettings["menuLength"]);
            itemPerGroupStepper.Value = Convert.ToDecimal(CurrentSettings["itemsPerGroup"]);
            startupAtLoginCheckBox.Checked = Convert.ToBoolean(CurrentSettings["startAtLogin"]);
        }

        private bool resetToDefaultSettings()
        {
            return SaveSettings(DefaultSettings);
        }

        private bool saveCurrentSettings()
        {
            updateCurrentSettings();
            return SaveSettings(CurrentSettings);
        }

        private bool SaveSettings(Dictionary<string, Object> dict)
        {
            Properties.Settings.Default.monoFontName = Convert.ToString(dict["monoFontName"]);
            Properties.Settings.Default.monoFontSize = Convert.ToSingle(dict["monoFontSize"]);
            Properties.Settings.Default.monoFontStyle = Convert.ToString(dict["monoFontStyle"]);
            Properties.Settings.Default.numberOfHistories = Convert.ToInt32(dict["numberOfHistories"]);
            Properties.Settings.Default.menuLength = Convert.ToInt32(dict["menuLength"]);
            Properties.Settings.Default.itemsPerGroup = Convert.ToInt32(dict["itemsPerGroup"]);
            Properties.Settings.Default.startAtLogin = Convert.ToBoolean(dict["startAtLogin"]);
            try
            {
                Properties.Settings.Default.Save();
            }
            catch (Exception excp)
            {
                Console.WriteLine(excp.Message);
                return false;
            }
            return true;
        }

        private void changeCodeFontButton_Click(object sender, EventArgs e)
        {

            var dialog = new FontDialog();
            dialog.Font = fetchMonoFont();
            dialog.AllowVerticalFonts = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                CurrentSettings["monoFontName"] = dialog.Font.Name;
                CurrentSettings["monoFontStyle"] = dialog.Font.Style.ToString();
                CurrentSettings["monoFontSize"] = dialog.Font.Size;
                fontNameTextBox.Text = dialog.Font.Name + " " + dialog.Font.Size + "pt " + dialog.Font.Style.ToString();
            }
        }

        private Font fetchMonoFont()
        {
            string fontName = Properties.Settings.Default.monoFontName;
            float fontSize = Properties.Settings.Default.monoFontSize;
            FontStyle fontStyle = (FontStyle)Enum.Parse(typeof(FontStyle), Properties.Settings.Default.monoFontStyle);
            var UIFont = new Font(fontName, fontSize, fontStyle);
            return UIFont;
        }

        private void updateCurrentSettings()
        {
            CurrentSettings["numberOfHistories"] = numberOfHistoriesStepper.Value;
            CurrentSettings["menuLength"] = menuLengthStepper.Value;
            CurrentSettings["itemsPerGroup"] = itemPerGroupStepper.Value;
            CurrentSettings["startAtLogin"] = startupAtLoginCheckBox.Checked;
            // Update start up status
            updateStartupItem(startupAtLoginCheckBox.Checked);
        }

        private void updateStartupItem(bool startup)
        {
            RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (startup)
            {
                rkApp.SetValue("Clipy", Application.ExecutablePath);
            }
            else
            {
                rkApp.DeleteValue("Clipy", false);
            }
        }
        
        private void resetButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(resmgr.GetString("__message_box_message_Reset_all", ci), resmgr.GetString("__message_box_title_Reset_all", ci), MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // The logic here is a bit strange, if you press yes, the settings will revert to default immediately.
                resetToDefaultSettings();
                loadCurrentSettingsToUI();
                Close();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (saveCurrentSettings())
            {
                MessageBox.Show(resmgr.GetString("__message_box_message_saved", ci));
            }
            else
            {
                MessageBox.Show(resmgr.GetString("__message_box_message_save_error", ci));
            }
            // Right now, do nothing...
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
