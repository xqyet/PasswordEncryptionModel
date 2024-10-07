using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

public static class PasswordManager
{
    private static string filePath = "passwords.json";
    private static string encryptionKey = "your-secret-key"; // Keep it secure

    public static void SavePassword(string website, string username, string password)
    {
        List<PasswordEntry> entries = LoadPasswords();
        string encryptedPassword = EncryptionHelper.Encrypt(password, encryptionKey);

        entries.Add(new PasswordEntry { Website = website, Username = username, EncryptedPassword = encryptedPassword });

        File.WriteAllText(filePath, JsonConvert.SerializeObject(entries));
    }

    public static List<PasswordEntry> LoadPasswords()
    {
        if (!File.Exists(filePath)) return new List<PasswordEntry>();

        string json = File.ReadAllText(filePath);
        return JsonConvert.DeserializeObject<List<PasswordEntry>>(json);
    }
}
