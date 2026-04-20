using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace SmartHomeSystem
{
    public partial class SettingsForm : Form
    {
        public bool AutoSaveEnabled { get; private set; }

        public SettingsForm()
        {
            InitializeComponent();
            LoadSettings();
        }

        private void LoadSettings()
        {
            try
            {
                if (File.Exists(AppSettings.SettingsPath))
                {
                    string json = File.ReadAllText(AppSettings.SettingsPath);
                    var settings = JsonConvert.DeserializeObject<AppSettings>(json);
                    if (settings != null)
                    {
                        chkAutoSave.Checked = settings.AutoSaveEnabled;
                        AutoSaveEnabled = settings.AutoSaveEnabled;
                    }
                }
            }
            catch { }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                AutoSaveEnabled = chkAutoSave.Checked;

                AppSettings.EnsureDataFolder();
                var settings = new AppSettings { AutoSaveEnabled = chkAutoSave.Checked };
                File.WriteAllText(AppSettings.SettingsPath,
                    JsonConvert.SerializeObject(settings, Formatting.Indented));

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Settings could not be saved:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}