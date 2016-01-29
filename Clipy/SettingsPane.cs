using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clipy
{
    public partial class SettingsPane : Form
    {
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
                    defaultSettings.Add("startAtLogin", false);
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
                    currentSettings.Add("monoFontName", "Consolas");
                    currentSettings.Add("monoFontSize", 9.5F);
                    currentSettings.Add("monoFontStyle", "Regular");
                    currentSettings.Add("numberOfHistories", new decimal(50));
                    currentSettings.Add("menuLength", new decimal(20));
                    currentSettings.Add("itemsPerGroup", new decimal(10));
                    currentSettings.Add("startAtLogin", false);
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
            // Load current settings.
            CurrentSettings["monoFontName"] = Properties.Settings.Default.monoFontName;
            CurrentSettings["monoFontSize"] = Properties.Settings.Default.monoFontSize;
            CurrentSettings["monoFontStyle"] = Properties.Settings.Default.monoFontStyle;
            CurrentSettings["numberOfHistories"] = Properties.Settings.Default.numberOfHistories;
            CurrentSettings["menuLength"] = Properties.Settings.Default.menuLength;
            CurrentSettings["itemsPerGroup"] = Properties.Settings.Default.itemsPerGroup;
            CurrentSettings["startAtLogin"] = Properties.Settings.Default.startAtLogin;
            // fill UI
            fontNameTextBox.Text = Properties.Settings.Default.monoFontName + " " + Properties.Settings.Default.monoFontSize + "pt " + Properties.Settings.Default.monoFontStyle;
            numberOfHistoriesStepper.Value = Properties.Settings.Default.numberOfHistories;
            menuLengthStepper.Value = Properties.Settings.Default.menuLength;
            itemPerGroupStepper.Value = Properties.Settings.Default.itemsPerGroup;
            startupAtLoginCheckBox.Checked = Properties.Settings.Default.startAtLogin;
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

            Properties.Settings.Default.monoFontName = (string)dict["monoFontName"];
            Properties.Settings.Default.monoFontSize = (float)dict["monoFontSize"];
            Properties.Settings.Default.monoFontStyle = (string)dict["monoFontStyle"];
            Properties.Settings.Default.numberOfHistories = decimal.ToInt32((decimal)dict["numberOfHistories"]);
            Properties.Settings.Default.menuLength = decimal.ToInt32((decimal)dict["menuLength"]);
            Properties.Settings.Default.itemsPerGroup = decimal.ToInt32((decimal)dict["itemsPerGroup"]);
            Properties.Settings.Default.startAtLogin = (bool)dict["startAtLogin"];
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
            dialog.AllowVerticalFonts = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                CurrentSettings["monoFontName"] = dialog.Font.Name;
                CurrentSettings["monoFontStyle"] = dialog.Font.Style.ToString();
                CurrentSettings["monoFontSize"] = dialog.Font.Size;
                fontNameTextBox.Text = dialog.Font.Name + " " + dialog.Font.Size + "pt " + dialog.Font.Style.ToString();
            }
        }

        private void updateCurrentSettings()
        {
            CurrentSettings["numberOfHistories"] = numberOfHistoriesStepper.Value;
            CurrentSettings["menuLength"] = menuLengthStepper.Value;
            CurrentSettings["itemsPerGroup"] = itemPerGroupStepper.Value;
            CurrentSettings["startAtLogin"] = startupAtLoginCheckBox.Checked;
        }
        
        private void resetButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Reset all settings to default values?", "Reset to default", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
                MessageBox.Show("Saved");
            }
            else
            {
                MessageBox.Show("Error saving settings.");
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
