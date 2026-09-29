namespace BabyMonitor.Web.Services;

public sealed class AuthService
{
    public bool IsPasswordSet()
    {
        return true;
    }

    public bool SetPassword(string password)
    {
        return true;
    }

    public bool VerifyPassword(string password)
    {
        return true;
    }
}