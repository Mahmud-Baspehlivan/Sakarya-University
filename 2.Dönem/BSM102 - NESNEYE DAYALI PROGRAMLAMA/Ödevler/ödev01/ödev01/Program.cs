using System;

public class PasswordStrengthChecker
{
    static void Main()
    { }
    private int GetLengthScore(string password)
    {
        return Math.Min(10, password.Length) * 6;
    }

    private int GetLowerScore(string password)
    {
        int rawScore = password.Length - Regex.Replace(password, "[a-z]", "").Length;
        return Math.Min(2, rawScore) * 5;
    }

    private int GetUpperScore(string password)
    {
        int rawScore = password.Length - Regex.Replace(password, "[A-Z]", "").Length;
        return Math.Min(2, rawScore) * 5;
    }

    private int GetDigitScore(string password)
    {
        int rawScore = password.Length - Regex.Replace(password, "[0-9]", "").Length;
        return Math.Min(2, rawScore) * 5;
    }

    private int GetSymbolScore(string password)
    {
        int rawScore = Regex.Replace(password, "[a-zA-Z0-9]", "").Length;
        return Math.Min(2, rawScore) * 5;
    }
    public int GeneratePasswordScore(string password)
    {
        if (password == null)
        {
            return 0;
        }

        int lengthScore = GetLengthScore(password);
        int lowerScore = GetLowerScore(password);
        int upperScore = GetUpperScore(password);
        int digitScore = GetDigitScore(password);
        int symbolScore = GetSymbolScore(password);

        return lengthScore + lowerScore + upperScore + digitScore + symbolScore;
    }
    public enum PasswordStrength
    {
        Unacceptable,
        Weak,
        Normal,
        Strong,
        Secure
    }
    public PasswordStrength GetPasswordStrength(string password)
    {
        int score = GeneratePasswordScore(password);

        if (score < 50)
            return PasswordStrength.Unacceptable;
        else if (score < 60)
            return PasswordStrength.Weak;
        else if (score < 80)
            return PasswordStrength.Normal;
        else if (score < 90)
            return PasswordStrength.Strong;
        else
            return PasswordStrength.Secure;
    }
//    PasswordStrengthChecker checker = new PasswordStrengthChecker();
//    int score;

//    score = checker.GeneratePasswordScore("pwd");           /// 28
//    score = checker.GeneratePasswordScore("password");      /// 58
//    score = checker.GeneratePasswordScore("P45Sword");      /// 78
//    score = checker.GeneratePasswordScore("P45Sword!");     /// 89
//    score = checker.GeneratePasswordScore("ASriws34#!");    /// 100
 
//    PasswordStrength strength;

//        strength = checker.GetPasswordStrength("pwd");          /// Kabul Edilemez
//    strength = checker.GetPasswordStrength("password");     /// Zayif
//    strength = checker.GetPasswordStrength("P45Sword");     /// Normal
//    strength = checker.GetPasswordStrength("P45Sword!");    /// Guclu
//    strength = checker.GetPasswordStrength("ASriws34#!");   /// Guvenli
}