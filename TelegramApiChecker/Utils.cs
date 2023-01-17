namespace TelegramApiChecker
{
    internal static class Utils
    {
        public static string GetTelegramApiToken()
        {
            var telegramApi = Environment.GetEnvironmentVariable("TELEGRAM_API");
            ArgumentNullException.ThrowIfNull(telegramApi, "TELEGRAM_API");
            return telegramApi;
        }
    }
}
