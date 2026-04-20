using SmartHomeSystem.Classes.Abstract;
using System;

namespace SmartHomeSystem.Classes.Devices
{
    public class SmartSpeaker : SmartDevice
    {
        #region Fields
        private int _volume;
        #endregion

        #region Properties
        public int Volume
        {
            get => _volume;
            set
            {
                if (value < 0) _volume = 0;
                else if (value > 100) _volume = 100;
                else _volume = value;
            }
        }
        #endregion

        #region Constructor
        public SmartSpeaker(string name, string location, double baseWatt, int volume = 0)
            : base(name, location, baseWatt)
        {
            Volume = volume;
        }
        #endregion

        #region Method Overloading
        public void TurnOn(int volume)
        {
            base.TurnOn();
            Volume = volume;
        }
        #endregion

        #region Polymorphism
        public override double CalculateCurrentConsumption()
        {
            double baseActiveConsumption = base.CalculateCurrentConsumption();
            if (baseActiveConsumption > 0)
                return BaseWatt * Math.Pow((Volume / 100.0), 2);
            return 0;
        }

        public override string ToString()
        {
            double consumption = CalculateCurrentConsumption();
            return $"{base.ToString()} | Volume: %{Volume} | Consumption: {consumption:N2}W";
        }
        #endregion
    }
}