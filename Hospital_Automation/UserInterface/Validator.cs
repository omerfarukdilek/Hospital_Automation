using System.Text.RegularExpressions;

public class Validator
{
    private readonly static string EMAIL_PATTERN = @"^[A-Z0-9._%+-]+@[A-Z0-9.-]+.(com|org|net|edu|gov|mil|biz|info|mobi)(.[A-Z]{2})?$";
    private readonly static string PASSWORD_PATTERN = @"^[a-zA-Z0-9]\w{7,15}$";
    private readonly static string DOCTOR_USERNAME_PATTERN = @"^(dr?[a-zA-Z0-9])";
    private readonly static string PHARMACIST_USERNAME_PATTERN = @"^(ph?[a-zA-Z0-9])";



    public static bool isEmailValid(string emailInput)
    {
        Regex regex = new Regex(EMAIL_PATTERN, RegexOptions.IgnoreCase);
        return regex.IsMatch(emailInput);
    }
    public static bool isPasswordValid(string passwordInput)
    {
        Regex regex = new Regex(PASSWORD_PATTERN, RegexOptions.IgnoreCase);
        return regex.IsMatch(passwordInput);
    }
    public static bool isDoctorUserNameValid(string usernameInput)
    {
        Regex regex = new Regex(DOCTOR_USERNAME_PATTERN, RegexOptions.IgnoreCase);
        return regex.IsMatch(usernameInput);
    }
    public static bool isPharmacistUserNameValid(string usernameInput)
    {
        Regex regex = new Regex(PHARMACIST_USERNAME_PATTERN, RegexOptions.IgnoreCase);
        return regex.IsMatch(usernameInput);
    }


}

