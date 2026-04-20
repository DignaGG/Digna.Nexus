using System;

namespace SmartHomeSystem.Classes.Abstract
{
    public abstract class SmartDevice
    {
        #region Fields
        private static int _idCounter = 0;
        private readonly int _id;
        private string _deviceName;
        private string _location;
        private double _baseWatt;
        private bool _isActive;
        #endregion

        #region Properties
        public int Id { get { return _id; } }

        public string DeviceName
        {
            get { return _deviceName; }
            set { _deviceName = !string.IsNullOrWhiteSpace(value) ? value : "Unknown Device"; }
        }

        public string Location
        {
            get { return _location; }
            set { _location = !string.IsNullOrWhiteSpace(value) ? value : "General"; }
        }

        public double BaseWatt
        {
            get { return _baseWatt; }
            protected set { _baseWatt = value >= 0 ? value : 0; }
        }

        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }

        public double CurrentConsumption => CalculateCurrentConsumption();

        public static void ResetIdCounter(int value)
        {
            _idCounter = value;
        }
        #endregion

        #region Constructors
        protected SmartDevice(string deviceName, string location, double baseWatt)
        {
            _id = ++_idCounter;
            DeviceName = deviceName;
            Location = location;
            BaseWatt = baseWatt;
            IsActive = false;
        }
        #endregion

        #region State Management
        public virtual void TurnOn() { IsActive = true; }
        public virtual void TurnOff() { IsActive = false; }
        public void Toggle() { IsActive = !IsActive; }
        #endregion

        #region Configuration Update (Overloading)
        public void UpdateSettings(string newName)
        {
            DeviceName = newName;
        }

        public void UpdateSettings(string newName, string newLocation)
        {
            DeviceName = newName;
            Location = newLocation;
        }

        public void UpdateSettings(string newName, string newLocation, double newBaseWatt)
        {
            DeviceName = newName;
            Location = newLocation;
            BaseWatt = newBaseWatt;
        }
        #endregion

        #region Polymorphic Methods
        public virtual double CalculateCurrentConsumption()
        {
            return IsActive ? BaseWatt : 0;
        }

        public override string ToString()
        {
            string status = IsActive ? "Active" : "Inactive";
            double consumption = CalculateCurrentConsumption();
            return $"[{status}] {DeviceName} (ID: {Id}) | Room: {Location} | Base: {BaseWatt}W | Consumption: {consumption:N2}W";
        }
        #endregion
    }
}