using SmartHomeSystem.Classes.Abstract;

namespace SmartHomeSystem.Classes.Devices
{
    public enum Resolution { HD, FullHD, UHD_4K }

    public class SecurityCamera : SmartDevice
    {
        #region Fields
        private Resolution _resolution;
        private bool _isNightVisionActive;
        private bool _isRecording;
        #endregion

        #region Properties
        public Resolution Resolution { get => _resolution; set => _resolution = value; }
        public bool IsNightVisionActive { get => _isNightVisionActive; set => _isNightVisionActive = value; }
        public bool IsRecording { get => _isRecording; set => _isRecording = value; }
        #endregion

        #region Constructor
        public SecurityCamera(string name, string location, double baseWatt,
            Resolution resolution = Resolution.FullHD,
            bool isNightVisionActive = false,
            bool isRecording = true)
            : base(name, location, baseWatt)
        {
            Resolution = resolution;
            IsNightVisionActive = isNightVisionActive;
            IsRecording = isRecording;
        }
        #endregion

        #region Method Overloading
        public void TurnOn(Resolution resolution = Resolution.FullHD, bool nightVision = false, bool isRecording = true)
        {
            base.TurnOn();
            Resolution = resolution;
            IsNightVisionActive = nightVision;
            IsRecording = isRecording;
        }
        #endregion

        #region Polymorphism
        public override double CalculateCurrentConsumption()
        {
            double consumption = base.CalculateCurrentConsumption();
            if (consumption > 0)
            {
                if (IsRecording) consumption *= 1.2;
                if (IsNightVisionActive) consumption *= 1.25;
            }
            return consumption;
        }

        public override string ToString()
        {
            string recordingStatus = IsRecording ? "REC" : "Standby";
            string nvStatus = IsNightVisionActive ? "NV On" : "NV Off";
            double consumption = CalculateCurrentConsumption();
            return $"{base.ToString()} | {Resolution} | {recordingStatus} | {nvStatus} | Consumption: {consumption:N2}W";
        }
        #endregion
    }
}