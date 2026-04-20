using System.IO;
using System.Windows.Forms;

namespace SmartHomeSystem
{
    public class AppSettings
    {
        public bool AutoSaveEnabled { get; set; }

        private static readonly string DataFolder = Path.Combine(
            Path.GetDirectoryName(Application.ExecutablePath), "data");

        public static readonly string SettingsPath = Path.Combine(DataFolder, "settings.json");
        public static readonly string DevicesPath = Path.Combine(DataFolder, "devices.json");

        public static void EnsureDataFolder()
        {
            Directory.CreateDirectory(DataFolder);
        }
    }
}