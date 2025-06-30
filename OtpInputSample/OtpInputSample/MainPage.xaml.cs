using Syncfusion.Maui.Toolkit.OtpInput;

namespace OtpInputSample
{
    public partial class MainPage : ContentPage
    {
        private string _otpInput = "976584";
        public MainPage()
        {
            InitializeComponent();
        }
        private void otpInput_ValueChanged(object sender, OtpInputValueChangedEventArgs e)
        {
            if (e.NewValue?.Length != otpInput.Length)
            {
                otpInput.InputState = OtpInputState.Warning;
            }
            else if (e.NewValue?.Length == otpInput.Length && otpInput.Value != _otpInput)
            {
                otpInput.InputState = OtpInputState.Error;
            }
            else if (e.NewValue?.Length == otpInput.Length && otpInput.Value == _otpInput)
            {
                otpInput.InputState = OtpInputState.Success;
            }

        }
    }
}
