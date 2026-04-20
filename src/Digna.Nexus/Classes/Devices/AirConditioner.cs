using SmartHomeSystem.Classes.Abstract;

namespace SmartHomeSystem.Classes.Devices
{
    public enum ACMode { Heating, Cooling }

    public class AirConditioner : SmartDevice
    {
        #region Fields
        private int _targetTemperature;
        #endregion

        #region Properties
        public int TargetTemperature
        {
            get => _targetTemperature;
            set
            {
                if (value < 16) _targetTemperature = 16;
                else if (value > 30) _targetTemperature = 30;
                else _targetTemperature = value;
            }
        }

        public ACMode Mode { get; set; }
        #endregion

        #region Constructor
        public AirConditioner(string name, string location, double baseWatt, int targetTemp = 24, ACMode mode = ACMode.Cooling)
            : base(name, location, baseWatt)
        {
            TargetTemperature = targetTemp;
            Mode = mode;
        }
        #endregion

        #region Method Overloading
        public void TurnOn(int temp, ACMode mode)
        {
            base.TurnOn();
            this.TargetTemperature = temp;
            this.Mode = mode;
        }
        #endregion

        #region Polymorphism
        public override double CalculateCurrentConsumption()
        {
            double currentBase = base.CalculateCurrentConsumption();
            if (currentBase > 0)
                return Mode == ACMode.Heating ? currentBase * 1.2 : currentBase;
            return 0;
        }

        public override string ToString()
        {
            double consumption = CalculateCurrentConsumption();
            return $"{base.ToString()} | Mode: {Mode} | Target: {TargetTemperature}°C | Consumption: {consumption:N2}W";
        }
        #endregion
    }
}