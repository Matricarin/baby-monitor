using System.Security.Cryptography;

namespace BabyMonitor.Web.Services;

public sealed class AuthService
{
    private string _passwordFilePath;

    public AuthService()
    {
        var directoryPath = Path.Combine(AppContext.BaseDirectory, "data");
        Directory.CreateDirectory(directoryPath);
        _passwordFilePath = Path.Combine(directoryPath, "baby-monitor.json");
    }


    public bool IsPasswordSet()
    {
        return File.Exists(_passwordFilePath);
    }

    public bool SetPassword(string password)
    {
        //  шифруем

        //  сохраняем пароль в файл
        return true;
    }

    public bool VerifyPassword(string password)
    {
        //  считываем пароль из файла

        //  расшифровываем пароль

        //  проверяем соответствие введеному паролю

        return true;
    }

    private class AuthData
    {
        public string Salt { get; set; }
        public string Hash { get; set; }
    }
}