# Enhancing-Security-with-Maui-OTP-Input-Validation-Techniques
This repository provides techniques to enhance the security of OTP Input using various validation methods in .NET MAUI

The following code example illustrate how to enhance security with MAUI OTP Input validation techniques.

XAML:
```
   <syncfusion:SfOtpInput x:Name="otpInput" Length="6" ValueChanged="otpInput_ValueChanged"/>

```
C#:
```

private void otpInput_ValueChanged(object sender, OtpInputValueChangedEventArgs e)
{
    if(e.NewValue?.Length == otpInput.Length)
    {
        otpInput.InputState = OtpInputState.Success;
    }
    else
    {
        otpInput.InputState = OtpInputState.Error;
    }
}

```