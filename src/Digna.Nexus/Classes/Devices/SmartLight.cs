using SmartHomeSystem.Classes.Abstract;

namespace SmartHomeSystem.Classes.Devices
{
    public class SmartLight : SmartDevice
    {
        #region Fields
        private int _brightness;
        #endregion

        #region Properties
        public int Brightness
        {
            get => _brightness;
            set
            {
                if (value < 0) _brightness = 0;
                else if (value > 100) _brightness = 100;
                else _brightness = value;
            }
        }
        #endregion

        #region Constructor
        public SmartLight(string name, string location, double baseWatt, int brightness = 100)
            : base(name, location, baseWatt)
        {
            Brightness = brightness;
        }
        #endregion

        #region Method Overloading
        public void TurnOn(int brightness)
        {
            base.TurnOn();
            Brightness = brightness;
        }
        #endregion

        #region Polymorphism
        public override double CalculateCurrentConsumption()
        {
            return base.CalculateCurrentConsumption() * (Brightness / 100.0);
        }

        public override string ToString()
        {
            double consumption = CalculateCurrentConsumption();
            return $"{base.ToString()} | Brightness: %{Brightness} | Consumption: {consumption:N2}W";
        }
        #endregion
    }
}