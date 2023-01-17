namespace TelegramApiChecker
{
    internal static class Utils
    {
        public static string GetTelegramApiToken()
        {
            return "5950500239:AAFDaZuUUVs-xbmFlA6wVZRQ0AKK-bAE4CU";
            var telegramApi = Environment.GetEnvironmentVariable("TELEGRAM_API");
            ArgumentNullException.ThrowIfNull(telegramApi, "TELEGRAM_API");
            return telegramApi;
        }
    }
}
