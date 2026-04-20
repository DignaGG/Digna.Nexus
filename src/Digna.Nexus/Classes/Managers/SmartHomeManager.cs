using SmartHomeSystem.Classes.Abstract;
using SmartHomeSystem.Classes.Devices;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace SmartHomeSystem.Classes.Managers
{
    public class SmartHomeManager
    {
        #region Fields
        private readonly List<SmartDevice> _devices;
        #endregion

        #region Properties
        public IReadOnlyList<SmartDevice> Devices => _devices.AsReadOnly();
        public int DeviceCount => _devices.Count;
        #endregion

        #region Constructor
        public SmartHomeManager()
        {
            _devices = new List<SmartDevice>();
        }
        #endregion

        #region Device Management
        public string AddDevice(SmartDevice device)
        {
            if (device == null) return "Invalid Device: Null reference.";
            _devices.Add(device);
            return $"SUCCESS: {device.DeviceName} added to {device.Location}.";
        }

        public string RemoveDevice(SmartDevice device)
        {
            if (device == null) return "Invalid Device: Selection is empty.";
            if (_devices.Remove(device))
                return $"REMOVED: {device.DeviceName} has been disconnected.";
            return $"ERROR: Device {device.DeviceName} not found in system.";
        }

        public void ClearAllDevices() => _devices.Clear();
        #endregion

        #region Calculations
        public double CalculateTotalConsumption()
        {
            return _devices.Sum(d => d.CalculateCurrentConsumption());
        }
        #endregion

        #region Reporting
        public string ShowAllDevices()
        {
            if (!_devices.Any()) return "Attached device not found.";

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("--- SMART HOME STATUS REPORT ---");
            sb.AppendLine($"Timestamp: {System.DateTime.Now:HH:mm:ss}");
            sb.AppendLine("--------------------------------");

            foreach (var device in _devices)
                sb.AppendLine(device.ToString());

            sb.AppendLine("--------------------------------");
            sb.AppendLine($"TOTAL CONSUMPTION: {CalculateTotalConsumption():N2} Watts");

            return sb.ToString();
        }
        #endregion

        #region JSON Persistence
        public void SaveDevices()
        {
            AppSettings.EnsureDataFolder();

            var settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All,
                Formatting = Formatting.Indented
            };

            string json = JsonConvert.SerializeObject(_devices, settings);
            File.WriteAllText(AppSettings.DevicesPath, json);
        }

        public void LoadDevices()
        {
            if (!File.Exists(AppSettings.DevicesPath)) return;

            var settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            };

            string json = File.ReadAllText(AppSettings.DevicesPath);
            var loaded = JsonConvert.DeserializeObject<List<SmartDevice>>(json, settings);

            if (loaded != null)
            {
                _devices.Clear();
                _devices.AddRange(loaded);
                if (_devices.Count > 0)
                    SmartDevice.ResetIdCounter(_devices.Max(d => d.Id));
            }
        }
        #endregion
    }
}