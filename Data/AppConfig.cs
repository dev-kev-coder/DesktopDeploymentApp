using System.Text.Json;

namespace DeploymentApp.Data
{
    public class AppConfig
    {
        public string ApplicationBackupFilePath { get; set; }
        public string SqlServerBackupFilePath { get; set; }
    }

    public static class JsonConfig
    {
        private static string _configPath = Path.Combine(FileSystem.AppDataDirectory, "appConfig.json");

        public static async void SaveAsync<T>(T config, Action<string> callback)
        {
            var json = JsonSerializer.Serialize(config);

            await File.WriteAllTextAsync(_configPath, json);

            var message = "Application configuration has been set";

            callback(message);
        }

        public static async Task<T?> LoadAsync<T>() where T : class
        { 
            if (File.Exists(_configPath))
            {
                var json = await File.ReadAllTextAsync(_configPath);
                
                try
                {
                    return JsonSerializer.Deserialize<T>(json);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

            return default;
        }

    }
}
