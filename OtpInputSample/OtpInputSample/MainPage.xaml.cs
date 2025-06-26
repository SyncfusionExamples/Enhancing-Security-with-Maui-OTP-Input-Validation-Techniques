using Syncfusion.Maui.Toolkit.OtpInput;

namespace OtpInputSample
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }
        private void otpInput_ValueChanged(object sender, OtpInputValueChangedEventArgs e)
        {
            if (e.NewValue?.Length == otpInput.Length)
            {
                otpInput.InputState = OtpInputState.Success;
            }
            else
            {
                otpInput.InputState = OtpInputState.Error;
            }
        }
    }
}
